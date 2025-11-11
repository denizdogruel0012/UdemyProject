using HoteilerProject.EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoteilerProject.DataaccessLayer.Concreate
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DENIZ\\MSSQLSERVER08;initial catalog=HotielerProjectApi;integrated Security=true;Trust server certificate=true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
    }
}
