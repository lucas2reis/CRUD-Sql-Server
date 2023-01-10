﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDSQL.Models;

namespace CRUDSQL.Data
{
    public class CRUDSQLContext : DbContext
    {
        public CRUDSQLContext (DbContextOptions<CRUDSQLContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDSQL.Models.Produto> Produto { get; set; }
    }
}
