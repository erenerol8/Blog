using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2c091a90-ee08-4ba7-9a1b-14b4056111c9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e8ff6115-e40a-4048-a035-680107f1d5be"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0a07df3e-dd6d-4a2a-94ec-efc634e48753"), new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"), "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 1, 31, 16, 15, 49, 962, DateTimeKind.Local).AddTicks(1123), null, null, new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"), false, null, null, "ASP.NET Core Deneme Makalesi", 15 },
                    { new Guid("9876b92c-e8a3-4506-9656-edd23f0c3852"), new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"), "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 1, 31, 16, 15, 49, 962, DateTimeKind.Local).AddTicks(1133), null, null, new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"), false, null, null, "Entity Framework Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 15, 49, 962, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 15, 49, 962, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 15, 49, 962, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 15, 49, 962, DateTimeKind.Local).AddTicks(1638));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0a07df3e-dd6d-4a2a-94ec-efc634e48753"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9876b92c-e8a3-4506-9656-edd23f0c3852"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2c091a90-ee08-4ba7-9a1b-14b4056111c9"), new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"), "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 1, 31, 16, 13, 58, 684, DateTimeKind.Local).AddTicks(7244), null, null, new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"), false, null, null, "ASP.NET Core Deneme Makalesi", 15 },
                    { new Guid("e8ff6115-e40a-4048-a035-680107f1d5be"), new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"), "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 1, 31, 16, 13, 58, 684, DateTimeKind.Local).AddTicks(7255), null, null, new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"), false, null, null, "Entity Framework Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 13, 58, 684, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 13, 58, 684, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 13, 58, 684, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                column: "CreatedDate",
                value: new DateTime(2023, 1, 31, 16, 13, 58, 684, DateTimeKind.Local).AddTicks(8017));
        }
    }
}
