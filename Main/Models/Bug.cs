using Contracts;
using TicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Main.Models
{
    public class Bug 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bug title is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "Bug title must contain atleast 2 alpha characters.")]
        public string Title { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Bug description is required")]
        [StringLength(maximumLength: 200, MinimumLength = 10, ErrorMessage = "Bug description must contain atleast 10 alpha characters.")]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Solution is required.")]
        [StringLength(maximumLength: 200, MinimumLength = 10, ErrorMessage = "Bug solution must contain atleast 10 alpha characters.")]
        public string Solution { get; set; }

        [Required(ErrorMessage = "Current priority for the bug is required.")]
        public PriorityLevel Priority { get; set; }

        [Required(ErrorMessage = "Current status for the bug is required.")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "Current level of warning for the bug is required.")]
        public WarningLevel Warning { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "End date for this bug is required.")]
        public DateTime EndDate { get; set; }

        public int AssignedMemberId { get; set; }
        
        public virtual Member AssignedMember { get; set; }

        public int AssignedProjectId { get; set; }
       
        public virtual Project AssignedProject { get; set; }

        public DateTime DateSubmitted { get; set; }
       
        public DateTime DateModified { get; set;}   
    }
}
