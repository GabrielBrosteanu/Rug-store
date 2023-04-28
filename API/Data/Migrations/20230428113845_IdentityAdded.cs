using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09646a19-970c-47dc-8b08-460112c6b118");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab315167-faf1-4b05-8dbb-e0b091401701");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f4b7b80-1aee-4030-b8bc-47e1e7cc5d32", null, "Member", "MEMBER" },
                    { "4bcc9b4b-6e17-44d2-8309-023c2a7116e7", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f4b7b80-1aee-4030-b8bc-47e1e7cc5d32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4bcc9b4b-6e17-44d2-8309-023c2a7116e7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09646a19-970c-47dc-8b08-460112c6b118", null, "Member", "MEMBER" },
                    { "ab315167-faf1-4b05-8dbb-e0b091401701", null, "Admin", "ADMIN" }
                });
        }
    }
}
