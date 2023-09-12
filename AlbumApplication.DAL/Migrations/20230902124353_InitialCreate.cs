using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlbumApplication.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesStatu = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminAlbum",
                columns: table => new
                {
                    AdminsId = table.Column<int>(type: "int", nullable: false),
                    AlbumsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminAlbum", x => new { x.AdminsId, x.AlbumsId });
                    table.ForeignKey(
                        name: "FK_AdminAlbum_Admins_AdminsId",
                        column: x => x.AdminsId,
                        principalTable: "Admins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminAlbum_Albums_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "IsDeleted", "Password", "UserName" },
                values: new object[] { 1, false, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "DiscountRate", "IsDeleted", "Name", "Price", "ReleaseDate", "SalesStatu" },
                values: new object[,]
                {
                    { 1, "Teoman", 0m, false, "İki Aşk", 10.99m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, "Adele", 0m, false, "21", 12.99m, new DateTime(2011, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, "Amy Winehouse", 0.10m, false, "Back to Black", 9.99m, new DateTime(2006, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 4, "Nirvana", 0m, false, "Nevermind", 8.99m, new DateTime(1991, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, "Pink Floyd", 0m, false, "The Dark Side of the Moon", 11.99m, new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, "The Beatles", 0.11m, false, "Abbey Road", 10.99m, new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, "Fleetwood Mac", 0m, false, "Rumours", 9.99m, new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 8, "Michael Jackson", 0m, false, "Thriller", 12.99m, new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, "U2", 0.15m, false, "The Joshua Tree", 11.99m, new DateTime(1987, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10, "Guns N' Roses", 0m, false, "Appetite for Destruction", 10.99m, new DateTime(1987, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminAlbum_AlbumsId",
                table: "AdminAlbum",
                column: "AlbumsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminAlbum");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
