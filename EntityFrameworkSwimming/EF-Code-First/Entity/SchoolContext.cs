﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Entity
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=DefaultConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
