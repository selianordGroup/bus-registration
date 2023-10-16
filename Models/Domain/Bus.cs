using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace bus_registration.Models.Domain
{
    public class Bus
    {
        public Guid Id { get; set; }
        public int BusNumber { get; set; }
        public int PickUpNumber { get; set; }
        public int DropOffNumber { get; set; }
        public string PickUpName { get; set; }
        public string DropOffName { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime DropOffTime { get; set; }
        public int BusLimit { get; set; }
        public bool ApplicationsStatus { get; set; }
        public int WaitingNumber { get; set; }
        public DateTime WaitingListDate { get; set; }


        //Link
        [ForeignKey("Learner")]
        public Guid LearnerId { get; set; }
        //[ForeignKey("Route")]
        //public Guid RouteId { get; set; }

        //navigation
        public Learner Learner { get; set; }
        // public Route Route { get; set; }

    }
}