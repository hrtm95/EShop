using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinsAddress",
                table: "Pictures",
                newName: "LinkAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkAddress",
                table: "Pictures",
                newName: "LinsAddress");
        }
    }
}
