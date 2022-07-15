using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDotNetCoreMVC.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
    }
}