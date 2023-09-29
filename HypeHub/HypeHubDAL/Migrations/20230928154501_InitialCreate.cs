using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    IsPrivate = table.Column<int>(type: "int", nullable: false),
                    AccountTypes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountCredentials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountCredentials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountCredentials_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CloathingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Colorway = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Outfits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outfits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Outfits_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountItemLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountItemLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountItemLikes_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemsImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsImages_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountOutfitLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OutfitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountOutfitLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountOutfitLikes_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OutfitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutfitImages_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitItems",
                columns: table => new
                {
                    OutfitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitItems", x => new { x.ItemId, x.OutfitId });
                    table.ForeignKey(
                        name: "FK_OutfitItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutfitItems_Outfits_OutfitId",
                        column: x => x.OutfitId,
                        principalTable: "Outfits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountTypes", "AvatarUrl", "IsPrivate", "Username" },
                values: new object[,]
                {
                    { new Guid("053135ab-a8e4-41c4-9e87-7e70982028ee"), "User", "https://example.com/avatar/user1.png", 0, "User1" },
                    { new Guid("ba8f19b2-193d-4f17-8b30-9112a8001142"), "User", null, 1, "User2" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("3a0be4b8-2b2a-44cc-8d53-789f9441b1a9"), new Guid("053135ab-a8e4-41c4-9e87-7e70982028ee"), "User1@gmail.com", "hasłoMasło651" },
                    { new Guid("82360feb-1e74-4e0b-893a-f678b408c063"), new Guid("ba8f19b2-193d-4f17-8b30-9112a8001142"), "User2@gmail.com", "hasłoMasło289" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AccountId", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("4911a837-9945-4de6-a7b8-69699202cbc9"), new Guid("ba8f19b2-193d-4f17-8b30-9112a8001142"), "Brand1", "Torso", "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 28, 15, 45, 1, 89, DateTimeKind.Utc).AddTicks(2308) },
                    { new Guid("c84fb656-955a-4d73-ad41-44099f34ec5a"), new Guid("053135ab-a8e4-41c4-9e87-7e70982028ee"), "Brand1", "Torso", "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 28, 15, 45, 1, 89, DateTimeKind.Utc).AddTicks(2275) }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "CreationDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1e13b80c-88ee-4870-bd3c-e3c46c592b59"), new Guid("053135ab-a8e4-41c4-9e87-7e70982028ee"), new DateTime(2023, 9, 28, 17, 45, 1, 89, DateTimeKind.Local).AddTicks(2076), "Outfit559" },
                    { new Guid("1f710cdb-8262-424d-b079-8d3537ee5b60"), new Guid("053135ab-a8e4-41c4-9e87-7e70982028ee"), new DateTime(2023, 9, 28, 17, 45, 1, 89, DateTimeKind.Local).AddTicks(2169), "Outfit397" },
                    { new Guid("4961cf46-27f0-4600-835e-a38df2996526"), new Guid("ba8f19b2-193d-4f17-8b30-9112a8001142"), new DateTime(2023, 9, 28, 17, 45, 1, 89, DateTimeKind.Local).AddTicks(2179), "Outfit715" },
                    { new Guid("cbbaad43-f8bd-4349-bd20-1a8fb9875f20"), new Guid("ba8f19b2-193d-4f17-8b30-9112a8001142"), new DateTime(2023, 9, 28, 17, 45, 1, 89, DateTimeKind.Local).AddTicks(2175), "Outfit782" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("54b0f528-c0a4-42ee-98fa-78a8fa96ff37"), new Guid("c84fb656-955a-4d73-ad41-44099f34ec5a"), "exampleURL" },
                    { new Guid("7fa67b53-0365-4295-b066-9a4d867121b7"), new Guid("4911a837-9945-4de6-a7b8-69699202cbc9"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("5218e490-4b0d-45ce-8a96-d5728f522942"), new Guid("1f710cdb-8262-424d-b079-8d3537ee5b60"), "exampleURL" },
                    { new Guid("bb121807-fda2-4cd6-b5e2-ea5c0fb6ebb0"), new Guid("4961cf46-27f0-4600-835e-a38df2996526"), "exampleURL" },
                    { new Guid("d162b263-5bfc-4de8-a625-07f64d2cec58"), new Guid("1e13b80c-88ee-4870-bd3c-e3c46c592b59"), "exampleURL" },
                    { new Guid("d92a6dd5-10a4-45c6-83d4-d2a262b612af"), new Guid("cbbaad43-f8bd-4349-bd20-1a8fb9875f20"), "exampleURL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountCredentials_AccountId",
                table: "AccountCredentials",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountCredentials_Email",
                table: "AccountCredentials",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountItemLikes_ItemId",
                table: "AccountItemLikes",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountOutfitLikes_OutfitId",
                table: "AccountOutfitLikes",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Username",
                table: "Accounts",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_AccountId",
                table: "Items",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsImages_ItemId",
                table: "ItemsImages",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitImages_OutfitId",
                table: "OutfitImages",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitItems_OutfitId",
                table: "OutfitItems",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_Outfits_AccountId",
                table: "Outfits",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountCredentials");

            migrationBuilder.DropTable(
                name: "AccountItemLikes");

            migrationBuilder.DropTable(
                name: "AccountOutfitLikes");

            migrationBuilder.DropTable(
                name: "ItemsImages");

            migrationBuilder.DropTable(
                name: "OutfitImages");

            migrationBuilder.DropTable(
                name: "OutfitItems");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Outfits");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
