using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations
{
    /// <inheritdoc />
    public partial class Configurators_created : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("2fb2c037-b784-49d8-a1c9-fcfa0e709e1b"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("f33eabfa-9eb9-4c5c-b62c-65e269240540"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b1ec3574-75a3-468e-839e-153e3bccf296"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("f9b070fd-c134-43c0-a8d9-2dc439213e9e"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("1707dd11-7a59-4868-9535-a72afc56ec6d"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("2990dbb8-0bfe-434b-8f77-c6d1b62b178a"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("9582f01d-ebf3-4a74-b778-bb14d899a6ab"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("b007172f-e8b8-45c4-a865-83967b5cff72"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("763ce401-ec6f-4aa0-826c-aca06be0d961"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("901596a2-fcd5-45fc-8000-a622a9344973"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("43d96434-d58f-4f1d-8e86-47d3a8e999ee"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("4964428f-9280-487b-90c8-43090827b7b2"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("5929c1ac-0eeb-4c13-b348-e5f394f34d0e"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("e7159096-4224-455b-b2c4-3cb307f72521"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d1f0397c-360c-47bd-9452-9ddbe3355101"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e62c9e73-3590-4ff0-bf2f-6daee0229552"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountTypes", "AvatarUrl", "IsPrivate", "Username" },
                values: new object[,]
                {
                    { new Guid("508b5c0b-3355-411f-90ab-d74d6213e484"), 0, null, true, "User2" },
                    { new Guid("ee27627c-0713-4c69-b312-0265cf6d1770"), 0, "https://example.com/avatar/user1.png", false, "User1" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("4dec7b04-9ad9-4302-ad38-90a65d47d2a9"), new Guid("ee27627c-0713-4c69-b312-0265cf6d1770"), "User1@gmail.com", "hasłoMasło304" },
                    { new Guid("bea029e5-9e1e-4f61-8040-7a3b4e54dc1d"), new Guid("508b5c0b-3355-411f-90ab-d74d6213e484"), "User2@gmail.com", "hasłoMasło459" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AccountId", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("98d5cde6-ce90-4ebb-b0f3-f393cc3a9633"), new Guid("ee27627c-0713-4c69-b312-0265cf6d1770"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 20, 53, 54, 348, DateTimeKind.Utc).AddTicks(1286) },
                    { new Guid("cd6992ba-96fa-426a-a971-64b1c964a99c"), new Guid("508b5c0b-3355-411f-90ab-d74d6213e484"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 20, 53, 54, 348, DateTimeKind.Utc).AddTicks(1321) }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "Name" },
                values: new object[,]
                {
                    { new Guid("18196aad-7e6f-4e23-9ec0-55fc91d4cb1c"), new Guid("ee27627c-0713-4c69-b312-0265cf6d1770"), "Outfit85" },
                    { new Guid("d1b84d29-f08d-4366-bcab-6f7771e215cf"), new Guid("508b5c0b-3355-411f-90ab-d74d6213e484"), "Outfit238" },
                    { new Guid("d556b333-20df-4b65-8a04-33d44316258d"), new Guid("508b5c0b-3355-411f-90ab-d74d6213e484"), "Outfit846" },
                    { new Guid("d73ae1de-89ca-4b4d-b210-43b841ecb88f"), new Guid("ee27627c-0713-4c69-b312-0265cf6d1770"), "Outfit41" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("522dc7f2-1159-4788-b0a3-db6f5efd9e34"), new Guid("98d5cde6-ce90-4ebb-b0f3-f393cc3a9633"), "exampleURL" },
                    { new Guid("52423c03-87f5-4b4b-8cdd-e77461e517a8"), new Guid("cd6992ba-96fa-426a-a971-64b1c964a99c"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("1620e0ed-55db-4fdb-8317-9790b6aca495"), new Guid("d556b333-20df-4b65-8a04-33d44316258d"), "exampleURL" },
                    { new Guid("68f0394d-22ac-4bb7-a16a-672f42c5baed"), new Guid("18196aad-7e6f-4e23-9ec0-55fc91d4cb1c"), "exampleURL" },
                    { new Guid("96db27c7-dbb5-4525-833e-af21a521ca86"), new Guid("d73ae1de-89ca-4b4d-b210-43b841ecb88f"), "exampleURL" },
                    { new Guid("9ad6c227-c151-4467-9760-08dbd691d1ee"), new Guid("d1b84d29-f08d-4366-bcab-6f7771e215cf"), "exampleURL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("4dec7b04-9ad9-4302-ad38-90a65d47d2a9"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("bea029e5-9e1e-4f61-8040-7a3b4e54dc1d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("522dc7f2-1159-4788-b0a3-db6f5efd9e34"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("52423c03-87f5-4b4b-8cdd-e77461e517a8"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("1620e0ed-55db-4fdb-8317-9790b6aca495"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("68f0394d-22ac-4bb7-a16a-672f42c5baed"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("96db27c7-dbb5-4525-833e-af21a521ca86"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("9ad6c227-c151-4467-9760-08dbd691d1ee"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("98d5cde6-ce90-4ebb-b0f3-f393cc3a9633"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cd6992ba-96fa-426a-a971-64b1c964a99c"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("18196aad-7e6f-4e23-9ec0-55fc91d4cb1c"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("d1b84d29-f08d-4366-bcab-6f7771e215cf"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("d556b333-20df-4b65-8a04-33d44316258d"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("d73ae1de-89ca-4b4d-b210-43b841ecb88f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("508b5c0b-3355-411f-90ab-d74d6213e484"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ee27627c-0713-4c69-b312-0265cf6d1770"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountTypes", "AvatarUrl", "IsPrivate", "Username" },
                values: new object[,]
                {
                    { new Guid("d1f0397c-360c-47bd-9452-9ddbe3355101"), 0, "https://example.com/avatar/user1.png", false, "User1" },
                    { new Guid("e62c9e73-3590-4ff0-bf2f-6daee0229552"), 0, null, true, "User2" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("2fb2c037-b784-49d8-a1c9-fcfa0e709e1b"), new Guid("d1f0397c-360c-47bd-9452-9ddbe3355101"), "User1@gmail.com", "hasłoMasło188" },
                    { new Guid("f33eabfa-9eb9-4c5c-b62c-65e269240540"), new Guid("e62c9e73-3590-4ff0-bf2f-6daee0229552"), "User2@gmail.com", "hasłoMasło591" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "AccountId", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { new Guid("763ce401-ec6f-4aa0-826c-aca06be0d961"), new Guid("d1f0397c-360c-47bd-9452-9ddbe3355101"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 17, 54, 31, 888, DateTimeKind.Utc).AddTicks(2035) },
                    { new Guid("901596a2-fcd5-45fc-8000-a622a9344973"), new Guid("e62c9e73-3590-4ff0-bf2f-6daee0229552"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 13, 17, 54, 31, 888, DateTimeKind.Utc).AddTicks(2065) }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "Name" },
                values: new object[,]
                {
                    { new Guid("43d96434-d58f-4f1d-8e86-47d3a8e999ee"), new Guid("e62c9e73-3590-4ff0-bf2f-6daee0229552"), "Outfit727" },
                    { new Guid("4964428f-9280-487b-90c8-43090827b7b2"), new Guid("d1f0397c-360c-47bd-9452-9ddbe3355101"), "Outfit960" },
                    { new Guid("5929c1ac-0eeb-4c13-b348-e5f394f34d0e"), new Guid("e62c9e73-3590-4ff0-bf2f-6daee0229552"), "Outfit735" },
                    { new Guid("e7159096-4224-455b-b2c4-3cb307f72521"), new Guid("d1f0397c-360c-47bd-9452-9ddbe3355101"), "Outfit352" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("b1ec3574-75a3-468e-839e-153e3bccf296"), new Guid("901596a2-fcd5-45fc-8000-a622a9344973"), "exampleURL" },
                    { new Guid("f9b070fd-c134-43c0-a8d9-2dc439213e9e"), new Guid("763ce401-ec6f-4aa0-826c-aca06be0d961"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("1707dd11-7a59-4868-9535-a72afc56ec6d"), new Guid("5929c1ac-0eeb-4c13-b348-e5f394f34d0e"), "exampleURL" },
                    { new Guid("2990dbb8-0bfe-434b-8f77-c6d1b62b178a"), new Guid("43d96434-d58f-4f1d-8e86-47d3a8e999ee"), "exampleURL" },
                    { new Guid("9582f01d-ebf3-4a74-b778-bb14d899a6ab"), new Guid("e7159096-4224-455b-b2c4-3cb307f72521"), "exampleURL" },
                    { new Guid("b007172f-e8b8-45c4-a865-83967b5cff72"), new Guid("4964428f-9280-487b-90c8-43090827b7b2"), "exampleURL" }
                });
        }
    }
}
