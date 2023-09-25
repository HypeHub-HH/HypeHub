using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations
{
    /// <inheritdoc />
    public partial class configurations_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Outfits",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Outfits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Items",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Colorway",
                table: "Items",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CloathingType",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Items",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Accounts",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "IsPrivate",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Accounts",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountTypes",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountCredentials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AccountCredentials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Username",
                table: "Accounts",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountCredentials_Email",
                table: "AccountCredentials",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Accounts_Username",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_AccountCredentials_Email",
                table: "AccountCredentials");

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

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Outfits");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Outfits",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Colorway",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CloathingType",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<bool>(
                name: "IsPrivate",
                table: "Accounts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AvatarUrl",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccountTypes",
                table: "Accounts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountCredentials",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AccountCredentials",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

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
    }
}
