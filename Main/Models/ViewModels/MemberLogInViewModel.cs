using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Main.Models.Context
{
    public class MemberLogInViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public byte[] Salt { get; set; }
    }
}
