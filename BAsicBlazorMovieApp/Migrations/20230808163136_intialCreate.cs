using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BAsicBlazorMovieApp.Migrations
{
    /// <inheritdoc />
    public partial class intialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MovieModels",
                columns: new[] { "Id", "Description", "ImageUrl", "Review", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ", "/images/movies/Highlander.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia", "Highlander" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ", "/images/movies/Godfather.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia", "Godfather" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ", "/images/movies/LastOfTheMohicans.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia", "Last of the Mohicans" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ", "/images/movies/RearWindow.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia", "Rear Window" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ", "/images/movies/RoadHouse.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia", "Road House" },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. ", "/images/movies/StarTreck4.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vitae nunc risus. Cras sed ex augue. Etiam rutrum massa at enim sollicitudin scelerisque. Pellentesque dignissim, velit vitae lacinia", "Star Treck IV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieModels");
        }
    }
}
