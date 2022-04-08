using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZPI
{
    class HandleConnection : DbContext
    {
        public DbSet<CardModel> Card { get; set; }
        public DbSet<RoomModel> Room { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=RFIDdb.db");
            base.OnConfiguring(dbContextOptionsBuilder);

        }
    }
}
