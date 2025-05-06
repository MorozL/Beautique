using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Beautique.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryAndProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Shampoos & Conditioners" },
                    { 2, 2, "Body Washes & Soaps" },
                    { 3, 3, "Facial Care" },
                    { 4, 4, "Body Care" },
                    { 5, 5, "Deodorants & Antiperspirants" },
                    { 6, 6, "Shaving Products" },
                    { 7, 7, "Nail Care" },
                    { 8, 8, "Perfumes & Fragrances" },
                    { 9, 9, "Lip Care" },
                    { 10, 10, "Hand Care" },
                    { 11, 11, "Hair Care" },
                    { 12, 12, "Eye & Eyelid Care" },
                    { 13, 13, "Cleansing & Makeup Removal" },
                    { 14, 14, "Organic & Bio Cosmetics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "BarCode", "ImageUrl", "ListPrice", "Maker", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, 1, "A premium shampoo that provides ultimate shine and smoothness.", "SW123456789", "", 55.0, "SparkLife", 50.0, 40.0, 45.0, "ShineWave" },
                    { 2, 2, "A gentle body wash that leaves your skin refreshed and hydrated.", "PG987654321", "", 40.0, "CleanseCo", 35.0, 25.0, 30.0, "PureGlow" },
                    { 3, 3, "A soft and nourishing facial cream for smooth and glowing skin.", "ST111223344", "", 65.0, "VelvetSkin", 60.0, 50.0, 55.0, "SoftTouch" },
                    { 4, 5, "A refreshing deodorant spray that keeps you fresh all day long.", "CS554433221", "", 20.0, "LushCare", 18.0, 14.0, 16.0, "ClearSpark" },
                    { 5, 6, "A shaving gel that provides a smooth and irritation-free shave.", "FC998877665", "", 35.0, "SharpEdge", 30.0, 25.0, 28.0, "FreshCut" },
                    { 6, 7, "A long-lasting nail polish with vibrant colors and a glossy finish.", "GN332211445", "", 15.0, "NailArt", 13.0, 10.0, 12.0, "GlowNail" },
                    { 7, 8, "A fresh and uplifting fragrance that is perfect for daily wear.", "EV776655443", "", 50.0, "ScentAura", 45.0, 35.0, 40.0, "EauVibe" },
                    { 8, 9, "A hydrating lip balm with a smooth texture and subtle scent.", "SK223344556", "", 10.0, "LipsCare", 9.0, 7.0, 8.0, "SoftKiss" },
                    { 9, 10, "A nourishing hand cream that keeps your skin soft and hydrated.", "HH556677889", "", 18.0, "SkinGuard", 16.0, 12.0, 14.0, "HandHeal" },
                    { 10, 12, "A rejuvenating eye cream that targets puffiness and dark circles.", "EL998877665", "", 45.0, "VisionGlow", 40.0, 30.0, 35.0, "EyeLuxe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
