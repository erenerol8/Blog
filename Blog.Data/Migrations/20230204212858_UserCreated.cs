using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8b03e030-2c94-4058-b4e6-22c1100f7aaa"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9daea9e3-7342-444b-af5d-147aa8a17c0b"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("9e7c3966-2486-4b59-bdc8-35b723385726"), new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"), "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 5, 0, 28, 57, 786, DateTimeKind.Local).AddTicks(1240), null, null, new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"), false, null, null, "ASP.NET Core Deneme Makalesi", 15 },
                    { new Guid("f07da726-3299-45a2-9318-fd42990b40fa"), new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"), "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 5, 0, 28, 57, 786, DateTimeKind.Local).AddTicks(1254), null, null, new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"), false, null, null, "Entity Framework Core Deneme Makalesi", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("cee8c724-f055-4305-94f7-bc386ec6db82"), "d4ce04d6-5911-4caf-b686-c1dd899227be", "Superadmin", "SUPERADMIN" },
                    { new Guid("f5bdad15-96e8-4c15-b315-4ec584e1f7d4"), "4235aeb8-a75a-4e86-bc79-bed1401f33c6", "Admin", "ADMIN" },
                    { new Guid("fa407313-afc8-48a9-b09a-a20b75beabad"), "fd5de4f5-fe2b-45ca-80dc-8b8e0ab31358", "User", "UserDATA" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1ed47a79-f320-46f9-b79d-5b563a9ea703"), 0, "5d7481b8-2ab0-4384-b0ec-f8dcd9d64f0b", "admin@gmail.com", false, "Can", "Admin", false, null, "ADMIN@gmail.com", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHP29iCN5+AKcA3T2mfuN8DC/ixvZBm/aeh1ZPYoBPhHB9u31y07lIptDotWrWbWHQ==", "356897850", false, "f145d619-328e-46c8-94bf-1efd279a0745", false, "admin@gmail.com" },
                    { new Guid("90df825a-2d77-4586-9f8f-7bbc82eb3c16"), 0, "6327df45-d0f6-411c-bba4-4f6b1d16c1ff", "superadmin@gmail.com", true, "Eren", "Erol", false, null, "SUPERADMIN@gmail.com", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHuOXSjDFJAxeSozS3uRJ9ZdinmCGiIZZmKhakTULKPcwyIb8OwsrvClLkylhQRdIA==", "1234567890", true, "d0284996-447c-4323-9bac-21e0b9bf9528", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 5, 0, 28, 57, 786, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 5, 0, 28, 57, 786, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 5, 0, 28, 57, 786, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 5, 0, 28, 57, 786, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f5bdad15-96e8-4c15-b315-4ec584e1f7d4"), new Guid("1ed47a79-f320-46f9-b79d-5b563a9ea703") },
                    { new Guid("cee8c724-f055-4305-94f7-bc386ec6db82"), new Guid("90df825a-2d77-4586-9f8f-7bbc82eb3c16") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9e7c3966-2486-4b59-bdc8-35b723385726"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f07da726-3299-45a2-9318-fd42990b40fa"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8b03e030-2c94-4058-b4e6-22c1100f7aaa"), new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"), "Entity Framework Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(582), null, null, new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"), false, null, null, "Entity Framework Core Deneme Makalesi", 15 },
                    { new Guid("9daea9e3-7342-444b-af5d-147aa8a17c0b"), new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"), "Lorem ipsum dolares lorem ipsum dolar dolares ipsum lorem Türkiye Cumhuriyeti Fenerbahce Ankara ve Kar", "Admin Test", new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(571), null, null, new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"), false, null, null, "ASP.NET Core Deneme Makalesi", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58952bf2-a492-477f-a89b-619dc9d22af2"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("981f97c3-b8d9-49bf-8cae-9446f57a504f"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f4e2124-07af-42f9-a361-9d47b944193e"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("52e698d3-2d58-428b-8b7c-2cd54b384ecd"),
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 16, 14, 45, 770, DateTimeKind.Local).AddTicks(1356));
        }
    }
}
