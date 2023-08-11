using Microsoft.EntityFrameworkCore;

namespace BakersAPI.Models
{
    public class BakerContext : DbContext
    {
        public BakerContext(DbContextOptions<BakerContext> options)
          : base(options)
        {
        }

        public DbSet<Bakeritem> BakerItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bakeritem>().HasData(
                new Bakeritem()
                {
                    Id = 1,
                    Name = "Chees Cake",
                    Price = 1200,
                    Description = "Carrot cake is moist, light, fluffy, and topped with a rich cream cheese frosting.Very moist and very tasty, will buy this cake again.Absolutely delicious! The main beauty is that it only comes in a larger size and square cup-cake size as a platter too, which can be a stunning dessert",
                    BakerName = "Chef_Bongi",
                    ImageUrl = "https://www.allrecipes.com/thmb/hz54Dw9cCRehCTe6ZyF2IGeRo9Y=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/7402-carrot-cake-iii-sarah-dipity-1x1-1-2e7c90d8c07c47039b4906ec01911015.jpg",


                },
                 new Bakeritem()
                 {
                     Id = 2,
                     Name = "Black Forest Cake ",
                     Price = 1800,
                     Description = "Soaking the chocolate sponge in sugar syrup flavored with cherry brandy and topped with whipped cream and gelatin, or cornstarch.",
                     BakerName = "Chef_Bongi",
                     ImageUrl = "https://bon.sitenet.co.za/wp-content/uploads/2022/08/cooking-school-in-pretoria-1536x816.png",
                 },
                  new Bakeritem()
                  {
                      Id = 3,
                      Name = "Red Velvet Cake ",
                      Price = 1450,
                      Description = "Deep and rich, red velvet cake is a mild chocolate confection. cocoa flavor, As for frosting, Our cream cheese.",
                      BakerName = "Chef_Annah",
                      ImageUrl = "https://funcakes.com/content/uploads/2021/02/Red-Velvet-Cake-with-Fruit-960x960-c-default.jpg",
                  },

                    new Bakeritem()
                    {
                        Id = 4,
                        Name = "Strawberry Cake ",
                        Price = 1050,
                        Description = "Filled and coated in a wonderful strawberry cream cheese frosting, this cake has strawberry flavoring through and through.This strawberry cheesecake is a wonderful combination of rich, creamy New York cheesecake and bright, homemade strawberry sauce! It makes the best summertime dessert and is perfect for using those fresh, ripe, seasonal strawberries.",
                        BakerName = "Chef_Ria",
                        ImageUrl = "https://preppykitchen.com/wp-content/uploads/2022/05/Strawberry-Cake-Recipe-Card.jpg",
                    },
                    new Bakeritem()
                    {
                        Id = 5,
                        Name = "Mixed Cake Platter ",
                        Price = 3300,
                        Description = "Strawberry Cake, Red velvet cake and Carrot Cake.",
                        BakerName = "Chef_Annah",
                        ImageUrl = "https://bon.sitenet.co.za/wp-content/uploads/2022/08/bonaria-baking-school-in-pretoria-1024x683.png",
                    });
        }
    }

}
