using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations.Users
{
    /// <inheritdoc />
    public partial class InitialCreateWithSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", null, "User", "USER" },
                    { "77ec7b31-d322-4f02-93df-4b52dd5c6632", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000002-0000-0000-0000-000000000000", 0, "642d8628-33b9-43d1-9560-47eec97094f0", "ControllerKing@gmail.com", false, false, null, "CONTROLLERKING@GMAIL.COM", "CONTROLLERKING", "AQAAAAIAAYagAAAAELk4Z3/RJ4LQgQ/tGhBv0a4n9WO3qSIcqbh1Vw1VVDvD/JQToPg56VGP7VbtNLmpCw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "878cb454-63cc-48ce-9747-b0d5f1688db0", false, "ControllerKing" },
                    { "11111111-1111-1111-1111-111111111111", 0, "3ae6be6d-5d79-4d85-902c-40451aec5f75", "Gamer123@gmail.com", false, false, null, "GAMER123@GMAIL.COM", "GAMER123", "AQAAAAIAAYagAAAAEJZFfvYfFtQ49J3uXSJxY4GmulXEmfRFZMDEuS2S/5Gq5XBCfOow2ocI/D0cRbL8Zg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "27be5e3f-be62-4c2c-9dfc-9f1c4550a68e", false, "Gamer123" },
                    { "11111111-1111-1211-1111-111111111111", 0, "9689e38b-0354-4a3d-aff3-aa2af431533d", "PwnedYou@gmail.com", false, false, null, "PWNEDYOU@GMAIL.COM", "PWNEDYOU", "AQAAAAIAAYagAAAAEAp2x4Mtwj4HCv477UdThFJZ4SPQMVOprb1wSYZd3A9K51TF1jDBE1fn4FWOyEFsug==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cbf33cb1-7911-4751-8e0c-1a30eb3a1d4f", false, "PwnedYou" },
                    { "11112222-3333-4444-5555-666677778888", 0, "822fc2a3-4fae-432e-bd6c-70a58f1c059f", "LevelUp@gmail.com", false, false, null, "LEVELUP@GMAIL.COM", "LEVELUP", "AQAAAAIAAYagAAAAEB4iyRV2TzbK3XcXH7m3AmWCYYh1HeNKTybUMNqY8xFfJ962tjefUBlJE2pXxmtO/g==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4d1a3c3b-485a-4649-9468-1449e16a1ff7", false, "LevelUp" },
                    { "11211111-1111-1111-1111-111111111111", 0, "2f0724d1-7123-477a-b9cf-1c820ded4f94", "eSportsChamp@gmail.com", false, false, null, "ESPORTSCHAMP@GMAIL.COM", "ESPORTSCHAMP", "AQAAAAIAAYagAAAAEJ4Et0luM3D7ZHOm/a0UUyPOEHUI8pRNbYnaGshEoMqAY7IIdC0NyKPKuX60PCFWog==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7e4098e7-81aa-4bf7-9758-b32de715599c", false, "eSportsChamp" },
                    { "11311111-1111-1111-1111-111111111111", 0, "01b4d14b-b2a6-45c5-894c-c39d9111d0d2", "GameWizard@gmail.com", false, false, null, "GAMEWIZARD@GMAIL.COM", "GAMEWIZARD", "AQAAAAIAAYagAAAAEBXVNwo2RWuEkCRjozajWK6z6pzqzLVpuBG7NIxNUy2YzgRIBHZFBgmknn4tviIPPQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c723b194-6743-43ae-a3f2-160a686f3d0b", false, "GameWizard" },
                    { "11411111-1111-1111-1111-111111111111", 0, "b92302f8-9a32-48ef-b065-692d4dd6d289", "GamingJunkie@gmail.com", false, false, null, "GAMINGJUNKIE@GMAIL.COM", "GAMINGJUNKIE", "AQAAAAIAAYagAAAAEHOb/ACHe80oHOC8ce1R6roJAIbzX7q6G5jIf2XbK3eu79560hUSJ3tv0h49kuT3yA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a604ebe7-9e88-4773-a7f3-53e2f46e5480", false, "GamingJunkie" },
                    { "11511111-1111-1111-1111-111111111111", 0, "6ddc35ce-de95-4f6e-bd27-3f59f6d45c0e", "PixelPirate@gmail.com", false, false, null, "PIXELPIRATE@GMAIL.COM", "PIXELPIRATE", "AQAAAAIAAYagAAAAEBxq6cQC4bYU+GTF8uZUQPGC5E3sfIKjPkbrLI5XVLBQOVkhGKmg5fP7eJguc+tYGA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9a94511a-89d4-4784-955f-b7dc6a627a8f", false, "PixelPirate" },
                    { "11611111-1111-1111-1111-111111111111", 0, "3f6ed6b0-3147-4086-a3c2-8b263d0e6c08", "RPGHero@gmail.com", false, false, null, "RPGHERO@GMAIL.COM", "RPGHERO", "AQAAAAIAAYagAAAAEPEwmEdsewfeUBImOnh9ArmauhUmPtiQwvzFD9IynxDY795w66d0bJhjAMxjtTe4ew==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c0ecf633-ca24-401e-ba5d-03b8d876fa33", false, "RPGHero" },
                    { "12111111-1111-1111-1111-111111111111", 0, "0cb8fae3-6d3f-4902-b88b-b0f2f4ca73da", "MageMaster@gmail.com", false, false, null, "MAGEMASTER@GMAIL.COM", "MAGEMASTER", "AQAAAAIAAYagAAAAEBebvExKaEPE5rNbaxe7cqH2yc/J1nSg7trXId96CJLqRkeu+5exvRWmxzqGYSuPZA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e51d94f0-df99-471e-a1cf-e340b799da50", false, "MageMaster" },
                    { "13111111-1111-1111-1111-111111111111", 0, "e7995ee2-19d1-4457-a1a5-890b4e34484a", "LootHunter@gmail.com", false, false, null, "LOOTHUNTER@GMAIL.COM", "LOOTHUNTER", "AQAAAAIAAYagAAAAEPogQDIqsKuytPU0Gd3+Wc+3rSZwOmQTXkn7ZvY9iOqQ7Jlyb1G/eKB5M5GgPdAORQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16a9657b-2bc0-4909-b1cd-ed7f9c6247fb", false, "LootHunter" },
                    { "14111111-1111-1111-1111-111111111111", 0, "04cae4d0-94c6-430b-8b01-5a731c5a60ed", "DungeonCrawler@gmail.com", false, false, null, "DUNGEONCRAWLER@GMAIL.COM", "DUNGEONCRAWLER", "AQAAAAIAAYagAAAAECVvHUpZKjhrxMbAlkVaROj/VXklpQJ1xByLYUuZ+avCY5HaETJyN9evNuBr7Idqpw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9397f095-dd93-4616-a006-f8872f786a76", false, "DungeonCrawler" },
                    { "15111111-1111-1111-1111-111111111111", 0, "d97e35ff-299e-4821-b27d-8c300cf62390", "HighScore@gmail.com", false, false, null, "HIGHSCORE@GMAIL.COM", "HIGHSCORE", "AQAAAAIAAYagAAAAEPjl9tqWsMO8xhOei2kVT1jYf5kXutGD9b+RyRET3AGafyhA+J9w1Q/iYxweTuwFpQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a608a532-db3a-4245-82b2-d02d96eb26d5", false, "HighScore" },
                    { "16111111-1111-1111-1111-111111111111", 0, "2a178081-77d3-4cb9-80b3-01d70777aadc", "BossBattler@gmail.com", false, false, null, "BOSSBATTLER@GMAIL.COM", "BOSSBATTLER", "AQAAAAIAAYagAAAAENgKr/cP+TKDKBndziQnwI01mNHVxoGmPso8aRFK5ZuKjZPBPgy802oA2F1TAtP8fQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "444b459f-3ed8-4239-b512-5d46eb347bd1", false, "BossBattler" },
                    { "17111111-1111-1111-1111-111111111111", 0, "f9b5f77b-9f10-4359-954b-30d446a7d939", "SniperElite@gmail.com", false, false, null, "SNIPERELITE@GMAIL.COM", "SNIPERELITE", "AQAAAAIAAYagAAAAEOK14fhndZvu0vW4pzB3lcIjM0i+gStkIV7LlxdCrH01ZcgDxeqoegHpzBqqqpa8Hw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cb426534-aeea-44c7-9c9e-4b8e9d7c6398", false, "SniperElite" },
                    { "18111111-1111-1111-1111-111111111111", 0, "d034df47-4d00-428e-b904-74fb0325f979", "GameGuru@gmail.com", false, false, null, "GAMEGURU@GMAIL.COM", "GAMEGURU", "AQAAAAIAAYagAAAAEOcsPoEBkjzh3u6uFCs+EvVPOz9sWkNYE84hl72FTK5/7QY0T1hLPug0TBUGsjHQgQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0577cb09-840a-4751-99a7-07f99acf488a", false, "GameGuru" },
                    { "19111111-1111-1111-1111-111111111111", 0, "6806373d-b6ba-4d61-b24b-605555a2e641", "SpeedRunner@gmail.com", false, false, null, "SPEEDRUNNER@GMAIL.COM", "SPEEDRUNNER", "AQAAAAIAAYagAAAAEO3FfjbgA5+dr9e3tq8GOCwrk8oYWmNlylAS1thKgfUmjNM6wsvu2zL9cmPeJ9eqxA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c6b67be9-baa4-453d-ae89-8d0a799c1fb5", false, "SpeedRunner" },
                    { "21111111-1111-1111-1111-111111111111", 0, "cfa0594d-48b7-46fd-94b6-06a97c763e5f", "QuestHunter@gmail.com", false, false, null, "QUESTHUNTER@GMAIL.COM", "QUESTHUNTER", "AQAAAAIAAYagAAAAEO3giZ5DFHKkmsiZyPQ2XC75W3pVASf9nqmH21X4gYmLTEqmIj6xKziH3H1LPpcgmA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "572e0ff6-7b47-41d0-b13d-c8e56f2a8b87", false, "QuestHunter" },
                    { "22222222-2222-2222-2222-222222222222", 0, "0d316d7d-88cb-42ee-872b-4d8109bca236", "GameMaster@gmail.com", false, false, null, "GAMEMASTER@GMAIL.COM", "GAMEMASTER", "AQAAAAIAAYagAAAAEGDwMctckCcur7RFuv4yeOFlzmgdJFNc+VTyt/RNcfWBPoGsQsTqZinMPh6s5jFxYg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "65e6e9bb-94f0-4fea-929e-3106c49b027d", false, "GameMaster" },
                    { "31111111-1111-1111-1111-111111111111", 0, "35aa492e-933d-4697-afc2-7a5a7cbfc39c", "RetroGamer@gmail.com", false, false, null, "RETROGAMER@GMAIL.COM", "RETROGAMER", "AQAAAAIAAYagAAAAEPAsSmMWBMGZVJ0I5XlmtgWmAAskTJ6NMjlMSXy5lD6CwiYKVyb68xqjqXoTqfSdQQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "01132823-fbf6-4671-a720-33cc710243b6", false, "RetroGamer" },
                    { "33333333-3333-3333-3333-333333333333", 0, "bc45b47f-2918-44f1-a313-612c2aa8f139", "ProPlayer@gmail.com", false, false, null, "PROPLAYER@GMAIL.COM", "PROPLAYER", "AQAAAAIAAYagAAAAEMNRBFj59VNyLwf42uypOuBwxUUFarLt/nokY1hK1wq67nrjskqgHuMLsj496K8UxA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "981a2d6b-6f5a-433e-8e79-712b6f3ca9a5", false, "ProPlayer" },
                    { "41111111-1111-1111-1111-111111111111", 0, "c1195541-d637-4183-b543-27090533edd7", "ArcadeHero@gmail.com", false, false, null, "ARCADEHERO@GMAIL.COM", "ARCADEHERO", "AQAAAAIAAYagAAAAEOiTIWfnwOh8VSVK3zyeTaRoeOQX1w9VdWFhWHbdV+LI+Hlf8G+657Bq4rLjj1bJEw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f59b070e-0cc4-46cd-9763-abd16e64dbac", false, "ArcadeHero" },
                    { "44444444-4444-4444-4444-444444444444", 0, "3841c922-6578-4eef-b387-250ae5210b0d", "NinjaGamer@gmail.com", false, false, null, "NINJAGAMER@GMAIL.COM", "NINJAGAMER", "AQAAAAIAAYagAAAAEH0+aegRuWeV1z36OmPxn3kQuFDi4d6LZIikdaNgj8wgwJMIptSSBEpFHFpUHnYMag==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "49c346d1-b78b-4843-9d0a-3639f942a3b3", false, "NinjaGamer" },
                    { "51111111-1111-1111-1111-111111111111", 0, "7f399a9d-0649-418f-aadc-9020fb6f3493", "ConsoleChamp@gmail.com", false, false, null, "CONSOLECHAMP@GMAIL.COM", "CONSOLECHAMP", "AQAAAAIAAYagAAAAECXb9vtiinlsYjGtqgdUwc8Z6WZ683ar7LUGyqEpTUgvGDORBBngU0OIkuz2yjyKuQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "58ced55b-7266-414a-a614-e779ff1b76c4", false, "ConsoleChamp" },
                    { "55555555-5555-5555-5555-555555555555", 0, "f062d51e-f917-433d-b8fb-7e2bfae58a0c", "NoobSlayer@gmail.com", false, false, null, "NOOBSLAYER@GMAIL.COM", "NOOBSLAYER", "AQAAAAIAAYagAAAAENKeoITOuv4dldrma/NpYOTszIaWInboSuBllI2yXxNsdTbyfzrBHhfYpoSTdrLRSA==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "59acd55a-bc21-4382-9b76-32c87736e2a1", false, "NoobSlayer" },
                    { "61111111-1111-1111-1111-111111111111", 0, "589387b3-85fe-4116-a95f-df8ac55f68f0", "OnlineWarrior@gmail.com", false, false, null, "ONLINEWARRIOR@GMAIL.COM", "ONLINEWARRIOR", "AQAAAAIAAYagAAAAECTUY6FPtFJKkByugnJojnWLVO2w3z4V3EJjnitQKxq0vgNDBlzughmGzYVthIky4w==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6cd91411-b82a-4e26-aff1-00e2436c845f", false, "OnlineWarrior" },
                    { "66666666-6666-6666-6666-666666666666", 0, "544df8af-2e8d-4364-9c83-00b2cddc01e6", "EpicGamer@gmail.com", false, false, null, "EPICGAMER@GMAIL.COM", "EPICGAMER", "AQAAAAIAAYagAAAAEAV1PxglbXbqpSQIgKR8AT3tJgQlgnFiKzMrxMCcIvQRO37qaciy8Iy1RzHhC3I1CQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "519911e3-753b-4015-b079-eab8e5698de4", false, "EpicGamer" },
                    { "71111111-1111-1111-1111-111111111111", 0, "3f156def-f282-400f-b90d-6cb25a4b6528", "GamerGirl@gmail.com", false, false, null, "GAMERGIRL@GMAIL.COM", "GAMERGIRL", "AQAAAAIAAYagAAAAEBglBB5fcX54d4ErbHekY1/8ZqDvLhyNAbYIY+GWfKGFdXQKvc2LXf/YkuHhyZJA2w==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "910c46e5-ee64-455f-9daa-41ad67c0d60a", false, "GamerGirl" },
                    { "77777777-7777-7777-7777-777777777777", 0, "fe5d6c09-3964-41f5-b1db-19bdabdee179", "TheLegend27@gmail.com", false, false, null, "THELEGEND27@GMAIL.COM", "THELEGEND27", "AQAAAAIAAYagAAAAEB+hCw9FPrxxlMA+6gAZEsz8XB16HKC/SDGeM+mITnoLah041O175vZQ/jPlG2UlLQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "49263ca7-3bc4-4c4f-bf04-8d95b4d46b97", false, "TheLegend27" },
                    { "81111111-1111-1111-1111-111111111111", 0, "370c2e55-9e9e-4790-90bf-c9fe6ea8148c", "GameNerd@gmail.com", false, false, null, "GAMENERD@GMAIL.COM", "GAMENERD", "AQAAAAIAAYagAAAAEP/NkVv878NnyXxX18spE7wggs3sbl/TFvBhsWz77E2mZqDrctrSU7w8LHln/3KpTQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5c19aaca-3203-4e0f-a6e5-66ca46131c28", false, "GameNerd" },
                    { "88888888-8888-8888-8888-888888888888", 0, "5803b757-0c49-4861-9e9c-fd9a89767fa4", "GameAddict@gmail.com", false, false, null, "GAMEADDICT@GMAIL.COM", "GAMEADDICT", "AQAAAAIAAYagAAAAEP6RS7H49Bf4DvPmk+xdJA7QBTqJ0u58q3BjLvFWNFxeihhlpAwTLPmYMFlRmLAy+w==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "240d48c4-b9aa-471b-b747-e5689a458799", false, "GameAddict" },
                    { "91111111-1111-1111-1111-111111111111", 0, "fdbe180f-8f4f-424c-b53f-4c901092e3a9", "ZombieSlayer@gmail.com", false, false, null, "ZOMBIESLAYER@GMAIL.COM", "ZOMBIESLAYER", "AQAAAAIAAYagAAAAEMX/EXRG+GZcaxP6HBvRka9J4AkQC1EENHUM/gI5wpQVkmZ9K3KxxCm4Fh3S8LYing==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "edc40cf9-c410-4f66-9e20-dc7bf89d1138", false, "ZombieSlayer" },
                    { "99999999-9999-9999-9999-999999999999", 0, "4218c47c-2764-4e2a-ae8b-f4912b1aa2f0", "XxGamerxX@gmail.com", false, false, null, "XXGAMERXX@GMAIL.COM", "XXGAMERXX", "AQAAAAIAAYagAAAAEGV2xChHatc9rptc2cRqtHYM4IQ9hTm0fRTI26uZ6fk0bAm5+yw37qiRxZ33NMW1Bg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "84ca7909-90aa-4dc3-a970-0ac612cf165f", false, "XxGamerxX" },
                    { "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", 0, "1d2d436f-fb7f-414c-8035-06197bf7c331", "SwordMaster@gmail.com", false, false, null, "SWORDMASTER@GMAIL.COM", "SWORDMASTER", "AQAAAAIAAYagAAAAEPfAv7RkKwtP5pPkta99BDIgw6msRykUIgxoJYxgD7b/e4HxwGIQES/h9PF2CS6Pdw==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "f3b1327c-773d-42ff-ace3-c24809c5e897", false, "SwordMaster" },
                    { "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb", 0, "e4415c0d-3d90-448b-b213-781c87ae43c3", "PixelWarrior@gmail.com", false, false, null, "PIXELWARRIOR@GMAIL.COM", "PIXELWARRIOR", "AQAAAAIAAYagAAAAEMzbANiOUAjStBqKDcbQunRmTYscEQqdtki5a30wenksy60GAKljdkOg/8BLi8Cthg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "277d3602-ab02-423b-b1cd-1d1d27a34824", false, "PixelWarrior" },
                    { "cccccccc-cccc-cccc-cccc-cccccccccccc", 0, "41bd7167-71e0-43e5-baa6-d3238acdfad9", "GamingGeek@gmail.com", false, false, null, "GAMINGGEEK@GMAIL.COM", "GAMINGGEEK", "AQAAAAIAAYagAAAAEBVrfPJQQCmpS0RiDNXLn3RRftMQqOQRTAzX5MFWLPK0k8rd8mTLkCjpYIEjm+sn0A==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bf082f84-9b99-4b55-8840-e7889a663a2a", false, "GamingGeek" },
                    { "dddddddd-dddd-dddd-dddd-dddddddddddd", 0, "60e5ddfb-4a07-49b7-8fbe-e10d843dbf5d", "GameOn123@gmail.com", false, false, null, "GAMEON123@GMAIL.COM", "GAMEON123", "AQAAAAIAAYagAAAAEGZ/uuIzwYypB7JWS4MWtF59omK+11JLdQc/2dT2FaCcXg2188t/hq79UId2vM7SDg==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "37228f58-9340-4b23-9406-c80ecffda16a", false, "GameOn123" },
                    { "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee", 0, "38935d2d-3793-44a4-9423-256851b8f1c5", "FragMeister@gmail.com", false, false, null, "FRAGMEISTER@GMAIL.COM", "FRAGMEISTER", "AQAAAAIAAYagAAAAEK6r23mk+AWlWnwZejGOAYzmHM4+6DGAjR/22W6YxdUcTBkVXP63YG+2oLQYmHG4XQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caf07899-102a-49e0-aaeb-2aae7cd970b1", false, "FragMeister" },
                    { "ffffffff-ffff-ffff-ffff-ffffffffffff", 0, "14283a71-beed-410c-9069-042183e17a22", "DigitalWarrior@gmail.com", false, false, null, "DIGITALWARRIOR@GMAIL.COM", "DIGITALWARRIOR", "AQAAAAIAAYagAAAAEJ+70OHj9Jk/r7EeFYVREDcRaDfd+6Xfy0lw9FYEV4UmiOaymbGga+IjkejrqwlgIQ==", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bd64ecdf-6190-435c-b4cc-8d81f6a2f0a2", false, "DigitalWarrior" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "00000002-0000-0000-0000-000000000000" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11111111-1111-1211-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11112222-3333-4444-5555-666677778888" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11211111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11311111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11411111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11511111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "11611111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "12111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "13111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "14111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "15111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "16111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "17111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "18111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "19111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "21111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "22222222-2222-2222-2222-222222222222" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "31111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "33333333-3333-3333-3333-333333333333" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "41111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "44444444-4444-4444-4444-444444444444" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "51111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "55555555-5555-5555-5555-555555555555" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "61111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "66666666-6666-6666-6666-666666666666" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "71111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "77777777-7777-7777-7777-777777777777" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "81111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "88888888-8888-8888-8888-888888888888" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "91111111-1111-1111-1111-111111111111" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "99999999-9999-9999-9999-999999999999" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "cccccccc-cccc-cccc-cccc-cccccccccccc" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "dddddddd-dddd-dddd-dddd-dddddddddddd" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee" },
                    { "37cadf13-b04f-4467-94a3-34ede27d31cd", "ffffffff-ffff-ffff-ffff-ffffffffffff" }
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
        }
    }
}
