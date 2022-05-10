using Microsoft.EntityFrameworkCore;
using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess
{
    internal class PersonelBilgiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-808K207; Database=PersonelBilgiDB; uid=sa; pwd=1234;");
        }
        public DbSet<PersonelBilgi> PersonelBilgisi { get; set; }
    }
}
