using Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main.Data
{
    public static class EntitySeed
    {
        public static ICollection<Bug> Bugs { get; } = new List<Bug>()
        {
            new Bug
            {
                Id = 1,
                Title = "UI Frontend",
                Description = "Buttons not working correctly",
                DateSubmitted = DateTime.Now,
                DateModified = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
                Status = TicketLibrary.Status.New,
                Solution = "Test solution field",
                Priority = TicketLibrary.PriorityLevel.Low,
                Warning = TicketLibrary.WarningLevel.Normal,
                AssignedProjectId = 1,
                AssignedMemberId = 1
            },
        };
        public static ICollection<Project> Projects { get; } = new List<Project>()
        {
            new Project
            {
                Id = 1,
                Title = "CMS",
                Description = "Test description field",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
            }
        };

        public static ICollection<Member> Members { get; } = new List<Member>()
        {
            new Member
            {
                Id = 1,
                FirstName = "Brendon",
                LastName = "Anderson",
                Email = "brendonander205@gmail.com",
                ContactNo = "0727716055",
                Role = TicketLibrary.MemberRole.Developer,
            }
        };
    }
}
