using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnoForest_Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    BuyProduct = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "AirConditioners",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    PowerCooling = table.Column<double>(nullable: false),
                    PowerHeating = table.Column<double>(nullable: false),
                    NoiseLevel = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditioners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirConditioners_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Fridges",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    TotalCapacity = table.Column<int>(nullable: false),
                    CapacityRefrigerator = table.Column<int>(nullable: false),
                    CapacityFreezer = table.Column<int>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fridges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fridges_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MobilePhones",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Memory = table.Column<string>(nullable: false),
                    SizeOfDisplay = table.Column<double>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Picture = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobilePhones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MobilePhones_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TVs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Size = table.Column<double>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TVs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VacuumCleaners",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Power = table.Column<int>(nullable: false),
                    NoiseLevel = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacuumCleaners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacuumCleaners_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WashingMachines",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsBought = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    WashingCapacity = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WashingMachines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WashingMachines_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    TVsId = table.Column<string>(nullable: true),
                    WashingMachineId = table.Column<string>(nullable: true),
                    MobilePhoneId = table.Column<string>(nullable: true),
                    FridgeId = table.Column<string>(nullable: true),
                    AirConditionerId = table.Column<string>(nullable: true),
                    VacuumCleanerId = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<decimal>(nullable: true),
                    AddTOCart = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AirConditioners_AirConditionerId",
                        column: x => x.AirConditionerId,
                        principalTable: "AirConditioners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Fridges_FridgeId",
                        column: x => x.FridgeId,
                        principalTable: "Fridges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_MobilePhones_MobilePhoneId",
                        column: x => x.MobilePhoneId,
                        principalTable: "MobilePhones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_TVs_TVsId",
                        column: x => x.TVsId,
                        principalTable: "TVs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_VacuumCleaners_VacuumCleanerId",
                        column: x => x.VacuumCleanerId,
                        principalTable: "VacuumCleaners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_WashingMachines_WashingMachineId",
                        column: x => x.WashingMachineId,
                        principalTable: "WashingMachines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AirConditioners",
                columns: new[] { "Id", "IsBought", "Model", "NoiseLevel", "PowerCooling", "PowerHeating", "Price", "ProductName", "UserId" },
                values: new object[,]
                {
                    { "c015da0f-33f9-46d3-85cf-5314e0c76b95", false, "TAC-09CHSD", 30, 2.6000000000000001, 2.6099999999999999, 639m, "SANG", null },
                    { "de59b84d-aeb2-4fa8-9370-89617cc82744", false, "AS09TA2HRA", 40, 2.6000000000000001, 2.7999999999999998, 759m, "HAIER ", null },
                    { "e23eba28-66af-4239-9c66-798a7c956fa0", false, "BEVPI 121", 43, 3.5, 2.6000000000000001, 879m, "BEKO  ", null }
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "Id", "CapacityFreezer", "CapacityRefrigerator", "Color", "Height", "IsBought", "Model", "Price", "ProductName", "TotalCapacity", "UserId", "Width" },
                values: new object[,]
                {
                    { "42a046da-3717-4c47-88b8-defacf39499e", 42, 171, "White", 144.0, false, "VFD 263", 355m, "VESTFROST", 213, null, 54.0 },
                    { "56780700-4a74-4ce0-bc55-893f5d8cd4ca", 88, 229, "Inox", 195.0, false, "RF 36SM-Z/P1CB27", 749m, "SNAIGE", 317, null, 60.0 },
                    { "988e82bc-f781-419d-89fa-9af95eb213d2", 98, 210, "Inox", 185.0, false, "RB31FDRNDSA/EF", 949m, "SAMSUNG", 308, null, 60.0 },
                    { "15902133-9037-4541-862c-ec501deafbb5", 167, 368, "Inox", 179.30000000000001, false, "NRS9182VX", 1999m, "GORENJE", 535, null, 68.700000000000003 },
                    { "29faa7a1-b5aa-4bc1-b78e-0c6099009ea1", 210, 407, "Black", 178.0, false, "RS68N8220B1/EF", 2599m, "SAMSUNG ", 617, null, 77.200000000000003 }
                });

            migrationBuilder.InsertData(
                table: "MobilePhones",
                columns: new[] { "Id", "Color", "IsBought", "Memory", "Model", "Picture", "Price", "ProductName", "SizeOfDisplay", "UserId" },
                values: new object[,]
                {
                    { "17e9c26c-030f-4ee9-8d45-992d78971e1f", "Black", false, "32 GB", "7 Plus", "~/images/Black7Plus.jpg", 929.36m, "Iphone", 5.5, null },
                    { "665d2175-1792-4078-b5ad-a4b7939eeb72", "Pink", false, "32 GB", "7 Plus", "~/images/Pink7Plus.jpg", 1029.36m, "Iphone", 5.5, null },
                    { "1668c2b3-cbf6-4c8e-8f36-cbf600e78610", "Gray", false, "64 GB", " 6S", "~/images/Gray6s.jpg", 1029.36m, "Iphone", 5.5, null },
                    { "00a206e5-c65b-4626-890a-2d39f9687f28", "Gray", false, "64 GB", "X", "~/images/Xgray.jpg", 1849.99m, "Iphone", 5.7999999999999998, null },
                    { "964460f8-fade-4c5d-96ba-9831b7c7185f", "Pink", false, "64 GB", "X", "~/images/Xgray.jpg", 2049.99m, "Iphone", 5.7999999999999998, null }
                });

            migrationBuilder.InsertData(
                table: "TVs",
                columns: new[] { "Id", "IsBought", "Model", "Price", "ProductName", "Size", "UserId" },
                values: new object[,]
                {
                    { "6b798382-fab7-4dd8-8824-516ff63c2baf", false, "32PFS4132/12", 388m, "PHILIPS", 32.0, null },
                    { "bdaf9613-95b3-4daa-affe-39fab1e1975a", false, "70UI9362E", 1449.99m, "Sharp", 70.0, null },
                    { "3db78497-8adb-4400-8fdc-7d10e0350160", false, "KD55XG8196BAEP", 1389m, "Sony", 55.0, null },
                    { "e99a4a02-b8ab-4d66-b509-4618e66f0b38", false, "BRAVIA", 2899m, "Sony", 55.0, null },
                    { "f27ff3d6-7dda-49eb-9348-c54c3a11cf8b", false, "43LK5100PLA", 428m, "LG", 43.0, null }
                });

            migrationBuilder.InsertData(
                table: "VacuumCleaners",
                columns: new[] { "Id", "Color", "IsBought", "Model", "NoiseLevel", "Power", "Price", "ProductName", "UserId" },
                values: new object[,]
                {
                    { "9c21bee7-20fd-46c3-8a23-867fe58e4c2e", "Blue", false, "VCEA01GACBUCY", 85, 800, 139m, "GORENJE", null },
                    { "1cee3c19-e11b-41a3-bbfb-88951a84c50c", "Black", false, "VCC45T0S3R", 80, 850, 149m, "SAMSUNG", null },
                    { "803ff24c-4815-485c-8162-29bd1a72c7ec", "Black", false, "BGS05A220", 78, 700, 169m, "BOSCH ", null },
                    { "5824fa78-1bdb-4196-b4cc-f003dfb291a1", "Black", false, "FC9333", 76, 650, 219m, "PHILIPS  ", null },
                    { "fccee9db-3fe1-4300-bef7-78cf9a8b68df", "Black-blue", false, "RO3731EACOMPACT", 79, 750, 189m, "ROWENTA  ", null }
                });

            migrationBuilder.InsertData(
                table: "WashingMachines",
                columns: new[] { "Id", "IsBought", "Model", "Picture", "Price", "ProductName", "UserId", "WashingCapacity" },
                values: new object[,]
                {
                    { "c51ade36-a168-4dbf-813f-61fbcdc36b9a", false, "TDLR 70210", null, 599m, "Whirlpool", null, 8 },
                    { "c2a7b1b5-d960-4e0b-87eb-bc65ff48d9e6", false, "WW70K44305W", null, 609m, "Samsung", null, 7 },
                    { "7443cad9-1255-4e16-94d6-b8f54b03ba78", false, "WMY81483LMB1", null, 669.99m, "Beko", null, 8 },
                    { "ba0e316a-5bce-46dc-abb0-bd0473833558", false, "L9WBA61B", null, 2899.99m, "AEG", null, 9 },
                    { "26c4f63d-7cf5-431c-935d-e209cd94865f", false, "F2J6HM0W", null, 799m, "LG", null, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirConditioners_UserId",
                table: "AirConditioners",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Fridges_UserId",
                table: "Fridges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MobilePhones_UserId",
                table: "MobilePhones",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_AirConditionerId",
                table: "ShoppingCarts",
                column: "AirConditionerId",
                unique: true,
                filter: "[AirConditionerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_FridgeId",
                table: "ShoppingCarts",
                column: "FridgeId",
                unique: true,
                filter: "[FridgeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_MobilePhoneId",
                table: "ShoppingCarts",
                column: "MobilePhoneId",
                unique: true,
                filter: "[MobilePhoneId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_TVsId",
                table: "ShoppingCarts",
                column: "TVsId",
                unique: true,
                filter: "[TVsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_VacuumCleanerId",
                table: "ShoppingCarts",
                column: "VacuumCleanerId",
                unique: true,
                filter: "[VacuumCleanerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_WashingMachineId",
                table: "ShoppingCarts",
                column: "WashingMachineId",
                unique: true,
                filter: "[WashingMachineId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TVs_UserId",
                table: "TVs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VacuumCleaners_UserId",
                table: "VacuumCleaners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WashingMachines_UserId",
                table: "WashingMachines",
                column: "UserId");
        }

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
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AirConditioners");

            migrationBuilder.DropTable(
                name: "Fridges");

            migrationBuilder.DropTable(
                name: "MobilePhones");

            migrationBuilder.DropTable(
                name: "TVs");

            migrationBuilder.DropTable(
                name: "VacuumCleaners");

            migrationBuilder.DropTable(
                name: "WashingMachines");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
