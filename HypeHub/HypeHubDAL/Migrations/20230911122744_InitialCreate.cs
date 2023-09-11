using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    AccountTypes = table.Column<int>(type: "int", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Outfits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Wardrobes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wardrobes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wardrobes_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountOutfit",
                columns: table => new
                {
                    LikedOutfitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LikesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountOutfit", x => new { x.LikedOutfitsId, x.LikesId });
                    table.ForeignKey(
                        name: "FK_AccountOutfit_Accounts_LikesId",
                        column: x => x.LikesId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountOutfit_Outfits_LikedOutfitsId",
                        column: x => x.LikedOutfitsId,
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
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardrobeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CloathingType = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colorway = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Wardrobes_WardrobeId",
                        column: x => x.WardrobeId,
                        principalTable: "Wardrobes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


        migrationBuilder.CreateTable(
                name: "AccountItem",
                columns: table => new
                {
                    LikedItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LikesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountItem", x => new { x.LikedItemsId, x.LikesId });
                    table.ForeignKey(
                        name: "FK_AccountItem_Accounts_LikesId",
                        column: x => x.LikesId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountItem_Items_LikedItemsId",
                        column: x => x.LikedItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemOutfit",
                columns: table => new
                {
                    ItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OutfitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOutfit", x => new { x.ItemsId, x.OutfitsId });
                    table.ForeignKey(
                        name: "FK_ItemOutfit_Items_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemOutfit_Outfits_OutfitsId",
                        column: x => x.OutfitsId,
                        principalTable: "Outfits",
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

            migrationBuilder.CreateIndex(
                name: "IX_AccountCredentials_AccountId",
                table: "AccountCredentials",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountItem_LikesId",
                table: "AccountItem",
                column: "LikesId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountOutfit_LikesId",
                table: "AccountOutfit",
                column: "LikesId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOutfit_OutfitsId",
                table: "ItemOutfit",
                column: "OutfitsId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_WardrobeId",
                table: "Items",
                column: "WardrobeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsImages_ItemId",
                table: "ItemsImages",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitImages_OutfitId",
                table: "OutfitImages",
                column: "OutfitId");

            migrationBuilder.CreateIndex(
                name: "IX_Outfits_AccountId",
                table: "Outfits",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Wardrobes_AccountId",
                table: "Wardrobes",
                column: "AccountId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountCredentials");

            migrationBuilder.DropTable(
                name: "AccountItem");

            migrationBuilder.DropTable(
                name: "AccountOutfit");

            migrationBuilder.DropTable(
                name: "ItemOutfit");

            migrationBuilder.DropTable(
                name: "ItemsImages");

            migrationBuilder.DropTable(
                name: "OutfitImages");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Outfits");

            migrationBuilder.DropTable(
                name: "Wardrobes");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
