using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class Team
    {
        public int teamID { get; set; }
        public string city { get; set; }
        public string teamName { get; set; }
        public string payroll { get; set; }
        public ICollection<Player> Player { get; set; }
    }
}