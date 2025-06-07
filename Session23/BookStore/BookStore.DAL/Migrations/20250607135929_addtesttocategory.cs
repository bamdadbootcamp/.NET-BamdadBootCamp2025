using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addtesttocategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Test",
                schema: "bs",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                schema: "bs",
                table: "Category");
        }
    }
}
