using ApiProjeKampi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeKampi.Context
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KIRMIZI\\SQLEXPRESS01 ;initial catalog=ApiYummyDb; integrated security=true;TrustServerCertificate=True");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation>Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimoinal> Testimonials { get; set; }


      
    }
}
