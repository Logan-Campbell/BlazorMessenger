using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LANMessenger.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddGroupAndExampleUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "message",
                table: "Message",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "password", "username" },
                values: new object[,]
                {
                    { 1, "password", "Group" },
                    { 100, "letmein", "John Doe" },
                    { 101, "letmein", "Jane Smith" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DropColumn(
                name: "message",
                table: "Message");
        }
    }
}
