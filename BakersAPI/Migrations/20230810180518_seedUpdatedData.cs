using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakersAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedUpdatedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "BakerName",
                value: "Chef_Annah");

            migrationBuilder.UpdateData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 4L,
                column: "BakerName",
                value: "Chef_Ria");

            migrationBuilder.UpdateData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 5L,
                column: "BakerName",
                value: "Chef_Annah");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "BakerName",
                value: null);

            migrationBuilder.UpdateData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 4L,
                column: "BakerName",
                value: null);

            migrationBuilder.UpdateData(
                table: "BakerItems",
                keyColumn: "Id",
                keyValue: 5L,
                column: "BakerName",
                value: null);
        }
    }
}
