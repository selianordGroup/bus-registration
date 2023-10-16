using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class Adminstrator
    {
        public Guid Id { get; set; }
        public char Initials { get; set; }
        public string SurName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        //Link table
        [ForeignKey("Learner")]
        public Guid LearnerId { get; set; }

        //Navigation
        public Learner Learner { get; set; }
    }
}