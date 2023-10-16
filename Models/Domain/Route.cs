using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class BusRoute
    {
        public Guid Id { get; set; }
        public string RouteName { get; set; }
        [ForeignKey("Bus")]
        public Guid BusId { get; set; }

        //Navigation property
        public Bus Bus { get; set; }
        
    }
}