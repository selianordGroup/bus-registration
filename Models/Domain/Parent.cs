using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class Parent
    {
        public Guid Id { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string Password { get; set; }
        public string CellphoneNumber { get; set; }

        public string ParentEmail { get; set; }

        //Links table

        [ForeignKey("Learner")]
        public Guid LearnerId { get; set; }

        //Navigation
        public Learner Learner { get; set; }
    }

}