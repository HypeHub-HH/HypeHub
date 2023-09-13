using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations
{
    /// <inheritdoc />
    public partial class InitilCreate : Migration
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
                    { new Guid("026d99c4-a457-4d2a-953b-12febbc245df"), 0, "https://example.com/avatar/user7.png", false, "User7" },
                    { new Guid("0599bf4d-e63c-4940-b70c-946feb68ee9f"), 0, null, true, "User4" },
                    { new Guid("06488e04-37de-4da5-9ba6-83f2e21b3bfa"), 0, null, true, "User16" },
                    { new Guid("1f45c761-5d9b-4308-abb8-7246250956d1"), 0, null, true, "User10" },
                    { new Guid("297a46e0-2ac4-4463-98c6-89da90a73ae0"), 0, "https://example.com/avatar/user11.png", false, "User11" },
                    { new Guid("739c2635-61bf-48a0-8bd2-72f19d8c5a2f"), 0, "https://example.com/avatar/user13.png", false, "User13" },
                    { new Guid("80e887de-8083-4011-8b63-a895916d7fb9"), 0, null, true, "User2" },
                    { new Guid("8bba8de6-d1ff-4fbf-b259-b5f264fe624f"), 0, "https://example.com/avatar/user15.png", false, "User15" },
                    { new Guid("8e9c6734-41e8-4b44-ad2d-0b473310d1b6"), 0, null, true, "User8" },
                    { new Guid("b25ddd90-53f2-4e8d-8d79-bf3011c4fb99"), 0, null, true, "User20" },
                    { new Guid("b70008af-efa8-434b-8514-3e3db69120f2"), 0, "https://example.com/avatar/user19.png", false, "User19" },
                    { new Guid("bc78b00c-42b8-4c82-b7f0-8bdc9e3d3262"), 0, "https://example.com/avatar/user5.png", false, "User5" },
                    { new Guid("bfcd8446-cdae-4299-9cc4-0fc7aafe9192"), 0, null, true, "User6" },
                    { new Guid("c0dfebce-5562-4a74-a337-6d5b9720929f"), 0, null, true, "User18" },
                    { new Guid("cbb81d03-474e-4990-8a64-c6cef328f790"), 0, "https://example.com/avatar/user9.png", false, "User9" },
                    { new Guid("cc660763-ad76-41cf-a6ea-8b9196fb04ba"), 0, "https://example.com/avatar/user1.png", false, "User1" },
                    { new Guid("d0cdbe28-fbf2-42a8-a0e6-dd66b13688c3"), 0, null, true, "User12" },
                    { new Guid("e2616eb8-fcbb-403e-9667-43a06d872abe"), 0, "https://example.com/avatar/user3.png", false, "User3" },
                    { new Guid("e3ffd180-792e-4a8d-9cfa-6c887b24e615"), 0, "https://example.com/avatar/user17.png", false, "User17" },
                    { new Guid("f50605eb-9cdf-411b-ab41-45617a58f10f"), 0, null, true, "User14" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("04362def-fe7e-4008-9495-3c9472bb1da9"), new Guid("0599bf4d-e63c-4940-b70c-946feb68ee9f"), "User4@gmail.com", "hasłoMasło373" },
                    { new Guid("12ff1d1e-481e-459e-91bc-4eefd2c33679"), new Guid("cbb81d03-474e-4990-8a64-c6cef328f790"), "User9@gmail.com", "hasłoMasło334" },
                    { new Guid("347e0b4c-1f49-4722-9b69-96dda95bc803"), new Guid("b70008af-efa8-434b-8514-3e3db69120f2"), "User19@gmail.com", "hasłoMasło305" },
                    { new Guid("37086d7b-1f57-4fa5-bd37-52f2bb2f34e3"), new Guid("297a46e0-2ac4-4463-98c6-89da90a73ae0"), "User11@gmail.com", "hasłoMasło47" },
                    { new Guid("41925508-89f8-4898-82a1-e45b7107f7f4"), new Guid("8e9c6734-41e8-4b44-ad2d-0b473310d1b6"), "User8@gmail.com", "hasłoMasło659" },
                    { new Guid("5191d968-f7a5-47c7-9e79-763dfb9ac11f"), new Guid("bc78b00c-42b8-4c82-b7f0-8bdc9e3d3262"), "User5@gmail.com", "hasłoMasło224" },
                    { new Guid("6675f56c-c258-4280-abc5-d2775c4f4d66"), new Guid("f50605eb-9cdf-411b-ab41-45617a58f10f"), "User14@gmail.com", "hasłoMasło758" },
                    { new Guid("6ade1e77-3aec-43b7-8b54-8885050a87f7"), new Guid("e3ffd180-792e-4a8d-9cfa-6c887b24e615"), "User17@gmail.com", "hasłoMasło997" },
                    { new Guid("7a51eea9-4ed1-4a29-9cb1-8639155afd86"), new Guid("739c2635-61bf-48a0-8bd2-72f19d8c5a2f"), "User13@gmail.com", "hasłoMasło87" },
                    { new Guid("7ebe64a6-5eaa-4897-a88e-1dc4378bc6f4"), new Guid("bfcd8446-cdae-4299-9cc4-0fc7aafe9192"), "User6@gmail.com", "hasłoMasło112" },
                    { new Guid("847a71de-ddcc-40cb-a14a-4ae82b7b4be2"), new Guid("8bba8de6-d1ff-4fbf-b259-b5f264fe624f"), "User15@gmail.com", "hasłoMasło503" },
                    { new Guid("8a6705e4-a79a-44e7-9569-86b274c05e71"), new Guid("80e887de-8083-4011-8b63-a895916d7fb9"), "User2@gmail.com", "hasłoMasło947" },
                    { new Guid("c4be9188-35f3-411a-b6c6-feffb1f92945"), new Guid("c0dfebce-5562-4a74-a337-6d5b9720929f"), "User18@gmail.com", "hasłoMasło819" },
                    { new Guid("d96529cc-91d9-4c34-9b89-089bee7766fc"), new Guid("1f45c761-5d9b-4308-abb8-7246250956d1"), "User10@gmail.com", "hasłoMasło624" },
                    { new Guid("dd9a8642-6344-4f82-b490-7882661c7526"), new Guid("d0cdbe28-fbf2-42a8-a0e6-dd66b13688c3"), "User12@gmail.com", "hasłoMasło358" },
                    { new Guid("e152775e-b577-4331-81a0-0b3587a8d74f"), new Guid("cc660763-ad76-41cf-a6ea-8b9196fb04ba"), "User1@gmail.com", "hasłoMasło540" },
                    { new Guid("e19f79ff-35fe-4e5f-b860-96a69f8a2490"), new Guid("026d99c4-a457-4d2a-953b-12febbc245df"), "User7@gmail.com", "hasłoMasło731" },
                    { new Guid("f1bb5a57-cd63-47c0-b5f5-e500383be42d"), new Guid("b25ddd90-53f2-4e8d-8d79-bf3011c4fb99"), "User20@gmail.com", "hasłoMasło786" },
                    { new Guid("fa713ad3-fd8f-4b4e-bbfb-584358f80737"), new Guid("e2616eb8-fcbb-403e-9667-43a06d872abe"), "User3@gmail.com", "hasłoMasło782" },
                    { new Guid("fdf82b4d-be80-4773-b707-821d68dd4170"), new Guid("06488e04-37de-4da5-9ba6-83f2e21b3bfa"), "User16@gmail.com", "hasłoMasło142" }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "Name" },
                values: new object[,]
                {
                    { new Guid("00fa3a9b-4ff9-4a2c-b85d-502c61373875"), new Guid("c0dfebce-5562-4a74-a337-6d5b9720929f"), "Outfit328" },
                    { new Guid("036b65a3-c021-4fc7-b137-c5e0c36296f9"), new Guid("297a46e0-2ac4-4463-98c6-89da90a73ae0"), "Outfit736" },
                    { new Guid("03d0fb6e-6575-4dbb-ab1e-7eb2023dce64"), new Guid("739c2635-61bf-48a0-8bd2-72f19d8c5a2f"), "Outfit722" },
                    { new Guid("097eecc2-00d5-40f6-ac36-d2c2437fc689"), new Guid("1f45c761-5d9b-4308-abb8-7246250956d1"), "Outfit774" },
                    { new Guid("0b956389-f4da-4a82-9a4c-9c24322e4248"), new Guid("026d99c4-a457-4d2a-953b-12febbc245df"), "Outfit441" },
                    { new Guid("10716740-09d4-4adb-9808-1f4fc84653ec"), new Guid("bfcd8446-cdae-4299-9cc4-0fc7aafe9192"), "Outfit437" },
                    { new Guid("186c124b-b034-4db0-9f62-2f45de79f0ee"), new Guid("bc78b00c-42b8-4c82-b7f0-8bdc9e3d3262"), "Outfit756" },
                    { new Guid("2043ae3d-95df-424b-bbe7-5cb20e296b29"), new Guid("bfcd8446-cdae-4299-9cc4-0fc7aafe9192"), "Outfit133" },
                    { new Guid("26747773-87c2-42d0-acdb-f71231f3c2a7"), new Guid("f50605eb-9cdf-411b-ab41-45617a58f10f"), "Outfit345" },
                    { new Guid("2b694040-0c6c-4aa7-a463-6da84c56db9a"), new Guid("cbb81d03-474e-4990-8a64-c6cef328f790"), "Outfit370" },
                    { new Guid("30d69e4b-c005-4eba-8cfd-402703088012"), new Guid("026d99c4-a457-4d2a-953b-12febbc245df"), "Outfit429" },
                    { new Guid("32cd98d0-565c-425e-a3eb-9b6e516720d0"), new Guid("06488e04-37de-4da5-9ba6-83f2e21b3bfa"), "Outfit172" },
                    { new Guid("3a8255b7-6eeb-406c-92f4-8f453fdd5a5c"), new Guid("80e887de-8083-4011-8b63-a895916d7fb9"), "Outfit798" },
                    { new Guid("42ac8945-b381-465b-8b6b-b097ae22d66b"), new Guid("cc660763-ad76-41cf-a6ea-8b9196fb04ba"), "Outfit199" },
                    { new Guid("473c1849-2d1a-4c70-b05b-520ac7e9cf85"), new Guid("cc660763-ad76-41cf-a6ea-8b9196fb04ba"), "Outfit928" },
                    { new Guid("4cfc4a6e-44b4-4bc4-94e8-d7fa04607bfa"), new Guid("b70008af-efa8-434b-8514-3e3db69120f2"), "Outfit230" },
                    { new Guid("53c7b616-c16f-4791-9c19-f104afdc4995"), new Guid("e2616eb8-fcbb-403e-9667-43a06d872abe"), "Outfit888" },
                    { new Guid("55547fa2-54af-4407-9f2b-a722ccdb00c8"), new Guid("0599bf4d-e63c-4940-b70c-946feb68ee9f"), "Outfit202" },
                    { new Guid("589eaae3-a5fc-4467-80a8-8e3510896f86"), new Guid("d0cdbe28-fbf2-42a8-a0e6-dd66b13688c3"), "Outfit994" },
                    { new Guid("5943fa3a-6de9-4e8e-b674-2a72ec18c8c7"), new Guid("bc78b00c-42b8-4c82-b7f0-8bdc9e3d3262"), "Outfit764" },
                    { new Guid("5ca5f297-45c0-4290-8995-e75e4a510e36"), new Guid("c0dfebce-5562-4a74-a337-6d5b9720929f"), "Outfit366" },
                    { new Guid("6a8e26d8-8cc1-4080-a7a8-bb8aeb7afc8e"), new Guid("739c2635-61bf-48a0-8bd2-72f19d8c5a2f"), "Outfit385" },
                    { new Guid("6b6ce3e5-cd9a-4534-80f3-53c0f801ac65"), new Guid("8e9c6734-41e8-4b44-ad2d-0b473310d1b6"), "Outfit528" },
                    { new Guid("6bac7e95-a2fb-48c6-8a98-c8409f3a6897"), new Guid("f50605eb-9cdf-411b-ab41-45617a58f10f"), "Outfit340" },
                    { new Guid("7101bff2-40dc-4e92-b4de-cece469f5e9e"), new Guid("8bba8de6-d1ff-4fbf-b259-b5f264fe624f"), "Outfit559" },
                    { new Guid("7b6a0ccf-4fc1-4af5-b195-b4ae4885bf96"), new Guid("06488e04-37de-4da5-9ba6-83f2e21b3bfa"), "Outfit394" },
                    { new Guid("811ff6d9-d699-4913-857f-ffe37a6a76de"), new Guid("b25ddd90-53f2-4e8d-8d79-bf3011c4fb99"), "Outfit592" },
                    { new Guid("86e83275-9037-4cdf-a4af-85cb458f49e7"), new Guid("8e9c6734-41e8-4b44-ad2d-0b473310d1b6"), "Outfit982" },
                    { new Guid("94f90904-6846-4a1e-a8b6-d3d21908612c"), new Guid("8bba8de6-d1ff-4fbf-b259-b5f264fe624f"), "Outfit662" },
                    { new Guid("a982a431-91f6-461e-9da2-94553ef34485"), new Guid("e3ffd180-792e-4a8d-9cfa-6c887b24e615"), "Outfit79" },
                    { new Guid("be9d2cbb-7af2-472e-bc7f-91341bffb54a"), new Guid("d0cdbe28-fbf2-42a8-a0e6-dd66b13688c3"), "Outfit417" },
                    { new Guid("c1bf8875-897b-4e5a-a523-c3bee016c93f"), new Guid("b25ddd90-53f2-4e8d-8d79-bf3011c4fb99"), "Outfit897" },
                    { new Guid("c492ae93-a1cb-4562-b0a0-c53576bfc99a"), new Guid("b70008af-efa8-434b-8514-3e3db69120f2"), "Outfit452" },
                    { new Guid("cd3318e4-c148-4fe3-bd49-cdd4a4df4a49"), new Guid("cbb81d03-474e-4990-8a64-c6cef328f790"), "Outfit121" },
                    { new Guid("cd7e449b-a9c7-41fe-92f6-4942601dad84"), new Guid("0599bf4d-e63c-4940-b70c-946feb68ee9f"), "Outfit524" },
                    { new Guid("cf8630a6-3958-4ae5-a975-4d6404de6a24"), new Guid("80e887de-8083-4011-8b63-a895916d7fb9"), "Outfit682" },
                    { new Guid("e71ac2f8-3037-4c1e-babf-a3e98510a1d1"), new Guid("e3ffd180-792e-4a8d-9cfa-6c887b24e615"), "Outfit283" },
                    { new Guid("eec61697-1a5f-47b1-8a97-85de7728da37"), new Guid("e2616eb8-fcbb-403e-9667-43a06d872abe"), "Outfit681" },
                    { new Guid("eefabbdd-3bb4-4010-a899-01b8478666bb"), new Guid("1f45c761-5d9b-4308-abb8-7246250956d1"), "Outfit450" },
                    { new Guid("fa8db6fb-70f7-4223-b72c-58dad8e64c15"), new Guid("297a46e0-2ac4-4463-98c6-89da90a73ae0"), "Outfit726" }
                });

            migrationBuilder.InsertData(
                table: "Wardrobes",
                columns: new[] { "Id", "AccountId" },
                values: new object[,]
                {
                    { new Guid("041882d4-78ac-41fe-92f6-0de4992322e5"), new Guid("b70008af-efa8-434b-8514-3e3db69120f2") },
                    { new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f"), new Guid("8bba8de6-d1ff-4fbf-b259-b5f264fe624f") },
                    { new Guid("184e99bc-5d98-4750-b655-856b8043de33"), new Guid("bfcd8446-cdae-4299-9cc4-0fc7aafe9192") },
                    { new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f"), new Guid("c0dfebce-5562-4a74-a337-6d5b9720929f") },
                    { new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e"), new Guid("8e9c6734-41e8-4b44-ad2d-0b473310d1b6") },
                    { new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea"), new Guid("bc78b00c-42b8-4c82-b7f0-8bdc9e3d3262") },
                    { new Guid("338c04b4-18e2-4976-998a-40321921f63c"), new Guid("80e887de-8083-4011-8b63-a895916d7fb9") },
                    { new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1"), new Guid("06488e04-37de-4da5-9ba6-83f2e21b3bfa") },
                    { new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b"), new Guid("739c2635-61bf-48a0-8bd2-72f19d8c5a2f") },
                    { new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a"), new Guid("0599bf4d-e63c-4940-b70c-946feb68ee9f") },
                    { new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba"), new Guid("026d99c4-a457-4d2a-953b-12febbc245df") },
                    { new Guid("95554678-78dc-4bc2-9711-cc16c62f9454"), new Guid("297a46e0-2ac4-4463-98c6-89da90a73ae0") },
                    { new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b"), new Guid("e2616eb8-fcbb-403e-9667-43a06d872abe") },
                    { new Guid("a81f3c61-6033-4d6b-a99a-570af386d267"), new Guid("b25ddd90-53f2-4e8d-8d79-bf3011c4fb99") },
                    { new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74"), new Guid("1f45c761-5d9b-4308-abb8-7246250956d1") },
                    { new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357"), new Guid("e3ffd180-792e-4a8d-9cfa-6c887b24e615") },
                    { new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5"), new Guid("cbb81d03-474e-4990-8a64-c6cef328f790") },
                    { new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04"), new Guid("cc660763-ad76-41cf-a6ea-8b9196fb04ba") },
                    { new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117"), new Guid("d0cdbe28-fbf2-42a8-a0e6-dd66b13688c3") },
                    { new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c"), new Guid("f50605eb-9cdf-411b-ab41-45617a58f10f") }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate", "WardrobeId" },
                values: new object[,]
                {
                    { new Guid("0435c047-8762-4b58-af50-4f4eee669143"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2567), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("044f0e55-2b37-4874-b985-f501387eb7b9"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3582), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("06acd5ee-0939-4148-b116-27e1bcbf1e2b"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4247), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("085eb9cf-932f-47cb-9726-36d7d2938dbd"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4857), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("091e868f-c20b-4406-b4c0-4ce4c662a715"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3819), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("0a4de78e-62db-487e-99db-9cf1021468f4"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4376), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("0b680d72-1289-4d46-8259-543ffde34cac"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4662), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("0c6c2763-71d6-4e48-b0b2-1846ffd9291d"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2448), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("0dab6c91-c5f6-40e7-9ceb-16256d0cbe01"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2898), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("0ea83b1f-8e55-4840-8f18-a45af3b4ae67"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3949), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("0f264517-ce45-45da-9140-f121073103ae"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1406), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("0f754291-dce0-4222-83e5-bd017031bd59"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2266), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("0fc7bc71-d5f2-4f37-9763-39aed5b5f5ab"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4066), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("0ffb1f6d-b3d1-4105-9e38-9d2422a01d2a"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3663), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("10a869b2-0cc0-4d9b-a1e1-c4d1ad6e5b72"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3098), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("11ac5387-1b0b-4fdd-8ee5-a366bd74c3ce"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1941), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("13419627-8250-4edc-9081-e2b3acfc1d6d"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3676), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("1375b309-d4fa-4c50-bca4-dddbe143aa1b"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3556), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("14dcb5b0-84ec-4428-a0ce-909eef1a802e"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3113), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("171ed945-f0da-4ad0-ba53-c33cbdbb4ecc"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4180), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("188b9aca-c828-4cb6-ac07-443ec02d1c65"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3233), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("1a2f5902-003e-473e-a568-5a87e7d80354"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3636), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("1b3faa2c-8647-4c86-8dc0-6d064dbf8960"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3806), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("1c3bfafd-c359-4901-8d27-7f462e69a2dc"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1832), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("1cc8f6c8-282b-4c77-a388-111bc24abb89"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3205), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("1e4a7d7b-ff15-4c4c-b34a-34b6a94b397c"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1913), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("1e5bd900-de9a-4ef2-b9ec-b5466018b1c1"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1885), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("1ef895a2-82a6-4441-87aa-d219f7097e01"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4232), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("1fb2c668-71b3-40a4-8b94-06e1354be0e7"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1898), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("1ff0bd60-a7d8-404a-98ae-de2c8e535390"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2796), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("22ae2075-5a15-4c45-89f5-02cd8a89a012"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2176), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("239d4cb8-5734-4712-8332-0170b590bd72"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2595), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("23e7ed16-e388-442b-8ea7-630ff106526a"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4482), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("242d9c32-7eb1-4603-9b5e-5cb1f821bd1b"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3792), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("29dbeda5-ae9b-4a16-b55c-c1b3fdde91f5"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4091), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("29fc21d8-a1ef-4164-bed4-0e99c3283a6c"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3831), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("2a69442d-5ec2-464a-bb4b-0d1c79a24b0a"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2554), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("2b283c35-a9de-451e-a284-a9f2d374a326"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2966), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("2d1e95d5-c705-4ce0-b8e7-047a18e47198"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3180), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("300577c9-0a02-422c-8399-d405abeba603"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3386), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("32214717-851e-414d-b92f-f96b4056e149"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4285), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("32e7eb5e-76f3-44ce-8cfe-519f79f9f3d1"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4300), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("33d7272b-3cbe-49ef-8554-44c7f58743f9"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2728), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("353885fc-fa92-498a-bff4-be86f9e10826"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2579), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("3654b44d-e430-45eb-a936-56637a0d2445"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2473), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("393fe644-c16f-4aff-89d0-545310aa2239"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4702), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("3b2d5bdc-8d70-41a5-855b-338b9601f354"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3258), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("3be746bd-ec5b-4b1e-a6de-6c0512405aae"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4634), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("3c79c5cf-1977-41d0-8db6-24191c236778"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2979), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("3cb8fb31-a092-4a8c-ad1c-62a3bcb539fe"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4195), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("4178568b-6496-4bd5-8097-0b0d48e90818"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3974), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("43639fd1-501f-4029-8e10-78f772864473"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4273), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("4385834b-596b-4b47-8b6c-90f635f60a47"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2716), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("43a96df1-5c48-4c0a-b25d-4f8caff46ef7"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3361), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("464737a9-c93f-466e-97a9-2d7dc56af6fc"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4610), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("47266674-c382-49a2-90b0-a1f5e0f7e1c4"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4155), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("481f1342-a0f9-45d3-b2b5-013b8b82e2f7"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4829), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("494e219a-19aa-4035-b3bf-e245c7966b1d"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4727), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("49555e19-47f2-4e70-b92b-ef1fbf1b2146"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4417), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("49bac94d-7acc-44f8-81e2-9a131eb90770"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4260), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("4a1e167a-0b04-4e3a-8231-5a538225d9ba"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4363), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("4aeb6ca3-fc6c-49d8-ace3-c5be84bd841b"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2951), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("4b181735-9bae-4dca-a1c9-e0dfc441e16a"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4013), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("4cf3861c-31eb-4ba7-8579-50ee995ec234"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4509), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("4eea2e90-61c8-485c-b71c-36f9b547d4ec"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2809), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("4f154546-84da-407b-8039-ef1a3884e0ac"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4816), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("50fa83ff-5242-4ab9-b0da-73fd6547ac2a"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2824), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("57452ee1-9c0d-46dc-b6d8-05182eae892e"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4869), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("58082963-7465-4622-abef-98b850e69d6a"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3004), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("585c76f9-feaa-4191-81d0-683483175c9c"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3467), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("5b854f85-f9da-4795-b56b-d24020ec3f10"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4457), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("5cc9ae2d-e48f-47bb-bfcd-7760fda1746a"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4581), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("5d4cff34-15b1-4c69-bfb0-a8a22aee66de"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4079), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("5e4b9beb-07a0-4de4-a5d2-c76315c2e8b4"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2095), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("606f2cb4-4334-4fcf-ae87-cf440afe0800"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3019), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("6382a102-155a-4d5c-a839-e7537bda1cf6"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4053), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("64312d4e-3431-4eae-9bd6-95a4f2d6b873"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3414), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("67489766-cf26-4b8c-a016-a31c750105ef"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3427), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("6812fe19-a549-4a82-ac24-c1ba2ff1f09a"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4142), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("6aaff054-00b4-4d37-ba9a-e6aabf5d83c8"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4469), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("6af469b5-d27f-44d4-ba81-dc1d1669160d"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2514), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("6baa25f2-9f96-4ce6-a315-7d97bcd634d4"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1451), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("6db2482f-f871-4d19-8425-6666caf7c613"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2347), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("703018e3-b32a-490a-a685-f7f7c68db12f"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1795), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("70eb5d29-262c-48dc-9d3d-9460dd39d3cd"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3031), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("73965159-6251-4780-970b-3d36e6bcf4ef"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4494), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("76846931-390b-4d47-8730-07b7cc2783e0"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1814), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("76c7cc88-f0da-4887-9f8f-35fdf7253cfb"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2332), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("786158ae-11ba-409f-93df-2f77690815f5"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3595), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("7a072543-daf5-48cb-885d-26a04d29ada2"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2294), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("7c9a9621-be1c-4e63-a329-2de02258f732"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4207), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("7e76c486-d016-49d8-801c-1fb8b8ff9b16"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2108), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("7fc31c35-b0fc-4592-ac28-1b4759c3ea99"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3334), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("812f8791-8bca-40f3-9259-b27bfebf8f49"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2150), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("834639f2-7d40-4067-bdc0-c53898babcf6"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2885), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("84fca2c6-3781-43d8-a8ca-9fa18c662961"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2279), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("86523c2f-545c-4f8e-9561-8cfba4df6ac3"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2434), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("8720ea22-b513-4fda-8ce8-80a1f4fdd201"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2701), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("8b1a6908-5b5d-4d33-a60d-ebc5aceab6d1"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3126), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("8d006c7b-80be-4b82-aa13-27a237dc33f1"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2501), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("8d91f813-bdca-4c26-b623-4aac87780d7e"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1870), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("8dbccd51-2aa7-46f5-9d46-082dfd476e49"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2015), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("8f08186d-e2b4-43a0-a561-e1d7c9a2d856"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3440), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("8f6a170c-e1c9-4eb8-9edc-59f3ec024fb2"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4714), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("8fee12d3-50a4-4bc5-bafc-907213a80bf1"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3859), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("920da9ca-41a3-43b1-84ab-ed6eba9e6a51"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4429), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("9558d0ac-2911-4191-a72b-2c881d94a20f"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2542), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("96b92847-e9c6-4105-8b60-a95ae26515fe"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2743), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("980ec6b2-a51a-4010-8bc8-a9e39b61b622"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2241), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("98669ef5-2c5c-4112-828c-47a59bfd4891"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2371), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("98993254-5f28-4ac1-98b2-6d0725a57be8"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4167), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("99f42038-0970-41a2-ae55-22b4fd411e3e"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2027), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("9b0c133c-0a3c-469d-be7b-01b408ad4cc8"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2607), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("9c52b57f-f345-4d60-bfa9-bbe764ce8b66"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2688), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("9d6082ed-ecc7-4262-a90b-923b293b6b7b"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2488), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("9d84b289-f537-4ff9-a518-a2c1dd0f8e62"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1600), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("9e9ca412-1bd4-4648-a6a9-7e481d6783ce"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1926), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("a20a9e9e-e104-4a24-91fd-943348d13248"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3480), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("a2d6b575-c58e-4dde-9547-8141b552872f"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3986), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("a589d542-fd8d-4d75-a5d1-ad58b23af8ee"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3919), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("a64f924e-890a-4d5d-9f6a-07dba0f3b5c0"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3453), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("a66588aa-f99f-44d1-8ab8-8a29b281f207"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4791), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("a67a1648-d34d-4545-bc3c-03dcb461bfd8"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4220), new Guid("4ed3f02b-05c6-485e-b575-0222dc5437c1") },
                    { new Guid("a69158e8-a1fb-402d-9a55-483d710afa06"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2319), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("a7f5392b-8fc1-4c1f-9a2c-f69078bd8a2d"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1471), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("a8cc4c7c-6ff6-401f-9942-6db0687386e8"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1858), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("a925cee5-7faf-4333-abb7-d58a49739acf"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3346), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("ab7dfa18-a11a-4699-ad08-f6405b7a30c6"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4882), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("afd6acca-a895-4b35-9e10-cfff0879a012"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2991), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("b12729be-e6f0-4db3-a4d6-2890d01a1739"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1520), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("b1479e9c-5541-4ff3-b5c4-ecd32f839187"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2756), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("b2e5968b-bc78-4f70-b649-ed0fb121f546"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2081), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("b34047d2-60e3-4cb7-a194-3b4585ff555f"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3569), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("b395e9cd-5f6f-461f-99e2-1dda47037684"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3220), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("b60736e0-8a5d-4f8c-ad2a-361ce269df04"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2225), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("b73f319d-b8f8-419c-8ee1-f6275fac5a5a"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2837), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("ba7e6b95-323c-4a23-9353-94ee727b3cbf"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2384), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("bce8b3b5-e52e-4daf-91f2-37141fb52439"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2527), new Guid("184e99bc-5d98-4750-b655-856b8043de33") },
                    { new Guid("bd1cdf60-7db3-4284-b435-f8de38d0be28"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4026), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("be053155-7031-47b0-bcd6-d27166fd99c6"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3764), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("bf7b7fa9-51d3-4e33-b370-cb3d89b7ad46"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2925), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("c0798cb3-36a6-4b1f-b9d6-12e088238203"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1581), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("c1045df1-723f-4a2a-8566-7449739745c1"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3648), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("c1bd1c94-6381-4257-963c-de47857074fa"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1954), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("c2a2bf3d-9cfe-4c38-a459-71131dbdb0da"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4740), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("c41a044b-d11f-47bd-acc2-1fdd2286c033"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3527), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("c9b0d508-6d29-4a6e-884d-080d1537ca08"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4844), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("ca3188da-b4dc-449e-8429-11a0a109b08d"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4674), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("ca51da66-5717-4164-af4d-62bc716a3ad5"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4897), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("cbce8809-c210-492d-806d-b601f8190dfd"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3779), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("cbd991c7-6d1b-4606-8fb7-a889971b4ab3"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1845), new Guid("338c04b4-18e2-4976-998a-40321921f63c") },
                    { new Guid("cceddfa7-1f17-4cf3-9d06-c9d844e3a148"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1740), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("ce8351d1-3b89-45f4-842a-477e0c4d1eea"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3044), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("d0dc153d-7c87-4ed6-8dfb-e20f59ba0bc1"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3152), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("d103b352-d0e4-4dec-8b5c-97ec2fad2d11"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3610), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("d159d839-db44-46b0-b84a-2f98c9bbe14f"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3373), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("d22a5daa-ac88-4ca0-8169-5dfe05eacf43"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4622), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("d26f5615-76ed-4681-98aa-aac09386916d"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3541), new Guid("e7badbff-63a8-4954-9e23-92b26a7b4117") },
                    { new Guid("d2d12c8a-d797-4612-9719-8a1e180fd8f3"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1549), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("d352065b-5987-4da9-8a16-0eae003f4f0e"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2913), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("d401c437-952b-4227-8ae3-b228c5950243"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4687), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("d40bdbf6-5311-439c-8dee-83edff4066dd"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4649), new Guid("041882d4-78ac-41fe-92f6-0de4992322e5") },
                    { new Guid("d44a8dde-148f-4597-868a-bb15c25181a8"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2135), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("d5d067a6-1e5e-4568-874a-45853211cbaf"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4534), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("d6f57567-1cbb-484c-ab64-c884cc86faeb"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3623), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("d9b52e5f-8f52-4a44-893c-36036ad9edd3"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4597), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("de6400d7-12df-41de-9516-a130d8a8e444"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2253), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") },
                    { new Guid("de9ef9d4-4cf7-49db-bb50-a2cbbb6e6b04"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3139), new Guid("dc874efb-cb13-48aa-b7ec-32cf072cd5c5") },
                    { new Guid("df0d483f-e28b-4c4a-bc76-f19c6f20c48a"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2121), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("df8ce5da-5dd2-46ed-8991-05c25b249adb"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3274), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("e0115924-5764-435b-a906-4c40932bc7c4"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3844), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("e141ab8e-f696-4a34-85b3-f9e7eba2f06e"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2783), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("e6154adf-0782-4107-88b1-38a09b8d1619"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4404), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("e6f0eaeb-be3c-4397-a9a5-65ee59b01d40"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4001), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("e70fd70f-733c-4963-a2df-6b89337b3894"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2938), new Guid("2a4d907d-454b-403d-ab6a-2791b1c6f74e") },
                    { new Guid("e835742c-a581-4085-9c53-ec061f1142f3"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3751), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("e9535bff-dc24-4631-acb9-4f7edaafc280"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3167), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("ea5ae1a0-d5ac-4bfe-9c9e-483b5ce9d353"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4389), new Guid("b8574766-a1cf-4dad-a506-1d2574e2d357") },
                    { new Guid("eb2d2201-2fdb-482d-8f81-721f05dc3450"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4442), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("eb652ce6-2632-420e-b664-321c42c3a840"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4038), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("ebc12e48-891a-4ce9-a62e-0127fbaf5a9d"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2307), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("edd6cbfa-bb73-4755-9c72-f8c5917876a1"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3321), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("ee6b8314-4bb4-4dd5-90ef-0060a997b62f"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2043), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("ef27964e-2b49-4b56-b40b-5fcdb4646fbd"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(1625), new Guid("dca9cc24-9d23-4ea3-8d05-c9742cea8f04") },
                    { new Guid("f1024ac3-8ad1-421d-a5f3-69fc138e6737"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2461), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("f1bca1b7-263e-4ead-93fa-afdaa70c8903"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3399), new Guid("95554678-78dc-4bc2-9711-cc16c62f9454") },
                    { new Guid("f1d0e366-fcb4-4af4-95d9-4170a5166377"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2770), new Guid("6e4bc369-b1f3-47b4-9bc3-61bfb73717ba") },
                    { new Guid("f3a69dd7-2121-4224-91bd-801cee5c93e1"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3246), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("f43e1e35-7122-47d0-b2f3-f1a32a75ea45"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3961), new Guid("0ee7c3c9-8f16-49b5-b3a4-69e11684476f") },
                    { new Guid("f44733bd-5aa0-45b4-b014-7cf406621681"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4804), new Guid("a81f3c61-6033-4d6b-a99a-570af386d267") },
                    { new Guid("f529b88c-07ed-4d86-beea-c487fc4b8a83"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3689), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("f567fe5a-2028-4ad6-8850-5b5ad8dc5e95"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3872), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("f77c7d05-9791-45a5-963d-5179d586a077"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2055), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("fb1698ba-575c-415b-9a83-0b53ab4cc0ef"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2359), new Guid("2c3a24c1-ed90-45b5-a2bb-879e0e1e04ea") },
                    { new Guid("fb583844-20c9-4699-b263-3bf20092d82b"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3933), new Guid("e7c7a820-87ea-4d5d-87ca-8c3f60349b6c") },
                    { new Guid("fb99d393-c2fb-4854-893c-3fff615ef5f0"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2068), new Guid("98cf2e18-9822-49f2-9a69-55c7750d824b") },
                    { new Guid("fc6b2076-1736-4999-9d8c-ed72c3f1fda3"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(4522), new Guid("1d536edf-a375-4486-9f5b-1ca57ec9600f") },
                    { new Guid("fd6af885-e7a8-427a-b200-571d7b1592bc"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3192), new Guid("ad82d022-de95-4a91-b92e-dcf5d8546c74") },
                    { new Guid("fe184269-f9f4-4341-ac70-0afeabd9b546"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(3701), new Guid("59495ffe-3b34-42c3-9ef6-45f7be115b0b") },
                    { new Guid("ff4ef783-48d6-406a-866b-92239aace862"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 13, 12, 54, 23, 772, DateTimeKind.Utc).AddTicks(2162), new Guid("6e206c0d-b689-4b8e-9fac-6411f3cf9c5a") }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("149d4420-fec6-48bc-8ae6-91b82209d437"), new Guid("c492ae93-a1cb-4562-b0a0-c53576bfc99a"), "exampleURL" },
                    { new Guid("18401bc8-8329-4ebc-bef6-1aed6b9e4bb6"), new Guid("94f90904-6846-4a1e-a8b6-d3d21908612c"), "exampleURL" },
                    { new Guid("224e2181-94bc-4f0d-b6af-0e783c76ab14"), new Guid("473c1849-2d1a-4c70-b05b-520ac7e9cf85"), "exampleURL" },
                    { new Guid("24c561d9-0511-41b8-ab74-e6b801681105"), new Guid("6b6ce3e5-cd9a-4534-80f3-53c0f801ac65"), "exampleURL" },
                    { new Guid("26a34a41-abe5-4e07-b7bc-6fce13ba5352"), new Guid("10716740-09d4-4adb-9808-1f4fc84653ec"), "exampleURL" },
                    { new Guid("3a3b7c8d-b6ea-4460-832c-c6fb0acc1408"), new Guid("03d0fb6e-6575-4dbb-ab1e-7eb2023dce64"), "exampleURL" },
                    { new Guid("3b6bd743-48f2-4b84-b687-753554f6e940"), new Guid("e71ac2f8-3037-4c1e-babf-a3e98510a1d1"), "exampleURL" },
                    { new Guid("3b9aefb1-9b41-4f95-afae-4e1b93a75bf0"), new Guid("097eecc2-00d5-40f6-ac36-d2c2437fc689"), "exampleURL" },
                    { new Guid("3be48b93-7bb8-4064-a138-e5e28b9a44c5"), new Guid("6a8e26d8-8cc1-4080-a7a8-bb8aeb7afc8e"), "exampleURL" },
                    { new Guid("3e079d63-c751-41ac-adc1-0ef42771ca5d"), new Guid("6bac7e95-a2fb-48c6-8a98-c8409f3a6897"), "exampleURL" },
                    { new Guid("4345069e-cdc4-4e83-8758-27fb76d0b61f"), new Guid("26747773-87c2-42d0-acdb-f71231f3c2a7"), "exampleURL" },
                    { new Guid("47593a86-2795-4348-b86a-1907e3db93b5"), new Guid("036b65a3-c021-4fc7-b137-c5e0c36296f9"), "exampleURL" },
                    { new Guid("476b4223-aa8f-4c80-a640-55aa25ffe58a"), new Guid("811ff6d9-d699-4913-857f-ffe37a6a76de"), "exampleURL" },
                    { new Guid("4a7d7416-c118-4837-9931-98a90717034b"), new Guid("00fa3a9b-4ff9-4a2c-b85d-502c61373875"), "exampleURL" },
                    { new Guid("63a6fa5d-ea6c-42d3-94c9-bb8c55fb3037"), new Guid("42ac8945-b381-465b-8b6b-b097ae22d66b"), "exampleURL" },
                    { new Guid("6d0079fa-8c07-4d30-a151-7190c57f586b"), new Guid("cf8630a6-3958-4ae5-a975-4d6404de6a24"), "exampleURL" },
                    { new Guid("6f3f52ed-790c-4eac-bd88-4a3a1a51c975"), new Guid("eec61697-1a5f-47b1-8a97-85de7728da37"), "exampleURL" },
                    { new Guid("84272003-4b08-4a8d-8886-30b7f427004c"), new Guid("589eaae3-a5fc-4467-80a8-8e3510896f86"), "exampleURL" },
                    { new Guid("8c89293e-8287-4c54-9938-6db1db11558c"), new Guid("7b6a0ccf-4fc1-4af5-b195-b4ae4885bf96"), "exampleURL" },
                    { new Guid("8e10e250-85db-4477-9d33-6d2cff89573e"), new Guid("30d69e4b-c005-4eba-8cfd-402703088012"), "exampleURL" },
                    { new Guid("8ff0ac1d-b005-4f13-8141-dd2a5d039937"), new Guid("5ca5f297-45c0-4290-8995-e75e4a510e36"), "exampleURL" },
                    { new Guid("a00a8022-b0e1-4283-b814-625f2ad7b838"), new Guid("be9d2cbb-7af2-472e-bc7f-91341bffb54a"), "exampleURL" },
                    { new Guid("a0b6304b-e3ef-479c-a9c8-102eda313600"), new Guid("eefabbdd-3bb4-4010-a899-01b8478666bb"), "exampleURL" },
                    { new Guid("a2d84960-a0e8-4dd8-8ed2-ecbfeaea36ed"), new Guid("7101bff2-40dc-4e92-b4de-cece469f5e9e"), "exampleURL" },
                    { new Guid("a3dd624d-0b63-494b-9327-2725be32c4f3"), new Guid("c1bf8875-897b-4e5a-a523-c3bee016c93f"), "exampleURL" },
                    { new Guid("aa6ad750-44fc-4578-a783-1d9352e314c9"), new Guid("fa8db6fb-70f7-4223-b72c-58dad8e64c15"), "exampleURL" },
                    { new Guid("aa950e3b-466d-4539-8359-11987170c9b7"), new Guid("cd3318e4-c148-4fe3-bd49-cdd4a4df4a49"), "exampleURL" },
                    { new Guid("b3ba3554-20b8-4264-b360-5df3c304e0f2"), new Guid("32cd98d0-565c-425e-a3eb-9b6e516720d0"), "exampleURL" },
                    { new Guid("b5be9078-9c6e-4506-bd9a-6e5681729474"), new Guid("55547fa2-54af-4407-9f2b-a722ccdb00c8"), "exampleURL" },
                    { new Guid("b7a242f4-4ea1-4d69-94f6-34ff9e9d450c"), new Guid("53c7b616-c16f-4791-9c19-f104afdc4995"), "exampleURL" },
                    { new Guid("b9ed82bd-a3e6-4b2d-9080-8c2ae4b65020"), new Guid("186c124b-b034-4db0-9f62-2f45de79f0ee"), "exampleURL" },
                    { new Guid("c68e5618-b80a-4758-8dd3-2938a55f1f05"), new Guid("2b694040-0c6c-4aa7-a463-6da84c56db9a"), "exampleURL" },
                    { new Guid("c9750d33-dc23-43ad-b3bf-e47e5598c8de"), new Guid("2043ae3d-95df-424b-bbe7-5cb20e296b29"), "exampleURL" },
                    { new Guid("caf33805-7aa9-4e8b-92dd-d477eac7dbc3"), new Guid("cd7e449b-a9c7-41fe-92f6-4942601dad84"), "exampleURL" },
                    { new Guid("ce8c5d47-73fc-4e06-95d4-4fc73b977f8d"), new Guid("4cfc4a6e-44b4-4bc4-94e8-d7fa04607bfa"), "exampleURL" },
                    { new Guid("d0596c23-1b3e-473e-ac25-dc62351e41fc"), new Guid("5943fa3a-6de9-4e8e-b674-2a72ec18c8c7"), "exampleURL" },
                    { new Guid("eb3fdf45-c069-46a7-9588-4783067d75bd"), new Guid("3a8255b7-6eeb-406c-92f4-8f453fdd5a5c"), "exampleURL" },
                    { new Guid("f4ab52ef-a004-4034-af6b-8fe5d0691b20"), new Guid("a982a431-91f6-461e-9da2-94553ef34485"), "exampleURL" },
                    { new Guid("f55a0d33-52e8-490c-a2f7-cb4aa59c19c8"), new Guid("86e83275-9037-4cdf-a4af-85cb458f49e7"), "exampleURL" },
                    { new Guid("f5ad38b7-ee47-4db6-bc9b-61e7a8b8d3da"), new Guid("0b956389-f4da-4a82-9a4c-9c24322e4248"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("01b5b01b-6aa8-476a-aec0-1a28d4e3c42c"), new Guid("8dbccd51-2aa7-46f5-9d46-082dfd476e49"), "exampleURL" },
                    { new Guid("023df42f-abbd-416d-9353-59efe560a083"), new Guid("f77c7d05-9791-45a5-963d-5179d586a077"), "exampleURL" },
                    { new Guid("02530ba2-4887-4ebe-9f1a-d8df0946471a"), new Guid("d44a8dde-148f-4597-868a-bb15c25181a8"), "exampleURL" },
                    { new Guid("046d4399-7797-4db8-b97b-d721ed27c382"), new Guid("e141ab8e-f696-4a34-85b3-f9e7eba2f06e"), "exampleURL" },
                    { new Guid("04a9f3e8-2011-418a-9ef5-1ed3d4950bd2"), new Guid("834639f2-7d40-4067-bdc0-c53898babcf6"), "exampleURL" },
                    { new Guid("04e383fe-71d2-40a9-8f48-adc4018b4df2"), new Guid("14dcb5b0-84ec-4428-a0ce-909eef1a802e"), "exampleURL" },
                    { new Guid("053b2f3a-366c-41c3-8a99-70653f2883f7"), new Guid("76c7cc88-f0da-4887-9f8f-35fdf7253cfb"), "exampleURL" },
                    { new Guid("07c71b28-4f70-4086-9f3e-424595ab7873"), new Guid("6af469b5-d27f-44d4-ba81-dc1d1669160d"), "exampleURL" },
                    { new Guid("0d23731b-bb89-47a3-b229-66a08cc5f773"), new Guid("29fc21d8-a1ef-4164-bed4-0e99c3283a6c"), "exampleURL" },
                    { new Guid("0f39d2bf-f026-4790-92ae-73b90cc78dd2"), new Guid("a2d6b575-c58e-4dde-9547-8141b552872f"), "exampleURL" },
                    { new Guid("0f4e8504-c910-4917-a657-c195d6b15206"), new Guid("ab7dfa18-a11a-4699-ad08-f6405b7a30c6"), "exampleURL" },
                    { new Guid("11179725-2bc3-4ca4-a1b3-aec04a2f2db2"), new Guid("64312d4e-3431-4eae-9bd6-95a4f2d6b873"), "exampleURL" },
                    { new Guid("11d6e4fc-76c7-477d-9d0d-cfbea6b9618c"), new Guid("df8ce5da-5dd2-46ed-8991-05c25b249adb"), "exampleURL" },
                    { new Guid("1271b960-9cad-45e9-9437-f795e2e737bc"), new Guid("c0798cb3-36a6-4b1f-b9d6-12e088238203"), "exampleURL" },
                    { new Guid("134e1ca8-ab59-4ad4-8768-2c3de6d86237"), new Guid("1ef895a2-82a6-4441-87aa-d219f7097e01"), "exampleURL" },
                    { new Guid("156e9e08-aed5-49fe-a8f7-9187347d3dd6"), new Guid("32e7eb5e-76f3-44ce-8cfe-519f79f9f3d1"), "exampleURL" },
                    { new Guid("16465457-de4f-4403-9124-ab6d1e598551"), new Guid("0dab6c91-c5f6-40e7-9ceb-16256d0cbe01"), "exampleURL" },
                    { new Guid("165cd7a3-7635-4cd2-bde8-813b6712d291"), new Guid("9b0c133c-0a3c-469d-be7b-01b408ad4cc8"), "exampleURL" },
                    { new Guid("16629f22-5571-4637-a867-7934ef5becbb"), new Guid("22ae2075-5a15-4c45-89f5-02cd8a89a012"), "exampleURL" },
                    { new Guid("1ab1c6eb-5ac4-4527-a5c0-774c870297e7"), new Guid("49555e19-47f2-4e70-b92b-ef1fbf1b2146"), "exampleURL" },
                    { new Guid("1b9a51ae-ebd7-40e8-a724-7276348c5995"), new Guid("70eb5d29-262c-48dc-9d3d-9460dd39d3cd"), "exampleURL" },
                    { new Guid("1bfaa7e0-f827-431d-80b6-e4eaa3905360"), new Guid("ea5ae1a0-d5ac-4bfe-9c9e-483b5ce9d353"), "exampleURL" },
                    { new Guid("1c660e10-38ee-44c8-8626-aaced29b4b09"), new Guid("a7f5392b-8fc1-4c1f-9a2c-f69078bd8a2d"), "exampleURL" },
                    { new Guid("1da31c92-25bd-4118-b2f3-aa2abc95bdb7"), new Guid("ca51da66-5717-4164-af4d-62bc716a3ad5"), "exampleURL" },
                    { new Guid("1f2df717-9c28-47e9-add6-4410d556d143"), new Guid("239d4cb8-5734-4712-8332-0170b590bd72"), "exampleURL" },
                    { new Guid("201f461a-7237-4870-9296-e46db7d310d3"), new Guid("8f6a170c-e1c9-4eb8-9edc-59f3ec024fb2"), "exampleURL" },
                    { new Guid("23531477-1b4f-4a21-8876-3178d0f3a1b5"), new Guid("50fa83ff-5242-4ab9-b0da-73fd6547ac2a"), "exampleURL" },
                    { new Guid("239301ba-4419-481c-8418-71ba9286818a"), new Guid("98993254-5f28-4ac1-98b2-6d0725a57be8"), "exampleURL" },
                    { new Guid("23c5e9d5-2c99-49e9-bd0c-cb0e93886db0"), new Guid("86523c2f-545c-4f8e-9561-8cfba4df6ac3"), "exampleURL" },
                    { new Guid("244506a0-e250-412d-b0dc-edab486ec76a"), new Guid("84fca2c6-3781-43d8-a8ca-9fa18c662961"), "exampleURL" },
                    { new Guid("267d8497-b8f2-4a0c-8aa6-e5aee535fafc"), new Guid("171ed945-f0da-4ad0-ba53-c33cbdbb4ecc"), "exampleURL" },
                    { new Guid("26dd09e8-34eb-4591-99c1-340aeb8fd143"), new Guid("464737a9-c93f-466e-97a9-2d7dc56af6fc"), "exampleURL" },
                    { new Guid("26e42166-2860-4b96-bb5c-ee7140b72974"), new Guid("9e9ca412-1bd4-4648-a6a9-7e481d6783ce"), "exampleURL" },
                    { new Guid("273c4176-04e6-4e56-a092-8bd36b1e0666"), new Guid("5cc9ae2d-e48f-47bb-bfcd-7760fda1746a"), "exampleURL" },
                    { new Guid("29f2c9fb-be7d-49ba-ab15-551bb75ccc43"), new Guid("f3a69dd7-2121-4224-91bd-801cee5c93e1"), "exampleURL" },
                    { new Guid("2af21306-4d0c-4278-acc5-150e197933ef"), new Guid("afd6acca-a895-4b35-9e10-cfff0879a012"), "exampleURL" },
                    { new Guid("2b468bc7-e7cf-4ed0-8d2f-42163ffa18c8"), new Guid("0ffb1f6d-b3d1-4105-9e38-9d2422a01d2a"), "exampleURL" },
                    { new Guid("2beee6c7-f23e-46ae-90ba-c5d7e7e91b8f"), new Guid("b34047d2-60e3-4cb7-a194-3b4585ff555f"), "exampleURL" },
                    { new Guid("2e36686d-073c-4c7b-85bf-e5b66e5af166"), new Guid("c1045df1-723f-4a2a-8566-7449739745c1"), "exampleURL" },
                    { new Guid("30c74c1a-a058-4f38-b6f4-9ab62e00d860"), new Guid("920da9ca-41a3-43b1-84ab-ed6eba9e6a51"), "exampleURL" },
                    { new Guid("31821b61-19fa-4402-be56-f3082b08ccd3"), new Guid("091e868f-c20b-4406-b4c0-4ce4c662a715"), "exampleURL" },
                    { new Guid("32cdef97-e981-4dd0-adb3-140aeb771a39"), new Guid("76846931-390b-4d47-8730-07b7cc2783e0"), "exampleURL" },
                    { new Guid("345aaae8-de41-4b66-bcd8-d7911e1a3101"), new Guid("3c79c5cf-1977-41d0-8db6-24191c236778"), "exampleURL" },
                    { new Guid("350bedbc-5447-427e-a9e1-d2b463986643"), new Guid("b60736e0-8a5d-4f8c-ad2a-361ce269df04"), "exampleURL" },
                    { new Guid("353aae8e-216c-4695-b651-ce3d4a4d0edb"), new Guid("4a1e167a-0b04-4e3a-8231-5a538225d9ba"), "exampleURL" },
                    { new Guid("35c1015a-60ee-4d9e-9d72-629336617804"), new Guid("96b92847-e9c6-4105-8b60-a95ae26515fe"), "exampleURL" },
                    { new Guid("381b1eb7-ddd7-43fd-bb7d-4bfad114d2f7"), new Guid("6812fe19-a549-4a82-ac24-c1ba2ff1f09a"), "exampleURL" },
                    { new Guid("38ced3fa-6aba-4694-b507-40ab1f504413"), new Guid("06acd5ee-0939-4148-b116-27e1bcbf1e2b"), "exampleURL" },
                    { new Guid("3b435d00-8aeb-42b9-aa2b-938dd8dcc5be"), new Guid("4cf3861c-31eb-4ba7-8579-50ee995ec234"), "exampleURL" },
                    { new Guid("3bd0e603-ad9b-42f6-9c60-074b968619f7"), new Guid("b395e9cd-5f6f-461f-99e2-1dda47037684"), "exampleURL" },
                    { new Guid("3d7bed49-431b-4dd4-90a8-d34737cd026c"), new Guid("f1d0e366-fcb4-4af4-95d9-4170a5166377"), "exampleURL" },
                    { new Guid("3ff5def9-1dd8-4e70-a2b9-9acedf5fcef9"), new Guid("7c9a9621-be1c-4e63-a329-2de02258f732"), "exampleURL" },
                    { new Guid("42474e71-996e-45ba-8359-6516eb72ac76"), new Guid("cceddfa7-1f17-4cf3-9d06-c9d844e3a148"), "exampleURL" },
                    { new Guid("4553dece-0c54-4562-8718-da9a447bbee1"), new Guid("ebc12e48-891a-4ce9-a62e-0127fbaf5a9d"), "exampleURL" },
                    { new Guid("459055d5-b887-4abc-917b-b8cad589880f"), new Guid("fb1698ba-575c-415b-9a83-0b53ab4cc0ef"), "exampleURL" },
                    { new Guid("4810a9c7-48bc-46b7-8925-dd4bdf3a7d82"), new Guid("8b1a6908-5b5d-4d33-a60d-ebc5aceab6d1"), "exampleURL" },
                    { new Guid("499c4e44-4d0a-427b-8b90-561b8dee0d4e"), new Guid("0fc7bc71-d5f2-4f37-9763-39aed5b5f5ab"), "exampleURL" },
                    { new Guid("49f3207f-3715-4d0e-ae56-665abf9d51e8"), new Guid("6382a102-155a-4d5c-a839-e7537bda1cf6"), "exampleURL" },
                    { new Guid("4a8347f9-cca8-481a-8af6-75b076c524a2"), new Guid("a64f924e-890a-4d5d-9f6a-07dba0f3b5c0"), "exampleURL" },
                    { new Guid("4b454f0d-c7e6-43b6-9b2e-28fc196213e4"), new Guid("0435c047-8762-4b58-af50-4f4eee669143"), "exampleURL" },
                    { new Guid("4bb590d7-3f5c-45c3-8b4e-d056ddb623fa"), new Guid("98669ef5-2c5c-4112-828c-47a59bfd4891"), "exampleURL" },
                    { new Guid("4cafbcbd-01c2-47fb-94d5-90c8dee537a1"), new Guid("5b854f85-f9da-4795-b56b-d24020ec3f10"), "exampleURL" },
                    { new Guid("4ee23fd7-420b-4676-8db2-90b83080539a"), new Guid("300577c9-0a02-422c-8399-d405abeba603"), "exampleURL" },
                    { new Guid("4f12f68e-5427-4d7e-84dd-fb54799ba88e"), new Guid("786158ae-11ba-409f-93df-2f77690815f5"), "exampleURL" },
                    { new Guid("4f5b8c5f-eecf-49f2-8f26-016d21754817"), new Guid("ce8351d1-3b89-45f4-842a-477e0c4d1eea"), "exampleURL" },
                    { new Guid("536e49db-e090-42dd-8268-9141d7b85cc8"), new Guid("ff4ef783-48d6-406a-866b-92239aace862"), "exampleURL" },
                    { new Guid("545498bf-1d42-4c85-b39b-e75b08ec509f"), new Guid("fc6b2076-1736-4999-9d8c-ed72c3f1fda3"), "exampleURL" },
                    { new Guid("55b394a0-7d04-4cb1-a87c-4dfa42476725"), new Guid("1e5bd900-de9a-4ef2-b9ec-b5466018b1c1"), "exampleURL" },
                    { new Guid("55c111f1-c5fa-41f9-88f0-8ab59cc7a677"), new Guid("fb583844-20c9-4699-b263-3bf20092d82b"), "exampleURL" },
                    { new Guid("56e1fc27-4d9c-42d0-b6f1-7eeb011c8a19"), new Guid("1c3bfafd-c359-4901-8d27-7f462e69a2dc"), "exampleURL" },
                    { new Guid("56efe60e-7b2d-4570-84aa-331d92ab9d73"), new Guid("13419627-8250-4edc-9081-e2b3acfc1d6d"), "exampleURL" },
                    { new Guid("57aaf003-27d5-47aa-a543-a3d8608dd7ed"), new Guid("edd6cbfa-bb73-4755-9c72-f8c5917876a1"), "exampleURL" },
                    { new Guid("57ca0649-8431-461d-884e-0b37f6d780c2"), new Guid("5d4cff34-15b1-4c69-bfb0-a8a22aee66de"), "exampleURL" },
                    { new Guid("5b099bc3-4168-4e66-9d95-19048dc57099"), new Guid("606f2cb4-4334-4fcf-ae87-cf440afe0800"), "exampleURL" },
                    { new Guid("5b40fb3c-c854-47bc-9514-4eb6d4cf77c3"), new Guid("d401c437-952b-4227-8ae3-b228c5950243"), "exampleURL" },
                    { new Guid("5bf6a979-d513-427f-b28a-e530521bf5a4"), new Guid("d26f5615-76ed-4681-98aa-aac09386916d"), "exampleURL" },
                    { new Guid("5d03b231-0b3c-4ce4-a7d9-78b894d85ac2"), new Guid("1cc8f6c8-282b-4c77-a388-111bc24abb89"), "exampleURL" },
                    { new Guid("60537854-87f4-4e7b-b314-319c55cdbdef"), new Guid("29dbeda5-ae9b-4a16-b55c-c1b3fdde91f5"), "exampleURL" },
                    { new Guid("6363462e-bdef-42c2-8cc5-32bb5f080132"), new Guid("1a2f5902-003e-473e-a568-5a87e7d80354"), "exampleURL" },
                    { new Guid("636fb931-2fbe-4c13-b923-62f71c456ab5"), new Guid("d5d067a6-1e5e-4568-874a-45853211cbaf"), "exampleURL" },
                    { new Guid("648b1868-fc49-4fed-bdef-180a61e6312c"), new Guid("5e4b9beb-07a0-4de4-a5d2-c76315c2e8b4"), "exampleURL" },
                    { new Guid("66bb7c86-6787-4f3c-92b5-7a6b8e1dce81"), new Guid("c9b0d508-6d29-4a6e-884d-080d1537ca08"), "exampleURL" },
                    { new Guid("679a1ce5-91b4-411b-871c-0876e7896665"), new Guid("ba7e6b95-323c-4a23-9353-94ee727b3cbf"), "exampleURL" },
                    { new Guid("6848cad9-1253-4d1b-88cc-14c8c5453311"), new Guid("0b680d72-1289-4d46-8259-543ffde34cac"), "exampleURL" },
                    { new Guid("6b5d45d2-30a7-4984-bfb0-e16b93e62270"), new Guid("703018e3-b32a-490a-a685-f7f7c68db12f"), "exampleURL" },
                    { new Guid("6d4e5804-72e8-4763-841a-6e933d94f21d"), new Guid("d40bdbf6-5311-439c-8dee-83edff4066dd"), "exampleURL" },
                    { new Guid("713533fa-6e32-49f2-8a6c-a38e91f07570"), new Guid("6baa25f2-9f96-4ce6-a315-7d97bcd634d4"), "exampleURL" },
                    { new Guid("736f057a-bfba-44ed-821b-cc998b25e0a8"), new Guid("eb2d2201-2fdb-482d-8f81-721f05dc3450"), "exampleURL" },
                    { new Guid("73b4dfd7-5c3f-40f5-833e-47ece5083274"), new Guid("4eea2e90-61c8-485c-b71c-36f9b547d4ec"), "exampleURL" },
                    { new Guid("73f8afb7-8157-4677-b818-a6d531294a4e"), new Guid("4f154546-84da-407b-8039-ef1a3884e0ac"), "exampleURL" },
                    { new Guid("75a711ed-d95b-4ba3-a3f1-2eb04e4311cf"), new Guid("9d6082ed-ecc7-4262-a90b-923b293b6b7b"), "exampleURL" },
                    { new Guid("75d8339e-fb80-410e-91aa-11460e16c00e"), new Guid("b73f319d-b8f8-419c-8ee1-f6275fac5a5a"), "exampleURL" },
                    { new Guid("76593e70-bd09-4dee-8a3f-17861430364d"), new Guid("4178568b-6496-4bd5-8097-0b0d48e90818"), "exampleURL" },
                    { new Guid("76c4b075-0003-4dd2-b43b-ef067fc2358c"), new Guid("b2e5968b-bc78-4f70-b649-ed0fb121f546"), "exampleURL" },
                    { new Guid("77125698-9832-45eb-a908-69aa75811e18"), new Guid("3cb8fb31-a092-4a8c-ad1c-62a3bcb539fe"), "exampleURL" },
                    { new Guid("7789e58e-3c86-4743-b5c0-80d2c3ce2890"), new Guid("a20a9e9e-e104-4a24-91fd-943348d13248"), "exampleURL" },
                    { new Guid("79891765-c964-451b-a079-6e2c6c54d38e"), new Guid("f43e1e35-7122-47d0-b2f3-f1a32a75ea45"), "exampleURL" },
                    { new Guid("7b425e2e-1075-4e16-b38d-19925c35f3af"), new Guid("3be746bd-ec5b-4b1e-a6de-6c0512405aae"), "exampleURL" },
                    { new Guid("7b4b91e2-ccff-4e72-a842-b7e61348717f"), new Guid("d22a5daa-ac88-4ca0-8169-5dfe05eacf43"), "exampleURL" },
                    { new Guid("7bab477b-0c02-4c67-adeb-703b1a94ca3f"), new Guid("df0d483f-e28b-4c4a-bc76-f19c6f20c48a"), "exampleURL" },
                    { new Guid("7bf3c581-d408-489e-8ff8-16b5abbedb7e"), new Guid("044f0e55-2b37-4874-b985-f501387eb7b9"), "exampleURL" },
                    { new Guid("7e710aac-587a-4834-97d3-b43120db91a4"), new Guid("d2d12c8a-d797-4612-9719-8a1e180fd8f3"), "exampleURL" },
                    { new Guid("7ea0c370-9236-4496-887c-dd80296cb1bf"), new Guid("6db2482f-f871-4d19-8425-6666caf7c613"), "exampleURL" },
                    { new Guid("7f149126-8ed7-4b40-ab05-8ff77d5f3637"), new Guid("9d84b289-f537-4ff9-a518-a2c1dd0f8e62"), "exampleURL" },
                    { new Guid("805df37a-8425-451a-8b8b-aa66d4d9c111"), new Guid("d0dc153d-7c87-4ed6-8dfb-e20f59ba0bc1"), "exampleURL" },
                    { new Guid("8621789e-f230-4934-9131-445f5158e18a"), new Guid("8fee12d3-50a4-4bc5-bafc-907213a80bf1"), "exampleURL" },
                    { new Guid("86a39b3c-75a6-48e4-923e-1e315648f704"), new Guid("3654b44d-e430-45eb-a936-56637a0d2445"), "exampleURL" },
                    { new Guid("8744bea9-ac8e-403e-9488-8314898218d3"), new Guid("bce8b3b5-e52e-4daf-91f2-37141fb52439"), "exampleURL" },
                    { new Guid("888a0802-26e5-47b1-a2fb-0a5249e7d648"), new Guid("67489766-cf26-4b8c-a016-a31c750105ef"), "exampleURL" },
                    { new Guid("8aa3e18a-ff3f-4bbc-ab10-f0390df6cb23"), new Guid("c2a2bf3d-9cfe-4c38-a459-71131dbdb0da"), "exampleURL" },
                    { new Guid("8b10efb9-773c-47ff-8540-63d437456dbe"), new Guid("f1024ac3-8ad1-421d-a5f3-69fc138e6737"), "exampleURL" },
                    { new Guid("8c0dbcc5-7e41-4768-87b2-4949c04e1cde"), new Guid("188b9aca-c828-4cb6-ac07-443ec02d1c65"), "exampleURL" },
                    { new Guid("8f4e6155-da64-450f-99ed-4b0326d39f97"), new Guid("e0115924-5764-435b-a906-4c40932bc7c4"), "exampleURL" },
                    { new Guid("91e6c7b8-0e08-420f-b257-466b3414b4ad"), new Guid("9c52b57f-f345-4d60-bfa9-bbe764ce8b66"), "exampleURL" },
                    { new Guid("92417412-afd3-4d0d-af5c-be06e365353f"), new Guid("d159d839-db44-46b0-b84a-2f98c9bbe14f"), "exampleURL" },
                    { new Guid("934aeb32-9061-48c4-b1f8-fdc85c62b082"), new Guid("ee6b8314-4bb4-4dd5-90ef-0060a997b62f"), "exampleURL" },
                    { new Guid("9484a852-2bdf-430e-9ee3-bfd9c51272df"), new Guid("1e4a7d7b-ff15-4c4c-b34a-34b6a94b397c"), "exampleURL" },
                    { new Guid("94d653fb-49f7-43c3-bc3a-3972de5acf77"), new Guid("393fe644-c16f-4aff-89d0-545310aa2239"), "exampleURL" },
                    { new Guid("966386aa-300a-4cb3-a9a6-a691d4e61343"), new Guid("eb652ce6-2632-420e-b664-321c42c3a840"), "exampleURL" },
                    { new Guid("96f9a939-b26a-4cee-8d54-4193898ea7f3"), new Guid("b12729be-e6f0-4db3-a4d6-2890d01a1739"), "exampleURL" },
                    { new Guid("99314a87-2b25-40c5-9cf2-c0e87a5aaa8d"), new Guid("e6f0eaeb-be3c-4397-a9a5-65ee59b01d40"), "exampleURL" },
                    { new Guid("9bd13f03-1551-4dd8-8410-14c4f4290400"), new Guid("0f264517-ce45-45da-9140-f121073103ae"), "exampleURL" },
                    { new Guid("9c9af446-4702-4d4a-9cf7-468e8365faa4"), new Guid("a66588aa-f99f-44d1-8ab8-8a29b281f207"), "exampleURL" },
                    { new Guid("9d616d58-7bb3-4b69-bdb9-557b9b4f4c87"), new Guid("f529b88c-07ed-4d86-beea-c487fc4b8a83"), "exampleURL" },
                    { new Guid("9d644ce9-032a-4dc8-a48b-8f3b063f500c"), new Guid("1fb2c668-71b3-40a4-8b94-06e1354be0e7"), "exampleURL" },
                    { new Guid("9e0a94e2-8ef3-4bb7-ab7c-a492629130f3"), new Guid("2b283c35-a9de-451e-a284-a9f2d374a326"), "exampleURL" },
                    { new Guid("9f2e3ec3-a0cf-4995-b780-d68f105c7741"), new Guid("cbd991c7-6d1b-4606-8fb7-a889971b4ab3"), "exampleURL" },
                    { new Guid("a320a5db-0462-4e1a-b374-f61221aac692"), new Guid("be053155-7031-47b0-bcd6-d27166fd99c6"), "exampleURL" },
                    { new Guid("a5a6b4f5-bf8c-460f-9776-3e04eaafea69"), new Guid("4aeb6ca3-fc6c-49d8-ace3-c5be84bd841b"), "exampleURL" },
                    { new Guid("a74a15a4-2659-41ba-a134-dfb86650418e"), new Guid("a69158e8-a1fb-402d-9a55-483d710afa06"), "exampleURL" },
                    { new Guid("a9a641b3-3571-449c-843a-5d51b2e031b5"), new Guid("585c76f9-feaa-4191-81d0-683483175c9c"), "exampleURL" },
                    { new Guid("aaccd543-1493-408f-935f-fc4b1147e215"), new Guid("980ec6b2-a51a-4010-8bc8-a9e39b61b622"), "exampleURL" },
                    { new Guid("aad29061-8428-419d-9416-95d9df86ef25"), new Guid("6aaff054-00b4-4d37-ba9a-e6aabf5d83c8"), "exampleURL" },
                    { new Guid("aade7ef4-ca6d-4b66-a9cb-16598e658fa4"), new Guid("0c6c2763-71d6-4e48-b0b2-1846ffd9291d"), "exampleURL" },
                    { new Guid("ab1b87d0-8764-4269-9a80-77565725e1b2"), new Guid("8720ea22-b513-4fda-8ce8-80a1f4fdd201"), "exampleURL" },
                    { new Guid("ab984701-db2c-4c07-8b96-965619396a8e"), new Guid("49bac94d-7acc-44f8-81e2-9a131eb90770"), "exampleURL" },
                    { new Guid("abd6186a-03e9-40ba-b5f5-084c9efb4b4d"), new Guid("c1bd1c94-6381-4257-963c-de47857074fa"), "exampleURL" },
                    { new Guid("ac2483af-e6a4-4d9a-9784-982604fe0edc"), new Guid("cbce8809-c210-492d-806d-b601f8190dfd"), "exampleURL" },
                    { new Guid("ac446829-5202-4a73-9b0f-338295937efd"), new Guid("d6f57567-1cbb-484c-ab64-c884cc86faeb"), "exampleURL" },
                    { new Guid("ac4691b8-33d8-46d2-9b75-325cbdc64d6f"), new Guid("e70fd70f-733c-4963-a2df-6b89337b3894"), "exampleURL" },
                    { new Guid("aca73e7b-13b4-4837-8d7e-23b5dc5440cb"), new Guid("58082963-7465-4622-abef-98b850e69d6a"), "exampleURL" },
                    { new Guid("aeeb4cf7-a050-40d0-b141-947367d1c1e6"), new Guid("8d91f813-bdca-4c26-b623-4aac87780d7e"), "exampleURL" },
                    { new Guid("b0df0a5e-3201-4900-836e-c4739620b473"), new Guid("ca3188da-b4dc-449e-8429-11a0a109b08d"), "exampleURL" },
                    { new Guid("b3870c1a-2117-4875-a981-28faa3f271d5"), new Guid("43a96df1-5c48-4c0a-b25d-4f8caff46ef7"), "exampleURL" },
                    { new Guid("b5bec96b-eb72-4378-906d-e3b5bc04bf71"), new Guid("73965159-6251-4780-970b-3d36e6bcf4ef"), "exampleURL" },
                    { new Guid("b5e15e0e-29a2-46ee-8d63-d4235c888b00"), new Guid("de9ef9d4-4cf7-49db-bb50-a2cbbb6e6b04"), "exampleURL" },
                    { new Guid("b8ffc3da-e5f1-446a-998c-b64cd5210c4e"), new Guid("43639fd1-501f-4029-8e10-78f772864473"), "exampleURL" },
                    { new Guid("b95cbe17-1607-46b3-a120-f54fd09e7e7d"), new Guid("a925cee5-7faf-4333-abb7-d58a49739acf"), "exampleURL" },
                    { new Guid("ba73779e-2f4e-4447-a3c1-345a6d4720a4"), new Guid("bf7b7fa9-51d3-4e33-b370-cb3d89b7ad46"), "exampleURL" },
                    { new Guid("ba738b05-ce13-4de5-9a34-c8ef0d80730e"), new Guid("32214717-851e-414d-b92f-f96b4056e149"), "exampleURL" },
                    { new Guid("babb3b9e-e34c-4321-b1fe-5b34cfee2062"), new Guid("2a69442d-5ec2-464a-bb4b-0d1c79a24b0a"), "exampleURL" },
                    { new Guid("bb3e1e6c-dec3-4d09-8fda-2edec7fbdaf9"), new Guid("de6400d7-12df-41de-9516-a130d8a8e444"), "exampleURL" },
                    { new Guid("bc26863b-b7e4-4853-9c05-e262343e81f2"), new Guid("0f754291-dce0-4222-83e5-bd017031bd59"), "exampleURL" },
                    { new Guid("bc68ae64-a328-424d-99c5-0856c8e61300"), new Guid("d9b52e5f-8f52-4a44-893c-36036ad9edd3"), "exampleURL" },
                    { new Guid("bce6e0f9-3580-4b27-9088-9672cc8d3286"), new Guid("4385834b-596b-4b47-8b6c-90f635f60a47"), "exampleURL" },
                    { new Guid("be2ec6b1-a507-40bd-80d8-6cc42263a97a"), new Guid("a67a1648-d34d-4545-bc3c-03dcb461bfd8"), "exampleURL" },
                    { new Guid("bef093df-34f9-4cd9-8a2e-d79bf920c8de"), new Guid("57452ee1-9c0d-46dc-b6d8-05182eae892e"), "exampleURL" },
                    { new Guid("c0a49762-5a11-4360-aa36-e0e51b317f10"), new Guid("11ac5387-1b0b-4fdd-8ee5-a366bd74c3ce"), "exampleURL" },
                    { new Guid("c0c0ffe0-95c2-4025-b680-e8eda0789238"), new Guid("0ea83b1f-8e55-4840-8f18-a45af3b4ae67"), "exampleURL" },
                    { new Guid("c0e542c8-5947-4d3b-99af-2361517454eb"), new Guid("23e7ed16-e388-442b-8ea7-630ff106526a"), "exampleURL" },
                    { new Guid("c0e6ffc8-3011-4cee-979c-6a6fe06f212a"), new Guid("481f1342-a0f9-45d3-b2b5-013b8b82e2f7"), "exampleURL" },
                    { new Guid("c2832a98-5ab9-4e44-8e3f-6ead52034d88"), new Guid("a8cc4c7c-6ff6-401f-9942-6db0687386e8"), "exampleURL" },
                    { new Guid("c2a9ce5f-bb2c-4cf8-ac7c-40f49374541f"), new Guid("fe184269-f9f4-4341-ac70-0afeabd9b546"), "exampleURL" },
                    { new Guid("c369f7af-402d-4869-8410-438adb7096c8"), new Guid("7e76c486-d016-49d8-801c-1fb8b8ff9b16"), "exampleURL" },
                    { new Guid("c454dedc-5597-4814-90d4-ef17f9d7eedb"), new Guid("b1479e9c-5541-4ff3-b5c4-ecd32f839187"), "exampleURL" },
                    { new Guid("c4645674-a920-4e52-a152-7a3e39ba440b"), new Guid("c41a044b-d11f-47bd-acc2-1fdd2286c033"), "exampleURL" },
                    { new Guid("c4e20d04-947b-48c3-891d-0a173228d187"), new Guid("3b2d5bdc-8d70-41a5-855b-338b9601f354"), "exampleURL" },
                    { new Guid("c75ae194-c5f5-473c-84c6-d05d43d0d678"), new Guid("353885fc-fa92-498a-bff4-be86f9e10826"), "exampleURL" },
                    { new Guid("c7fa7f00-f56f-41bb-a98f-a2e708c5d5a8"), new Guid("085eb9cf-932f-47cb-9726-36d7d2938dbd"), "exampleURL" },
                    { new Guid("c927f792-9d7e-4bb0-92af-91d146976922"), new Guid("99f42038-0970-41a2-ae55-22b4fd411e3e"), "exampleURL" },
                    { new Guid("c95e4386-f4e5-4cd8-b74e-10ce66de7643"), new Guid("9558d0ac-2911-4191-a72b-2c881d94a20f"), "exampleURL" },
                    { new Guid("cc69c6b2-b8f9-43db-9459-b6934315baaa"), new Guid("242d9c32-7eb1-4603-9b5e-5cb1f821bd1b"), "exampleURL" },
                    { new Guid("ce96ed98-49d3-4e37-8e56-d94d70490f04"), new Guid("f44733bd-5aa0-45b4-b014-7cf406621681"), "exampleURL" },
                    { new Guid("d2825d77-6e7c-4700-95bb-dc03de5e6a64"), new Guid("d103b352-d0e4-4dec-8b5c-97ec2fad2d11"), "exampleURL" },
                    { new Guid("d2fa261a-24df-4a2b-a78c-405429eed907"), new Guid("e9535bff-dc24-4631-acb9-4f7edaafc280"), "exampleURL" },
                    { new Guid("d4eb56db-be89-4e2f-9ba8-01e5b16f6555"), new Guid("1375b309-d4fa-4c50-bca4-dddbe143aa1b"), "exampleURL" },
                    { new Guid("d732b95f-2312-48e8-a277-92058b2e2595"), new Guid("7fc31c35-b0fc-4592-ac28-1b4759c3ea99"), "exampleURL" },
                    { new Guid("d87df227-2d14-45bc-9f36-667f6295001b"), new Guid("f1bca1b7-263e-4ead-93fa-afdaa70c8903"), "exampleURL" },
                    { new Guid("daee73b3-868d-4a0a-80d0-22597b8bb4ce"), new Guid("2d1e95d5-c705-4ce0-b8e7-047a18e47198"), "exampleURL" },
                    { new Guid("daf33b91-c3bd-4536-b8b4-f5dcbc10f160"), new Guid("1b3faa2c-8647-4c86-8dc0-6d064dbf8960"), "exampleURL" },
                    { new Guid("db665be9-31aa-4146-8253-054bc5a1cf87"), new Guid("ef27964e-2b49-4b56-b40b-5fcdb4646fbd"), "exampleURL" },
                    { new Guid("dc940929-e549-43b6-bcc9-f4df8661e292"), new Guid("fb99d393-c2fb-4854-893c-3fff615ef5f0"), "exampleURL" },
                    { new Guid("de5ab4ba-a75d-46f8-9ddb-6d936760d6b7"), new Guid("4b181735-9bae-4dca-a1c9-e0dfc441e16a"), "exampleURL" },
                    { new Guid("e0176717-f912-420b-be58-f25869e51a21"), new Guid("fd6af885-e7a8-427a-b200-571d7b1592bc"), "exampleURL" },
                    { new Guid("e19c70c2-20f9-4791-8d4a-7ae7679e0f89"), new Guid("812f8791-8bca-40f3-9259-b27bfebf8f49"), "exampleURL" },
                    { new Guid("e716a123-1c96-4abf-8b6d-1968109756b7"), new Guid("8f08186d-e2b4-43a0-a561-e1d7c9a2d856"), "exampleURL" },
                    { new Guid("e7d484d4-b51b-4048-a9a1-23aba25dde14"), new Guid("10a869b2-0cc0-4d9b-a1e1-c4d1ad6e5b72"), "exampleURL" },
                    { new Guid("e88bb463-5ee9-4519-b150-0e1dae895916"), new Guid("7a072543-daf5-48cb-885d-26a04d29ada2"), "exampleURL" },
                    { new Guid("eadbba49-f3c6-42aa-86e3-6f767f507260"), new Guid("bd1cdf60-7db3-4284-b435-f8de38d0be28"), "exampleURL" },
                    { new Guid("ecafbe13-4151-4425-a08f-8c64b0e5618b"), new Guid("1ff0bd60-a7d8-404a-98ae-de2c8e535390"), "exampleURL" },
                    { new Guid("ed2b38e9-98e6-44b5-bab8-7fab9dfab750"), new Guid("e835742c-a581-4085-9c53-ec061f1142f3"), "exampleURL" },
                    { new Guid("ed916198-cf0a-46c6-b194-514acc9d2e7e"), new Guid("0a4de78e-62db-487e-99db-9cf1021468f4"), "exampleURL" },
                    { new Guid("f12ac630-c729-40cb-bc08-aa5e08f876f2"), new Guid("f567fe5a-2028-4ad6-8850-5b5ad8dc5e95"), "exampleURL" },
                    { new Guid("f2fd1a46-0829-4273-a66b-e84151d37d7f"), new Guid("e6154adf-0782-4107-88b1-38a09b8d1619"), "exampleURL" },
                    { new Guid("f3248ee8-90d0-4406-916a-c206874754b8"), new Guid("33d7272b-3cbe-49ef-8554-44c7f58743f9"), "exampleURL" },
                    { new Guid("f50db1a0-2d06-4f12-9008-3966a225c332"), new Guid("a589d542-fd8d-4d75-a5d1-ad58b23af8ee"), "exampleURL" },
                    { new Guid("f530be5c-1f0c-4562-815c-6a7e9c6a1099"), new Guid("8d006c7b-80be-4b82-aa13-27a237dc33f1"), "exampleURL" },
                    { new Guid("f6bf1f7a-08f6-4439-a1e4-2781028f180f"), new Guid("47266674-c382-49a2-90b0-a1f5e0f7e1c4"), "exampleURL" },
                    { new Guid("fb0dccce-3c87-41dd-84ff-efa1f8b487a0"), new Guid("d352065b-5987-4da9-8a16-0eae003f4f0e"), "exampleURL" },
                    { new Guid("fe3a949c-5843-4f1e-8a76-0984bedd9a5f"), new Guid("494e219a-19aa-4035-b3bf-e245c7966b1d"), "exampleURL" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountCredentials_AccountId",
                table: "AccountCredentials",
                column: "AccountId",
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
                name: "IX_OutfitItems_OutfitId",
                table: "OutfitItems",
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
                name: "Wardrobes");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
