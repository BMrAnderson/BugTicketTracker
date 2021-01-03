using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Models
{
    public class Project
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Ticket> Bugs { get; } = new List<Ticket>();
    }
}
