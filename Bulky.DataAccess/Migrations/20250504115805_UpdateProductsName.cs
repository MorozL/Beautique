using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beautique.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 33.0, 28.0, 18.0, 23.0, "ShineElixir" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "CalmBright" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 50.0, 45.0, 35.0, 40.0, "MicellarWipe" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 45.0, 40.0, 30.0, 35.0, "BioVital" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 20.0, 15.0, 5.0, 10.0, "HydraBounce" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 36.0, 31.0, 21.0, 26.0, "ZenAqua" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 23.0, 18.0, 8.0, 13.0, "ToneCare" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 41.0, 36.0, 26.0, 31.0, "SmoothHydra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 55.0, 50.0, 40.0, 45.0, "BlockActive" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "BladeSmooth" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 60.0, 55.0, 45.0, 50.0, "TintSparkle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "AuraMist" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "SilkSoft" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 47.0, 42.0, 32.0, 37.0, "HealCare" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "NourishSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 50.0, 45.0, 35.0, 40.0, "FreshEye" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 57.0, 52.0, 42.0, 47.0, "WashMicellar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 53.0, 48.0, 38.0, 43.0, "HerbalOrganic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 61.0, 56.0, 46.0, 51.0, "SmoothGlow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 36.0, 31.0, 21.0, 26.0, "PureCleanse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "ToneBalance" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 61.0, 56.0, 46.0, 51.0, "HydraSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 43.0, 38.0, 28.0, 33.0, "BlockPower" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 49.0, 44.0, 34.0, 39.0, "FreshCalm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 23.0, 18.0, 8.0, 13.0, "PopTint" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 31.0, 26.0, 16.0, 21.0, "MistDream" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "SilkSmooth" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "CalmShield" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 56.0, 51.0, 41.0, 46.0, "ShineCare" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "LuxeEye" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 53.0, 48.0, 38.0, 43.0, "FoamWash" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "BioOrganic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 60.0, 55.0, 45.0, 50.0, "SilkBounce" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 51.0, 46.0, 36.0, 41.0, "PureBloom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "FreshBalance" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 35.0, 30.0, 20.0, 25.0, "TouchSmooth" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "GuardZone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 51.0, 46.0, 36.0, 41.0, "FoamSmooth" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 65.0, 60.0, 50.0, 55.0, "TintGlam" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "DreamBloom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 51.0, 46.0, 36.0, 41.0, "SoftSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "RepairCalm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "OilCare" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 23.0, 18.0, 8.0, 13.0, "CalmLuxe" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "MicellarClean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "NatureGreen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 62.0, 57.0, 47.0, 52.0, "ShineSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 17.0, 12.0, 2.0, 7.0, "BloomFoam" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 47.0, 42.0, 32.0, 37.0, "VelvetGlow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 53.0, 48.0, 38.0, 43.0, "ButterSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 43.0, 38.0, 28.0, 33.0, "FreshShield" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 53.0, 48.0, 38.0, 43.0, "SmoothCalm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "GlamTint" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 62.0, 57.0, 47.0, 52.0, "EssenceAura" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "GlowSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 19.0, 14.0, 4.0, 9.0, "CareGuard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 19.0, 14.0, 4.0, 9.0, "ElixirSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 21.0, 16.0, 6.0, 11.0, "GlowBright" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 48.0, 43.0, 33.0, 38.0, "WashFoam" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 23.0, 18.0, 8.0, 13.0, "PureBio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "LusterHydra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 46.0, 41.0, 31.0, 36.0, "BloomWave" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 35.0, 30.0, 20.0, 25.0, "VelvetTone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "TouchSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 16.0, 11.0, 1.0, 6.0, "GuardPower" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "EdgeFoam" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "TintGloss" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 59.0, 54.0, 44.0, 49.0, "ScentBloom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 22.0, 17.0, 7.0, 12.0, "HydraGlow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 17.0, 12.0, 2.0, 7.0, "VelvetSoft" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 47.0, 42.0, 32.0, 37.0, "OilSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "CalmLift" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 16.0, 11.0, 1.0, 6.0, "CleanMicellar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 49.0, 44.0, 34.0, 39.0, "OrganicBio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 62.0, 57.0, 47.0, 52.0, "FreshSilk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 49.0, 44.0, 34.0, 39.0, "CleanseMist" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 37.0, 32.0, 22.0, 27.0, "FreshSoft" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 19.0, 14.0, 4.0, 9.0, "EssenceHydra" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 37.0, 32.0, 22.0, 27.0, "ZonePower" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 50.0, 45.0, 35.0, 40.0, "BladeEdge" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 36.0, 31.0, 21.0, 26.0, "PopColor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 60.0, 55.0, 45.0, 50.0, "BloomAura" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "BalmCare" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "CareHeal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 16.0, 11.0, 1.0, 6.0, "DropNourish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "LiftSoft" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 53.0, 48.0, 38.0, 43.0, "CleanWash" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 63.0, 58.0, 48.0, 53.0, "HerbalNature" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "FreshSmooth" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 23.0, 18.0, 8.0, 13.0, "ZenWave" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "Hair Oil 11" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 46.0, 41.0, 31.0, 36.0, "Eye Cream 12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 24.0, 19.0, 9.0, 14.0, "Makeup Remover 13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 20.0, 15.0, 5.0, 10.0, "Organic Lotion 14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "Shampoo 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 35.0, 30.0, 20.0, 25.0, "Body Wash 16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "Face Cream 17" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "Body Lotion 18" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "Deodorant 19" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 16.0, 11.0, 1.0, 6.0, "Shaving Cream 20" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 38.0, 33.0, 23.0, 28.0, "Nail Polish 21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "Perfume 22" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 17.0, 12.0, 2.0, 7.0, "Lip Balm 23" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "Hand Cream 24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 40.0, 35.0, 25.0, 30.0, "Hair Oil 25" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "Eye Cream 26" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 44.0, 39.0, 29.0, 34.0, "Makeup Remover 27" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 18.0, 13.0, 3.0, 8.0, "Organic Lotion 28" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 37.0, 32.0, 22.0, 27.0, "Shampoo 29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 45.0, 40.0, 30.0, 35.0, "Body Wash 30" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "Face Cream 31" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 49.0, 44.0, 34.0, 39.0, "Body Lotion 32" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "Deodorant 33" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 59.0, 54.0, 44.0, 49.0, "Shaving Cream 34" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "Nail Polish 35" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 17.0, 12.0, 2.0, 7.0, "Perfume 36" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 19.0, 14.0, 4.0, 9.0, "Lip Balm 37" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 34.0, 29.0, 19.0, 24.0, "Hand Cream 38" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "Hair Oil 39" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 37.0, 32.0, 22.0, 27.0, "Eye Cream 40" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "Makeup Remover 41" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 43.0, 38.0, 28.0, 33.0, "Organic Lotion 42" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "Shampoo 43" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 19.0, 14.0, 4.0, 9.0, "Body Wash 44" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 57.0, 52.0, 42.0, 47.0, "Face Cream 45" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 29.0, 24.0, 14.0, 19.0, "Body Lotion 46" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "Deodorant 47" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 15.0, 10.0, 1.0, 5.0, "Shaving Cream 48" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 35.0, 30.0, 20.0, 25.0, "Nail Polish 49" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 52.0, 47.0, 37.0, 42.0, "Perfume 50" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 40.0, 35.0, 25.0, 30.0, "Lip Balm 51" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "Hand Cream 52" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "Hair Oil 53" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 15.0, 10.0, 1.0, 5.0, "Eye Cream 54" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 43.0, 38.0, 28.0, 33.0, "Makeup Remover 55" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 65.0, 60.0, 50.0, 55.0, "Organic Lotion 56" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 65.0, 60.0, 50.0, 55.0, "Shampoo 57" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "Body Wash 58" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "Face Cream 59" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 21.0, 16.0, 6.0, 11.0, "Body Lotion 60" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 27.0, 22.0, 12.0, 17.0, "Deodorant 61" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 62.0, 57.0, 47.0, 52.0, "Shaving Cream 62" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 51.0, 46.0, 36.0, 41.0, "Nail Polish 63" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 36.0, 31.0, 21.0, 26.0, "Perfume 64" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 39.0, 34.0, 24.0, 29.0, "Lip Balm 65" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 51.0, 46.0, 36.0, 41.0, "Hand Cream 66" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 54.0, 49.0, 39.0, 44.0, "Hair Oil 67" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 41.0, 36.0, 26.0, 31.0, "Eye Cream 68" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 53.0, 48.0, 38.0, 43.0, "Makeup Remover 69" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "Organic Lotion 70" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 16.0, 11.0, 1.0, 6.0, "Shampoo 71" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 48.0, 43.0, 33.0, 38.0, "Body Wash 72" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 17.0, 12.0, 2.0, 7.0, "Face Cream 73" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 62.0, 57.0, 47.0, 52.0, "Body Lotion 74" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 19.0, 14.0, 4.0, 9.0, "Deodorant 75" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 29.0, 24.0, 14.0, 19.0, "Shaving Cream 76" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "Nail Polish 77" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 24.0, 19.0, 9.0, 14.0, "Perfume 78" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 34.0, 29.0, 19.0, 24.0, "Lip Balm 79" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 41.0, 36.0, 26.0, 31.0, "Hand Cream 80" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "Hair Oil 81" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 43.0, 38.0, 28.0, 33.0, "Eye Cream 82" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "Makeup Remover 83" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 24.0, 19.0, 9.0, 14.0, "Organic Lotion 84" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "Shampoo 85" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 32.0, 27.0, 17.0, 22.0, "Body Wash 86" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 59.0, 54.0, 44.0, 49.0, "Face Cream 87" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 24.0, 19.0, 9.0, 14.0, "Body Lotion 88" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 20.0, 15.0, 5.0, 10.0, "Deodorant 89" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 47.0, 42.0, 32.0, 37.0, "Shaving Cream 90" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 37.0, 32.0, 22.0, 27.0, "Nail Polish 91" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 22.0, 17.0, 7.0, 12.0, "Perfume 92" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 42.0, 37.0, 27.0, 32.0, "Lip Balm 93" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 16.0, 11.0, 1.0, 6.0, "Hand Cream 94" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 58.0, 53.0, 43.0, 48.0, "Hair Oil 95" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 25.0, 20.0, 10.0, 15.0, "Eye Cream 96" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 60.0, 55.0, 45.0, 50.0, "Makeup Remover 97" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 38.0, 33.0, 23.0, 28.0, "Organic Lotion 98" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 22.0, 17.0, 7.0, 12.0, "Shampoo 99" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 30.0, 25.0, 15.0, 20.0, "Body Wash 100" });
        }
    }
}
