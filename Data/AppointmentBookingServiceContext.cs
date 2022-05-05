#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppointmentBookingService.Models;

namespace AppointmentBookingService.Data
{
    public class AppointmentBookingServiceContext : DbContext
    {
        public AppointmentBookingServiceContext (DbContextOptions<AppointmentBookingServiceContext> options)
            : base(options)
        {
        }

        public DbSet<AppointmentBookingService.Models.Booking> Booking { get; set; }
    }
}
