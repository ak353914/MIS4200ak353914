using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class Sport
    {
        public int sportID { get; set; }
        [Display(Name = "Sport")]
        [Required(ErrorMessage = "Sport is a required field.")]
        [StringLength(30)]

        public string sportName { get; set; }
        [Display(Name = "Country of Origin")]
        [Required(ErrorMessage = "Country of Origin is a required field.")]
        [StringLength(30)]

        public string sportCountry { get; set; }
        public ICollection<PlayerSport> PlayerSport { get; set; }
    }
}