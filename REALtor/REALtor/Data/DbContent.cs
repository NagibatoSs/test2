using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using REALtor.Data.Models;

namespace REALtor.Data
{
    public class DbContent : DbContext
    {
        public DbContent(DbContextOptions<DbContent> options) : base(options)
        {

        }
        public DbSet<House> House {get;set;}
    }
}
