using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FileNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4a73b448-dfb3-4f43-9ab1-057a5e93e529", "8fe5a189-51fd-429d-8d7e-dd150061d633" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a73b448-dfb3-4f43-9ab1-057a5e93e529");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fe5a189-51fd-429d-8d7e-dd150061d633");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dae1c0d3-ebdb-4361-8702-6c7e3520dc74", "dae1c0d3-ebdb-4361-8702-6c7e3520dc74", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0347e455-cccc-427d-b9c7-e3cdbd537a55", 0, "e2f558f5-e432-4839-b547-d5072aee0c2b", "adminuser@wsei.edu.pl", true, false, null, "ADMINUSER@WSEI.EDU.PL", "ADMINUSER@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEJ8x/qcE6FX2gjwyTNyPjeBjcH6NXbzGOHgbwVYLaao/CQsKrdHosK+FxY1fBEtR0g==", null, false, "ef96c0ad-5625-4b81-a1cb-52d8420a103a", false, "adminuser@wsei.edu.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dae1c0d3-ebdb-4361-8702-6c7e3520dc74", "0347e455-cccc-427d-b9c7-e3cdbd537a55" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dae1c0d3-ebdb-4361-8702-6c7e3520dc74", "0347e455-cccc-427d-b9c7-e3cdbd537a55" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dae1c0d3-ebdb-4361-8702-6c7e3520dc74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0347e455-cccc-427d-b9c7-e3cdbd537a55");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a73b448-dfb3-4f43-9ab1-057a5e93e529", "4a73b448-dfb3-4f43-9ab1-057a5e93e529", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8fe5a189-51fd-429d-8d7e-dd150061d633", 0, "53c5ac6e-6036-47b7-93a0-d2a246889d1b", "adminuser@wsei.edu.pl", true, false, null, "ADMINUSER@WSEI.EDU.PL", "ADMINUSER@WSEI.EDU.PL", "AQAAAAIAAYagAAAAEENn2kBAS/qNcAuod5sr1nQuEtYK7pWBmL71iYpmj0SvBHfY8P3Qn34PW97u52vr6Q==", null, false, "ca153983-665f-4e24-a839-d31265e6f675", false, "adminuser@wsei.edu.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4a73b448-dfb3-4f43-9ab1-057a5e93e529", "8fe5a189-51fd-429d-8d7e-dd150061d633" });
        }
    }
}
