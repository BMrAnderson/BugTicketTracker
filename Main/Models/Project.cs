using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TicketLibrary;

namespace Main.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Project title is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 2, ErrorMessage = "Project title must contain atleast 2 alpha characters.")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Project description is required.")]
        [StringLength(maximumLength: 200, MinimumLength = 10, ErrorMessage = "Project description must contain atleast 10 alpha characters.")]
        public string Description { get; set; }
       
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Start date of the project is required.")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "End date of the project is required.")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Select the current status of the project.")]
        public Status Status { get; set; }

        public virtual ICollection<Bug> Bugs { get; set; } 

        public virtual ICollection<Member> MembersAssigned { get; set; }
    }
}
