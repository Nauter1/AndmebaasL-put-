using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtGallery.Data.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseFixChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Artwork_ArtworkId",
                table: "Artist");

            migrationBuilder.DropForeignKey(
                name: "FK_Artwork_DisplayDates_DisplayDatesDisplayId",
                table: "Artwork");

            migrationBuilder.DropForeignKey(
                name: "FK_Exhibit_DisplayDates_DisplayDatesDisplayId",
                table: "Exhibit");

            migrationBuilder.DropForeignKey(
                name: "FK_Gallery_Exhibit_ExhibitId",
                table: "Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Gallery_ExhibitId",
                table: "Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Artist_ArtworkId",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "ExhibitId",
                table: "Gallery");

            migrationBuilder.DropColumn(
                name: "ArtworkId",
                table: "Artist");

            migrationBuilder.RenameColumn(
                name: "DisplayDatesDisplayId",
                table: "Exhibit",
                newName: "GalleryId");

            migrationBuilder.RenameIndex(
                name: "IX_Exhibit_DisplayDatesDisplayId",
                table: "Exhibit",
                newName: "IX_Exhibit_GalleryId");

            migrationBuilder.RenameColumn(
                name: "DisplayDatesDisplayId",
                table: "Artwork",
                newName: "ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Artwork_DisplayDatesDisplayId",
                table: "Artwork",
                newName: "IX_Artwork_ArtistId");

            migrationBuilder.AddColumn<int>(
                name: "ArtworkId",
                table: "DisplayDates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExhibitId",
                table: "DisplayDates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DisplayDates_ArtworkId",
                table: "DisplayDates",
                column: "ArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_DisplayDates_ExhibitId",
                table: "DisplayDates",
                column: "ExhibitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artwork_Artist_ArtistId",
                table: "Artwork",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisplayDates_Artwork_ArtworkId",
                table: "DisplayDates",
                column: "ArtworkId",
                principalTable: "Artwork",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DisplayDates_Exhibit_ExhibitId",
                table: "DisplayDates",
                column: "ExhibitId",
                principalTable: "Exhibit",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exhibit_Gallery_GalleryId",
                table: "Exhibit",
                column: "GalleryId",
                principalTable: "Gallery",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artwork_Artist_ArtistId",
                table: "Artwork");

            migrationBuilder.DropForeignKey(
                name: "FK_DisplayDates_Artwork_ArtworkId",
                table: "DisplayDates");

            migrationBuilder.DropForeignKey(
                name: "FK_DisplayDates_Exhibit_ExhibitId",
                table: "DisplayDates");

            migrationBuilder.DropForeignKey(
                name: "FK_Exhibit_Gallery_GalleryId",
                table: "Exhibit");

            migrationBuilder.DropIndex(
                name: "IX_DisplayDates_ArtworkId",
                table: "DisplayDates");

            migrationBuilder.DropIndex(
                name: "IX_DisplayDates_ExhibitId",
                table: "DisplayDates");

            migrationBuilder.DropColumn(
                name: "ArtworkId",
                table: "DisplayDates");

            migrationBuilder.DropColumn(
                name: "ExhibitId",
                table: "DisplayDates");

            migrationBuilder.RenameColumn(
                name: "GalleryId",
                table: "Exhibit",
                newName: "DisplayDatesDisplayId");

            migrationBuilder.RenameIndex(
                name: "IX_Exhibit_GalleryId",
                table: "Exhibit",
                newName: "IX_Exhibit_DisplayDatesDisplayId");

            migrationBuilder.RenameColumn(
                name: "ArtistId",
                table: "Artwork",
                newName: "DisplayDatesDisplayId");

            migrationBuilder.RenameIndex(
                name: "IX_Artwork_ArtistId",
                table: "Artwork",
                newName: "IX_Artwork_DisplayDatesDisplayId");

            migrationBuilder.AddColumn<int>(
                name: "ExhibitId",
                table: "Gallery",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArtworkId",
                table: "Artist",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gallery_ExhibitId",
                table: "Gallery",
                column: "ExhibitId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ArtworkId",
                table: "Artist",
                column: "ArtworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Artwork_ArtworkId",
                table: "Artist",
                column: "ArtworkId",
                principalTable: "Artwork",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artwork_DisplayDates_DisplayDatesDisplayId",
                table: "Artwork",
                column: "DisplayDatesDisplayId",
                principalTable: "DisplayDates",
                principalColumn: "DisplayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exhibit_DisplayDates_DisplayDatesDisplayId",
                table: "Exhibit",
                column: "DisplayDatesDisplayId",
                principalTable: "DisplayDates",
                principalColumn: "DisplayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gallery_Exhibit_ExhibitId",
                table: "Gallery",
                column: "ExhibitId",
                principalTable: "Exhibit",
                principalColumn: "Id");
        }
    }
}
