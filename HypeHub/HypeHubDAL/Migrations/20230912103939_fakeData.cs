using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HypeHubDAL.Migrations
{
    /// <inheritdoc />
    public partial class fakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountTypes", "AvatarUrl", "IsPrivate", "Username" },
                values: new object[,]
                {
                    { new Guid("1ba36070-5292-4128-ad11-676a1bfaf1a5"), 0, "https://example.com/avatar/user11.png", false, "User11" },
                    { new Guid("1d3556f0-a0cc-4e3e-a984-91cfe9003c38"), 0, "https://example.com/avatar/user7.png", false, "User7" },
                    { new Guid("344fdef8-c7ff-4359-90f2-3279b842da28"), 0, null, true, "User2" },
                    { new Guid("351df3f3-970f-4909-a440-2912235dc19b"), 0, "https://example.com/avatar/user9.png", false, "User9" },
                    { new Guid("48a75a21-6e7e-4e55-bc58-df7a9b3d37a5"), 0, null, true, "User18" },
                    { new Guid("4f1835d3-fdd3-4192-a077-c6eaf9d5c607"), 0, null, true, "User6" },
                    { new Guid("5c21c61b-e96f-472d-8f6b-8f967cbd3513"), 0, "https://example.com/avatar/user3.png", false, "User3" },
                    { new Guid("6253e315-9e1d-48b8-af0e-7c68f0b00fe5"), 0, null, true, "User10" },
                    { new Guid("6440c4a0-b31f-4ac0-9b79-80b09ae4b201"), 0, "https://example.com/avatar/user15.png", false, "User15" },
                    { new Guid("687d7b0d-4c6d-4d7d-8fd5-0b26a82d1655"), 0, "https://example.com/avatar/user1.png", false, "User1" },
                    { new Guid("6bdc83a0-31b4-48ff-acd6-fb2aedaeda39"), 0, "https://example.com/avatar/user5.png", false, "User5" },
                    { new Guid("6e4d406a-0e6b-4424-9a93-0a3921614e33"), 0, null, true, "User12" },
                    { new Guid("79513aeb-462e-4ec4-801e-6d5e0cd91efc"), 0, null, true, "User14" },
                    { new Guid("a6ebc502-f6a2-47bb-ae2b-6cad0905c7d7"), 0, "https://example.com/avatar/user19.png", false, "User19" },
                    { new Guid("af8e17fb-4d03-49ac-889e-1286e5c8a280"), 0, "https://example.com/avatar/user13.png", false, "User13" },
                    { new Guid("b92595c1-a5c0-48ca-ac51-01a127b5945f"), 0, null, true, "User8" },
                    { new Guid("b96bc4f0-75c6-44bc-992a-2a12fff04fa9"), 0, "https://example.com/avatar/user17.png", false, "User17" },
                    { new Guid("c19bcb1a-a830-44b5-bad9-4b0a1cfd2e69"), 0, null, true, "User16" },
                    { new Guid("cecfc43c-5532-4f69-be1a-9cbe69e0697b"), 0, null, true, "User20" },
                    { new Guid("d0741908-1af4-4805-ab60-e049eec48cc0"), 0, null, true, "User4" }
                });

            migrationBuilder.InsertData(
                table: "AccountCredentials",
                columns: new[] { "Id", "AccountId", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("155fa1ae-0b53-45d0-adc9-9f3d8e6e24da"), new Guid("af8e17fb-4d03-49ac-889e-1286e5c8a280"), "User13@gmail.com", "hasłoMasło600" },
                    { new Guid("27f85bfe-c39f-4da3-925d-55f7d6e5c6ca"), new Guid("6440c4a0-b31f-4ac0-9b79-80b09ae4b201"), "User15@gmail.com", "hasłoMasło717" },
                    { new Guid("295cc5ac-9ded-499d-a207-91286f27f9bb"), new Guid("1d3556f0-a0cc-4e3e-a984-91cfe9003c38"), "User7@gmail.com", "hasłoMasło572" },
                    { new Guid("301631fb-ad8f-4eb2-9034-4eb2ce197128"), new Guid("c19bcb1a-a830-44b5-bad9-4b0a1cfd2e69"), "User16@gmail.com", "hasłoMasło766" },
                    { new Guid("3ba331f5-fe28-43f0-b626-e21f8f4816f2"), new Guid("79513aeb-462e-4ec4-801e-6d5e0cd91efc"), "User14@gmail.com", "hasłoMasło135" },
                    { new Guid("52729316-80a5-4420-85be-d56f4e307987"), new Guid("687d7b0d-4c6d-4d7d-8fd5-0b26a82d1655"), "User1@gmail.com", "hasłoMasło414" },
                    { new Guid("59d2fc89-6d2a-4b82-9542-90e31e360779"), new Guid("d0741908-1af4-4805-ab60-e049eec48cc0"), "User4@gmail.com", "hasłoMasło483" },
                    { new Guid("5c029ddf-e980-4aaf-a281-28d30a1bc077"), new Guid("b96bc4f0-75c6-44bc-992a-2a12fff04fa9"), "User17@gmail.com", "hasłoMasło749" },
                    { new Guid("6dca929a-3583-4a9f-86fa-86ff044773c0"), new Guid("5c21c61b-e96f-472d-8f6b-8f967cbd3513"), "User3@gmail.com", "hasłoMasło630" },
                    { new Guid("769ab22f-56bb-4409-8835-d06a2999faf5"), new Guid("351df3f3-970f-4909-a440-2912235dc19b"), "User9@gmail.com", "hasłoMasło574" },
                    { new Guid("7ae5847a-3fc0-4a8e-bf67-f6f0557fae1f"), new Guid("344fdef8-c7ff-4359-90f2-3279b842da28"), "User2@gmail.com", "hasłoMasło463" },
                    { new Guid("9479a6d7-d17c-448a-9f79-c331e34457b0"), new Guid("6bdc83a0-31b4-48ff-acd6-fb2aedaeda39"), "User5@gmail.com", "hasłoMasło275" },
                    { new Guid("9850a93b-4490-4c11-a16e-00208fd0b8ce"), new Guid("cecfc43c-5532-4f69-be1a-9cbe69e0697b"), "User20@gmail.com", "hasłoMasło358" },
                    { new Guid("a96d2a19-4773-440b-b29e-2e80425a4d68"), new Guid("48a75a21-6e7e-4e55-bc58-df7a9b3d37a5"), "User18@gmail.com", "hasłoMasło91" },
                    { new Guid("af1f005e-3b2e-4967-bb68-ffab9170e583"), new Guid("b92595c1-a5c0-48ca-ac51-01a127b5945f"), "User8@gmail.com", "hasłoMasło854" },
                    { new Guid("c80269cd-ee0b-46cf-aa87-892dba1f00f2"), new Guid("1ba36070-5292-4128-ad11-676a1bfaf1a5"), "User11@gmail.com", "hasłoMasło93" },
                    { new Guid("d8f53baa-a9f9-452e-8308-ef23c41dcdf8"), new Guid("6e4d406a-0e6b-4424-9a93-0a3921614e33"), "User12@gmail.com", "hasłoMasło839" },
                    { new Guid("ed76c882-6ca7-4753-8554-f0e467d2226e"), new Guid("6253e315-9e1d-48b8-af0e-7c68f0b00fe5"), "User10@gmail.com", "hasłoMasło101" },
                    { new Guid("f4f3bd1e-6c9a-4d6f-8c07-70dc94083d3d"), new Guid("4f1835d3-fdd3-4192-a077-c6eaf9d5c607"), "User6@gmail.com", "hasłoMasło685" },
                    { new Guid("f9efc636-71fe-4a2a-8476-da2bb9028088"), new Guid("a6ebc502-f6a2-47bb-ae2b-6cad0905c7d7"), "User19@gmail.com", "hasłoMasło662" }
                });

            migrationBuilder.InsertData(
                table: "Outfits",
                columns: new[] { "Id", "AccountId", "Name" },
                values: new object[,]
                {
                    { new Guid("05360092-92d3-4c8c-af00-e81ef12ba4ec"), new Guid("79513aeb-462e-4ec4-801e-6d5e0cd91efc"), "Outfit446" },
                    { new Guid("0a8a81d7-114e-4b21-857b-93acf6afb949"), new Guid("4f1835d3-fdd3-4192-a077-c6eaf9d5c607"), "Outfit414" },
                    { new Guid("0c1cd940-3258-4fe4-9b0b-32b768b5f048"), new Guid("48a75a21-6e7e-4e55-bc58-df7a9b3d37a5"), "Outfit744" },
                    { new Guid("12540349-521d-41f5-b31c-ed6cc32570c3"), new Guid("af8e17fb-4d03-49ac-889e-1286e5c8a280"), "Outfit561" },
                    { new Guid("12fcdb71-d091-4ae8-9128-5693a371f0af"), new Guid("351df3f3-970f-4909-a440-2912235dc19b"), "Outfit136" },
                    { new Guid("1eb089c4-76fa-43dd-9a99-4d5fabb9598a"), new Guid("344fdef8-c7ff-4359-90f2-3279b842da28"), "Outfit811" },
                    { new Guid("2128b55f-dd9b-4ba4-905c-f7994f5b42d2"), new Guid("a6ebc502-f6a2-47bb-ae2b-6cad0905c7d7"), "Outfit958" },
                    { new Guid("25d17622-3ff0-4fea-b609-672bf1bef46e"), new Guid("6253e315-9e1d-48b8-af0e-7c68f0b00fe5"), "Outfit558" },
                    { new Guid("2f6dbdcc-c1bf-482e-86df-81fa69b70e20"), new Guid("4f1835d3-fdd3-4192-a077-c6eaf9d5c607"), "Outfit107" },
                    { new Guid("3d3a94bf-76f4-461a-ab60-194942fc7a71"), new Guid("b92595c1-a5c0-48ca-ac51-01a127b5945f"), "Outfit610" },
                    { new Guid("543941b2-329d-44cc-a53d-5734f82e6971"), new Guid("6253e315-9e1d-48b8-af0e-7c68f0b00fe5"), "Outfit875" },
                    { new Guid("55f813ca-616d-4547-9b4a-7d753d373579"), new Guid("1d3556f0-a0cc-4e3e-a984-91cfe9003c38"), "Outfit683" },
                    { new Guid("57493cc6-b145-4905-8031-f687ebe028e3"), new Guid("a6ebc502-f6a2-47bb-ae2b-6cad0905c7d7"), "Outfit65" },
                    { new Guid("58e198f5-395e-4eba-89b0-dd5fc9d78cab"), new Guid("cecfc43c-5532-4f69-be1a-9cbe69e0697b"), "Outfit438" },
                    { new Guid("60cb7a4d-e26d-48f9-8aa2-fb0c1cd3e57f"), new Guid("5c21c61b-e96f-472d-8f6b-8f967cbd3513"), "Outfit165" },
                    { new Guid("87b8f4c5-5f63-445c-870e-9bc2acf34391"), new Guid("b96bc4f0-75c6-44bc-992a-2a12fff04fa9"), "Outfit541" },
                    { new Guid("8e33c9ef-e92e-4907-8f86-36448a2a4b34"), new Guid("c19bcb1a-a830-44b5-bad9-4b0a1cfd2e69"), "Outfit523" },
                    { new Guid("92c4309d-4d7f-4643-89fa-7e1524c92b98"), new Guid("b92595c1-a5c0-48ca-ac51-01a127b5945f"), "Outfit699" },
                    { new Guid("971ae71b-73f6-450c-b8cf-f16f7a393211"), new Guid("cecfc43c-5532-4f69-be1a-9cbe69e0697b"), "Outfit480" },
                    { new Guid("99a1b56d-da00-4612-bf5b-ca3834e1d569"), new Guid("1ba36070-5292-4128-ad11-676a1bfaf1a5"), "Outfit326" },
                    { new Guid("9a60abdf-f023-4636-88ff-4b54248b4f20"), new Guid("b96bc4f0-75c6-44bc-992a-2a12fff04fa9"), "Outfit349" },
                    { new Guid("9c9a0760-30f0-431e-86b4-ede9e1e44855"), new Guid("344fdef8-c7ff-4359-90f2-3279b842da28"), "Outfit47" },
                    { new Guid("a5d14959-b4f6-487a-b187-45fa39352088"), new Guid("5c21c61b-e96f-472d-8f6b-8f967cbd3513"), "Outfit58" },
                    { new Guid("a7d8c1d7-73fa-4061-8ca0-9d249aefa53b"), new Guid("1d3556f0-a0cc-4e3e-a984-91cfe9003c38"), "Outfit289" },
                    { new Guid("acf32c5a-3a1b-482a-8d8d-faefe6fbed9b"), new Guid("d0741908-1af4-4805-ab60-e049eec48cc0"), "Outfit27" },
                    { new Guid("b195beef-0e6f-4f40-a4d5-2a3e599a1267"), new Guid("6440c4a0-b31f-4ac0-9b79-80b09ae4b201"), "Outfit695" },
                    { new Guid("b30af038-0408-4957-92ad-f6f30b184970"), new Guid("6e4d406a-0e6b-4424-9a93-0a3921614e33"), "Outfit447" },
                    { new Guid("b858c402-4e09-4240-b900-0b3adf001316"), new Guid("c19bcb1a-a830-44b5-bad9-4b0a1cfd2e69"), "Outfit898" },
                    { new Guid("b898165c-6560-43a0-a301-d861078aac86"), new Guid("79513aeb-462e-4ec4-801e-6d5e0cd91efc"), "Outfit649" },
                    { new Guid("bb2cb682-30ac-4a39-a6da-f43940456dd4"), new Guid("6bdc83a0-31b4-48ff-acd6-fb2aedaeda39"), "Outfit100" },
                    { new Guid("c4c92877-79c4-410d-9a3f-54d5ee9c2c48"), new Guid("6bdc83a0-31b4-48ff-acd6-fb2aedaeda39"), "Outfit344" },
                    { new Guid("c859fb4a-d8e1-4de0-b8bb-0a0feddbd178"), new Guid("6e4d406a-0e6b-4424-9a93-0a3921614e33"), "Outfit616" },
                    { new Guid("c9509c8d-564f-4f98-84b4-6e57fe8de2ac"), new Guid("687d7b0d-4c6d-4d7d-8fd5-0b26a82d1655"), "Outfit272" },
                    { new Guid("ccd494df-bdff-485c-bff5-357d954d1ece"), new Guid("48a75a21-6e7e-4e55-bc58-df7a9b3d37a5"), "Outfit465" },
                    { new Guid("db79cd1e-94ca-40ba-a62b-c00d2841ab77"), new Guid("6440c4a0-b31f-4ac0-9b79-80b09ae4b201"), "Outfit4" },
                    { new Guid("e1f6b8f7-7322-43e5-b091-da0924ad7fb0"), new Guid("d0741908-1af4-4805-ab60-e049eec48cc0"), "Outfit717" },
                    { new Guid("e6d63fad-e5b7-4fb2-8c8b-3d25dfa20ac7"), new Guid("687d7b0d-4c6d-4d7d-8fd5-0b26a82d1655"), "Outfit490" },
                    { new Guid("e807a2fc-b75a-45d1-96a2-10e7384edb23"), new Guid("af8e17fb-4d03-49ac-889e-1286e5c8a280"), "Outfit252" },
                    { new Guid("ea1fcd92-0600-4307-a0f0-046ae1df9ba2"), new Guid("1ba36070-5292-4128-ad11-676a1bfaf1a5"), "Outfit213" },
                    { new Guid("ee2358b2-fced-426e-9975-7b697808400a"), new Guid("351df3f3-970f-4909-a440-2912235dc19b"), "Outfit430" }
                });

            migrationBuilder.InsertData(
                table: "Wardrobes",
                columns: new[] { "Id", "AccountId" },
                values: new object[,]
                {
                    { new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6"), new Guid("6e4d406a-0e6b-4424-9a93-0a3921614e33") },
                    { new Guid("14c9d812-b906-4de8-9b5b-844815174fd2"), new Guid("cecfc43c-5532-4f69-be1a-9cbe69e0697b") },
                    { new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a"), new Guid("6bdc83a0-31b4-48ff-acd6-fb2aedaeda39") },
                    { new Guid("36455683-5660-422a-bfd9-6d9f3502713c"), new Guid("4f1835d3-fdd3-4192-a077-c6eaf9d5c607") },
                    { new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f"), new Guid("6253e315-9e1d-48b8-af0e-7c68f0b00fe5") },
                    { new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6"), new Guid("351df3f3-970f-4909-a440-2912235dc19b") },
                    { new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c"), new Guid("79513aeb-462e-4ec4-801e-6d5e0cd91efc") },
                    { new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822"), new Guid("c19bcb1a-a830-44b5-bad9-4b0a1cfd2e69") },
                    { new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7"), new Guid("1d3556f0-a0cc-4e3e-a984-91cfe9003c38") },
                    { new Guid("799439b3-5855-4178-b870-69d2f930cb2e"), new Guid("344fdef8-c7ff-4359-90f2-3279b842da28") },
                    { new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc"), new Guid("687d7b0d-4c6d-4d7d-8fd5-0b26a82d1655") },
                    { new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b"), new Guid("6440c4a0-b31f-4ac0-9b79-80b09ae4b201") },
                    { new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57"), new Guid("af8e17fb-4d03-49ac-889e-1286e5c8a280") },
                    { new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1"), new Guid("a6ebc502-f6a2-47bb-ae2b-6cad0905c7d7") },
                    { new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d"), new Guid("48a75a21-6e7e-4e55-bc58-df7a9b3d37a5") },
                    { new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47"), new Guid("b92595c1-a5c0-48ca-ac51-01a127b5945f") },
                    { new Guid("c7de371c-fc32-4649-9435-459d2ca87b57"), new Guid("d0741908-1af4-4805-ab60-e049eec48cc0") },
                    { new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d"), new Guid("1ba36070-5292-4128-ad11-676a1bfaf1a5") },
                    { new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1"), new Guid("5c21c61b-e96f-472d-8f6b-8f967cbd3513") },
                    { new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e"), new Guid("b96bc4f0-75c6-44bc-992a-2a12fff04fa9") }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Brand", "CloathingType", "Colorway", "Model", "Name", "Price", "PurchaseDate", "WardrobeId" },
                values: new object[,]
                {
                    { new Guid("00778d03-a5d3-4dc1-9c15-494d7a2f6168"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2046), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("02a688aa-87a3-4936-961a-0f9300ebb8d1"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3677), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("03c5dbb8-de31-4996-b456-5d540580ae0f"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2779), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("03cf4d47-e8e4-40ac-b968-d0ebbc054b14"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2254), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("054d5e58-6d26-40ed-818e-fb6b0b68768f"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3890), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("05f4c23e-6f3e-47d9-a6e3-c75dc9436298"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4169), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("07c7d000-d2fd-4955-908b-e4bee93a4d36"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2381), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("0b169ecc-c733-44f5-815d-cb89468bab7e"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2441), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("0b803689-2aec-40c8-af8f-c49d6b5aa76f"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1968), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("0c476002-2366-43d6-8f03-c2fe2c094c08"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2768), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("0debaa72-63ff-4c8f-9d7a-994b027604e4"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2405), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("0e08b8f2-c013-468c-ac31-e24d1ccc0460"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4444), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("0eaeb816-97cb-4f63-92a6-6e77ffe2aa6d"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3189), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("11fb547c-6e10-4940-b212-a5910858b7ac"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2948), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("1264461d-9b05-4193-b60d-b02b790126ed"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4551), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("12bef15f-6710-4600-9aa6-6e85ec3d390a"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3521), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("156b1fc2-3a71-4b96-bc30-294939143319"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1933), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("187b4ead-57ba-4beb-8eec-877b288e7c07"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3761), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("1b60de2f-7716-4ae2-bb0c-e476947f90f1"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3237), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("1bfe6338-dc16-4678-a7b7-8bd09bba9e6a"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3069), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("1d07a254-a01c-457a-811c-1540bba98fbf"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2707), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("1db9591e-337f-4472-ada4-36375d08fe70"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3582), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("1e6ea9d5-c9fa-40d9-a70f-de4ed5921ffc"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1862), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("222d35c8-5507-4b79-a4b7-c6b1e5e824b8"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2106), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("241420bc-070b-438f-9340-a244ca068862"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2502), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("2468ef9c-8a35-4bc5-882b-4d14acf95613"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2876), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("24aaffd1-4753-4275-9810-9dcf81367fa6"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2791), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("26f7d4a1-10d2-498c-8f67-4ba2222cde7e"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3642), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("28a0297b-4c90-4a8b-8908-03a9dd29252d"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3330), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("29b7abe0-91d4-473f-87a4-e7eee3da1aee"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1784), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("2bae35e8-ca96-4d13-a9cb-1f48b15843a9"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3163), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("2c991a76-d5cb-4fa7-a274-74cd25ca8590"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2647), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("2ce7ed07-bea3-4f77-9465-48a2d61927a0"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4059), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("2d863096-f7be-43aa-868a-847e7f33b05a"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4094), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("2da1b8c4-d35d-413c-a48a-781b41bfb464"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2573), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("30ed66d3-616b-47c9-9757-67f448e1c3f3"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2973), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("34690257-a3b5-4af2-aca4-726f382d5277"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1886), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("35015e89-e81c-477f-b995-bd458287b4a3"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2804), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("3567103a-2ae1-4985-957a-b6a3fc2a08b2"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3045), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("3c472af2-537d-4d45-97cf-2207ecc64b86"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3830), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("3ca19678-2df0-4317-8ed0-10ca31c879d6"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3140), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("3d732b2e-ba2f-4ff9-b65a-21ea0fec042a"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2696), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("3d958d0b-4364-4ab0-b87b-0188c083ab3a"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2216), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("3ed71070-5842-4eb4-8d9f-0a7f9ae7873a"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2538), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("3fbd628c-13a8-4ada-a6f0-3d74fee87d5e"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4312), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("4020e2a0-063f-4c31-b259-4921f8648a10"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3223), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("40633568-2094-4b04-b80b-783e11f5bfcc"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2526), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("409f793a-0529-4a5e-aa53-8f1d88958472"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2838), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("41e1217d-1d86-479b-89c7-9d909de52c8d"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2230), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("42ead622-959d-47d0-bf34-0d5eb11eb35f"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4131), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("44ec7960-018f-4271-bcd7-0cf59bfe30b9"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3786), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("45bcdd43-1462-40d7-9901-4724b04ed448"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3009), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("46d70f34-5f16-4399-b07f-0eea067a55f6"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1922), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("4b91589a-5041-4e62-979e-ddc395aa0df7"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3402), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("4bb04e80-489e-4783-8ce9-7ab34faf3b4b"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4419), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("4c43fc8b-d98b-48db-939c-379b2069aab8"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2515), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("4cb397c8-db37-4463-9707-12a44018e66f"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1835), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("4cbaceb8-1883-440b-a860-2b4d6a9de99f"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3056), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("4e845077-5330-43c6-aea0-2080f79da76b"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2658), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("4f09ad04-515d-4d2c-a70e-254f2bd20bd6"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4108), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("4fd2a202-51f8-4d15-8e8b-1ae38b7a3221"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2477), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("5095c7c3-aa87-404a-ae25-f364ad170aba"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4263), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("519c1ee5-aa98-480a-9bb4-b99a99149dd4"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2466), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("5475c6e7-1886-4e96-886e-cb7f47a662ac"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4143), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("547e0856-8ee8-4839-afce-12f698ca79d1"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2279), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("54895ee0-3209-49f9-a92f-ba1b1b60fda9"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1734), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("54c7e887-a565-40e4-b155-01c1d1e35ce0"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2009), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("55f1a543-ce91-4a5e-8676-60ab1b275a5b"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4046), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("55fc0a2b-8cf8-497b-847d-8af5e5030cb8"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2180), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("5699be17-9aa4-462f-b777-ed21f42559bf"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2610), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("5857adb4-a109-4d85-b9bf-fe8bce9a9b90"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4180), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("585e6ce6-f69c-454c-894b-36909a4ebcd0"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4119), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("59143f1d-bfee-4eac-a84f-e1f24bd0ab93"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4071), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("5bea49a8-b860-4d29-8006-eb61e77fdb32"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3556), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("5cdd0a7b-f59c-4afc-854e-9bd187c62b0d"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4479), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("5d17f433-2975-4057-8785-5c4a77f7f578"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2985), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("5fc0d7e3-68af-412a-b1e0-9b1b1b93cafa"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3212), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("5ff8eaea-b219-40fc-b0c4-60dbbc5397e9"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1747), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("6226a895-72b6-43fd-a6f1-6de0ad421d37"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3901), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("634c877f-2ae5-48a6-814b-ec1cca7bf2a0"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4034), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("64cbb93d-531e-47a9-8bd2-7b84e99fa123"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2193), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("65f52df2-0ce3-4d02-a16b-4e1436fd2cd4"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1811), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("65ffad7d-ad69-4896-9aae-f25a91d0cefb"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2936), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("688c6c39-4fbf-490f-9b74-781507d85a56"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3366), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("6a3ad84b-2366-43bd-a488-7f17d02bdd7c"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2083), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("6b27df34-68e4-4c6c-9ce5-f28fe0787e0a"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4251), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("6cff8c5a-52ca-437f-9b1b-a8af3ed6ac18"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4240), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("6e60eaa4-9cb0-45ae-b6ed-39f2c6b75b92"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4300), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("6f13f4e9-7afa-43a1-9f3f-6c9496f7da62"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3926), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("71d3db00-b792-4541-a055-292fff17772d"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2242), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("72aab350-aedb-4a47-82da-6d649bdd9cae"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3772), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("7480bd0f-6992-4294-b125-194df06aaa43"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3545), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("74cedc61-d87d-48a5-b696-2f2e93d6650e"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2598), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("75155e46-314b-4551-9d14-8d08496dc04d"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3486), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("757abbb1-2cad-43e8-a9bb-7ed9c2ea48a0"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3628), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("76347fb3-1605-4427-9c6b-dbd046b7ae4e"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2815), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("76e163ed-dc5d-42f5-9dc2-7df1bdff157a"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3127), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("7d2573f2-c4e7-48ae-9728-7e2ea5f9aab5"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2489), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("7e8903f0-42c1-4b2c-bca0-715e7f6161f2"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3389), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("7ee8f37e-844b-4a3e-ace7-283fbd61c91b"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2742), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("819a0c98-7e8f-4b67-addb-3a98630953ba"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3571), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("8345043c-e36c-439c-948a-faf088ffe524"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2094), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("853c686a-528d-42c7-a3c9-4234babbc927"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3749), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("85b5236e-e8e2-4a23-889b-60b109dfd241"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4540), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("861b022b-0982-4d41-a754-cd414c3becb0"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3654), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("868f5b2f-ed2c-47ed-96e1-a15ece5bd5dc"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3342), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("894c7732-4f9b-4bc4-84e3-e005cd508c82"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2635), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("8bfdac3f-67d1-4eb9-9034-f45c6a5cf268"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2418), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("8e5d93fb-871d-4ab2-bdfe-bd0faa6c9fc8"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2118), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("8f7e1e31-3947-4f15-9e7d-2f027eb4f4d2"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3738), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("8fe86803-fdf4-460a-9356-6f2cd5f36bbf"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4325), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("909eb667-5f50-4a53-a1cc-bae3a8591470"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2827), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("91368efc-5a09-43fd-89aa-a1cda0a078ad"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4503), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("94de810a-c6e0-40ce-a395-dc9349ec85c2"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3713), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("99bd093a-450a-4684-8990-363e6cbc0cd8"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3963), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("99c396f4-70cc-43f1-a136-351165ae25cf"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2058), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("99db6b53-ccbc-4563-9391-9cde29ab5df8"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3115), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("9ab5084b-353d-4cfc-8552-72c5ab1fa270"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4083), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("9af880e6-03d8-4ce7-9fb4-14b6ae95b89f"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2997), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("9c705147-d49b-4ddb-a6d2-d3ad06c9b4bd"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3533), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("9c90aae0-3590-43dc-b668-6f69c58815a2"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3293), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("9d41ee95-ea5c-4e40-bc6d-aac1e73732a1"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4337), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("9e0e4f1d-b097-4dd0-bd7f-0a20be10d5f1"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2453), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("9e59b881-f29b-473f-b6b7-4aff92527b43"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2924), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("9ff4a28b-b193-4dd4-b45b-f192052290a4"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1847), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("a28e65b7-7c59-436c-9c7d-8ee873389642"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4373), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("a3142969-b637-4ed7-afa3-8438a7ba656e"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3248), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("a53b37aa-c327-4212-839e-44f93bb7f0e7"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2327), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("ab285601-5cd8-4b90-bab2-c332f240e381"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4430), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("ab849233-7892-46ab-9703-ff0c8d1f2974"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3200), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("ad9b50cc-13c5-4cfe-8b68-aaf6200b582b"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3508), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("adbc276c-5509-4c35-8297-39df9d8e7343"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1911), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("ae16ca67-547e-42a3-aec0-98491d4d8586"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3853), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("af0741ea-bec9-4f3b-be93-929e9dca908c"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4348), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("afaa250c-015e-4cc1-b611-63caf3403ff3"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3867), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("b0347f0a-520c-4c3c-a645-c241f2a7fd6e"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2021), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("b32b2049-74e2-41d0-8652-ed4d6b5cca91"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2684), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("b5b286a6-5a75-485e-a598-6fd0ce8d1c82"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4277), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("b617d365-3075-4ba0-99b9-98f7099c130d"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4360), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("b77918b5-79bf-4aeb-972b-8c4fc3cefa51"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1897), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("b9567382-5dce-4c23-850f-61d4dc1c7d47"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3425), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("ba27a51b-54e0-4c26-a6dc-1d5efa341472"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1823), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("ba9dc1f3-1d8b-4329-991f-8cf74bb0ede1"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2393), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("bb756bc4-5a9f-4122-9aea-7084e1da6cf9"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2291), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("bbc7d760-0b26-4e3e-b6d6-d3160f5cadf8"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2069), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("bc2616ca-df88-40df-9f97-5be37851721e"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1874), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("bc3410f8-b1c0-4216-b5ab-9d0652dfe815"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4563), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("c1ceb2ba-d28d-434c-9985-88263611f7d8"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2205), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("c3ba6f81-3531-482a-8eb5-f2f7c702c4fb"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2863), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("c50ccadc-f0da-46a3-9135-0c50cc569d70"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3151), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("c518ac8d-d5c1-47ed-b3e7-615ff32fbba2"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3665), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("c6a9c21d-cd21-404b-a3d7-c08a969c9c22"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4406), new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1") },
                    { new Guid("c7808f9e-d689-40c9-a1ae-51b5011782f7"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2430), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("c87adf7d-6a88-47c6-80ac-636ec63feeb8"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3950), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("cec02d24-5753-4ee2-a796-9201f9c4e8a9"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4456), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("cf03693a-b255-4466-b4a9-202e865bf155"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2303), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("cf2bad0f-d79d-4895-a284-943ce4ab24dd"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3690), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("d114b512-c331-4637-bb9b-032eb4318bad"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2756), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("d2042124-db07-4e6a-8c91-8a64a449fc9d"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2960), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("d2f78bf6-8f80-41fc-ae12-cad995c837f2"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2314), new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a") },
                    { new Guid("d3962cbd-14a2-428d-981f-ebc04fba2dfa"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3319), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("d4bc36ab-4625-4d38-8397-7834ab6c752e"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4228), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("d790f50b-ae34-46be-b185-ff79b6688246"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2266), new Guid("c7de371c-fc32-4649-9435-459d2ca87b57") },
                    { new Guid("d7a25588-f662-4f8f-96ea-6e395c3e67a3"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3378), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("d94a66d2-6855-4978-9dbd-12a2e888f421"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3355), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("daefcb9a-ea57-46cb-a507-1136ecfc0e18"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2888), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("daff97d0-277a-479a-a0a5-9b11c36e5c79"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1703), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("dafff492-84c9-4bd0-89c4-cfa33c236327"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2852), new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47") },
                    { new Guid("db4eafbb-d276-4247-99d3-9401e2d6c971"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3022), new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6") },
                    { new Guid("de4c9b91-b78a-4289-ac53-91669411e912"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4467), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("dfff82db-b65f-4ce0-acb5-387f484151f5"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4157), new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e") },
                    { new Guid("e10bb9e1-fb6d-4e18-b25d-e3dee5884cca"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3594), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("e1ef810a-3bb1-443e-b5d9-658b5a55986f"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3080), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("e279117e-c82d-40f9-bff7-4aba42959e09"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3841), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("e3db0135-4af6-4147-9d2f-189c9c4e3237"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3702), new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c") },
                    { new Guid("e5d08930-1544-4a6b-bb34-b57702687ecb"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3497), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("e60aac2d-b301-4524-adb9-ee2f5fa3eebf"), "Brand3", 3, "Colorway3", "Model3", "Item3", 30m, new DateTime(2023, 6, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4191), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("e9678ce9-59d3-4f1d-a2be-14c41d8bbb7d"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3175), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("ed196e3c-9deb-4691-830a-c3f67eaea551"), "Brand7", 1, "Colorway7", "Model7", "Item7", 70m, new DateTime(2023, 2, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4527), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("ed758526-010f-48d5-94d5-679d61fa8297"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1997), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("ef8316fa-3a3f-40a7-988d-80c4d8aeaf52"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3450), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("ef938356-1d47-4c61-b2b1-23912016e350"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3878), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("ef9551d8-a75f-409a-82c7-2705d3ad6ec3"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3414), new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6") },
                    { new Guid("f164bcd9-cbbc-4e61-bb70-60c85939160e"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3437), new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57") },
                    { new Guid("f390d10c-c190-4b9c-86d6-b4297386538b"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4288), new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d") },
                    { new Guid("f42fddf1-2a06-4024-97e6-b07c29cce80e"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3915), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("f5e848c3-15fb-4812-ac4a-86827b0b02ef"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1984), new Guid("799439b3-5855-4178-b870-69d2f930cb2e") },
                    { new Guid("f7d0bb4d-cb34-4778-9116-e4fed6b0efab"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4515), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("f8a0c92c-bb09-4bc0-b461-a51540d5804c"), "Brand6", 0, "Colorway6", "Model6", "Item6", 60m, new DateTime(2023, 3, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3938), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("f8e63c16-1005-4a34-aca2-442f7a9b7262"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2586), new Guid("36455683-5660-422a-bfd9-6d9f3502713c") },
                    { new Guid("f953eaf8-c4e4-4657-87f6-17cfa8c59b54"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2622), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("f9c74c32-1add-462b-bfa1-aa20e7410dfb"), "Brand8", 2, "Colorway8", "Model8", "Item8", 80m, new DateTime(2023, 1, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3260), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") },
                    { new Guid("fa03433e-cb00-495c-a0d9-6dfd5cd3b56a"), "Brand2", 2, "Colorway2", "Model2", "Item2", 20m, new DateTime(2023, 7, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2034), new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1") },
                    { new Guid("fa1cfc26-f202-46ef-8cb5-e13a11c15850"), "Brand9", 3, "Colorway9", "Model9", "Item9", 90m, new DateTime(2022, 12, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3975), new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822") },
                    { new Guid("fa70e99e-880c-49c8-88f4-d4176f1f57f0"), "Brand4", 4, "Colorway4", "Model4", "Item4", 40m, new DateTime(2023, 5, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(4492), new Guid("14c9d812-b906-4de8-9b5b-844815174fd2") },
                    { new Guid("facbd615-080d-4b67-9c26-f31a453867ad"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(2670), new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7") },
                    { new Guid("fcfabc14-83eb-4aea-9241-a4a29ba64886"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3033), new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f") },
                    { new Guid("fd2b36e8-07f5-403e-95f9-b05f12cbc118"), "Brand1", 1, "Colorway1", "Model1", "Item1", 10m, new DateTime(2023, 8, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3725), new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b") },
                    { new Guid("fe5303e3-5095-4529-b9e9-a7b646485385"), "Brand5", 5, "Colorway5", "Model5", "Item5", 50m, new DateTime(2023, 4, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(1797), new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc") },
                    { new Guid("fe538925-ca53-4d58-9c7e-d9183bcdbdb1"), "Brand10", 4, "Colorway10", "Model10", "Item10", 100m, new DateTime(2022, 11, 12, 10, 39, 39, 75, DateTimeKind.Utc).AddTicks(3307), new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d") }
                });

            migrationBuilder.InsertData(
                table: "OutfitImages",
                columns: new[] { "Id", "OutfitId", "Url" },
                values: new object[,]
                {
                    { new Guid("02d5a6b0-cce7-4d43-b8b3-de125131e8aa"), new Guid("db79cd1e-94ca-40ba-a62b-c00d2841ab77"), "exampleURL" },
                    { new Guid("04b3dc02-ef57-48d8-9337-5c8003c9dd1c"), new Guid("87b8f4c5-5f63-445c-870e-9bc2acf34391"), "exampleURL" },
                    { new Guid("0d0a5e60-b031-48ab-a98a-00decb8352c8"), new Guid("ea1fcd92-0600-4307-a0f0-046ae1df9ba2"), "exampleURL" },
                    { new Guid("1d142a64-be4b-4208-b1cf-b585290fe888"), new Guid("b898165c-6560-43a0-a301-d861078aac86"), "exampleURL" },
                    { new Guid("27f2d91f-4140-4d07-8d7e-51d578298e1b"), new Guid("a7d8c1d7-73fa-4061-8ca0-9d249aefa53b"), "exampleURL" },
                    { new Guid("3304a52d-ddc9-4668-9001-acbd92ee1bcc"), new Guid("e1f6b8f7-7322-43e5-b091-da0924ad7fb0"), "exampleURL" },
                    { new Guid("3461448b-1bae-47b9-be1c-f9dc5727f23f"), new Guid("b195beef-0e6f-4f40-a4d5-2a3e599a1267"), "exampleURL" },
                    { new Guid("34b48aab-2fc1-4fce-a7a6-62f93b1ff44e"), new Guid("60cb7a4d-e26d-48f9-8aa2-fb0c1cd3e57f"), "exampleURL" },
                    { new Guid("37a94cbc-eca1-4347-8a02-eb4b917d0d64"), new Guid("ccd494df-bdff-485c-bff5-357d954d1ece"), "exampleURL" },
                    { new Guid("4606d514-e5d9-421d-8ef9-2e304204ef64"), new Guid("2128b55f-dd9b-4ba4-905c-f7994f5b42d2"), "exampleURL" },
                    { new Guid("46a6c1b2-5b80-4f63-8b7e-ea9d37d351c8"), new Guid("55f813ca-616d-4547-9b4a-7d753d373579"), "exampleURL" },
                    { new Guid("4e3c670e-4042-408f-8b53-57b2b19f6ce4"), new Guid("12540349-521d-41f5-b31c-ed6cc32570c3"), "exampleURL" },
                    { new Guid("51add0cd-9fd5-4956-93ab-b6fc11931a9c"), new Guid("543941b2-329d-44cc-a53d-5734f82e6971"), "exampleURL" },
                    { new Guid("55fa02d4-2fd4-4a89-8823-d43ba77aa64d"), new Guid("bb2cb682-30ac-4a39-a6da-f43940456dd4"), "exampleURL" },
                    { new Guid("5b6c483f-f246-4a35-afb2-0213ca183368"), new Guid("2f6dbdcc-c1bf-482e-86df-81fa69b70e20"), "exampleURL" },
                    { new Guid("61abf25c-5e82-4de5-aac9-cf4737a656dd"), new Guid("0c1cd940-3258-4fe4-9b0b-32b768b5f048"), "exampleURL" },
                    { new Guid("71766b4c-d847-4313-975f-5d2eb7668d93"), new Guid("9a60abdf-f023-4636-88ff-4b54248b4f20"), "exampleURL" },
                    { new Guid("7336de67-5fb4-43f8-a6b6-75f55e9ac1b0"), new Guid("99a1b56d-da00-4612-bf5b-ca3834e1d569"), "exampleURL" },
                    { new Guid("75bd5bf7-330b-4baa-a36d-f1509e809f3a"), new Guid("c4c92877-79c4-410d-9a3f-54d5ee9c2c48"), "exampleURL" },
                    { new Guid("764bd87c-5389-4dbf-9f68-cfe0b1da18c0"), new Guid("ee2358b2-fced-426e-9975-7b697808400a"), "exampleURL" },
                    { new Guid("7bfebc06-a280-42fe-8a29-f036a5c410a7"), new Guid("57493cc6-b145-4905-8031-f687ebe028e3"), "exampleURL" },
                    { new Guid("7c623e59-dae2-48b4-b0d8-a8acee3f45b3"), new Guid("8e33c9ef-e92e-4907-8f86-36448a2a4b34"), "exampleURL" },
                    { new Guid("7d8a7508-35d8-43c2-8fd3-d43cf66ff43c"), new Guid("a5d14959-b4f6-487a-b187-45fa39352088"), "exampleURL" },
                    { new Guid("7da007ee-78db-40cd-8426-0c3a51f001d2"), new Guid("9c9a0760-30f0-431e-86b4-ede9e1e44855"), "exampleURL" },
                    { new Guid("86761054-01be-45ef-8e04-2a2ad0fae5b3"), new Guid("58e198f5-395e-4eba-89b0-dd5fc9d78cab"), "exampleURL" },
                    { new Guid("923d02bd-6d94-47c8-9a00-1375ec02f381"), new Guid("b858c402-4e09-4240-b900-0b3adf001316"), "exampleURL" },
                    { new Guid("9992d6b1-5d4b-493b-b967-0bb5f1fa1eec"), new Guid("e807a2fc-b75a-45d1-96a2-10e7384edb23"), "exampleURL" },
                    { new Guid("9f9fe259-ad70-4031-9375-4cecd40b74ee"), new Guid("05360092-92d3-4c8c-af00-e81ef12ba4ec"), "exampleURL" },
                    { new Guid("a20e740a-960f-4979-ab21-d6bed3408486"), new Guid("3d3a94bf-76f4-461a-ab60-194942fc7a71"), "exampleURL" },
                    { new Guid("ada2e54d-c7da-4a70-97b5-9ad6028b466b"), new Guid("12fcdb71-d091-4ae8-9128-5693a371f0af"), "exampleURL" },
                    { new Guid("bebf2216-8ccf-402b-a27e-552b5db4d0dd"), new Guid("1eb089c4-76fa-43dd-9a99-4d5fabb9598a"), "exampleURL" },
                    { new Guid("c54709ce-6c27-4d07-a33c-c780633aac6c"), new Guid("c9509c8d-564f-4f98-84b4-6e57fe8de2ac"), "exampleURL" },
                    { new Guid("caee0205-d5d4-462f-94ce-aa1a21372f5c"), new Guid("b30af038-0408-4957-92ad-f6f30b184970"), "exampleURL" },
                    { new Guid("cf5adb35-f3d3-4f5d-b552-4ae35bf6a389"), new Guid("e6d63fad-e5b7-4fb2-8c8b-3d25dfa20ac7"), "exampleURL" },
                    { new Guid("cf99b06a-4ceb-47d9-8180-21ccc3b93298"), new Guid("acf32c5a-3a1b-482a-8d8d-faefe6fbed9b"), "exampleURL" },
                    { new Guid("d37a60f9-39e8-4b29-be40-8f1fb3f0138f"), new Guid("25d17622-3ff0-4fea-b609-672bf1bef46e"), "exampleURL" },
                    { new Guid("d8ed9c41-be8a-46a9-9505-59fc1496db47"), new Guid("92c4309d-4d7f-4643-89fa-7e1524c92b98"), "exampleURL" },
                    { new Guid("e365add5-5f9d-49d9-aa7e-509e8ee7ed67"), new Guid("c859fb4a-d8e1-4de0-b8bb-0a0feddbd178"), "exampleURL" },
                    { new Guid("f11f4f1c-8b32-4eb0-88d7-7456110648ed"), new Guid("971ae71b-73f6-450c-b8cf-f16f7a393211"), "exampleURL" },
                    { new Guid("f9a7c868-1b80-4d8a-88d1-38200f077f5f"), new Guid("0a8a81d7-114e-4b21-857b-93acf6afb949"), "exampleURL" }
                });

            migrationBuilder.InsertData(
                table: "ItemsImages",
                columns: new[] { "Id", "ItemId", "Url" },
                values: new object[,]
                {
                    { new Guid("001697df-4eae-48bd-bd44-26d1abf34d7c"), new Guid("c7808f9e-d689-40c9-a1ae-51b5011782f7"), "exampleURL" },
                    { new Guid("004c2955-3493-4a22-98d1-6be31391d61d"), new Guid("a28e65b7-7c59-436c-9c7d-8ee873389642"), "exampleURL" },
                    { new Guid("01319f6d-2511-4c17-a6c9-d05d9c4c1399"), new Guid("28a0297b-4c90-4a8b-8908-03a9dd29252d"), "exampleURL" },
                    { new Guid("0255e954-34db-4f71-9964-86c6b9f0ed53"), new Guid("bbc7d760-0b26-4e3e-b6d6-d3160f5cadf8"), "exampleURL" },
                    { new Guid("02af12ef-f537-4dcc-87ee-29d6e4035c52"), new Guid("c1ceb2ba-d28d-434c-9985-88263611f7d8"), "exampleURL" },
                    { new Guid("05c28c8b-2854-4613-8b03-81452922baf9"), new Guid("d114b512-c331-4637-bb9b-032eb4318bad"), "exampleURL" },
                    { new Guid("0682ab46-ef89-42e1-a91d-fb8f102e292c"), new Guid("adbc276c-5509-4c35-8297-39df9d8e7343"), "exampleURL" },
                    { new Guid("06e54fb3-212f-47ae-aada-3a684a3e935c"), new Guid("fe538925-ca53-4d58-9c7e-d9183bcdbdb1"), "exampleURL" },
                    { new Guid("076d0445-7984-4642-b29e-544c052e2fa0"), new Guid("d2042124-db07-4e6a-8c91-8a64a449fc9d"), "exampleURL" },
                    { new Guid("0a2ae94e-09ea-4ef1-bb5f-a59e889453cd"), new Guid("868f5b2f-ed2c-47ed-96e1-a15ece5bd5dc"), "exampleURL" },
                    { new Guid("0b482b54-4ae5-42e8-9e97-cb1cebec0dc9"), new Guid("ab285601-5cd8-4b90-bab2-c332f240e381"), "exampleURL" },
                    { new Guid("0b932d44-a7e8-44d6-b905-03ffa7667cc0"), new Guid("4e845077-5330-43c6-aea0-2080f79da76b"), "exampleURL" },
                    { new Guid("0d50c29e-e6fa-4652-bea1-73bb55e04f31"), new Guid("76347fb3-1605-4427-9c6b-dbd046b7ae4e"), "exampleURL" },
                    { new Guid("0edf1343-cd51-49c0-82d7-93c483890184"), new Guid("b77918b5-79bf-4aeb-972b-8c4fc3cefa51"), "exampleURL" },
                    { new Guid("0f09b410-6224-4c69-86f2-a1621433892f"), new Guid("76e163ed-dc5d-42f5-9dc2-7df1bdff157a"), "exampleURL" },
                    { new Guid("0f297aa0-7022-42c1-9b15-14b50d5f0338"), new Guid("1d07a254-a01c-457a-811c-1540bba98fbf"), "exampleURL" },
                    { new Guid("107c0f80-fb78-4c3a-bdda-32b1e8c65fc2"), new Guid("b0347f0a-520c-4c3c-a645-c241f2a7fd6e"), "exampleURL" },
                    { new Guid("10f24c07-05da-4b95-8b7a-b8fa4de0070b"), new Guid("0c476002-2366-43d6-8f03-c2fe2c094c08"), "exampleURL" },
                    { new Guid("127c3db5-92b4-4344-8352-04c9a0ffb31d"), new Guid("688c6c39-4fbf-490f-9b74-781507d85a56"), "exampleURL" },
                    { new Guid("134b5af1-bcee-46d9-951c-5fae83df9baf"), new Guid("1264461d-9b05-4193-b60d-b02b790126ed"), "exampleURL" },
                    { new Guid("1414b500-eb0e-4c4a-9d40-2570e1661a86"), new Guid("fa1cfc26-f202-46ef-8cb5-e13a11c15850"), "exampleURL" },
                    { new Guid("14b84bb4-d97d-48fb-b731-6b2d562df72b"), new Guid("9e0e4f1d-b097-4dd0-bd7f-0a20be10d5f1"), "exampleURL" },
                    { new Guid("14f82ebf-f9ce-4473-bde1-f9479ff5dc60"), new Guid("fa70e99e-880c-49c8-88f4-d4176f1f57f0"), "exampleURL" },
                    { new Guid("15ff3873-f3f4-4079-8dbd-a590251d985b"), new Guid("45bcdd43-1462-40d7-9901-4724b04ed448"), "exampleURL" },
                    { new Guid("1779eab1-c010-4d30-9e78-c5daad68128e"), new Guid("ed758526-010f-48d5-94d5-679d61fa8297"), "exampleURL" },
                    { new Guid("17e713fa-1045-408d-8c30-fa1dcf359187"), new Guid("ab849233-7892-46ab-9703-ff0c8d1f2974"), "exampleURL" },
                    { new Guid("19201ccb-4aa3-416c-bd39-877a790ff290"), new Guid("5cdd0a7b-f59c-4afc-854e-9bd187c62b0d"), "exampleURL" },
                    { new Guid("1bad3b1e-c8ac-4135-ac14-0e7ad6ebe4d9"), new Guid("f390d10c-c190-4b9c-86d6-b4297386538b"), "exampleURL" },
                    { new Guid("1ca97123-7913-40b5-898e-d80894ca192c"), new Guid("2da1b8c4-d35d-413c-a48a-781b41bfb464"), "exampleURL" },
                    { new Guid("206423ea-8b41-49df-a76a-5d27679850f6"), new Guid("05f4c23e-6f3e-47d9-a6e3-c75dc9436298"), "exampleURL" },
                    { new Guid("20d18640-5b14-4428-8ef9-1d549d574afc"), new Guid("f164bcd9-cbbc-4e61-bb70-60c85939160e"), "exampleURL" },
                    { new Guid("20dbe35a-77ac-4268-8648-56cb9ee04fd8"), new Guid("42ead622-959d-47d0-bf34-0d5eb11eb35f"), "exampleURL" },
                    { new Guid("2120b0da-db3f-432c-9405-9fbbf6ef98cc"), new Guid("2ce7ed07-bea3-4f77-9465-48a2d61927a0"), "exampleURL" },
                    { new Guid("222ef9a2-a071-4a36-bf87-63e085bf2785"), new Guid("59143f1d-bfee-4eac-a84f-e1f24bd0ab93"), "exampleURL" },
                    { new Guid("2234e197-a12b-40cb-bf83-8df9ae264f52"), new Guid("d4bc36ab-4625-4d38-8397-7834ab6c752e"), "exampleURL" },
                    { new Guid("2272bb2d-a52c-479b-85c5-06377a85e963"), new Guid("8f7e1e31-3947-4f15-9e7d-2f027eb4f4d2"), "exampleURL" },
                    { new Guid("22dea70a-ccb4-4a11-9ad2-9d7fa4a752c5"), new Guid("55f1a543-ce91-4a5e-8676-60ab1b275a5b"), "exampleURL" },
                    { new Guid("290e60c8-8df6-40c2-870b-6a373ae05f3b"), new Guid("b617d365-3075-4ba0-99b9-98f7099c130d"), "exampleURL" },
                    { new Guid("2ae131e2-89da-414d-8724-a06382b7cda8"), new Guid("00778d03-a5d3-4dc1-9c15-494d7a2f6168"), "exampleURL" },
                    { new Guid("2bb7de2a-4cd0-4782-b4de-5bd466e5cf31"), new Guid("dafff492-84c9-4bd0-89c4-cfa33c236327"), "exampleURL" },
                    { new Guid("2c99bb6c-a209-4a3d-ad62-357c8214be6e"), new Guid("5095c7c3-aa87-404a-ae25-f364ad170aba"), "exampleURL" },
                    { new Guid("2ebc9f33-4758-40a0-8310-988558e53fcd"), new Guid("fd2b36e8-07f5-403e-95f9-b05f12cbc118"), "exampleURL" },
                    { new Guid("2fb61860-0826-4e01-a032-9d00d10197de"), new Guid("9ff4a28b-b193-4dd4-b45b-f192052290a4"), "exampleURL" },
                    { new Guid("2fc2dbdf-feed-4b27-a868-8f4b09a7f066"), new Guid("f953eaf8-c4e4-4657-87f6-17cfa8c59b54"), "exampleURL" },
                    { new Guid("3229a966-d6ba-4920-ba7c-af9702a677c8"), new Guid("7e8903f0-42c1-4b2c-bca0-715e7f6161f2"), "exampleURL" },
                    { new Guid("33d994fc-24ff-4005-a0a0-c46b04bbddbf"), new Guid("7480bd0f-6992-4294-b125-194df06aaa43"), "exampleURL" },
                    { new Guid("35672b9b-724a-42a8-8cb0-440d522890b2"), new Guid("156b1fc2-3a71-4b96-bc30-294939143319"), "exampleURL" },
                    { new Guid("36770267-841f-4992-a824-e307dd9f7d5e"), new Guid("26f7d4a1-10d2-498c-8f67-4ba2222cde7e"), "exampleURL" },
                    { new Guid("36c30d41-53b9-452c-b98c-401c35b83856"), new Guid("75155e46-314b-4551-9d14-8d08496dc04d"), "exampleURL" },
                    { new Guid("380a68b7-e2b3-4b83-a1e2-86361c73751d"), new Guid("44ec7960-018f-4271-bcd7-0cf59bfe30b9"), "exampleURL" },
                    { new Guid("398b71c8-e0f9-4fd6-a768-16e4ae72f7ff"), new Guid("0e08b8f2-c013-468c-ac31-e24d1ccc0460"), "exampleURL" },
                    { new Guid("3a495fd9-36ff-413a-917c-238f6d853994"), new Guid("02a688aa-87a3-4936-961a-0f9300ebb8d1"), "exampleURL" },
                    { new Guid("3ae3bacf-7d0a-489c-8dd1-6fee21e941c5"), new Guid("e5d08930-1544-4a6b-bb34-b57702687ecb"), "exampleURL" },
                    { new Guid("3b865bdd-538c-435b-9191-c368df106bc1"), new Guid("5857adb4-a109-4d85-b9bf-fe8bce9a9b90"), "exampleURL" },
                    { new Guid("3c45539a-87bf-46d6-ab47-16bf538ece8b"), new Guid("94de810a-c6e0-40ce-a395-dc9349ec85c2"), "exampleURL" },
                    { new Guid("3e8ae3bd-bd35-410a-945d-3104235078bb"), new Guid("2bae35e8-ca96-4d13-a9cb-1f48b15843a9"), "exampleURL" },
                    { new Guid("4012b93e-7549-46c3-8fb0-3dfdcbfa408d"), new Guid("c87adf7d-6a88-47c6-80ac-636ec63feeb8"), "exampleURL" },
                    { new Guid("428e8c60-bbdf-49ed-a647-a9767548c2ba"), new Guid("222d35c8-5507-4b79-a4b7-c6b1e5e824b8"), "exampleURL" },
                    { new Guid("42b00296-beac-400a-ba4c-589dcaa2096a"), new Guid("5ff8eaea-b219-40fc-b0c4-60dbbc5397e9"), "exampleURL" },
                    { new Guid("4580c40c-31da-4909-bf5c-18d1c35f372e"), new Guid("fa03433e-cb00-495c-a0d9-6dfd5cd3b56a"), "exampleURL" },
                    { new Guid("460a6405-418f-48d6-a1db-80866e57dcaa"), new Guid("8fe86803-fdf4-460a-9356-6f2cd5f36bbf"), "exampleURL" },
                    { new Guid("46cba471-a36f-497e-8cb5-26cc0e99f949"), new Guid("5bea49a8-b860-4d29-8006-eb61e77fdb32"), "exampleURL" },
                    { new Guid("476c6dc7-d736-4778-b430-53c5b7fd332a"), new Guid("41e1217d-1d86-479b-89c7-9d909de52c8d"), "exampleURL" },
                    { new Guid("4c56e3fe-ae5d-4f37-8023-6ce95a3a4d4c"), new Guid("3ed71070-5842-4eb4-8d9f-0a7f9ae7873a"), "exampleURL" },
                    { new Guid("4d55d907-b013-4957-b116-b6cbc28b8efa"), new Guid("f8e63c16-1005-4a34-aca2-442f7a9b7262"), "exampleURL" },
                    { new Guid("509b247d-3ec7-4a9b-b39b-5d4c95ac48a4"), new Guid("4020e2a0-063f-4c31-b259-4921f8648a10"), "exampleURL" },
                    { new Guid("522e1c37-2715-4c7b-b673-3ffee6e5ec2c"), new Guid("9af880e6-03d8-4ce7-9fb4-14b6ae95b89f"), "exampleURL" },
                    { new Guid("52e98903-27b5-4855-ae9c-af1547455b2e"), new Guid("547e0856-8ee8-4839-afce-12f698ca79d1"), "exampleURL" },
                    { new Guid("53957929-3ff2-4db7-a45e-fd0ea4a6e4ed"), new Guid("409f793a-0529-4a5e-aa53-8f1d88958472"), "exampleURL" },
                    { new Guid("55bbb989-5261-41ed-bc78-2e6622117abe"), new Guid("0b803689-2aec-40c8-af8f-c49d6b5aa76f"), "exampleURL" },
                    { new Guid("56c11cd6-70e5-4769-8ee8-a4ede1a3f93f"), new Guid("585e6ce6-f69c-454c-894b-36909a4ebcd0"), "exampleURL" },
                    { new Guid("5813d236-7441-4999-9fb4-793a149eca06"), new Guid("1b60de2f-7716-4ae2-bb0c-e476947f90f1"), "exampleURL" },
                    { new Guid("594c8a5d-27d2-4dff-9117-d814eed8e4c5"), new Guid("bc3410f8-b1c0-4216-b5ab-9d0652dfe815"), "exampleURL" },
                    { new Guid("5a3ed195-218f-4c9a-aae4-823bc49e79be"), new Guid("bb756bc4-5a9f-4122-9aea-7084e1da6cf9"), "exampleURL" },
                    { new Guid("5ae06ad8-d393-4392-a14e-3bb962003eeb"), new Guid("9d41ee95-ea5c-4e40-bc6d-aac1e73732a1"), "exampleURL" },
                    { new Guid("5b0f2dc0-e9d2-418b-abe3-b6605221a656"), new Guid("9c90aae0-3590-43dc-b668-6f69c58815a2"), "exampleURL" },
                    { new Guid("5b72d179-e994-4a94-9199-18e33d6852b7"), new Guid("c6a9c21d-cd21-404b-a3d7-c08a969c9c22"), "exampleURL" },
                    { new Guid("5def41ba-b2ad-4694-9ad0-86cebc04fa46"), new Guid("c50ccadc-f0da-46a3-9135-0c50cc569d70"), "exampleURL" },
                    { new Guid("5e01f09a-54f8-4c73-8489-e9ad13afe0ca"), new Guid("3d958d0b-4364-4ab0-b87b-0188c083ab3a"), "exampleURL" },
                    { new Guid("5f31a4a4-a3da-4922-8cef-ba94ee11aa35"), new Guid("b32b2049-74e2-41d0-8652-ed4d6b5cca91"), "exampleURL" },
                    { new Guid("5f3b9ffc-161a-45e6-b2c8-94ad8f7cb4d7"), new Guid("f7d0bb4d-cb34-4778-9116-e4fed6b0efab"), "exampleURL" },
                    { new Guid("5ff32236-4586-4a09-a510-b1608d14e813"), new Guid("db4eafbb-d276-4247-99d3-9401e2d6c971"), "exampleURL" },
                    { new Guid("62c3aef5-7d0f-458c-8667-32a081952e02"), new Guid("b5b286a6-5a75-485e-a598-6fd0ce8d1c82"), "exampleURL" },
                    { new Guid("62c6b687-7e8c-4395-8c05-721fb59d6994"), new Guid("f9c74c32-1add-462b-bfa1-aa20e7410dfb"), "exampleURL" },
                    { new Guid("668635ee-dbd6-43a4-9709-b1b7661ab18d"), new Guid("8345043c-e36c-439c-948a-faf088ffe524"), "exampleURL" },
                    { new Guid("66f7bcfa-1f87-45cb-90e2-f3aa4db6fc24"), new Guid("dfff82db-b65f-4ce0-acb5-387f484151f5"), "exampleURL" },
                    { new Guid("681b84f8-de7f-461b-a040-2bde60fb95a7"), new Guid("634c877f-2ae5-48a6-814b-ec1cca7bf2a0"), "exampleURL" },
                    { new Guid("686286f0-7868-43d7-ad64-021b2106f2cf"), new Guid("fe5303e3-5095-4529-b9e9-a7b646485385"), "exampleURL" },
                    { new Guid("6909a623-ce6f-45b6-ac98-422eb39fae9b"), new Guid("29b7abe0-91d4-473f-87a4-e7eee3da1aee"), "exampleURL" },
                    { new Guid("6adffb3a-af4c-445f-827c-762689c878b0"), new Guid("46d70f34-5f16-4399-b07f-0eea067a55f6"), "exampleURL" },
                    { new Guid("6b755ddc-37b5-43a9-9fdd-493f1235bb78"), new Guid("af0741ea-bec9-4f3b-be93-929e9dca908c"), "exampleURL" },
                    { new Guid("6bad0be9-6f9b-45b8-9b4d-16b4eb521a2b"), new Guid("3fbd628c-13a8-4ada-a6f0-3d74fee87d5e"), "exampleURL" },
                    { new Guid("6baf8dc6-43f8-44a3-a927-31c657fe0d64"), new Guid("6f13f4e9-7afa-43a1-9f3f-6c9496f7da62"), "exampleURL" },
                    { new Guid("6ccb37db-4c31-40d1-8346-345a9ca5f1a4"), new Guid("8bfdac3f-67d1-4eb9-9034-f45c6a5cf268"), "exampleURL" },
                    { new Guid("6cd1c674-594a-4e57-98b2-ace55bb1baee"), new Guid("a3142969-b637-4ed7-afa3-8438a7ba656e"), "exampleURL" },
                    { new Guid("70532582-94c1-498f-acf8-16ab4697a832"), new Guid("9ab5084b-353d-4cfc-8552-72c5ab1fa270"), "exampleURL" },
                    { new Guid("724c222e-ab17-4b7d-acfe-feb7185afdd1"), new Guid("861b022b-0982-4d41-a754-cd414c3becb0"), "exampleURL" },
                    { new Guid("72ab5887-07d8-4bba-a80c-2467645cbc4c"), new Guid("ef8316fa-3a3f-40a7-988d-80c4d8aeaf52"), "exampleURL" },
                    { new Guid("740a528f-c2da-4f18-b219-14716140f149"), new Guid("07c7d000-d2fd-4955-908b-e4bee93a4d36"), "exampleURL" },
                    { new Guid("748d90f8-66b8-4a09-9853-f887f65e2685"), new Guid("c3ba6f81-3531-482a-8eb5-f2f7c702c4fb"), "exampleURL" },
                    { new Guid("7710f6c2-9278-4c30-b754-8015ea54cc7b"), new Guid("0eaeb816-97cb-4f63-92a6-6e77ffe2aa6d"), "exampleURL" },
                    { new Guid("7b67ac0e-51a2-4015-bb34-810590ea5c1d"), new Guid("daefcb9a-ea57-46cb-a507-1136ecfc0e18"), "exampleURL" },
                    { new Guid("80d19a74-fffa-45f3-a658-6a8f2a2caf01"), new Guid("fcfabc14-83eb-4aea-9241-a4a29ba64886"), "exampleURL" },
                    { new Guid("80f3dca4-2603-437a-b159-84a6bc3393e9"), new Guid("e9678ce9-59d3-4f1d-a2be-14c41d8bbb7d"), "exampleURL" },
                    { new Guid("85b9ffb1-4260-45d1-8799-382b555df944"), new Guid("757abbb1-2cad-43e8-a9bb-7ed9c2ea48a0"), "exampleURL" },
                    { new Guid("8651adb1-14e9-44b0-a465-d8c73b855050"), new Guid("91368efc-5a09-43fd-89aa-a1cda0a078ad"), "exampleURL" },
                    { new Guid("873ed291-639d-41ad-8583-49e7a319702f"), new Guid("6226a895-72b6-43fd-a6f1-6de0ad421d37"), "exampleURL" },
                    { new Guid("88abfca0-1883-4505-94c9-829ffab8c61c"), new Guid("1bfe6338-dc16-4678-a7b7-8bd09bba9e6a"), "exampleURL" },
                    { new Guid("88bd87e9-1c8a-4ade-a4c5-c9bf7525a6bc"), new Guid("3567103a-2ae1-4985-957a-b6a3fc2a08b2"), "exampleURL" },
                    { new Guid("8aea7b5d-4256-444c-b08b-41b0c214f92b"), new Guid("e279117e-c82d-40f9-bff7-4aba42959e09"), "exampleURL" },
                    { new Guid("8b19c96d-c4be-44af-b726-9aff62b66733"), new Guid("9c705147-d49b-4ddb-a6d2-d3ad06c9b4bd"), "exampleURL" },
                    { new Guid("8b1d69fb-a1df-4782-90f7-417f4989595f"), new Guid("4bb04e80-489e-4783-8ce9-7ab34faf3b4b"), "exampleURL" },
                    { new Guid("8b3ba516-9682-4c91-a27d-4dcdb39c51ca"), new Guid("4cbaceb8-1883-440b-a860-2b4d6a9de99f"), "exampleURL" },
                    { new Guid("8bd0b135-331a-4f7e-9fd5-2c041a2cd7a5"), new Guid("54895ee0-3209-49f9-a92f-ba1b1b60fda9"), "exampleURL" },
                    { new Guid("8e0ae865-b7ae-4c25-9918-f07880d2ff28"), new Guid("ed196e3c-9deb-4691-830a-c3f67eaea551"), "exampleURL" },
                    { new Guid("92eaaa38-f140-4718-b02b-0d7531685bd4"), new Guid("e1ef810a-3bb1-443e-b5d9-658b5a55986f"), "exampleURL" },
                    { new Guid("9310a847-fc5d-4dc0-b472-35e5d10d9687"), new Guid("64cbb93d-531e-47a9-8bd2-7b84e99fa123"), "exampleURL" },
                    { new Guid("933b5d66-3c27-4182-bea5-d4023b57b222"), new Guid("3ca19678-2df0-4317-8ed0-10ca31c879d6"), "exampleURL" },
                    { new Guid("962c021d-a820-49a8-9cdd-7108d30fc74a"), new Guid("ef9551d8-a75f-409a-82c7-2705d3ad6ec3"), "exampleURL" },
                    { new Guid("998ddacd-fb40-4adc-8a9f-a56fa2790eaf"), new Guid("4cb397c8-db37-4463-9707-12a44018e66f"), "exampleURL" },
                    { new Guid("9ae99248-c3a7-4d75-a27b-57c138fc9d72"), new Guid("d2f78bf6-8f80-41fc-ae12-cad995c837f2"), "exampleURL" },
                    { new Guid("9c396bf0-60dd-4c96-bbe0-fe3534ec513f"), new Guid("2c991a76-d5cb-4fa7-a274-74cd25ca8590"), "exampleURL" },
                    { new Guid("9c7b20dc-c671-4fb8-b840-280813023312"), new Guid("853c686a-528d-42c7-a3c9-4234babbc927"), "exampleURL" },
                    { new Guid("9d88be57-22b2-4a8c-9744-6aada8140ba7"), new Guid("819a0c98-7e8f-4b67-addb-3a98630953ba"), "exampleURL" },
                    { new Guid("a0e7cca8-6206-464f-b02f-ab8fe5d50db2"), new Guid("909eb667-5f50-4a53-a1cc-bae3a8591470"), "exampleURL" },
                    { new Guid("a32dd15e-8a0f-4cfa-a871-aa0b8c40826e"), new Guid("55fc0a2b-8cf8-497b-847d-8af5e5030cb8"), "exampleURL" },
                    { new Guid("a4ab4265-18d1-497d-9e95-ae8dbd413a7e"), new Guid("3c472af2-537d-4d45-97cf-2207ecc64b86"), "exampleURL" },
                    { new Guid("a4b71a05-93f7-4a38-afe9-7362f4e86771"), new Guid("d790f50b-ae34-46be-b185-ff79b6688246"), "exampleURL" },
                    { new Guid("a6f02338-6b29-4b58-8cc2-dc82423568f4"), new Guid("f8a0c92c-bb09-4bc0-b461-a51540d5804c"), "exampleURL" },
                    { new Guid("a8848a9a-bea8-472d-8fd7-fe2022e2e95d"), new Guid("ae16ca67-547e-42a3-aec0-98491d4d8586"), "exampleURL" },
                    { new Guid("a9c4336c-b1d8-4d91-a99b-5d16b8873716"), new Guid("ba9dc1f3-1d8b-4329-991f-8cf74bb0ede1"), "exampleURL" },
                    { new Guid("a9f7f150-e843-4a99-8481-c3865fc8f036"), new Guid("de4c9b91-b78a-4289-ac53-91669411e912"), "exampleURL" },
                    { new Guid("ab95a35c-8eae-43d8-afe4-fc5bb1cc36a8"), new Guid("ba27a51b-54e0-4c26-a6dc-1d5efa341472"), "exampleURL" },
                    { new Guid("ac2aa550-9790-492b-bf72-42ed6ef5866f"), new Guid("c518ac8d-d5c1-47ed-b3e7-615ff32fbba2"), "exampleURL" },
                    { new Guid("ae565097-2791-49d5-b362-c21b6c195ffd"), new Guid("4b91589a-5041-4e62-979e-ddc395aa0df7"), "exampleURL" },
                    { new Guid("b02f41ad-99fa-4358-ac10-0b28a4338369"), new Guid("b9567382-5dce-4c23-850f-61d4dc1c7d47"), "exampleURL" },
                    { new Guid("b0750032-7199-4f28-862b-d152c657ae57"), new Guid("12bef15f-6710-4600-9aa6-6e85ec3d390a"), "exampleURL" },
                    { new Guid("b0ccd790-76d2-4c26-94e0-9d9ad6d5ab15"), new Guid("72aab350-aedb-4a47-82da-6d649bdd9cae"), "exampleURL" },
                    { new Guid("b2bbb6c7-d556-47e5-9f89-c73333e314ec"), new Guid("f5e848c3-15fb-4812-ac4a-86827b0b02ef"), "exampleURL" },
                    { new Guid("b34c4798-abf3-4cee-a02c-9cc6d605fc33"), new Guid("3d732b2e-ba2f-4ff9-b65a-21ea0fec042a"), "exampleURL" },
                    { new Guid("b501f2a6-1a90-43f6-a3f0-7bcfd1247f79"), new Guid("bc2616ca-df88-40df-9f97-5be37851721e"), "exampleURL" },
                    { new Guid("b6b1965a-b53c-44ca-89e9-f77a012f0305"), new Guid("5d17f433-2975-4057-8785-5c4a77f7f578"), "exampleURL" },
                    { new Guid("b6d07cab-8167-409b-9fd4-da30035ef921"), new Guid("6b27df34-68e4-4c6c-9ce5-f28fe0787e0a"), "exampleURL" },
                    { new Guid("b81f0c15-87fa-4ed5-b9db-4320ad4210b1"), new Guid("cf03693a-b255-4466-b4a9-202e865bf155"), "exampleURL" },
                    { new Guid("b8c1ee44-726d-42d1-a185-01b5003f1fdf"), new Guid("0debaa72-63ff-4c8f-9d7a-994b027604e4"), "exampleURL" },
                    { new Guid("babcb74e-073a-4273-a696-4069919b2417"), new Guid("03c5dbb8-de31-4996-b456-5d540580ae0f"), "exampleURL" },
                    { new Guid("baf9acd1-bee6-4ad2-ae30-32bd0c8b412a"), new Guid("35015e89-e81c-477f-b995-bd458287b4a3"), "exampleURL" },
                    { new Guid("bdfe9e88-75d0-4df7-9d33-6c409d62dd92"), new Guid("65f52df2-0ce3-4d02-a16b-4e1436fd2cd4"), "exampleURL" },
                    { new Guid("c0cd8637-0f2e-4fbe-9985-33f62ae396dc"), new Guid("519c1ee5-aa98-480a-9bb4-b99a99149dd4"), "exampleURL" },
                    { new Guid("c1d5df3d-bd51-4431-a06f-f99a5e856a37"), new Guid("e10bb9e1-fb6d-4e18-b25d-e3dee5884cca"), "exampleURL" },
                    { new Guid("c30bdb39-4fb1-4fc8-90dd-2fb039046fb8"), new Guid("54c7e887-a565-40e4-b155-01c1d1e35ce0"), "exampleURL" },
                    { new Guid("c4b19152-0281-4394-a92f-175638bcc6b5"), new Guid("e3db0135-4af6-4147-9d2f-189c9c4e3237"), "exampleURL" },
                    { new Guid("c8b339e9-37a2-4274-9c8a-f87e6d0ae296"), new Guid("cec02d24-5753-4ee2-a796-9201f9c4e8a9"), "exampleURL" },
                    { new Guid("ca3a4a3b-a387-41b1-ac45-b3f97e512108"), new Guid("1e6ea9d5-c9fa-40d9-a70f-de4ed5921ffc"), "exampleURL" },
                    { new Guid("cb7b16bd-00dc-4fa5-8977-bc4a69933f97"), new Guid("4fd2a202-51f8-4d15-8e8b-1ae38b7a3221"), "exampleURL" },
                    { new Guid("cd57d6de-0863-4f73-bb02-cee7430fdd68"), new Guid("ad9b50cc-13c5-4cfe-8b68-aaf6200b582b"), "exampleURL" },
                    { new Guid("cf4aab56-539a-423e-a22f-856f56c8b743"), new Guid("d3962cbd-14a2-428d-981f-ebc04fba2dfa"), "exampleURL" },
                    { new Guid("d08617e3-1dcd-402d-be01-ad250b8ee1ee"), new Guid("99db6b53-ccbc-4563-9391-9cde29ab5df8"), "exampleURL" },
                    { new Guid("d095827d-623b-4851-928f-7492d14f3ff2"), new Guid("4c43fc8b-d98b-48db-939c-379b2069aab8"), "exampleURL" },
                    { new Guid("d291bf14-8e50-4b6b-b570-88747caa95a3"), new Guid("74cedc61-d87d-48a5-b696-2f2e93d6650e"), "exampleURL" },
                    { new Guid("d3d2982b-3141-4af4-b428-a692ae483e5a"), new Guid("facbd615-080d-4b67-9c26-f31a453867ad"), "exampleURL" },
                    { new Guid("d43ab564-1294-4ed2-9767-e44b58c81694"), new Guid("a53b37aa-c327-4212-839e-44f93bb7f0e7"), "exampleURL" },
                    { new Guid("d64dbd6b-bfb5-4e85-843a-cc08b8baba7e"), new Guid("34690257-a3b5-4af2-aca4-726f382d5277"), "exampleURL" },
                    { new Guid("d6defe57-9fcc-409a-9322-92071bf0a64c"), new Guid("cf2bad0f-d79d-4895-a284-943ce4ab24dd"), "exampleURL" },
                    { new Guid("d7871e63-6b6e-4f43-b0be-848c0ae6b4ee"), new Guid("5475c6e7-1886-4e96-886e-cb7f47a662ac"), "exampleURL" },
                    { new Guid("d7b519d1-989d-4c91-aeb4-d70e9f7fdf61"), new Guid("65ffad7d-ad69-4896-9aae-f25a91d0cefb"), "exampleURL" },
                    { new Guid("d8289620-6f13-46fd-8772-3c8cd08376c7"), new Guid("5fc0d7e3-68af-412a-b1e0-9b1b1b93cafa"), "exampleURL" },
                    { new Guid("da96c813-490d-4b5a-859a-1091782e3299"), new Guid("4f09ad04-515d-4d2c-a70e-254f2bd20bd6"), "exampleURL" },
                    { new Guid("db81c843-83ea-469e-aca6-3e2766f2bd16"), new Guid("6a3ad84b-2366-43bd-a488-7f17d02bdd7c"), "exampleURL" },
                    { new Guid("dd42b05c-d46d-4e1c-b62f-7808f07d618b"), new Guid("894c7732-4f9b-4bc4-84e3-e005cd508c82"), "exampleURL" },
                    { new Guid("ddbe6254-9681-46c1-a0b7-ddad04d61f41"), new Guid("7ee8f37e-844b-4a3e-ace7-283fbd61c91b"), "exampleURL" },
                    { new Guid("e144fa36-cb8c-4794-ac40-f39ac6b0559a"), new Guid("241420bc-070b-438f-9340-a244ca068862"), "exampleURL" },
                    { new Guid("e1c882fa-0819-41a6-9893-67ac4dcdfba3"), new Guid("8e5d93fb-871d-4ab2-bdfe-bd0faa6c9fc8"), "exampleURL" },
                    { new Guid("e2781f54-94d4-4d2a-890d-bc38aa414439"), new Guid("85b5236e-e8e2-4a23-889b-60b109dfd241"), "exampleURL" },
                    { new Guid("e5238706-cc03-447a-ade8-a9c747808aa6"), new Guid("5699be17-9aa4-462f-b777-ed21f42559bf"), "exampleURL" },
                    { new Guid("e524d2af-506a-4273-89ae-de65471817a5"), new Guid("30ed66d3-616b-47c9-9757-67f448e1c3f3"), "exampleURL" },
                    { new Guid("e5356939-5ee3-4709-94e9-ac590550c5ee"), new Guid("e60aac2d-b301-4524-adb9-ee2f5fa3eebf"), "exampleURL" },
                    { new Guid("e5cb8da4-bd88-4801-9447-f161cfdf0c8a"), new Guid("2468ef9c-8a35-4bc5-882b-4d14acf95613"), "exampleURL" },
                    { new Guid("e66462e9-eddf-4740-812b-0ff08f8f0af9"), new Guid("d94a66d2-6855-4978-9dbd-12a2e888f421"), "exampleURL" },
                    { new Guid("e6965895-a484-4c32-b39b-973c9212d319"), new Guid("6e60eaa4-9cb0-45ae-b6ed-39f2c6b75b92"), "exampleURL" },
                    { new Guid("e72a45ba-e787-4fa7-a6d6-1211641db401"), new Guid("99c396f4-70cc-43f1-a136-351165ae25cf"), "exampleURL" },
                    { new Guid("e8efc4e0-6f79-46e3-902b-bbb87408a308"), new Guid("6cff8c5a-52ca-437f-9b1b-a8af3ed6ac18"), "exampleURL" },
                    { new Guid("ea5cdc49-4d80-45a2-9884-d56a9ce01075"), new Guid("054d5e58-6d26-40ed-818e-fb6b0b68768f"), "exampleURL" },
                    { new Guid("ec356d88-9f86-4740-ac74-a87456cb166a"), new Guid("187b4ead-57ba-4beb-8eec-877b288e7c07"), "exampleURL" },
                    { new Guid("ed6f08aa-f281-4911-88ce-e08e030e00e5"), new Guid("d7a25588-f662-4f8f-96ea-6e395c3e67a3"), "exampleURL" },
                    { new Guid("ee046098-6d5a-4d70-947e-c4c8bccd015b"), new Guid("71d3db00-b792-4541-a055-292fff17772d"), "exampleURL" },
                    { new Guid("eecf2360-1356-41fd-bf10-f651072bb117"), new Guid("afaa250c-015e-4cc1-b611-63caf3403ff3"), "exampleURL" },
                    { new Guid("ef15fb2f-8fee-43d5-a91e-b79cbe96135f"), new Guid("99bd093a-450a-4684-8990-363e6cbc0cd8"), "exampleURL" },
                    { new Guid("ef3a1e77-5c59-49ce-a582-dd092137bb9c"), new Guid("ef938356-1d47-4c61-b2b1-23912016e350"), "exampleURL" },
                    { new Guid("f19a9e85-6175-4db0-9739-c0fa356e8c4e"), new Guid("24aaffd1-4753-4275-9810-9dcf81367fa6"), "exampleURL" },
                    { new Guid("f1b58543-9d16-472e-9f57-0518bfc51a78"), new Guid("11fb547c-6e10-4940-b212-a5910858b7ac"), "exampleURL" },
                    { new Guid("f2664f15-1d8b-44ad-a50c-82f1700a9895"), new Guid("daff97d0-277a-479a-a0a5-9b11c36e5c79"), "exampleURL" },
                    { new Guid("f7693d9c-b303-436e-a64c-de128c22551d"), new Guid("7d2573f2-c4e7-48ae-9728-7e2ea5f9aab5"), "exampleURL" },
                    { new Guid("fa803f40-d5fb-49d6-b9ad-ed8c9c3bbfff"), new Guid("9e59b881-f29b-473f-b6b7-4aff92527b43"), "exampleURL" },
                    { new Guid("fbb823e1-72d7-4eb4-a13e-7c88700f67e0"), new Guid("2d863096-f7be-43aa-868a-847e7f33b05a"), "exampleURL" },
                    { new Guid("fdf629df-651a-45f8-87fc-63ae46e3e038"), new Guid("40633568-2094-4b04-b80b-783e11f5bfcc"), "exampleURL" },
                    { new Guid("fe8f742c-7ea5-4a69-8490-907df93be54f"), new Guid("03cf4d47-e8e4-40ac-b968-d0ebbc054b14"), "exampleURL" },
                    { new Guid("fef9c361-79bb-44f7-85af-a63c1f264144"), new Guid("f42fddf1-2a06-4024-97e6-b07c29cce80e"), "exampleURL" },
                    { new Guid("ffcdd76d-94b1-44c4-903e-576e71da8f6a"), new Guid("0b169ecc-c733-44f5-815d-cb89468bab7e"), "exampleURL" },
                    { new Guid("ffce2bad-7859-4d8d-bdac-597a3d5ac0e2"), new Guid("1db9591e-337f-4472-ada4-36375d08fe70"), "exampleURL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("155fa1ae-0b53-45d0-adc9-9f3d8e6e24da"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("27f85bfe-c39f-4da3-925d-55f7d6e5c6ca"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("295cc5ac-9ded-499d-a207-91286f27f9bb"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("301631fb-ad8f-4eb2-9034-4eb2ce197128"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("3ba331f5-fe28-43f0-b626-e21f8f4816f2"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("52729316-80a5-4420-85be-d56f4e307987"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("59d2fc89-6d2a-4b82-9542-90e31e360779"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("5c029ddf-e980-4aaf-a281-28d30a1bc077"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("6dca929a-3583-4a9f-86fa-86ff044773c0"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("769ab22f-56bb-4409-8835-d06a2999faf5"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("7ae5847a-3fc0-4a8e-bf67-f6f0557fae1f"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("9479a6d7-d17c-448a-9f79-c331e34457b0"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("9850a93b-4490-4c11-a16e-00208fd0b8ce"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("a96d2a19-4773-440b-b29e-2e80425a4d68"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("af1f005e-3b2e-4967-bb68-ffab9170e583"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("c80269cd-ee0b-46cf-aa87-892dba1f00f2"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("d8f53baa-a9f9-452e-8308-ef23c41dcdf8"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("ed76c882-6ca7-4753-8554-f0e467d2226e"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("f4f3bd1e-6c9a-4d6f-8c07-70dc94083d3d"));

            migrationBuilder.DeleteData(
                table: "AccountCredentials",
                keyColumn: "Id",
                keyValue: new Guid("f9efc636-71fe-4a2a-8476-da2bb9028088"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("001697df-4eae-48bd-bd44-26d1abf34d7c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("004c2955-3493-4a22-98d1-6be31391d61d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("01319f6d-2511-4c17-a6c9-d05d9c4c1399"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0255e954-34db-4f71-9964-86c6b9f0ed53"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("02af12ef-f537-4dcc-87ee-29d6e4035c52"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("05c28c8b-2854-4613-8b03-81452922baf9"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0682ab46-ef89-42e1-a91d-fb8f102e292c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("06e54fb3-212f-47ae-aada-3a684a3e935c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("076d0445-7984-4642-b29e-544c052e2fa0"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0a2ae94e-09ea-4ef1-bb5f-a59e889453cd"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0b482b54-4ae5-42e8-9e97-cb1cebec0dc9"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0b932d44-a7e8-44d6-b905-03ffa7667cc0"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0d50c29e-e6fa-4652-bea1-73bb55e04f31"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0edf1343-cd51-49c0-82d7-93c483890184"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0f09b410-6224-4c69-86f2-a1621433892f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("0f297aa0-7022-42c1-9b15-14b50d5f0338"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("107c0f80-fb78-4c3a-bdda-32b1e8c65fc2"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("10f24c07-05da-4b95-8b7a-b8fa4de0070b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("127c3db5-92b4-4344-8352-04c9a0ffb31d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("134b5af1-bcee-46d9-951c-5fae83df9baf"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("1414b500-eb0e-4c4a-9d40-2570e1661a86"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("14b84bb4-d97d-48fb-b731-6b2d562df72b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("14f82ebf-f9ce-4473-bde1-f9479ff5dc60"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("15ff3873-f3f4-4079-8dbd-a590251d985b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("1779eab1-c010-4d30-9e78-c5daad68128e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("17e713fa-1045-408d-8c30-fa1dcf359187"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("19201ccb-4aa3-416c-bd39-877a790ff290"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("1bad3b1e-c8ac-4135-ac14-0e7ad6ebe4d9"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("1ca97123-7913-40b5-898e-d80894ca192c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("206423ea-8b41-49df-a76a-5d27679850f6"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("20d18640-5b14-4428-8ef9-1d549d574afc"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("20dbe35a-77ac-4268-8648-56cb9ee04fd8"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2120b0da-db3f-432c-9405-9fbbf6ef98cc"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("222ef9a2-a071-4a36-bf87-63e085bf2785"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2234e197-a12b-40cb-bf83-8df9ae264f52"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2272bb2d-a52c-479b-85c5-06377a85e963"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("22dea70a-ccb4-4a11-9ad2-9d7fa4a752c5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("290e60c8-8df6-40c2-870b-6a373ae05f3b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2ae131e2-89da-414d-8724-a06382b7cda8"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2bb7de2a-4cd0-4782-b4de-5bd466e5cf31"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2c99bb6c-a209-4a3d-ad62-357c8214be6e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2ebc9f33-4758-40a0-8310-988558e53fcd"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2fb61860-0826-4e01-a032-9d00d10197de"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("2fc2dbdf-feed-4b27-a868-8f4b09a7f066"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("3229a966-d6ba-4920-ba7c-af9702a677c8"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("33d994fc-24ff-4005-a0a0-c46b04bbddbf"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("35672b9b-724a-42a8-8cb0-440d522890b2"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("36770267-841f-4992-a824-e307dd9f7d5e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("36c30d41-53b9-452c-b98c-401c35b83856"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("380a68b7-e2b3-4b83-a1e2-86361c73751d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("398b71c8-e0f9-4fd6-a768-16e4ae72f7ff"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("3a495fd9-36ff-413a-917c-238f6d853994"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("3ae3bacf-7d0a-489c-8dd1-6fee21e941c5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("3b865bdd-538c-435b-9191-c368df106bc1"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("3c45539a-87bf-46d6-ab47-16bf538ece8b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("3e8ae3bd-bd35-410a-945d-3104235078bb"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("4012b93e-7549-46c3-8fb0-3dfdcbfa408d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("428e8c60-bbdf-49ed-a647-a9767548c2ba"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("42b00296-beac-400a-ba4c-589dcaa2096a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("4580c40c-31da-4909-bf5c-18d1c35f372e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("460a6405-418f-48d6-a1db-80866e57dcaa"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("46cba471-a36f-497e-8cb5-26cc0e99f949"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("476c6dc7-d736-4778-b430-53c5b7fd332a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("4c56e3fe-ae5d-4f37-8023-6ce95a3a4d4c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("4d55d907-b013-4957-b116-b6cbc28b8efa"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("509b247d-3ec7-4a9b-b39b-5d4c95ac48a4"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("522e1c37-2715-4c7b-b673-3ffee6e5ec2c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("52e98903-27b5-4855-ae9c-af1547455b2e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("53957929-3ff2-4db7-a45e-fd0ea4a6e4ed"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("55bbb989-5261-41ed-bc78-2e6622117abe"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("56c11cd6-70e5-4769-8ee8-a4ede1a3f93f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5813d236-7441-4999-9fb4-793a149eca06"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("594c8a5d-27d2-4dff-9117-d814eed8e4c5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5a3ed195-218f-4c9a-aae4-823bc49e79be"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5ae06ad8-d393-4392-a14e-3bb962003eeb"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5b0f2dc0-e9d2-418b-abe3-b6605221a656"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5b72d179-e994-4a94-9199-18e33d6852b7"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5def41ba-b2ad-4694-9ad0-86cebc04fa46"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5e01f09a-54f8-4c73-8489-e9ad13afe0ca"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5f31a4a4-a3da-4922-8cef-ba94ee11aa35"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5f3b9ffc-161a-45e6-b2c8-94ad8f7cb4d7"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("5ff32236-4586-4a09-a510-b1608d14e813"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("62c3aef5-7d0f-458c-8667-32a081952e02"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("62c6b687-7e8c-4395-8c05-721fb59d6994"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("668635ee-dbd6-43a4-9709-b1b7661ab18d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("66f7bcfa-1f87-45cb-90e2-f3aa4db6fc24"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("681b84f8-de7f-461b-a040-2bde60fb95a7"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("686286f0-7868-43d7-ad64-021b2106f2cf"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6909a623-ce6f-45b6-ac98-422eb39fae9b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6adffb3a-af4c-445f-827c-762689c878b0"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6b755ddc-37b5-43a9-9fdd-493f1235bb78"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6bad0be9-6f9b-45b8-9b4d-16b4eb521a2b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6baf8dc6-43f8-44a3-a927-31c657fe0d64"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6ccb37db-4c31-40d1-8346-345a9ca5f1a4"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("6cd1c674-594a-4e57-98b2-ace55bb1baee"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("70532582-94c1-498f-acf8-16ab4697a832"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("724c222e-ab17-4b7d-acfe-feb7185afdd1"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("72ab5887-07d8-4bba-a80c-2467645cbc4c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("740a528f-c2da-4f18-b219-14716140f149"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("748d90f8-66b8-4a09-9853-f887f65e2685"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("7710f6c2-9278-4c30-b754-8015ea54cc7b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("7b67ac0e-51a2-4015-bb34-810590ea5c1d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("80d19a74-fffa-45f3-a658-6a8f2a2caf01"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("80f3dca4-2603-437a-b159-84a6bc3393e9"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("85b9ffb1-4260-45d1-8799-382b555df944"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8651adb1-14e9-44b0-a465-d8c73b855050"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("873ed291-639d-41ad-8583-49e7a319702f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("88abfca0-1883-4505-94c9-829ffab8c61c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("88bd87e9-1c8a-4ade-a4c5-c9bf7525a6bc"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8aea7b5d-4256-444c-b08b-41b0c214f92b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8b19c96d-c4be-44af-b726-9aff62b66733"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8b1d69fb-a1df-4782-90f7-417f4989595f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8b3ba516-9682-4c91-a27d-4dcdb39c51ca"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8bd0b135-331a-4f7e-9fd5-2c041a2cd7a5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("8e0ae865-b7ae-4c25-9918-f07880d2ff28"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("92eaaa38-f140-4718-b02b-0d7531685bd4"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("9310a847-fc5d-4dc0-b472-35e5d10d9687"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("933b5d66-3c27-4182-bea5-d4023b57b222"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("962c021d-a820-49a8-9cdd-7108d30fc74a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("998ddacd-fb40-4adc-8a9f-a56fa2790eaf"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("9ae99248-c3a7-4d75-a27b-57c138fc9d72"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("9c396bf0-60dd-4c96-bbe0-fe3534ec513f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("9c7b20dc-c671-4fb8-b840-280813023312"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("9d88be57-22b2-4a8c-9744-6aada8140ba7"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a0e7cca8-6206-464f-b02f-ab8fe5d50db2"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a32dd15e-8a0f-4cfa-a871-aa0b8c40826e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a4ab4265-18d1-497d-9e95-ae8dbd413a7e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a4b71a05-93f7-4a38-afe9-7362f4e86771"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a6f02338-6b29-4b58-8cc2-dc82423568f4"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a8848a9a-bea8-472d-8fd7-fe2022e2e95d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a9c4336c-b1d8-4d91-a99b-5d16b8873716"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("a9f7f150-e843-4a99-8481-c3865fc8f036"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ab95a35c-8eae-43d8-afe4-fc5bb1cc36a8"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ac2aa550-9790-492b-bf72-42ed6ef5866f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ae565097-2791-49d5-b362-c21b6c195ffd"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b02f41ad-99fa-4358-ac10-0b28a4338369"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b0750032-7199-4f28-862b-d152c657ae57"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b0ccd790-76d2-4c26-94e0-9d9ad6d5ab15"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b2bbb6c7-d556-47e5-9f89-c73333e314ec"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b34c4798-abf3-4cee-a02c-9cc6d605fc33"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b501f2a6-1a90-43f6-a3f0-7bcfd1247f79"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b6b1965a-b53c-44ca-89e9-f77a012f0305"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b6d07cab-8167-409b-9fd4-da30035ef921"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b81f0c15-87fa-4ed5-b9db-4320ad4210b1"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("b8c1ee44-726d-42d1-a185-01b5003f1fdf"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("babcb74e-073a-4273-a696-4069919b2417"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("baf9acd1-bee6-4ad2-ae30-32bd0c8b412a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("bdfe9e88-75d0-4df7-9d33-6c409d62dd92"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("c0cd8637-0f2e-4fbe-9985-33f62ae396dc"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("c1d5df3d-bd51-4431-a06f-f99a5e856a37"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("c30bdb39-4fb1-4fc8-90dd-2fb039046fb8"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("c4b19152-0281-4394-a92f-175638bcc6b5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("c8b339e9-37a2-4274-9c8a-f87e6d0ae296"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ca3a4a3b-a387-41b1-ac45-b3f97e512108"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("cb7b16bd-00dc-4fa5-8977-bc4a69933f97"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("cd57d6de-0863-4f73-bb02-cee7430fdd68"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("cf4aab56-539a-423e-a22f-856f56c8b743"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d08617e3-1dcd-402d-be01-ad250b8ee1ee"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d095827d-623b-4851-928f-7492d14f3ff2"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d291bf14-8e50-4b6b-b570-88747caa95a3"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d3d2982b-3141-4af4-b428-a692ae483e5a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d43ab564-1294-4ed2-9767-e44b58c81694"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d64dbd6b-bfb5-4e85-843a-cc08b8baba7e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d6defe57-9fcc-409a-9322-92071bf0a64c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d7871e63-6b6e-4f43-b0be-848c0ae6b4ee"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d7b519d1-989d-4c91-aeb4-d70e9f7fdf61"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("d8289620-6f13-46fd-8772-3c8cd08376c7"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("da96c813-490d-4b5a-859a-1091782e3299"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("db81c843-83ea-469e-aca6-3e2766f2bd16"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("dd42b05c-d46d-4e1c-b62f-7808f07d618b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ddbe6254-9681-46c1-a0b7-ddad04d61f41"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e144fa36-cb8c-4794-ac40-f39ac6b0559a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e1c882fa-0819-41a6-9893-67ac4dcdfba3"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e2781f54-94d4-4d2a-890d-bc38aa414439"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e5238706-cc03-447a-ade8-a9c747808aa6"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e524d2af-506a-4273-89ae-de65471817a5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e5356939-5ee3-4709-94e9-ac590550c5ee"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e5cb8da4-bd88-4801-9447-f161cfdf0c8a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e66462e9-eddf-4740-812b-0ff08f8f0af9"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e6965895-a484-4c32-b39b-973c9212d319"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e72a45ba-e787-4fa7-a6d6-1211641db401"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("e8efc4e0-6f79-46e3-902b-bbb87408a308"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ea5cdc49-4d80-45a2-9884-d56a9ce01075"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ec356d88-9f86-4740-ac74-a87456cb166a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ed6f08aa-f281-4911-88ce-e08e030e00e5"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ee046098-6d5a-4d70-947e-c4c8bccd015b"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("eecf2360-1356-41fd-bf10-f651072bb117"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ef15fb2f-8fee-43d5-a91e-b79cbe96135f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ef3a1e77-5c59-49ce-a582-dd092137bb9c"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("f19a9e85-6175-4db0-9739-c0fa356e8c4e"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("f1b58543-9d16-472e-9f57-0518bfc51a78"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("f2664f15-1d8b-44ad-a50c-82f1700a9895"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("f7693d9c-b303-436e-a64c-de128c22551d"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("fa803f40-d5fb-49d6-b9ad-ed8c9c3bbfff"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("fbb823e1-72d7-4eb4-a13e-7c88700f67e0"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("fdf629df-651a-45f8-87fc-63ae46e3e038"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("fe8f742c-7ea5-4a69-8490-907df93be54f"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("fef9c361-79bb-44f7-85af-a63c1f264144"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ffcdd76d-94b1-44c4-903e-576e71da8f6a"));

            migrationBuilder.DeleteData(
                table: "ItemsImages",
                keyColumn: "Id",
                keyValue: new Guid("ffce2bad-7859-4d8d-bdac-597a3d5ac0e2"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("02d5a6b0-cce7-4d43-b8b3-de125131e8aa"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("04b3dc02-ef57-48d8-9337-5c8003c9dd1c"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("0d0a5e60-b031-48ab-a98a-00decb8352c8"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("1d142a64-be4b-4208-b1cf-b585290fe888"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("27f2d91f-4140-4d07-8d7e-51d578298e1b"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("3304a52d-ddc9-4668-9001-acbd92ee1bcc"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("3461448b-1bae-47b9-be1c-f9dc5727f23f"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("34b48aab-2fc1-4fce-a7a6-62f93b1ff44e"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("37a94cbc-eca1-4347-8a02-eb4b917d0d64"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("4606d514-e5d9-421d-8ef9-2e304204ef64"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("46a6c1b2-5b80-4f63-8b7e-ea9d37d351c8"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("4e3c670e-4042-408f-8b53-57b2b19f6ce4"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("51add0cd-9fd5-4956-93ab-b6fc11931a9c"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("55fa02d4-2fd4-4a89-8823-d43ba77aa64d"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("5b6c483f-f246-4a35-afb2-0213ca183368"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("61abf25c-5e82-4de5-aac9-cf4737a656dd"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("71766b4c-d847-4313-975f-5d2eb7668d93"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("7336de67-5fb4-43f8-a6b6-75f55e9ac1b0"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("75bd5bf7-330b-4baa-a36d-f1509e809f3a"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("764bd87c-5389-4dbf-9f68-cfe0b1da18c0"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("7bfebc06-a280-42fe-8a29-f036a5c410a7"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("7c623e59-dae2-48b4-b0d8-a8acee3f45b3"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("7d8a7508-35d8-43c2-8fd3-d43cf66ff43c"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("7da007ee-78db-40cd-8426-0c3a51f001d2"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("86761054-01be-45ef-8e04-2a2ad0fae5b3"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("923d02bd-6d94-47c8-9a00-1375ec02f381"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("9992d6b1-5d4b-493b-b967-0bb5f1fa1eec"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("9f9fe259-ad70-4031-9375-4cecd40b74ee"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("a20e740a-960f-4979-ab21-d6bed3408486"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("ada2e54d-c7da-4a70-97b5-9ad6028b466b"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("bebf2216-8ccf-402b-a27e-552b5db4d0dd"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("c54709ce-6c27-4d07-a33c-c780633aac6c"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("caee0205-d5d4-462f-94ce-aa1a21372f5c"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("cf5adb35-f3d3-4f5d-b552-4ae35bf6a389"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("cf99b06a-4ceb-47d9-8180-21ccc3b93298"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("d37a60f9-39e8-4b29-be40-8f1fb3f0138f"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("d8ed9c41-be8a-46a9-9505-59fc1496db47"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("e365add5-5f9d-49d9-aa7e-509e8ee7ed67"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("f11f4f1c-8b32-4eb0-88d7-7456110648ed"));

            migrationBuilder.DeleteData(
                table: "OutfitImages",
                keyColumn: "Id",
                keyValue: new Guid("f9a7c868-1b80-4d8a-88d1-38200f077f5f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("00778d03-a5d3-4dc1-9c15-494d7a2f6168"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("02a688aa-87a3-4936-961a-0f9300ebb8d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("03c5dbb8-de31-4996-b456-5d540580ae0f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("03cf4d47-e8e4-40ac-b968-d0ebbc054b14"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("054d5e58-6d26-40ed-818e-fb6b0b68768f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("05f4c23e-6f3e-47d9-a6e3-c75dc9436298"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("07c7d000-d2fd-4955-908b-e4bee93a4d36"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0b169ecc-c733-44f5-815d-cb89468bab7e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0b803689-2aec-40c8-af8f-c49d6b5aa76f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0c476002-2366-43d6-8f03-c2fe2c094c08"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0debaa72-63ff-4c8f-9d7a-994b027604e4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0e08b8f2-c013-468c-ac31-e24d1ccc0460"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("0eaeb816-97cb-4f63-92a6-6e77ffe2aa6d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("11fb547c-6e10-4940-b212-a5910858b7ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1264461d-9b05-4193-b60d-b02b790126ed"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("12bef15f-6710-4600-9aa6-6e85ec3d390a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("156b1fc2-3a71-4b96-bc30-294939143319"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("187b4ead-57ba-4beb-8eec-877b288e7c07"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1b60de2f-7716-4ae2-bb0c-e476947f90f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1bfe6338-dc16-4678-a7b7-8bd09bba9e6a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1d07a254-a01c-457a-811c-1540bba98fbf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1db9591e-337f-4472-ada4-36375d08fe70"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("1e6ea9d5-c9fa-40d9-a70f-de4ed5921ffc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("222d35c8-5507-4b79-a4b7-c6b1e5e824b8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("241420bc-070b-438f-9340-a244ca068862"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2468ef9c-8a35-4bc5-882b-4d14acf95613"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("24aaffd1-4753-4275-9810-9dcf81367fa6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("26f7d4a1-10d2-498c-8f67-4ba2222cde7e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("28a0297b-4c90-4a8b-8908-03a9dd29252d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("29b7abe0-91d4-473f-87a4-e7eee3da1aee"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2bae35e8-ca96-4d13-a9cb-1f48b15843a9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2c991a76-d5cb-4fa7-a274-74cd25ca8590"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2ce7ed07-bea3-4f77-9465-48a2d61927a0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2d863096-f7be-43aa-868a-847e7f33b05a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("2da1b8c4-d35d-413c-a48a-781b41bfb464"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("30ed66d3-616b-47c9-9757-67f448e1c3f3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("34690257-a3b5-4af2-aca4-726f382d5277"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("35015e89-e81c-477f-b995-bd458287b4a3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3567103a-2ae1-4985-957a-b6a3fc2a08b2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3c472af2-537d-4d45-97cf-2207ecc64b86"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3ca19678-2df0-4317-8ed0-10ca31c879d6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3d732b2e-ba2f-4ff9-b65a-21ea0fec042a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3d958d0b-4364-4ab0-b87b-0188c083ab3a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3ed71070-5842-4eb4-8d9f-0a7f9ae7873a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("3fbd628c-13a8-4ada-a6f0-3d74fee87d5e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4020e2a0-063f-4c31-b259-4921f8648a10"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("40633568-2094-4b04-b80b-783e11f5bfcc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("409f793a-0529-4a5e-aa53-8f1d88958472"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("41e1217d-1d86-479b-89c7-9d909de52c8d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("42ead622-959d-47d0-bf34-0d5eb11eb35f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("44ec7960-018f-4271-bcd7-0cf59bfe30b9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("45bcdd43-1462-40d7-9901-4724b04ed448"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("46d70f34-5f16-4399-b07f-0eea067a55f6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4b91589a-5041-4e62-979e-ddc395aa0df7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4bb04e80-489e-4783-8ce9-7ab34faf3b4b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4c43fc8b-d98b-48db-939c-379b2069aab8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4cb397c8-db37-4463-9707-12a44018e66f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4cbaceb8-1883-440b-a860-2b4d6a9de99f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4e845077-5330-43c6-aea0-2080f79da76b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4f09ad04-515d-4d2c-a70e-254f2bd20bd6"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("4fd2a202-51f8-4d15-8e8b-1ae38b7a3221"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5095c7c3-aa87-404a-ae25-f364ad170aba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("519c1ee5-aa98-480a-9bb4-b99a99149dd4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5475c6e7-1886-4e96-886e-cb7f47a662ac"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("547e0856-8ee8-4839-afce-12f698ca79d1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("54895ee0-3209-49f9-a92f-ba1b1b60fda9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("54c7e887-a565-40e4-b155-01c1d1e35ce0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55f1a543-ce91-4a5e-8676-60ab1b275a5b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("55fc0a2b-8cf8-497b-847d-8af5e5030cb8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5699be17-9aa4-462f-b777-ed21f42559bf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5857adb4-a109-4d85-b9bf-fe8bce9a9b90"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("585e6ce6-f69c-454c-894b-36909a4ebcd0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("59143f1d-bfee-4eac-a84f-e1f24bd0ab93"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5bea49a8-b860-4d29-8006-eb61e77fdb32"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5cdd0a7b-f59c-4afc-854e-9bd187c62b0d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5d17f433-2975-4057-8785-5c4a77f7f578"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5fc0d7e3-68af-412a-b1e0-9b1b1b93cafa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("5ff8eaea-b219-40fc-b0c4-60dbbc5397e9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6226a895-72b6-43fd-a6f1-6de0ad421d37"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("634c877f-2ae5-48a6-814b-ec1cca7bf2a0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("64cbb93d-531e-47a9-8bd2-7b84e99fa123"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("65f52df2-0ce3-4d02-a16b-4e1436fd2cd4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("65ffad7d-ad69-4896-9aae-f25a91d0cefb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("688c6c39-4fbf-490f-9b74-781507d85a56"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6a3ad84b-2366-43bd-a488-7f17d02bdd7c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6b27df34-68e4-4c6c-9ce5-f28fe0787e0a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6cff8c5a-52ca-437f-9b1b-a8af3ed6ac18"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6e60eaa4-9cb0-45ae-b6ed-39f2c6b75b92"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("6f13f4e9-7afa-43a1-9f3f-6c9496f7da62"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("71d3db00-b792-4541-a055-292fff17772d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("72aab350-aedb-4a47-82da-6d649bdd9cae"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7480bd0f-6992-4294-b125-194df06aaa43"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("74cedc61-d87d-48a5-b696-2f2e93d6650e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("75155e46-314b-4551-9d14-8d08496dc04d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("757abbb1-2cad-43e8-a9bb-7ed9c2ea48a0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("76347fb3-1605-4427-9c6b-dbd046b7ae4e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("76e163ed-dc5d-42f5-9dc2-7df1bdff157a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7d2573f2-c4e7-48ae-9728-7e2ea5f9aab5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7e8903f0-42c1-4b2c-bca0-715e7f6161f2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("7ee8f37e-844b-4a3e-ace7-283fbd61c91b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("819a0c98-7e8f-4b67-addb-3a98630953ba"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8345043c-e36c-439c-948a-faf088ffe524"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("853c686a-528d-42c7-a3c9-4234babbc927"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("85b5236e-e8e2-4a23-889b-60b109dfd241"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("861b022b-0982-4d41-a754-cd414c3becb0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("868f5b2f-ed2c-47ed-96e1-a15ece5bd5dc"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("894c7732-4f9b-4bc4-84e3-e005cd508c82"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8bfdac3f-67d1-4eb9-9034-f45c6a5cf268"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8e5d93fb-871d-4ab2-bdfe-bd0faa6c9fc8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8f7e1e31-3947-4f15-9e7d-2f027eb4f4d2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("8fe86803-fdf4-460a-9356-6f2cd5f36bbf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("909eb667-5f50-4a53-a1cc-bae3a8591470"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("91368efc-5a09-43fd-89aa-a1cda0a078ad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("94de810a-c6e0-40ce-a395-dc9349ec85c2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("99bd093a-450a-4684-8990-363e6cbc0cd8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("99c396f4-70cc-43f1-a136-351165ae25cf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("99db6b53-ccbc-4563-9391-9cde29ab5df8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9ab5084b-353d-4cfc-8552-72c5ab1fa270"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9af880e6-03d8-4ce7-9fb4-14b6ae95b89f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c705147-d49b-4ddb-a6d2-d3ad06c9b4bd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9c90aae0-3590-43dc-b668-6f69c58815a2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9d41ee95-ea5c-4e40-bc6d-aac1e73732a1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9e0e4f1d-b097-4dd0-bd7f-0a20be10d5f1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9e59b881-f29b-473f-b6b7-4aff92527b43"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("9ff4a28b-b193-4dd4-b45b-f192052290a4"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a28e65b7-7c59-436c-9c7d-8ee873389642"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a3142969-b637-4ed7-afa3-8438a7ba656e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("a53b37aa-c327-4212-839e-44f93bb7f0e7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ab285601-5cd8-4b90-bab2-c332f240e381"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ab849233-7892-46ab-9703-ff0c8d1f2974"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ad9b50cc-13c5-4cfe-8b68-aaf6200b582b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("adbc276c-5509-4c35-8297-39df9d8e7343"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ae16ca67-547e-42a3-aec0-98491d4d8586"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("af0741ea-bec9-4f3b-be93-929e9dca908c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("afaa250c-015e-4cc1-b611-63caf3403ff3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b0347f0a-520c-4c3c-a645-c241f2a7fd6e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b32b2049-74e2-41d0-8652-ed4d6b5cca91"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b5b286a6-5a75-485e-a598-6fd0ce8d1c82"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b617d365-3075-4ba0-99b9-98f7099c130d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b77918b5-79bf-4aeb-972b-8c4fc3cefa51"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("b9567382-5dce-4c23-850f-61d4dc1c7d47"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba27a51b-54e0-4c26-a6dc-1d5efa341472"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ba9dc1f3-1d8b-4329-991f-8cf74bb0ede1"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bb756bc4-5a9f-4122-9aea-7084e1da6cf9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bbc7d760-0b26-4e3e-b6d6-d3160f5cadf8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bc2616ca-df88-40df-9f97-5be37851721e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("bc3410f8-b1c0-4216-b5ab-9d0652dfe815"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c1ceb2ba-d28d-434c-9985-88263611f7d8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c3ba6f81-3531-482a-8eb5-f2f7c702c4fb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c50ccadc-f0da-46a3-9135-0c50cc569d70"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c518ac8d-d5c1-47ed-b3e7-615ff32fbba2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c6a9c21d-cd21-404b-a3d7-c08a969c9c22"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c7808f9e-d689-40c9-a1ae-51b5011782f7"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("c87adf7d-6a88-47c6-80ac-636ec63feeb8"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cec02d24-5753-4ee2-a796-9201f9c4e8a9"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cf03693a-b255-4466-b4a9-202e865bf155"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("cf2bad0f-d79d-4895-a284-943ce4ab24dd"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d114b512-c331-4637-bb9b-032eb4318bad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d2042124-db07-4e6a-8c91-8a64a449fc9d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d2f78bf6-8f80-41fc-ae12-cad995c837f2"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d3962cbd-14a2-428d-981f-ebc04fba2dfa"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d4bc36ab-4625-4d38-8397-7834ab6c752e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d790f50b-ae34-46be-b185-ff79b6688246"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d7a25588-f662-4f8f-96ea-6e395c3e67a3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("d94a66d2-6855-4978-9dbd-12a2e888f421"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("daefcb9a-ea57-46cb-a507-1136ecfc0e18"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("daff97d0-277a-479a-a0a5-9b11c36e5c79"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dafff492-84c9-4bd0-89c4-cfa33c236327"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("db4eafbb-d276-4247-99d3-9401e2d6c971"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("de4c9b91-b78a-4289-ac53-91669411e912"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("dfff82db-b65f-4ce0-acb5-387f484151f5"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e10bb9e1-fb6d-4e18-b25d-e3dee5884cca"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e1ef810a-3bb1-443e-b5d9-658b5a55986f"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e279117e-c82d-40f9-bff7-4aba42959e09"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e3db0135-4af6-4147-9d2f-189c9c4e3237"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e5d08930-1544-4a6b-bb34-b57702687ecb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e60aac2d-b301-4524-adb9-ee2f5fa3eebf"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("e9678ce9-59d3-4f1d-a2be-14c41d8bbb7d"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ed196e3c-9deb-4691-830a-c3f67eaea551"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ed758526-010f-48d5-94d5-679d61fa8297"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef8316fa-3a3f-40a7-988d-80c4d8aeaf52"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef938356-1d47-4c61-b2b1-23912016e350"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("ef9551d8-a75f-409a-82c7-2705d3ad6ec3"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f164bcd9-cbbc-4e61-bb70-60c85939160e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f390d10c-c190-4b9c-86d6-b4297386538b"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f42fddf1-2a06-4024-97e6-b07c29cce80e"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f5e848c3-15fb-4812-ac4a-86827b0b02ef"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f7d0bb4d-cb34-4778-9116-e4fed6b0efab"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f8a0c92c-bb09-4bc0-b461-a51540d5804c"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f8e63c16-1005-4a34-aca2-442f7a9b7262"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f953eaf8-c4e4-4657-87f6-17cfa8c59b54"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("f9c74c32-1add-462b-bfa1-aa20e7410dfb"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fa03433e-cb00-495c-a0d9-6dfd5cd3b56a"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fa1cfc26-f202-46ef-8cb5-e13a11c15850"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fa70e99e-880c-49c8-88f4-d4176f1f57f0"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("facbd615-080d-4b67-9c26-f31a453867ad"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fcfabc14-83eb-4aea-9241-a4a29ba64886"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fd2b36e8-07f5-403e-95f9-b05f12cbc118"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe5303e3-5095-4529-b9e9-a7b646485385"));

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: new Guid("fe538925-ca53-4d58-9c7e-d9183bcdbdb1"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("05360092-92d3-4c8c-af00-e81ef12ba4ec"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("0a8a81d7-114e-4b21-857b-93acf6afb949"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("0c1cd940-3258-4fe4-9b0b-32b768b5f048"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("12540349-521d-41f5-b31c-ed6cc32570c3"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("12fcdb71-d091-4ae8-9128-5693a371f0af"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("1eb089c4-76fa-43dd-9a99-4d5fabb9598a"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("2128b55f-dd9b-4ba4-905c-f7994f5b42d2"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("25d17622-3ff0-4fea-b609-672bf1bef46e"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("2f6dbdcc-c1bf-482e-86df-81fa69b70e20"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("3d3a94bf-76f4-461a-ab60-194942fc7a71"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("543941b2-329d-44cc-a53d-5734f82e6971"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("55f813ca-616d-4547-9b4a-7d753d373579"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("57493cc6-b145-4905-8031-f687ebe028e3"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("58e198f5-395e-4eba-89b0-dd5fc9d78cab"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("60cb7a4d-e26d-48f9-8aa2-fb0c1cd3e57f"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("87b8f4c5-5f63-445c-870e-9bc2acf34391"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("8e33c9ef-e92e-4907-8f86-36448a2a4b34"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("92c4309d-4d7f-4643-89fa-7e1524c92b98"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("971ae71b-73f6-450c-b8cf-f16f7a393211"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("99a1b56d-da00-4612-bf5b-ca3834e1d569"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("9a60abdf-f023-4636-88ff-4b54248b4f20"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("9c9a0760-30f0-431e-86b4-ede9e1e44855"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("a5d14959-b4f6-487a-b187-45fa39352088"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("a7d8c1d7-73fa-4061-8ca0-9d249aefa53b"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("acf32c5a-3a1b-482a-8d8d-faefe6fbed9b"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("b195beef-0e6f-4f40-a4d5-2a3e599a1267"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("b30af038-0408-4957-92ad-f6f30b184970"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("b858c402-4e09-4240-b900-0b3adf001316"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("b898165c-6560-43a0-a301-d861078aac86"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("bb2cb682-30ac-4a39-a6da-f43940456dd4"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("c4c92877-79c4-410d-9a3f-54d5ee9c2c48"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("c859fb4a-d8e1-4de0-b8bb-0a0feddbd178"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("c9509c8d-564f-4f98-84b4-6e57fe8de2ac"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("ccd494df-bdff-485c-bff5-357d954d1ece"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("db79cd1e-94ca-40ba-a62b-c00d2841ab77"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("e1f6b8f7-7322-43e5-b091-da0924ad7fb0"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("e6d63fad-e5b7-4fb2-8c8b-3d25dfa20ac7"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("e807a2fc-b75a-45d1-96a2-10e7384edb23"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("ea1fcd92-0600-4307-a0f0-046ae1df9ba2"));

            migrationBuilder.DeleteData(
                table: "Outfits",
                keyColumn: "Id",
                keyValue: new Guid("ee2358b2-fced-426e-9975-7b697808400a"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("0a7ee7f6-34e3-4d74-9423-6c7d7bd046b6"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("14c9d812-b906-4de8-9b5b-844815174fd2"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("20b18b62-94bf-43f3-afd4-8db7fb0a199a"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("36455683-5660-422a-bfd9-6d9f3502713c"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("39f2a8ae-43e1-40d4-88a8-537692b9e13f"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("3cd2d327-c067-4913-a2c9-35358b1696f6"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("3f78d36f-ba96-48e3-8e80-734c79129f9c"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("68f43374-99cc-4ed2-be5a-33f0491d1822"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("771dfec7-8b6b-43c1-aef0-c60d446877a7"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("799439b3-5855-4178-b870-69d2f930cb2e"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("8765cb86-4dfb-43fc-a697-225048c4b6bc"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("8cdec795-ef5d-4947-af74-a4843b31b72b"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("9222ba23-30aa-496b-b3ba-751a768e4d57"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("9604ce6d-9b75-4646-8c7f-c5fa5a520ed1"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("a7f906c8-987d-49c4-a548-76d975f2da7d"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("a9de2401-21d5-42dd-ba02-97d0ab357f47"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("c7de371c-fc32-4649-9435-459d2ca87b57"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("cb385ca8-c333-49f9-9e1e-3b55b6089c8d"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("dc7697e7-3624-4ed1-a2bd-fcd5c327bae1"));

            migrationBuilder.DeleteData(
                table: "Wardrobes",
                keyColumn: "Id",
                keyValue: new Guid("e7fd1fcb-b59b-41b1-b2f7-81ac5538570e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1ba36070-5292-4128-ad11-676a1bfaf1a5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("1d3556f0-a0cc-4e3e-a984-91cfe9003c38"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("344fdef8-c7ff-4359-90f2-3279b842da28"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("351df3f3-970f-4909-a440-2912235dc19b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("48a75a21-6e7e-4e55-bc58-df7a9b3d37a5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("4f1835d3-fdd3-4192-a077-c6eaf9d5c607"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5c21c61b-e96f-472d-8f6b-8f967cbd3513"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6253e315-9e1d-48b8-af0e-7c68f0b00fe5"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6440c4a0-b31f-4ac0-9b79-80b09ae4b201"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("687d7b0d-4c6d-4d7d-8fd5-0b26a82d1655"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6bdc83a0-31b4-48ff-acd6-fb2aedaeda39"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6e4d406a-0e6b-4424-9a93-0a3921614e33"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("79513aeb-462e-4ec4-801e-6d5e0cd91efc"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("a6ebc502-f6a2-47bb-ae2b-6cad0905c7d7"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("af8e17fb-4d03-49ac-889e-1286e5c8a280"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b92595c1-a5c0-48ca-ac51-01a127b5945f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b96bc4f0-75c6-44bc-992a-2a12fff04fa9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("c19bcb1a-a830-44b5-bad9-4b0a1cfd2e69"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cecfc43c-5532-4f69-be1a-9cbe69e0697b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d0741908-1af4-4805-ab60-e049eec48cc0"));
        }
    }
}
