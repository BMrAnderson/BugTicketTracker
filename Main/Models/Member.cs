using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketLibrary;

namespace Main.Models
{
    public class Member
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string ContactNo { get; }
        public MemberRole Role { get; }
        public List<Ticket> Bugs { get; } = new List<Ticket>();
    }
}
