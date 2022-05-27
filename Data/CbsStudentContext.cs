using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CbsStudent.Models;

    public class CbsStudentContext : DbContext
    {
        public CbsStudentContext (DbContextOptions<CbsStudentContext> options)
            : base(options)
        {
        }

        public DbSet<CbsStudent.Models.Profile>? Profile { get; set; }

        public DbSet<CbsStudent.Models.Event>? Event { get; set; }
    }
