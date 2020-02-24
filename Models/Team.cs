using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class Team
    {
        public int teamID { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "City is a required field.")]
        [StringLength(30)]

        public string city { get; set; }
        [Display(Name = "Nickname")]
        [Required(ErrorMessage = "Nickname is a required field.")]
        [StringLength(30)]

        public string teamName { get; set; }
        [Display(Name = "Payroll")]
        [Required(ErrorMessage = "Payroll is a required field.")]
        [StringLength(12)]

        public string payroll { get; set; }
        public ICollection<Player> Player { get; set; }
    }
}