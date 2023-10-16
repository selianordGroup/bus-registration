using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class Adminstrator
    {
        public Guid AdminId { get; set; }
        public char Initials { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string Eamil { get; set; }

        //Link table
        public Guid LearnerId { get; set; }

        //Navigation
        public Learner Learner { get; set; }
    }
}