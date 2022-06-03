using Microsoft.EntityFrameworkCore;

namespace XpertEventsApi.Data
{
    public class XpertEventDbContext:DbContext
    {
        public XpertEventDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(

                new Customer
                {
                    Id = 1,
                    Name = "Tunde Adepegba",
                    password = "chemicals"
                }, new Customer
                {
                    Id = 2,
                    Name = "Smita Pandya",
                    password = "projectManagement"
                }); 
                
                modelBuilder.Entity<Category>().HasData(new Category
                {
                    Id = 1,
                    Name = "Wedding"
                },
            new Category
            {
                Id = 2,
                Name = "Naming Ceremony"
            }
            );
            modelBuilder.Entity<Event>().HasData(
                 new Event
                 {
                     Id = 1,
                     EventTitle = "Bukola's wedding",
                     Date = DateTime.Now,
                     CategoryId = 1,
                     CustomerId = 2,
                     
                     Description = "You are specially invited to the holy matrimony of Bukola and Tunde Adepegba on the 31st of may, 2023"
                 },
            new Event
            {
                Id = 2,
                EventTitle = "Tayo's wedding",
                Date = DateTime.Now,
                CategoryId = 1,
                CustomerId = 1,
                Description = "You are specially invited to the Naming Ceremony and marriage of tayo, 2023"
            });
                
        }
        
        
    }
}
