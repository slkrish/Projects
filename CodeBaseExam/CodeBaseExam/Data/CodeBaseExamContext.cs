using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBaseExam.Models;

namespace CodeBaseExam.Data
{
    public class CodeBaseExamContext : DbContext
    {
        public CodeBaseExamContext (DbContextOptions<CodeBaseExamContext> options)
            : base(options)
        {
        }

        public DbSet<CodeBaseExam.Models.Student> Student { get; set; }
    }
}
