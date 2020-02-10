using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class Sport
    {
        public int sportID { get; set; }
        public string sportName { get; set; }
        public string sportCountry { get; set; }
        public ICollection<PlayerSport> PlayerSport { get; set; }
    }
}