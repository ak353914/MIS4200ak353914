using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200ak353914.Models
{
    public class Player
    {
        public int playerID { get; set; }
        [Display (Name="First Name")]
        [Required(ErrorMessage ="First Name is a required field.")]
        //[StringLength(30)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is a required field.")]
        //[StringLength(40)]
        public string lastName { get; set; }
        [Display(Name = "Year")]
        [Required(ErrorMessage = "Year is a required field.")]
        //[StringLength(4)]

        public string year { get; set; }
        [Display(Name = "Salary")]
        [Required(ErrorMessage = "Salary is a required field.")]
        //[StringLength(10)]
        public string salary { get; set; }
        [Display(Name = "Games Played")]
        [Required(ErrorMessage = "Games Played is a required field.")]
        //[StringLength(3)]

        public string gamesPlayed { get; set; }
        public ICollection<PlayerSport> PlayerSport { get; set; }
        public int teamID { get; set; }
        public virtual Team Team { get; set; }
    }
}