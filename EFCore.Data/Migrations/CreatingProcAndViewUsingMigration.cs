using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatingProcAndViewUsingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.Sql(@"CREATE OR ALTER VIEW dbo.GetAllBookDetails
                AS
                SELECT * FROM dbo.Books m
               ");
            migrationBuilder.Sql(@"CREATE   PROICEDURE dbo.getBookDetailsById
                @bookId int
                AS
                SET NOCOUNT ON;
                SELECT * FROM dbo.Books b 
                WHERE b.BookId = @bookId
               ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.GetMainDetails");
            migrationBuilder.Sql("DROP VIEW dbo.GetAllBookDetails");
            migrationBuilder.Sql("DROP PROCEDURE dbo.getBookDetailById");

        }
    }
}