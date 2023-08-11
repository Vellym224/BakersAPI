using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakersAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BakerItems",
                columns: new[] { "Id", "BakerName", "Description", "ImageUrl", "IsDone", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Chef_Bongi", "Carrot cake is moist, light, fluffy, and topped with a rich cream cheese frosting.Very moist and very tasty, will buy this cake again.Absolutely delicious! The main beauty is that it only comes in a larger size and square cup-cake size as a platter too, which can be a stunning dessert", "https://www.allrecipes.com/thmb/hz54Dw9cCRehCTe6ZyF2IGeRo9Y=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/7402-carrot-cake-iii-sarah-dipity-1x1-1-2e7c90d8c07c47039b4906ec01911015.jpg", false, "Chees Cake", 1200 },
                    { 2L, "Chef_Bongi", "Soaking the chocolate sponge in sugar syrup flavored with cherry brandy and topped with whipped cream and gelatin, or cornstarch.", "https://bon.sitenet.co.za/wp-content/uploads/2022/08/cooking-school-in-pretoria-1536x816.png", false, "Black Forest Cake ", 1800 },
                    { 3L, null, "Deep and rich, red velvet cake is a mild chocolate confection. cocoa flavor, As for frosting, Our cream cheese.", "https://funcakes.com/content/uploads/2021/02/Red-Velvet-Cake-with-Fruit-960x960-c-default.jpg", false, "Red Velvet Cake ", 1450 },
                    { 4L, null, "Filled and coated in a wonderful strawberry cream cheese frosting, this cake has strawberry flavoring through and through.This strawberry cheesecake is a wonderful combination of rich, creamy New York cheesecake and bright, homemade strawberry sauce! It makes the best summertime dessert and is perfect for using those fresh, ripe, seasonal strawberries.", "https://preppykitchen.com/wp-content/uploads/2022/05/Strawberry-Cake-Recipe-Card.jpg", false, "Strawberry Cake ", 1050 },
                    { 5L, null, "Strawberry Cake, Red velvet cake and Carrot Cake.", "https://bon.sitenet.co.za/wp-content/uploads/2022/08/bonaria-baking-school-in-pretoria-1024x683.png", false, "Mixed Cake Platter ", 3300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 5L);
        }
    }
}
