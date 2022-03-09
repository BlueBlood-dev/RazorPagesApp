#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Data
{
    public class RazorPagesAppContext : DbContext
    {
        public RazorPagesAppContext (DbContextOptions<RazorPagesAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesApp.Models.Note> Note { get; set; }
    }
}
