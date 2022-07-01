using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Zoomeet.Data.Models;

namespace Zoomeet.Data
{
    public class ZoomeetDbContext : DbContext
    {
        public ZoomeetDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuarios> Usuarios { get; set; }
        
    }
}
