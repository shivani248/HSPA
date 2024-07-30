using System.Text;
using Microsoft.EntityFrameworkCore;
using WebAPI.Controllers;
using WebAPI.Model;
using WebAPI.Models;

namespace WebAPI
{
    public class DataContext : DbContext //Datacontext is derived form DbContext that is a instance 
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) //constructor & passed DbOption that is type of DatContext
        {
        }

        public DbSet<City> Cities { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyType> PropertyTypes { get; set; }

        public DbSet<FurnishingType> FurnishingTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "Demo",
                    Password = Encoding.UTF8.GetBytes("hashed_password"),// Your hashed password here,
                    PasswordKey = Encoding.UTF8.GetBytes("hashed_password_key"),// Your password key here,
                    LastUpdateOn = DateTime.Now,
                    LastUpdatedBy = 0
                }
            );

            modelBuilder.Entity<PropertyType>().HasData(
                new PropertyType { Id = 1, Name = "House", LastUpdateOn = DateTime.Now, LastUpdatedBy = 1 },
                new PropertyType { Id = 2, Name = "Apartment", LastUpdateOn = DateTime.Now, LastUpdatedBy = 1 },
                new PropertyType { Id = 3, Name = "Duplex", LastUpdateOn = DateTime.Now, LastUpdatedBy = 1 }
            );

            modelBuilder.Entity<FurnishingType>().HasData(
                new FurnishingType { Id = 1, Name = "Fully", LastUpdateOn = DateTime.Now, LastUpdatedBy = 1 },
                new FurnishingType { Id = 2, Name = "Semi", LastUpdateOn = DateTime.Now, LastUpdatedBy = 1 },
                new FurnishingType { Id = 3, Name = "Unfurnished", LastUpdateOn = DateTime.Now, LastUpdatedBy = 1 }
            );

            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "New York", LastUpdatedBy = 1, LastUpdateOn = DateTime.Now, Country = "USA" },
                new City { Id = 2, Name = "Houston", LastUpdatedBy = 1, LastUpdateOn = DateTime.Now, Country = "USA" },
                new City { Id = 3, Name = "Los Angeles", LastUpdatedBy = 1, LastUpdateOn = DateTime.Now, Country = "USA" },
                new City { Id = 4, Name = "New Delhi", LastUpdatedBy = 1, LastUpdateOn = DateTime.Now, Country = "India" },
                new City { Id = 5, Name = "Bangalore", LastUpdatedBy = 1, LastUpdateOn = DateTime.Now, Country = "India" }
            );

            modelBuilder.Entity<Property>().HasData(
                new Property
                {
                    Id = 1,
                    SellRent = 1,
                    Name = "White House Demo",
                    PropertyTypeId = 2, // Apartment
                    BHK = 2,
                    FurnishingTypeId = 1, // Fully
                    Price = 1800,
                    BuiltArea = 1400,
                    CarpetArea = 900,
                    Address = "6 Street",
                    Address2 = "Golf Course Road",
                    CityId = 1, // New York
                    FloorNo = 3,
                    TotalFloors = 3,
                    ReadyToMove = true, //1,
                    MainEntrance = "East",
                    Security = 0,
                    Gated = true, //1
                    Maintenance = 300,
                    EstPossessionOn = new DateTime(2019, 01, 01),
                    Age = 0,
                    Description = "Well Maintained builder floor available for rent at prime location...",
                    PostedOn = DateTime.Now,
                    PostedBy = 1,
                    
                },
                new Property
                {
                    Id = 2,
                    SellRent = 2,
                    Name = "Birla House Demo",
                    PropertyTypeId = 2, // Apartment
                    BHK = 2,
                    FurnishingTypeId = 1, // Fully
                    Price = 1800,
                    BuiltArea = 1400,
                    CarpetArea = 900,
                    Address = "6 Street",
                    Address2 = "Golf Course Road",
                    CityId = 1, // New York
                    FloorNo = 3,
                    TotalFloors = 3,
                    ReadyToMove = true, //1
                    MainEntrance = "East",
                    Security = 0,
                    Gated = true, //1
                    Maintenance = 300,
                    EstPossessionOn = new DateTime(2019, 01, 01),
                    Age = 0,
                    Description = "Well Maintained builder floor available for rent at prime location...",
                    PostedOn = DateTime.Now,
                    PostedBy = 1,
                    
                }
            );
        }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<City>().HasData(
        //        new City
        //        {
        //          Id = 2,
        //           Name = "robert Jones"
        //        }
        //    );
        //}

        //Now we have to register it so that it can be avialbale via dependency injection in controlers so lets do it in program.cs

    }

}
