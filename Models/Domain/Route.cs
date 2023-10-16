using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bus_registration.Models.Domain
{
    public class BusRoute
    {
        public Guid RouteId { get; set; }
        public string RouteName { get; set; }
        public Guid BusId { get; set; }

        //Navigation property
        public Bus Bus { get; set; }
        
    }
}