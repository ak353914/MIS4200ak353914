using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200ak353914.Models;
using System.Data.Entity;

namespace MIS4200ak353914.DAL
{
    public class MIS4200Context : DbContext
    {
     
            public MIS4200Context() : base("name=DefaultConnection")
            {

            }
            public DbSet<Team> Team { get; set; }
            public DbSet<Player> Player { get; set; }
            public DbSet<Sport> Sport { get; set; }
            public DbSet<PlayerSport> PlayerSport { get; set; }

        
    }
}