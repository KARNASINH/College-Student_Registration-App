﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using COMP2084_Assignment_02.Models;

namespace COMP2084_Assignment_02.Data
{
    public class COMP2084_Assignment_02Context : DbContext
    {
        public COMP2084_Assignment_02Context (DbContextOptions<COMP2084_Assignment_02Context> options)
            : base(options)
        {
        }

        public DbSet<COMP2084_Assignment_02.Models.Student> Student { get; set; }
    }
}