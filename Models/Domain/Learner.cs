using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class Learner
    {
        public Guid Id { get; set; } 
        public string LearnerName { get; set; }
        public string LearnerSurname { get; set; }
        public string LearnerCellPhoneNumber { get; set; }
        public string Grade { get; set; }

        //Link table
        [ForeignKey("Parent")]
        public Guid ParentId { get; set; }
        //Navigation Property
        public Parent Parent { get; set; }
    }
}