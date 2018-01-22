﻿using Disco.BI.Extensions;
using Disco.Data.Repository;
using Disco.Models.BI.Expressions;
using Disco.Models.Repository;
using Disco.Models.Services.Documents;
using Disco.Services;
using Disco.Services.Documents;
using Disco.Services.Expressions;
using Disco.Services.Interop.ActiveDirectory;
using Disco.Services.Users;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Disco.BI.Interop.Pdf
{
    public static class PdfGenerator
    {
        public static Stream GenerateBulkFromPackage(DocumentTemplatePackage package, DiscoDataContext Database, User CreatorUser, DateTime Timestamp, bool InsertBlankPages, List<IAttachmentTarget> DataObjects)
        {
            if (DataObjects.Count > 0)
            {
                List<Stream> generatedPdfs = new List<Stream>(DataObjects.Count);
                using (var state = DocumentState.DefaultState())
                {
                    foreach (var d in DataObjects)
                    {
                        generatedPdfs.Add(package.GeneratePdfPackage(Database, d, CreatorUser, Timestamp, state));
                        state.SequenceNumber++;
                        state.FlushScopeCache();
                    }
                }
                if (generatedPdfs.Count == 1)
                {
                    return generatedPdfs[0];
                }
                else
                {
                    Stream bulkPdf = Utilities.JoinPdfs(package.InsertBlankPages || InsertBlankPages, generatedPdfs);
                    foreach (Stream singlePdf in generatedPdfs)
                        singlePdf.Dispose();
                    return bulkPdf;
                }
            }
            return null;
        }

        public static Stream GenerateBulkFromPackage(DocumentTemplatePackage package, DiscoDataContext Database, User CreatorUser, DateTime Timestamp, bool InsertBlankPages, List<string> DataObjectsIds)
        {
            List<IAttachmentTarget> DataObjects;

            switch (package.Scope)
            {
                case AttachmentTypes.Device:
                    DataObjects = Database.Devices.Where(d => DataObjectsIds.Contains(d.SerialNumber)).ToList<IAttachmentTarget>();
                    break;
                case AttachmentTypes.Job:
                    int[] intDataObjectsIds = DataObjectsIds.Select(i => int.Parse(i)).ToArray();
                    DataObjects = Database.Jobs.Where(j => intDataObjectsIds.Contains(j.Id)).ToList<IAttachmentTarget>();
                    break;
                case AttachmentTypes.User:
                    DataObjects = new List<IAttachmentTarget>(DataObjectsIds.Count);
                    for (int idIndex = 0; idIndex < DataObjectsIds.Count; idIndex++)
                    {
                        string dataObjectId = DataObjectsIds[idIndex];
                        var user = UserService.GetUser(ActiveDirectory.ParseDomainAccountId(dataObjectId), Database, true);
                        if (user == null)
                            throw new Exception($"Unknown Username specified: {dataObjectId}");
                        DataObjects.Add(user);
                    }
                    break;
                default:
                    throw new InvalidOperationException("Invalid DocumentType Scope");
            }

            return GenerateBulkFromPackage(package, Database, CreatorUser, Timestamp, InsertBlankPages, DataObjects);
        }

        public static Stream GenerateFromPackage(DocumentTemplatePackage package, DiscoDataContext Database, IAttachmentTarget Data, User CreatorUser, DateTime Timestamp, DocumentState State)
        {
            var templates = package.GetDocumentTemplates(Database);

            if (templates.Count == 0)
                return null;

            bool generateExpression = !string.IsNullOrEmpty(package.OnGenerateExpression);
            string generateExpressionResult = null;

            if (generateExpression)
                generateExpressionResult = package.EvaluateOnGenerateExpression(Data, Database, CreatorUser, Timestamp, State);

            List<Stream> generatedPdfs = new List<Stream>(templates.Count);
            foreach (var template in templates)
            {
                generatedPdfs.Add(template.GeneratePdf(Database, Data, CreatorUser, Timestamp, State, true));

                State.SequenceNumber++;
                State.FlushScopeCache();
            }

            if (generateExpression)
                DocumentsLog.LogDocumentPackageGenerated(package, Data, CreatorUser, generateExpressionResult);
            else
                DocumentsLog.LogDocumentPackageGenerated(package, Data, CreatorUser);

            if (generatedPdfs.Count == 1)
            {
                return generatedPdfs[0];
            }
            else
            {
                Stream bulkPdf = Utilities.JoinPdfs(package.InsertBlankPages, generatedPdfs);
                foreach (Stream singlePdf in generatedPdfs)
                    singlePdf.Dispose();
                return bulkPdf;
            }
        }
        public static Stream GenerateBulkFromTemplate(DocumentTemplate dt, DiscoDataContext Database, User CreatorUser, DateTime Timestamp, bool InsertBlankPages, params IAttachmentTarget[] DataObjects)
        {
            if (DataObjects.Length > 0)
            {
                List<Stream> generatedPdfs = new List<Stream>(DataObjects.Length);
                using (var state = DocumentState.DefaultState())
                {
                    foreach (var d in DataObjects)
                    {
                        generatedPdfs.Add(dt.GeneratePdf(Database, d, CreatorUser, Timestamp, state, true));
                        state.SequenceNumber++;
                        state.FlushScopeCache();
                    }
                }
                if (generatedPdfs.Count == 1)
                {
                    return generatedPdfs[0];
                }
                else
                {
                    Stream bulkPdf = Utilities.JoinPdfs(InsertBlankPages, generatedPdfs);
                    foreach (Stream singlePdf in generatedPdfs)
                        singlePdf.Dispose();
                    return bulkPdf;
                }
            }
            return null;
        }

        public static Stream GenerateBulkFromTemplate(DocumentTemplate dt, DiscoDataContext Database, User CreatorUser, DateTime Timestamp, bool InsertBlankPages, params string[] DataObjectsIds)
        {
            IAttachmentTarget[] DataObjects;

            switch (dt.Scope)
            {
                case DocumentTemplate.DocumentTemplateScopes.Device:
                    DataObjects = Database.Devices.Where(d => DataObjectsIds.Contains(d.SerialNumber)).ToArray();
                    break;
                case DocumentTemplate.DocumentTemplateScopes.Job:
                    int[] intDataObjectsIds = DataObjectsIds.Select(i => int.Parse(i)).ToArray();
                    DataObjects = Database.Jobs.Where(j => intDataObjectsIds.Contains(j.Id)).ToArray();
                    break;
                case DocumentTemplate.DocumentTemplateScopes.User:
                    DataObjects = new IAttachmentTarget[DataObjectsIds.Length];
                    for (int idIndex = 0; idIndex < DataObjectsIds.Length; idIndex++)
                    {
                        string dataObjectId = DataObjectsIds[idIndex];

                        DataObjects[idIndex] = UserService.GetUser(ActiveDirectory.ParseDomainAccountId(dataObjectId), Database, true);
                        if (DataObjects[idIndex] == null)
                            throw new Exception($"Unknown Username specified: {dataObjectId}");
                    }
                    break;
                default:
                    throw new InvalidOperationException("Invalid DocumentType Scope");
            }

            return GenerateBulkFromTemplate(dt, Database, CreatorUser, Timestamp, InsertBlankPages, DataObjects);
        }

        public static Stream GenerateFromTemplate(DocumentTemplate dt, DiscoDataContext Database, IAttachmentTarget Data, User CreatorUser, DateTime TimeStamp, DocumentState State, bool FlattenFields = false)
        {
            // Validate Data
            switch (dt.Scope)
            {
                case DocumentTemplate.DocumentTemplateScopes.Device:
                    if (!(Data is Device))
                        throw new ArgumentException("This AttachmentType is configured for Devices only", "Data");
                    break;
                case DocumentTemplate.DocumentTemplateScopes.Job:
                    if (!(Data is Job))
                        throw new ArgumentException("This AttachmentType is configured for Jobs only", "Data");
                    break;
                case DocumentTemplate.DocumentTemplateScopes.User:
                    if (!(Data is User))
                        throw new ArgumentException("This AttachmentType is configured for Users only", "Data");
                    break;
                default:
                    throw new InvalidOperationException("Invalid AttachmentType Scope");
            }

            Database.Configuration.LazyLoadingEnabled = true;

            // Override FlattenFields if Document Template instructs.
            if (dt.FlattenForm)
                FlattenFields = true;

            ConcurrentDictionary<string, Expression> expressionCache = dt.PdfExpressionsFromCache(Database);

            string templateFilename = dt.RepositoryFilename(Database);
            PdfReader pdfReader = new PdfReader(templateFilename);

            MemoryStream pdfGeneratedStream = new MemoryStream();
            PdfStamper pdfStamper = new PdfStamper(pdfReader, pdfGeneratedStream);

            pdfStamper.FormFlattening = FlattenFields;
            pdfStamper.Writer.CloseStream = false;

            IDictionary expressionVariables = Expression.StandardVariables(dt, Database, CreatorUser, TimeStamp, State);

            foreach (string pdfFieldKey in pdfStamper.AcroFields.Fields.Keys)
            {
                if (pdfFieldKey.Equals("DiscoAttachmentId", StringComparison.OrdinalIgnoreCase))
                {
                    AcroFields.Item fields = pdfStamper.AcroFields.Fields[pdfFieldKey];
                    string fieldValue = dt.CreateUniqueIdentifier(Database, Data, CreatorUser, TimeStamp, 0).ToJson();
                    if (FlattenFields)
                        pdfStamper.AcroFields.SetField(pdfFieldKey, String.Empty);
                    else
                        pdfStamper.AcroFields.SetField(pdfFieldKey, fieldValue);

                    IList<AcroFields.FieldPosition> pdfFieldPositions = pdfStamper.AcroFields.GetFieldPositions(pdfFieldKey);
                    for (int pdfFieldOrdinal = 0; pdfFieldOrdinal < fields.Size; pdfFieldOrdinal++)
                    {
                        AcroFields.FieldPosition pdfFieldPosition = pdfFieldPositions[pdfFieldOrdinal];

                        // Create Binary Unique Identifier
                        var pageUniqueId = dt.CreateUniqueIdentifier(Database, Data, CreatorUser, TimeStamp, pdfFieldPosition.page);
                        var pageUniqueIdBytes = pageUniqueId.ToQRCodeBytes();

                        // Encode to QRCode byte array
                        var pageUniqueIdWidth = (int)pdfFieldPosition.position.Width;
                        var pageUniqueIdHeight = (int)pdfFieldPosition.position.Height;
                        var pageUniqueIdEncoded = QRCodeBinaryEncoder.Encode(pageUniqueIdBytes, pageUniqueIdWidth, pageUniqueIdHeight);

                        // Encode byte array to Image
                        var pageUniqueIdImageData = CCITTG4Encoder.Compress(pageUniqueIdEncoded, pageUniqueIdWidth, pageUniqueIdHeight);
                        var pageUniqueIdImage = iTextSharp.text.Image.GetInstance(pageUniqueIdWidth, pageUniqueIdHeight, false, 256, 1, pageUniqueIdImageData, null);

                        // Add to the pdf page
                        pageUniqueIdImage.SetAbsolutePosition(pdfFieldPosition.position.Left, pdfFieldPosition.position.Bottom);
                        pdfStamper.GetOverContent(pdfFieldPosition.page).AddImage(pageUniqueIdImage);
                    }
                    // Hide Fields
                    PdfDictionary field = fields.GetValue(0);
                    if ((PdfName)field.Get(PdfName.TYPE) == PdfName.ANNOT)
                    {
                        field.Put(PdfName.F, new PdfNumber(6));
                    }
                    else
                    {
                        PdfArray fieldKids = (PdfArray)field.Get(PdfName.KIDS);
                        foreach (PdfIndirectReference fieldKidRef in fieldKids)
                        {
                            ((PdfDictionary)pdfReader.GetPdfObject(fieldKidRef.Number)).Put(PdfName.F, new PdfNumber(6));
                        }
                    }
                }
                else
                {
                    Expression fieldExpression = null;
                    if (expressionCache.TryGetValue(pdfFieldKey, out fieldExpression))
                    {
                        if (fieldExpression.IsDynamic)
                        {
                            Tuple<string, bool, object> fieldExpressionResult = fieldExpression.Evaluate(Data, expressionVariables);

                            if (fieldExpressionResult.Item3 != null)
                            {
                                IImageExpressionResult imageResult = (fieldExpressionResult.Item3 as IImageExpressionResult);
                                if (imageResult != null)
                                {
                                    // Output Image
                                    AcroFields.Item fields = pdfStamper.AcroFields.Fields[pdfFieldKey];
                                    IList<AcroFields.FieldPosition> pdfFieldPositions = pdfStamper.AcroFields.GetFieldPositions(pdfFieldKey);
                                    for (int pdfFieldOrdinal = 0; pdfFieldOrdinal < fields.Size; pdfFieldOrdinal++)
                                    {
                                        AcroFields.FieldPosition pdfFieldPosition = pdfFieldPositions[pdfFieldOrdinal];
                                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(imageResult.GetImage((int)pdfFieldPosition.position.Width, (int)pdfFieldPosition.position.Height));
                                        pdfImage.SetAbsolutePosition(pdfFieldPosition.position.Left, pdfFieldPosition.position.Bottom);
                                        pdfStamper.GetOverContent(pdfFieldPosition.page).AddImage(pdfImage);
                                    }
                                    if (!fieldExpressionResult.Item2 && !imageResult.ShowField)
                                    {
                                        // Hide Fields
                                        PdfDictionary field = fields.GetValue(0);
                                        if ((PdfName)field.Get(PdfName.TYPE) == PdfName.ANNOT)
                                        {
                                            field.Put(PdfName.F, new PdfNumber(6));
                                        }
                                        else
                                        {
                                            PdfArray fieldKids = (PdfArray)field.Get(PdfName.KIDS);
                                            foreach (PdfIndirectReference fieldKidRef in fieldKids)
                                            {
                                                ((PdfDictionary)pdfReader.GetPdfObject(fieldKidRef.Number)).Put(PdfName.F, new PdfNumber(6));
                                            }
                                        }
                                    }
                                }
                            }

                            pdfStamper.AcroFields.SetField(pdfFieldKey, fieldExpressionResult.Item1);

                            if (fieldExpressionResult.Item2) // Expression Error
                            {
                                AcroFields.Item fields = pdfStamper.AcroFields.Fields[pdfFieldKey];
                                for (int pdfFieldOrdinal = 0; pdfFieldOrdinal < fields.Size; pdfFieldOrdinal++)
                                {
                                    PdfDictionary field = fields.GetValue(pdfFieldOrdinal);
                                    PdfDictionary fieldMK;
                                    if (field.Contains(PdfName.MK))
                                        fieldMK = field.GetAsDict(PdfName.MK);
                                    else
                                    {
                                        fieldMK = new PdfDictionary(PdfName.MK);
                                        field.Put(PdfName.MK, fieldMK);
                                    }
                                    fieldMK.Put(PdfName.BC, new PdfArray(new float[] { 1, 0, 0 }));
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("Pdf template field expressions are out of sync with the expression cache");
                    }
                }
                State.FlushFieldCache();
            }

            pdfStamper.Close();
            pdfReader.Close();

            if (dt.Scope == DocumentTemplate.DocumentTemplateScopes.Job)
            {
                // Write Job Log

                Job j = (Job)Data;
                JobLog jl = new JobLog()
                {
                    JobId = j.Id,
                    TechUserId = CreatorUser.UserId,
                    Timestamp = DateTime.Now
                };
                jl.Comments = string.Format("# Document Generated\r\n**{0}** [{1}]", dt.Description, dt.Id);
                Database.JobLogs.Add(jl);
            }

            pdfGeneratedStream.Position = 0;
            return pdfGeneratedStream;
        }

    }
}
