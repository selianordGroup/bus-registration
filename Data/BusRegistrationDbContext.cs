using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bus_registration.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace bus_registration.Data
{
    public class BusRegistrationDbContext :DbContext
    {
        public BusRegistrationDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }

        //DbSet
        public DbSet<Adminstrator> Adminstrators { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Route> Routes { get; set; }
    }
}