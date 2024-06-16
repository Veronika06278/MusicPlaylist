using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicPlaylist.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrlToArtist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Artists");
        }
    }
}
