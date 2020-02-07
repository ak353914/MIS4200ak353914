using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class Player
    {
        public int playerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string year { get; set; }
        public string salary { get; set; }
        public string gamesPlayed { get; set; }
        public int teamID { get; set; }
        public virtual Team Team { get; set; }
    }
}