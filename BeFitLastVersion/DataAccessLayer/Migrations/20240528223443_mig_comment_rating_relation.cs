using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_comment_rating_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceScore",
                table: "Places");

            migrationBuilder.AddColumn<int>(
                name: "PlaceScore",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceScore",
                table: "Comment");

            migrationBuilder.AddColumn<int>(
                name: "PlaceScore",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
