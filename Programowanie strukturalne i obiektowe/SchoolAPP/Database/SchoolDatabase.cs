﻿using Microsoft.EntityFrameworkCore;
using SchoolAPP.Database.Entities;
using System;
using System.Collections.Generic;

namespace SchoolAPP.Database
{
    class SchoolDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=schoolDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }
                                  
        public List<SchoolClass> SchoolClasses { get; set; }

    }
}