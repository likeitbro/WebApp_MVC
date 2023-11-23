using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppProject.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTableToWebAppDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) // Creates a table if build succeeds
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) // Drops a table if build does not succeed
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
