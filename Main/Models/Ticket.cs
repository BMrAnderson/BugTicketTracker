using Contracts;
using TicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Main.Models
{
    public class Ticket : IDescribable
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string GoalResult { get; set; }
        public string BugDirectory { get; set; }

        public PriorityLevel Priority { get; set; }
        public Status Status { get; set; }
        public WarningLevel Warning { get; set; }
        public Project Project { get; set; }
        public DateTime DateSubmitted { get; }
        public DateTime DateModified { get; }
        public DateTime EndDate { get; set; }
    }
}
