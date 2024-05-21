using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication8.Models;

namespace WebApplication8.DAL
{
    public class AppDbContex : IdentityDbContext
    {
        public AppDbContex(DbContextOptions options) : base(options)
        {
        }

      public DbSet<Workes> teams { get; set; }
    }
}
