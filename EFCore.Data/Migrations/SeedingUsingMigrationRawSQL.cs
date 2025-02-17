using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Cat 1')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Cat 2')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Cat 3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}