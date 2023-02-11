using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("82fae017-6571-437c-99a3-634bd91b1b12"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f656317f-34f0-4da1-97b5-d7d86686e575"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("00a305f6-f03e-40d3-97e9-a2c121e667ac"), new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"), "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 11, 10, 42, 45, 447, DateTimeKind.Local).AddTicks(146), null, null, new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"), false, null, null, "ASP.NET Core Deneme Makalesi", new Guid("90df825a-2d77-4586-9f8f-7bbc82eb3c16"), 15 },
                    { new Guid("72f92834-52e1-478b-ba08-c903256339ab"), new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"), "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 11, 10, 42, 45, 447, DateTimeKind.Local).AddTicks(160), null, null, new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"), false, null, null, "Entity Framework Core Deneme Makalesi", new Guid("1ed47a79-f320-46f9-b79d-5b563a9ea703"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cee8c724-f055-4305-94f7-bc386ec6db82"),
                column: "ConcurrencyStamp",
                value: "faf1174b-f956-46fe-9eec-eb5ee40859b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5bdad15-96e8-4c15-b315-4ec584e1f7d4"),
                column: "ConcurrencyStamp",
                value: "66e8946b-aa86-4502-ab56-a4a4698888e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa407313-afc8-48a9-b09a-a20b75beabad"),
                column: "ConcurrencyStamp",
                value: "4b04edc7-f0a7-4daa-bd55-81288274a3cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed47a79-f320-46f9-b79d-5b563a9ea703"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cc5ef20-1fc9-492b-96ac-88792ebc86ab", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHGX3rm2WvhRq8lt8bUiO+CNRXIESfvL8P+4m9d/wmSjJ1DPqjwSe5PauXwKmGdvzQ==", "158aef8c-2223-488e-84f1-3fb69a558902" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("90df825a-2d77-4586-9f8f-7bbc82eb3c16"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e61d736-48cb-4b7b-bb27-ac29c41a106a", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEITNz/gNP47FBt678JLLFOYmgH7EmbBT4h7hVIa2X5Ki/WL5GKsHuqErD09qBvgzzw==", "785f19fc-928c-4319-b7f7-61495b169aa8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 10, 42, 45, 447, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 10, 42, 45, 447, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 10, 42, 45, 447, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 10, 42, 45, 447, DateTimeKind.Local).AddTicks(642));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("00a305f6-f03e-40d3-97e9-a2c121e667ac"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("72f92834-52e1-478b-ba08-c903256339ab"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("82fae017-6571-437c-99a3-634bd91b1b12"), new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"), "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 11, 6, 32, 22, 665, DateTimeKind.Local).AddTicks(5622), null, null, new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"), false, null, null, "Entity Framework Core Deneme Makalesi", new Guid("1ed47a79-f320-46f9-b79d-5b563a9ea703"), 15 },
                    { new Guid("f656317f-34f0-4da1-97b5-d7d86686e575"), new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"), "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 11, 6, 32, 22, 665, DateTimeKind.Local).AddTicks(5608), null, null, new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"), false, null, null, "ASP.NET Core Deneme Makalesi", new Guid("90df825a-2d77-4586-9f8f-7bbc82eb3c16"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("cee8c724-f055-4305-94f7-bc386ec6db82"),
                column: "ConcurrencyStamp",
                value: "12644dd1-5400-48b2-8f66-1eb10816173f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f5bdad15-96e8-4c15-b315-4ec584e1f7d4"),
                column: "ConcurrencyStamp",
                value: "47e84bff-979e-4b92-9481-c9b371de2f9f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fa407313-afc8-48a9-b09a-a20b75beabad"),
                column: "ConcurrencyStamp",
                value: "0c4b967f-b6d4-4700-9a62-5d164bcaffd2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed47a79-f320-46f9-b79d-5b563a9ea703"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c38a346-3e51-4c71-bb93-d72966488919", "ADMIN@gmail.com", "AQAAAAEAACcQAAAAEBbKgB8CFuK64+Ej0ZC6rJ905Ddpb7qEWdJV4Dr2FLNsCBecd+k5P1+bfa95DSPF6w==", "33ebc973-c06d-425d-9e1e-a7a879b497c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("90df825a-2d77-4586-9f8f-7bbc82eb3c16"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00dd4b2b-dbbe-4f88-8e60-6007e1fc3102", "SUPERADMIN@gmail.com", "AQAAAAEAACcQAAAAECdfkUSlHiLQshnSz2WsOCpWb400P2LPYGAMGGz3R8W1shi0hWF9H3XjZKC6dUyl4g==", "668f387c-c062-4218-a856-cfa4e12db6fa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 6, 32, 22, 665, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 6, 32, 22, 665, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 6, 32, 22, 665, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 11, 6, 32, 22, 665, DateTimeKind.Local).AddTicks(6286));
        }
    }
}
