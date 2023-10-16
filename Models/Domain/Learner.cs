using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class Learner
    {
        public Guid LearnerId { get; set; } 
        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public string learnerCellPhoneNumber { get; set; }
        public string Grade { get; set; }

        //Link table
        public Guid ParentId { get; set; }
        //Navigation Property
        public Parent Parent { get; set; }
    }
}