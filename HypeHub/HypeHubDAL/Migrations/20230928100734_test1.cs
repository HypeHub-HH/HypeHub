using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("1a100b2d-683a-4a5d-8f40-cb786640177e"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("881d1538-413a-446b-9b55-e8e1747797d3"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("9cb5f4bd-0848-40b6-9929-2bdcfebecef8"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("f7b0a696-8098-4ac7-95b4-77156d3a9181"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("741d3886-760a-44c3-b49a-42ac5cd7db35"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("7d8c4d82-6ee7-4905-af5c-8e24273d6873"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("a08a00c4-d1c3-4b21-b45d-5aa5248213f5"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("e3e08ea6-765b-4f29-a4ae-bf700535c978"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4e71fd23-407a-44ae-91a2-4c328a16ba4e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bad749f5-4192-477a-b312-e05c9a82c54d"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("4e770bfc-ed96-457a-9549-1e3d86400e73"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("e891bd20-713c-4014-b65c-e13575412a2d"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("ede8d858-168c-47ba-935f-8d943ad67481"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("fd649a4e-f751-42ba-b7fd-c033ff7bdd59"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("8a1ca283-5f79-4cf2-9301-f1ba2ecf1d1b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b38299b3-80e4-4433-aa4e-6d84075ebda8"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountTypes", "AvatarUrl", "IsPrivate", "Username" },
                values: new object[,]
                {
                    { new Guid("44dec59d-3839-4b89-88a2-1527775d450d"), "User", "https://example.com/avatar/user1.png", 0, "User1" },
                    { new Guid("733aefec-d039-4fa3-9af6-db6a57819622"), "User", null, 1, "User2" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("de93be8b-2ac5-4dd6-8ce1-e808a05429cc"), new Guid("44dec59d-3839-4b89-88a2-1527775d450d"), "User1@gmail.com", "hasłoMasło521" },
                    { new Guid("f82c1929-02ec-449e-b0d0-6667e6979139"), new Guid("733aefec-d039-4fa3-9af6-db6a57819622"), "User2@gmail.com", "hasłoMasło520" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AccountId", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("49ea5e99-81db-48ad-b5a7-4865788fffbb"), new Guid("44dec59d-3839-4b89-88a2-1527775d450d"), "Brand1", "Torso", "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 28, 10, 7, 34, 352, DateTimeKind.Utc).AddTicks(9568) },
                    { new Guid("7a925b34-9613-47aa-a108-db9cd4dd5384"), new Guid("733aefec-d039-4fa3-9af6-db6a57819622"), "Brand1", "Torso", "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 28, 10, 7, 34, 352, DateTimeKind.Utc).AddTicks(9603) }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "CreationDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3c0af110-3845-4d78-a9fb-97d0bcfaa44b"), new Guid("44dec59d-3839-4b89-88a2-1527775d450d"), new DateTime(2023, 9, 28, 12, 7, 34, 352, DateTimeKind.Local).AddTicks(9471), "Outfit642" },
                    { new Guid("d809216b-f731-4382-9e3a-e6970417e607"), new Guid("733aefec-d039-4fa3-9af6-db6a57819622"), new DateTime(2023, 9, 28, 12, 7, 34, 352, DateTimeKind.Local).AddTicks(9479), "Outfit450" },
                    { new Guid("d90447a1-23df-4da0-ac01-dba9687ab872"), new Guid("44dec59d-3839-4b89-88a2-1527775d450d"), new DateTime(2023, 9, 28, 12, 7, 34, 352, DateTimeKind.Local).AddTicks(9412), "Outfit224" },
                    { new Guid("f6713d77-8f71-4aa8-af65-9b05387a0aab"), new Guid("733aefec-d039-4fa3-9af6-db6a57819622"), new DateTime(2023, 9, 28, 12, 7, 34, 352, DateTimeKind.Local).AddTicks(9475), "Outfit899" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("6a466515-d1b7-4360-af69-56ae03a5384d"), new Guid("49ea5e99-81db-48ad-b5a7-4865788fffbb"), "exampleURL" },
                    { new Guid("73632c2e-9c35-45c3-998b-73a089ba195f"), new Guid("7a925b34-9613-47aa-a108-db9cd4dd5384"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("2ee0f829-7717-4f51-bfd3-e83212422e5d"), new Guid("3c0af110-3845-4d78-a9fb-97d0bcfaa44b"), "exampleURL" },
                    { new Guid("9ee7ee2f-0a0c-4ab3-92ed-bdd1c5dc3e56"), new Guid("d90447a1-23df-4da0-ac01-dba9687ab872"), "exampleURL" },
                    { new Guid("ac764d02-5879-4850-adfa-35b5b2789c31"), new Guid("d809216b-f731-4382-9e3a-e6970417e607"), "exampleURL" },
                    { new Guid("d9d510f5-f42e-4899-b9f7-297a0135c6fa"), new Guid("f6713d77-8f71-4aa8-af65-9b05387a0aab"), "exampleURL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("de93be8b-2ac5-4dd6-8ce1-e808a05429cc"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("f82c1929-02ec-449e-b0d0-6667e6979139"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6a466515-d1b7-4360-af69-56ae03a5384d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("73632c2e-9c35-45c3-998b-73a089ba195f"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("2ee0f829-7717-4f51-bfd3-e83212422e5d"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("9ee7ee2f-0a0c-4ab3-92ed-bdd1c5dc3e56"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("ac764d02-5879-4850-adfa-35b5b2789c31"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("d9d510f5-f42e-4899-b9f7-297a0135c6fa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("49ea5e99-81db-48ad-b5a7-4865788fffbb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7a925b34-9613-47aa-a108-db9cd4dd5384"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("3c0af110-3845-4d78-a9fb-97d0bcfaa44b"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("d809216b-f731-4382-9e3a-e6970417e607"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("d90447a1-23df-4da0-ac01-dba9687ab872"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("f6713d77-8f71-4aa8-af65-9b05387a0aab"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("44dec59d-3839-4b89-88a2-1527775d450d"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("733aefec-d039-4fa3-9af6-db6a57819622"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountTypes", "AvatarUrl", "IsPrivate", "Username" },
                values: new object[,]
                {
                    { new Guid("8a1ca283-5f79-4cf2-9301-f1ba2ecf1d1b"), "User", null, 1, "User2" },
                    { new Guid("b38299b3-80e4-4433-aa4e-6d84075ebda8"), "User", "https://example.com/avatar/user1.png", 0, "User1" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("1a100b2d-683a-4a5d-8f40-cb786640177e"), new Guid("8a1ca283-5f79-4cf2-9301-f1ba2ecf1d1b"), "User2@gmail.com", "hasłoMasło142" },
                    { new Guid("881d1538-413a-446b-9b55-e8e1747797d3"), new Guid("b38299b3-80e4-4433-aa4e-6d84075ebda8"), "User1@gmail.com", "hasłoMasło965" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AccountId", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("4e71fd23-407a-44ae-91a2-4c328a16ba4e"), new Guid("8a1ca283-5f79-4cf2-9301-f1ba2ecf1d1b"), "Brand1", "Head", "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 25, 11, 2, 21, 74, DateTimeKind.Utc).AddTicks(550) },
                    { new Guid("bad749f5-4192-477a-b312-e05c9a82c54d"), new Guid("b38299b3-80e4-4433-aa4e-6d84075ebda8"), "Brand1", "Head", "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 25, 11, 2, 21, 74, DateTimeKind.Utc).AddTicks(520) }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "CreationDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4e770bfc-ed96-457a-9549-1e3d86400e73"), new Guid("8a1ca283-5f79-4cf2-9301-f1ba2ecf1d1b"), new DateTime(2023, 9, 25, 13, 2, 21, 74, DateTimeKind.Local).AddTicks(430), "Outfit208" },
                    { new Guid("e891bd20-713c-4014-b65c-e13575412a2d"), new Guid("b38299b3-80e4-4433-aa4e-6d84075ebda8"), new DateTime(2023, 9, 25, 13, 2, 21, 74, DateTimeKind.Local).AddTicks(425), "Outfit883" },
                    { new Guid("ede8d858-168c-47ba-935f-8d943ad67481"), new Guid("8a1ca283-5f79-4cf2-9301-f1ba2ecf1d1b"), new DateTime(2023, 9, 25, 13, 2, 21, 74, DateTimeKind.Local).AddTicks(436), "Outfit836" },
                    { new Guid("fd649a4e-f751-42ba-b7fd-c033ff7bdd59"), new Guid("b38299b3-80e4-4433-aa4e-6d84075ebda8"), new DateTime(2023, 9, 25, 13, 2, 21, 74, DateTimeKind.Local).AddTicks(364), "Outfit454" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("9cb5f4bd-0848-40b6-9929-2bdcfebecef8"), new Guid("4e71fd23-407a-44ae-91a2-4c328a16ba4e"), "exampleURL" },
                    { new Guid("f7b0a696-8098-4ac7-95b4-77156d3a9181"), new Guid("bad749f5-4192-477a-b312-e05c9a82c54d"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("741d3886-760a-44c3-b49a-42ac5cd7db35"), new Guid("ede8d858-168c-47ba-935f-8d943ad67481"), "exampleURL" },
                    { new Guid("7d8c4d82-6ee7-4905-af5c-8e24273d6873"), new Guid("e891bd20-713c-4014-b65c-e13575412a2d"), "exampleURL" },
                    { new Guid("a08a00c4-d1c3-4b21-b45d-5aa5248213f5"), new Guid("4e770bfc-ed96-457a-9549-1e3d86400e73"), "exampleURL" },
                    { new Guid("e3e08ea6-765b-4f29-a4ae-bf700535c978"), new Guid("fd649a4e-f751-42ba-b7fd-c033ff7bdd59"), "exampleURL" }
                });
        }
    }
}
