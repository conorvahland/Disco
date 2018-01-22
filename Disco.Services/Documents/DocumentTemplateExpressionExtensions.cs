﻿using Disco.Data.Repository;
using Disco.Models.Repository;
using Disco.Models.Services.Documents;
using Disco.Services.Documents;
using Disco.Services.Expressions;
using System;
using System.Collections.Generic;

namespace Disco.Services
{
    public static class DocumentTemplateExpressionExtensions
    {
        internal const string CacheTemplate = "DocumentTemplate_{0}";

        public static Expression FilterExpressionFromCache(this DocumentTemplate dt)
        {
            return ExpressionCache.GetValue("DocumentTemplate_FilterExpression", dt.Id, () => { return Expression.TokenizeSingleDynamic(null, dt.FilterExpression, 0); });
        }

        public static void FilterExpressionInvalidateCache(this DocumentTemplate dt)
        {
            ExpressionCache.InvalidateKey("DocumentTemplate_FilterExpression", dt.Id);
        }

        public static bool FilterExpressionMatches(this DocumentTemplate dt, object Data, DiscoDataContext Database, User User, System.DateTime TimeStamp, DocumentState State)
        {
            if (!string.IsNullOrEmpty(dt.FilterExpression))
            {
                var compiledExpression = dt.FilterExpressionFromCache();
                var evaluatorVariables = Expression.StandardVariables(dt, Database, User, TimeStamp, State);
                try
                {
                    var er = compiledExpression.EvaluateFirst<object>(Data, evaluatorVariables);
                    if (er is bool)
                    {
                        return (bool)er;
                    }
                    bool erBool;
                    if (bool.TryParse(er.ToString(), out erBool))
                    {
                        return erBool;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        public static Expression OnImportAttachmentExpressionFromCache(this DocumentTemplate dt)
        {
            return ExpressionCache.GetValue("DocumentTemplate_OnImportExpression", dt.Id, () => { return Expression.TokenizeSingleDynamic(null, dt.OnImportAttachmentExpression, 0); });
        }

        public static void OnImportAttachmentExpressionInvalidateCache(this DocumentTemplate dt)
        {
            ExpressionCache.InvalidateKey("DocumentTemplate_OnImportExpression", dt.Id);
        }

        public static string EvaluateOnAttachmentImportExpression(this DocumentTemplate dt, IAttachment Data, DiscoDataContext Database, User User, DateTime TimeStamp, List<DocumentUniqueIdentifier> PageIdentifiers)
        {
            if (!string.IsNullOrEmpty(dt.OnImportAttachmentExpression))
            {
                var compiledExpression = dt.OnImportAttachmentExpressionFromCache();
                var evaluatorVariables = Expression.StandardVariables(dt, Database, User, TimeStamp, null);
                evaluatorVariables.Add("PageIdentifiers", PageIdentifiers);
                var result = compiledExpression.EvaluateFirst<object>(Data, evaluatorVariables);
                if (result == null)
                    return null;
                else
                    return result.ToString();
            }
            return null;
        }

        public static Expression OnGenerateExpressionFromCache(this DocumentTemplate dt)
        {
            return ExpressionCache.GetValue("DocumentTemplate_OnGenerateExpression", dt.Id, () => { return Expression.TokenizeSingleDynamic(null, dt.OnGenerateExpression, 0); });
        }

        public static void OnGenerateExpressionInvalidateCache(this DocumentTemplate dt)
        {
            ExpressionCache.InvalidateKey("DocumentTemplate_OnGenerateExpression", dt.Id);
        }

        public static string EvaluateOnGenerateExpression(this DocumentTemplate dt, object Data, DiscoDataContext Database, User User, DateTime TimeStamp, DocumentState State)
        {
            if (!string.IsNullOrEmpty(dt.OnGenerateExpression))
            {
                var compiledExpression = dt.OnGenerateExpressionFromCache();
                var evaluatorVariables = Expression.StandardVariables(dt, Database, User, TimeStamp, State);

                var result = compiledExpression.EvaluateFirst<object>(Data, evaluatorVariables);
                return result.ToString();
            }
            return null;
        }
    }
}
