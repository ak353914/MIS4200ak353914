using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class PlayerSport
    {
        public int playerSportID { get; set; }
        public string position  { get; set; }
        public int playerID { get; set; }
        public virtual Player Player { get; set; }
        public int sportID { get; set; }
        public virtual Sport Sport { get; set; }
    }
}