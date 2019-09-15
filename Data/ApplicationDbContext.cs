using System;
using System.Collections.Generic;
using System.Text;
using FinGoals.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinGoals.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SavingsGoal> SavingsGoals { get; set; }
        public DbSet<SavingsAmount> SavingsAmounts { get; set; }
    }
}
