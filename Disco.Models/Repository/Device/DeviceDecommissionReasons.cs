﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disco.Models.Repository
{
    public enum DecommissionReasons
    {
        EndOfLife = 0,
        Sold = 10,
        Stolen = 20,
        Lost = 30,
        Damaged = 40,
        Donated = 50
    }
}
