using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBaseFinalEvaluation.Models;

namespace CodeBaseFinalEvaluation.Data
{
    public class CodeBaseFinalEvaluationContext : DbContext
    {
        public CodeBaseFinalEvaluationContext (DbContextOptions<CodeBaseFinalEvaluationContext> options)
            : base(options)
        {
        }

        public DbSet<CodeBaseFinalEvaluation.Models.Employee> Employee { get; set; }
    }
}
