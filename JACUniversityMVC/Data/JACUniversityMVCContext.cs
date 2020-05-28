using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JACUniverstityMVC.Models;

namespace JACUniversityMVC.Data
{
    public class JACUniversityMVCContext : DbContext
    {
        public JACUniversityMVCContext (DbContextOptions<JACUniversityMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JACUniverstityMVC.Models.Student> Student { get; set; }

        public DbSet<JACUniverstityMVC.Models.Course> Course { get; set; }

        public DbSet<JACUniverstityMVC.Models.Enrollment> Enrollment { get; set; }
    }
}
