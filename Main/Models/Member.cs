using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TicketLibrary;

namespace Main.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "First name must contain atleast 2 alpha characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(maximumLength: 50 ,MinimumLength = 2, ErrorMessage = "Last name must contain atleast 2 alpha characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public byte[] Salt { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }
        
        [Required(ErrorMessage = "Member role is required.")]
        public MemberRole Role { get; set; }

        public virtual ICollection<Bug> BugsAssigned { get; set; }
        
        public virtual ICollection<Project> ProjectsAssigned { get; set; }
    }
}
