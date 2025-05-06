using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Beautique.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BarCode", "CategoryId", "Description", "ImageUrl", "ListPrice", "Maker", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 11, "BC000000011", 11, "A nourishing oil for damaged hair.", "", 58.0, "GlowHair", 53.0, 43.0, 48.0, "Hair Oil 11" },
                    { 12, "BC000000012", 12, "Targets dark circles and fine lines.", "", 46.0, "BrightEyes", 41.0, 31.0, 36.0, "Eye Cream 12" },
                    { 13, "BC000000013", 13, "A gentle remover for all makeup types.", "", 24.0, "CleanSwipe", 19.0, 9.0, 14.0, "Makeup Remover 13" },
                    { 14, "BC000000014", 14, "An organic skin lotion with no parabens.", "", 20.0, "BioCare", 15.0, 5.0, 10.0, "Organic Lotion 14" },
                    { 15, "BC000000015", 1, "A revitalizing shampoo for daily use.", "", 27.0, "ShinyLocks", 22.0, 12.0, 17.0, "Shampoo 15" },
                    { 16, "BC000000016", 2, "A moisturizing body wash with essential oils.", "", 35.0, "AquaFresh", 30.0, 20.0, 25.0, "Body Wash 16" },
                    { 17, "BC000000017", 3, "A facial cream enriched with vitamins.", "", 54.0, "DermaGlow", 49.0, 39.0, 44.0, "Face Cream 17" },
                    { 18, "BC000000018", 4, "A hydrating lotion for silky skin.", "", 42.0, "SmoothCare", 37.0, 27.0, 32.0, "Body Lotion 18" },
                    { 19, "BC000000019", 5, "A long-lasting deodorant for active days.", "", 52.0, "FreshShield", 47.0, 37.0, 42.0, "Deodorant 19" },
                    { 20, "BC000000020", 6, "A rich shaving cream for sensitive skin.", "", 16.0, "BladeGuard", 11.0, 1.0, 6.0, "Shaving Cream 20" },
                    { 21, "BC000000021", 7, "Bright nail polish with lasting power.", "", 38.0, "ColorShine", 33.0, 23.0, 28.0, "Nail Polish 21" },
                    { 22, "BC000000022", 8, "A light perfume with floral notes.", "", 58.0, "EssenceMist", 53.0, 43.0, 48.0, "Perfume 22" },
                    { 23, "BC000000023", 9, "A soothing balm for chapped lips.", "", 17.0, "LipSilk", 12.0, 2.0, 7.0, "Lip Balm 23" },
                    { 24, "BC000000024", 10, "A cream to restore dry hands.", "", 54.0, "PalmSoft", 49.0, 39.0, 44.0, "Hand Cream 24" },
                    { 25, "BC000000025", 11, "A nourishing oil for damaged hair.", "", 40.0, "GlowHair", 35.0, 25.0, 30.0, "Hair Oil 25" },
                    { 26, "BC000000026", 12, "Targets dark circles and fine lines.", "", 25.0, "BrightEyes", 20.0, 10.0, 15.0, "Eye Cream 26" },
                    { 27, "BC000000027", 13, "A gentle remover for all makeup types.", "", 44.0, "CleanSwipe", 39.0, 29.0, 34.0, "Makeup Remover 27" },
                    { 28, "BC000000028", 14, "An organic skin lotion with no parabens.", "", 18.0, "BioCare", 13.0, 3.0, 8.0, "Organic Lotion 28" },
                    { 29, "BC000000029", 1, "A revitalizing shampoo for daily use.", "", 37.0, "ShinyLocks", 32.0, 22.0, 27.0, "Shampoo 29" },
                    { 30, "BC000000030", 2, "A moisturizing body wash with essential oils.", "", 45.0, "AquaFresh", 40.0, 30.0, 35.0, "Body Wash 30" },
                    { 31, "BC000000031", 3, "A facial cream enriched with vitamins.", "", 30.0, "DermaGlow", 25.0, 15.0, 20.0, "Face Cream 31" },
                    { 32, "BC000000032", 4, "A hydrating lotion for silky skin.", "", 49.0, "SmoothCare", 44.0, 34.0, 39.0, "Body Lotion 32" },
                    { 33, "BC000000033", 5, "A long-lasting deodorant for active days.", "", 27.0, "FreshShield", 22.0, 12.0, 17.0, "Deodorant 33" },
                    { 34, "BC000000034", 6, "A rich shaving cream for sensitive skin.", "", 59.0, "BladeGuard", 54.0, 44.0, 49.0, "Shaving Cream 34" },
                    { 35, "BC000000035", 7, "Bright nail polish with lasting power.", "", 54.0, "ColorShine", 49.0, 39.0, 44.0, "Nail Polish 35" },
                    { 36, "BC000000036", 8, "A light perfume with floral notes.", "", 17.0, "EssenceMist", 12.0, 2.0, 7.0, "Perfume 36" },
                    { 37, "BC000000037", 9, "A soothing balm for chapped lips.", "", 19.0, "LipSilk", 14.0, 4.0, 9.0, "Lip Balm 37" },
                    { 38, "BC000000038", 10, "A cream to restore dry hands.", "", 34.0, "PalmSoft", 29.0, 19.0, 24.0, "Hand Cream 38" },
                    { 39, "BC000000039", 11, "A nourishing oil for damaged hair.", "", 30.0, "GlowHair", 25.0, 15.0, 20.0, "Hair Oil 39" },
                    { 40, "BC000000040", 12, "Targets dark circles and fine lines.", "", 37.0, "BrightEyes", 32.0, 22.0, 27.0, "Eye Cream 40" },
                    { 41, "BC000000041", 13, "A gentle remover for all makeup types.", "", 25.0, "CleanSwipe", 20.0, 10.0, 15.0, "Makeup Remover 41" },
                    { 42, "BC000000042", 14, "An organic skin lotion with no parabens.", "", 43.0, "BioCare", 38.0, 28.0, 33.0, "Organic Lotion 42" },
                    { 43, "BC000000043", 1, "A revitalizing shampoo for daily use.", "", 52.0, "ShinyLocks", 47.0, 37.0, 42.0, "Shampoo 43" },
                    { 44, "BC000000044", 2, "A moisturizing body wash with essential oils.", "", 19.0, "AquaFresh", 14.0, 4.0, 9.0, "Body Wash 44" },
                    { 45, "BC000000045", 3, "A facial cream enriched with vitamins.", "", 57.0, "DermaGlow", 52.0, 42.0, 47.0, "Face Cream 45" },
                    { 46, "BC000000046", 4, "A hydrating lotion for silky skin.", "", 29.0, "SmoothCare", 24.0, 14.0, 19.0, "Body Lotion 46" },
                    { 47, "BC000000047", 5, "A long-lasting deodorant for active days.", "", 52.0, "FreshShield", 47.0, 37.0, 42.0, "Deodorant 47" },
                    { 48, "BC000000048", 6, "A rich shaving cream for sensitive skin.", "", 15.0, "BladeGuard", 10.0, 1.0, 5.0, "Shaving Cream 48" },
                    { 49, "BC000000049", 7, "Bright nail polish with lasting power.", "", 35.0, "ColorShine", 30.0, 20.0, 25.0, "Nail Polish 49" },
                    { 50, "BC000000050", 8, "A light perfume with floral notes.", "", 52.0, "EssenceMist", 47.0, 37.0, 42.0, "Perfume 50" },
                    { 51, "BC000000051", 9, "A soothing balm for chapped lips.", "", 40.0, "LipSilk", 35.0, 25.0, 30.0, "Lip Balm 51" },
                    { 52, "BC000000052", 10, "A cream to restore dry hands.", "", 58.0, "PalmSoft", 53.0, 43.0, 48.0, "Hand Cream 52" },
                    { 53, "BC000000053", 11, "A nourishing oil for damaged hair.", "", 54.0, "GlowHair", 49.0, 39.0, 44.0, "Hair Oil 53" },
                    { 54, "BC000000054", 12, "Targets dark circles and fine lines.", "", 15.0, "BrightEyes", 10.0, 1.0, 5.0, "Eye Cream 54" },
                    { 55, "BC000000055", 13, "A gentle remover for all makeup types.", "", 43.0, "CleanSwipe", 38.0, 28.0, 33.0, "Makeup Remover 55" },
                    { 56, "BC000000056", 14, "An organic skin lotion with no parabens.", "", 65.0, "BioCare", 60.0, 50.0, 55.0, "Organic Lotion 56" },
                    { 57, "BC000000057", 1, "A revitalizing shampoo for daily use.", "", 65.0, "ShinyLocks", 60.0, 50.0, 55.0, "Shampoo 57" },
                    { 58, "BC000000058", 2, "A moisturizing body wash with essential oils.", "", 25.0, "AquaFresh", 20.0, 10.0, 15.0, "Body Wash 58" },
                    { 59, "BC000000059", 3, "A facial cream enriched with vitamins.", "", 58.0, "DermaGlow", 53.0, 43.0, 48.0, "Face Cream 59" },
                    { 60, "BC000000060", 4, "A hydrating lotion for silky skin.", "", 21.0, "SmoothCare", 16.0, 6.0, 11.0, "Body Lotion 60" },
                    { 61, "BC000000061", 5, "A long-lasting deodorant for active days.", "", 27.0, "FreshShield", 22.0, 12.0, 17.0, "Deodorant 61" },
                    { 62, "BC000000062", 6, "A rich shaving cream for sensitive skin.", "", 62.0, "BladeGuard", 57.0, 47.0, 52.0, "Shaving Cream 62" },
                    { 63, "BC000000063", 7, "Bright nail polish with lasting power.", "", 51.0, "ColorShine", 46.0, 36.0, 41.0, "Nail Polish 63" },
                    { 64, "BC000000064", 8, "A light perfume with floral notes.", "", 36.0, "EssenceMist", 31.0, 21.0, 26.0, "Perfume 64" },
                    { 65, "BC000000065", 9, "A soothing balm for chapped lips.", "", 39.0, "LipSilk", 34.0, 24.0, 29.0, "Lip Balm 65" },
                    { 66, "BC000000066", 10, "A cream to restore dry hands.", "", 51.0, "PalmSoft", 46.0, 36.0, 41.0, "Hand Cream 66" },
                    { 67, "BC000000067", 11, "A nourishing oil for damaged hair.", "", 54.0, "GlowHair", 49.0, 39.0, 44.0, "Hair Oil 67" },
                    { 68, "BC000000068", 12, "Targets dark circles and fine lines.", "", 41.0, "BrightEyes", 36.0, 26.0, 31.0, "Eye Cream 68" },
                    { 69, "BC000000069", 13, "A gentle remover for all makeup types.", "", 53.0, "CleanSwipe", 48.0, 38.0, 43.0, "Makeup Remover 69" },
                    { 70, "BC000000070", 14, "An organic skin lotion with no parabens.", "", 25.0, "BioCare", 20.0, 10.0, 15.0, "Organic Lotion 70" },
                    { 71, "BC000000071", 1, "A revitalizing shampoo for daily use.", "", 16.0, "ShinyLocks", 11.0, 1.0, 6.0, "Shampoo 71" },
                    { 72, "BC000000072", 2, "A moisturizing body wash with essential oils.", "", 48.0, "AquaFresh", 43.0, 33.0, 38.0, "Body Wash 72" },
                    { 73, "BC000000073", 3, "A facial cream enriched with vitamins.", "", 17.0, "DermaGlow", 12.0, 2.0, 7.0, "Face Cream 73" },
                    { 74, "BC000000074", 4, "A hydrating lotion for silky skin.", "", 62.0, "SmoothCare", 57.0, 47.0, 52.0, "Body Lotion 74" },
                    { 75, "BC000000075", 5, "A long-lasting deodorant for active days.", "", 19.0, "FreshShield", 14.0, 4.0, 9.0, "Deodorant 75" },
                    { 76, "BC000000076", 6, "A rich shaving cream for sensitive skin.", "", 29.0, "BladeGuard", 24.0, 14.0, 19.0, "Shaving Cream 76" },
                    { 77, "BC000000077", 7, "Bright nail polish with lasting power.", "", 30.0, "ColorShine", 25.0, 15.0, 20.0, "Nail Polish 77" },
                    { 78, "BC000000078", 8, "A light perfume with floral notes.", "", 24.0, "EssenceMist", 19.0, 9.0, 14.0, "Perfume 78" },
                    { 79, "BC000000079", 9, "A soothing balm for chapped lips.", "", 34.0, "LipSilk", 29.0, 19.0, 24.0, "Lip Balm 79" },
                    { 80, "BC000000080", 10, "A cream to restore dry hands.", "", 41.0, "PalmSoft", 36.0, 26.0, 31.0, "Hand Cream 80" },
                    { 81, "BC000000081", 11, "A nourishing oil for damaged hair.", "", 42.0, "GlowHair", 37.0, 27.0, 32.0, "Hair Oil 81" },
                    { 82, "BC000000082", 12, "Targets dark circles and fine lines.", "", 43.0, "BrightEyes", 38.0, 28.0, 33.0, "Eye Cream 82" },
                    { 83, "BC000000083", 13, "A gentle remover for all makeup types.", "", 25.0, "CleanSwipe", 20.0, 10.0, 15.0, "Makeup Remover 83" },
                    { 84, "BC000000084", 14, "An organic skin lotion with no parabens.", "", 24.0, "BioCare", 19.0, 9.0, 14.0, "Organic Lotion 84" },
                    { 85, "BC000000085", 1, "A revitalizing shampoo for daily use.", "", 42.0, "ShinyLocks", 37.0, 27.0, 32.0, "Shampoo 85" },
                    { 86, "BC000000086", 2, "A moisturizing body wash with essential oils.", "", 32.0, "AquaFresh", 27.0, 17.0, 22.0, "Body Wash 86" },
                    { 87, "BC000000087", 3, "A facial cream enriched with vitamins.", "", 59.0, "DermaGlow", 54.0, 44.0, 49.0, "Face Cream 87" },
                    { 88, "BC000000088", 4, "A hydrating lotion for silky skin.", "", 24.0, "SmoothCare", 19.0, 9.0, 14.0, "Body Lotion 88" },
                    { 89, "BC000000089", 5, "A long-lasting deodorant for active days.", "", 20.0, "FreshShield", 15.0, 5.0, 10.0, "Deodorant 89" },
                    { 90, "BC000000090", 6, "A rich shaving cream for sensitive skin.", "", 47.0, "BladeGuard", 42.0, 32.0, 37.0, "Shaving Cream 90" },
                    { 91, "BC000000091", 7, "Bright nail polish with lasting power.", "", 37.0, "ColorShine", 32.0, 22.0, 27.0, "Nail Polish 91" },
                    { 92, "BC000000092", 8, "A light perfume with floral notes.", "", 22.0, "EssenceMist", 17.0, 7.0, 12.0, "Perfume 92" },
                    { 93, "BC000000093", 9, "A soothing balm for chapped lips.", "", 42.0, "LipSilk", 37.0, 27.0, 32.0, "Lip Balm 93" },
                    { 94, "BC000000094", 10, "A cream to restore dry hands.", "", 16.0, "PalmSoft", 11.0, 1.0, 6.0, "Hand Cream 94" },
                    { 95, "BC000000095", 11, "A nourishing oil for damaged hair.", "", 58.0, "GlowHair", 53.0, 43.0, 48.0, "Hair Oil 95" },
                    { 96, "BC000000096", 12, "Targets dark circles and fine lines.", "", 25.0, "BrightEyes", 20.0, 10.0, 15.0, "Eye Cream 96" },
                    { 97, "BC000000097", 13, "A gentle remover for all makeup types.", "", 60.0, "CleanSwipe", 55.0, 45.0, 50.0, "Makeup Remover 97" },
                    { 98, "BC000000098", 14, "An organic skin lotion with no parabens.", "", 38.0, "BioCare", 33.0, 23.0, 28.0, "Organic Lotion 98" },
                    { 99, "BC000000099", 1, "A revitalizing shampoo for daily use.", "", 22.0, "ShinyLocks", 17.0, 7.0, 12.0, "Shampoo 99" },
                    { 100, "BC000000100", 2, "A moisturizing body wash with essential oils.", "", 30.0, "AquaFresh", 25.0, 15.0, 20.0, "Body Wash 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
