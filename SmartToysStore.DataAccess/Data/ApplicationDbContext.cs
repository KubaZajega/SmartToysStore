using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartToysStore.Models;

namespace SmartToysStore.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Interactive", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Puzzle", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Feeder", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Waterer", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Plush", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Travel", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Movers", DisplayOrder = 7 }
            );
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", StreetAddress = "123 Tech St", City = "Tech City", State = "IL", PostalCode = "12121", PhoneNumber = "1234567890"},
                new Company { Id = 2, Name = "Vivid Books", StreetAddress = "999 Vid St", City = "Vid City", State = "IL", PostalCode = "66666", PhoneNumber = "0987654321"},
                new Company { Id = 3, Name = "Readers Club", StreetAddress = "587 Main St", City = "Lala Land", State = "NY", PostalCode = "99999", PhoneNumber = "1112223334"}
            );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1, 
                    Name = "Dog Puzzle Toy",
                    Description = "This interactive dog puzzle toy provides an entertaining brain game for puppies and cats. It encourages and trains your pets to seek food by sliding the parts, helping them increase their IQ through learning sequential steps and engaging in challenging play.",
                    ModelCode = "B0DCYYX4LR",
                    Price = 10.00,
                    Price50 = 9.80,
                    Price100 = 9.50,
                    Color = "Pink",
                    Link = "https://www.amazon.com/SYNATANA-Enrichment-Stimulation-Training-Dispense/dp/B0DCYYX4LR/ref=sr_1_1_sspa?crid=2R31LDUSIGVE6&dib=eyJ2IjoiMSJ9.27vy3bjlY6X8DSfw2qzdQ6IqxI8zm5keAnRoAwpuDcDwwMbGxlTe_WGX7Tfc7CnMECjp4JtxnnmE304bJJ97tWOAg7Gr5v9XBiRyK97zTEPBNctjbyuISDXCg0CpBvqb6jrGTKmCPypFnHk9_h9yTurRDC7bbaoJ4ejKyt9XI5njVtzqlIo9D-lTgI134LxnPJNKfEjTorKbzH5bgHiEAcFYGsd1gE41ZMPtqYfGwO3p-UhYjK-c4tbrCg99EOj9IxQ1zjyKVAj76WmabSNGrOa3Vc3Bkv3Xij_o9uFHIvg.jw4pl-sO9G1ILQzGEcYLfbQBiYMKiElc3Z_5Oqs3OV0&dib_tag=se&keywords=dogs%2Btoys%2Bsmart&qid=1732174403&sprefix=dogs%2Btoys%2Bsmar%2Caps%2C176&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&th=1",
                    Image = "https://m.media-amazon.com/images/I/71XFp-kRtGL._AC_SL1500_.jpg",
                    CategoryId = 2
                },
            new Product
                {
                    Id = 2, 
                    Name = "TEST Toy",
                    Description = "Testestestestest",
                    ModelCode = "Testcode",
                    Price = 111.50,
                    Price50 = 110.80,
                    Price100 = 110,
                    Color = "Yellow",
                    Link = "testLINK",
                    Image = "testIMAGE",
                    CategoryId = 1
                }
            );
        }
    }
};