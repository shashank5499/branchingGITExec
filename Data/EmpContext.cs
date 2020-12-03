using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppBranchingExercise.Models;

namespace WebAppBranchingExercise.Data
{
    public class EmpContext : DbContext
    {
        public EmpContext (DbContextOptions<EmpContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppBranchingExercise.Models.Emp> Emp { get; set; }
    }
}
