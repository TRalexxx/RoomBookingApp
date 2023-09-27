using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelReserveAppServer.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    MaxAmountOfPeople = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomReserves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReserveNumber = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomReserves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomReserves_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomReserves_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Class", "Description", "MaxAmountOfPeople", "Number" },
                values: new object[,]
                {
                    { 200, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, 252 },
                    { 201, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 415 },
                    { 202, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 445 },
                    { 203, 0, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 394 },
                    { 204, 0, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 379 },
                    { 205, 0, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, 337 },
                    { 206, 0, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, 279 },
                    { 207, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, 268 },
                    { 208, 0, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 307 },
                    { 209, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, 147 },
                    { 210, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 285 },
                    { 211, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, 241 },
                    { 212, 0, "The Football Is Good For Training And Recreational Purposes", 5, 462 },
                    { 213, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 498 },
                    { 214, 0, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, 178 },
                    { 215, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, 395 },
                    { 216, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, 381 },
                    { 217, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 466 },
                    { 218, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, 219 },
                    { 219, 0, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 149 },
                    { 220, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 285 },
                    { 221, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, 199 },
                    { 222, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 236 },
                    { 223, 0, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, 219 },
                    { 224, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 504 },
                    { 225, 3, "The Football Is Good For Training And Recreational Purposes", 4, 377 },
                    { 226, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 345 },
                    { 227, 1, "The Football Is Good For Training And Recreational Purposes", 6, 435 },
                    { 228, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 176 },
                    { 229, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, 356 },
                    { 230, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, 326 },
                    { 231, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 328 },
                    { 232, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 460 },
                    { 233, 0, "The Football Is Good For Training And Recreational Purposes", 6, 133 },
                    { 234, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 143 },
                    { 235, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 120 },
                    { 236, 0, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 152 },
                    { 237, 0, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 516 },
                    { 238, 0, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 278 },
                    { 239, 0, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 156 },
                    { 240, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 385 },
                    { 241, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, 288 },
                    { 242, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 158 },
                    { 243, 0, "The Football Is Good For Training And Recreational Purposes", 5, 249 },
                    { 244, 0, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 252 },
                    { 245, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, 349 },
                    { 246, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, 395 },
                    { 247, 0, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, 210 },
                    { 248, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, 420 },
                    { 249, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, 205 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone", "UserDescription" },
                values: new object[,]
                {
                    { new Guid("0614467b-bc02-9d42-1b39-d38ca6906c69"), "Henry_Ebert@gmail.com", "Marlin Altenwerth", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("0c18fada-9c82-9b9a-9218-6981da343366"), "Zachery.Rice@yahoo.com", "Shaina Erdman", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("0e94221c-f258-90e9-93e7-ae700d37f09f"), "Vivien_Hermiston@hotmail.com", "Sallie Reichel", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("11ddc22c-1778-7f8a-5aba-00ba134c765f"), "Maya.Zemlak3@gmail.com", "Rod Raynor", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("12fdcb22-58df-e6dc-afec-1313c6539625"), "Forest76@hotmail.com", "Penelope Halvorson", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("13b2b432-1bf4-f004-01c3-e1a66d98cdd9"), "Juanita.Kiehn@gmail.com", "Kayli Kilback", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("147ce235-54bb-6d99-1891-f5194310f425"), "Jeanie_Hahn@yahoo.com", "Gustave Harber", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("1ab6a42a-7add-8c8d-8606-1b89e150ece4"), "Keegan91@yahoo.com", "Seth McKenzie", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("1c0b5bf5-e9b0-3bf0-a193-3dcaef6c9d0f"), "Jamison.Kutch@hotmail.com", "Gladys Bechtelar", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("1d04d994-4eba-121d-24a5-c8407250d736"), "Bonita.Strosin49@hotmail.com", "Eladio Schumm", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("22a282cb-82b4-2fd2-66ff-eccf775cc7b0"), "Dan_Frami89@hotmail.com", "Pietro Huels", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("251196fb-f226-170a-35ee-973ca9ae84f6"), "Giovani25@gmail.com", "Cora Wuckert", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("29dce69b-f2c4-b7b9-eccc-2a3c79e1aafe"), "Anika.Keebler91@hotmail.com", "Grady Bode", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("2b7e20a8-e7e4-41ab-f74f-84c62ba4147a"), "Graciela_Mohr60@yahoo.com", "Katelyn Kutch", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("336e8770-4f9c-0a5d-2522-d6685e93eb7f"), "Andrew_Corwin@gmail.com", "Raphaelle Hammes", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("3906625a-7ed3-4d90-4660-a525e0a94365"), "Leta_Brown@hotmail.com", "Deshaun Huel", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("3b2996d9-e5b2-19d3-eb68-cd72299a8151"), "Vena.Smith66@hotmail.com", "Brock Farrell", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("3e4ec52c-0059-f77e-8cba-60da7b02199f"), "Stuart_Medhurst69@hotmail.com", "Nikko Lueilwitz", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("458205d5-2b09-1152-61ae-8f065433ac71"), "Keely_Prohaska@yahoo.com", "Domenick Keeling", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("4a43ad7e-7918-386e-b333-611712a9f388"), "Magnolia55@hotmail.com", "Allison Brakus", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("4ac9f7f8-76e7-15c3-1731-24e7e70351db"), "Dawson.Larkin76@yahoo.com", "Vickie Rempel", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("4d0dedf0-0131-69e3-6913-ea170d6a4c84"), "Mathew.Graham@hotmail.com", "Mozell Kris", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("4ef84899-fe9a-8416-f7c9-3d838b85bf36"), "Eldora.Connelly50@yahoo.com", "Gertrude Batz", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("516903d2-1358-512a-96fd-4519adf6ff47"), "Darryl.Beatty60@gmail.com", "Patience Doyle", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("66916fa4-6a83-b0b6-ee2c-6b69ccfe404e"), "Junior28@yahoo.com", "Angie Roob", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("7440edd9-2cab-4358-04f8-f808f5d50fc5"), "Chance82@hotmail.com", "Arnold Kuvalis", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("75234b4a-be28-4da9-dd01-6bd45a5f94f0"), "Pamela_Walker@gmail.com", "Kayli Nikolaus", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("7c619b4e-f8f3-2369-b8db-4752d49af18e"), "Jacinthe36@yahoo.com", "Caesar Welch", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("7ffaf94c-6d99-4b6c-4771-4732eef20492"), "Daisy_Reynolds87@gmail.com", "Santiago Leannon", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("80e18830-7835-2577-9d08-9fa294d7e65c"), "Claire_Murphy@gmail.com", "Dominic Feeney", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("8140a483-abe1-45b2-8124-d25704e6c0f5"), "Mozelle_Johnston@gmail.com", "Rasheed Littel", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("8203e558-9069-1317-e2a9-29446961b7b8"), "Chris58@yahoo.com", "Meda Schuppe", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("87dbbffd-a0a3-69f0-d8e8-25429134802b"), "Wyman_Monahan73@yahoo.com", "Brigitte Torp", "en", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { new Guid("909e2d48-5525-dd12-22dc-1c2b58496fe6"), "Megane_Becker@gmail.com", "Kariane Quitzon", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("9466a4a9-6b95-e46d-63c2-4ce5fba2816a"), "Elyssa_Cronin26@gmail.com", "Diego Schowalter", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("98d02b4f-15bc-618e-afc3-d55f8d05ef56"), "Alfreda_Lehner56@yahoo.com", "Watson Quigley", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("9f34e443-e219-ac06-6201-7166961931f7"), "Morris.Schulist61@hotmail.com", "Estrella Rath", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("a0cfb200-5e56-738a-d30e-1ee62f7d7d19"), "Jan11@hotmail.com", "Magnolia Rippin", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("a9cf9736-08cf-9c58-4f7f-585db1109667"), "Eriberto_Gerhold8@gmail.com", "Eden Feil", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("aabb629c-5146-8109-497a-dd19239bd994"), "Dean.Abbott@hotmail.com", "Deanna Zboncak", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("ae0ece3e-f5bc-d840-c596-65094f2b60be"), "Marcellus.Gerhold@yahoo.com", "Nestor Osinski", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("af193761-42cb-3dae-aa73-f8656822efb2"), "Blake28@hotmail.com", "Deonte Franecki", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("b053a2bf-c69b-efc6-1884-634d3b9b1c84"), "Luella19@gmail.com", "Shanelle Gerhold", "en", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { new Guid("b473008f-e86e-dedc-6d43-c3f7e21c62a5"), "Merlin_Fritsch@gmail.com", "Michele Effertz", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("bda71648-6226-4104-8190-351763e09769"), "Clare82@hotmail.com", "Frederique Schroeder", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("c518f083-a71a-f65f-ff2d-029bde1a822a"), "Madge.Spinka@gmail.com", "Jon Fay", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("c52afa4d-ebec-8a47-40da-4f4c3f336ef7"), "Ahmad_Spinka87@gmail.com", "Jany Kovacek", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("c7a6770d-3f78-fc23-5667-b84438d15f93"), "Turner_Lesch10@yahoo.com", "Brian Hane", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("d18056c7-a888-be0c-0397-65f2661cdd64"), "Charlene_Kihn@gmail.com", "Belle Kuhic", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("d4c89d8e-6b6c-ac03-8399-8a0b55ced399"), "Derek34@gmail.com", "Zena Will", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("d4d96602-ae72-c08a-b8fe-0ca24d35983d"), "Bridgette_Jast@hotmail.com", "Obie Nicolas", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("d6f6a459-abdc-9709-2447-271918a6a7c0"), "Leonardo_Williamson86@yahoo.com", "Irving Torp", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("df460280-dc03-cc09-e074-9c50b9834fd4"), "Rhoda_Metz@gmail.com", "Viviane Thompson", "en", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { new Guid("e02c8e73-c0ab-3781-938c-0f82c2b164d5"), "Devonte.Weimann53@hotmail.com", "Eileen Mayer", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("e2b62ef8-c6db-25d2-fddc-a215cbcca3b9"), "Mattie85@yahoo.com", "Marcelle Barrows", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("e4f75614-eaac-956d-03db-ddcd49a3079f"), "Adelia.Bogan45@yahoo.com", "Lindsay Raynor", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("f14febf6-d0f9-9575-d6df-c22de6e2dc0a"), "Alda_Lind@gmail.com", "Deion Collins", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("f46a7d2d-15d6-0661-b544-d56d82aac059"), "Lawson.Kilback@yahoo.com", "Brennan Larson", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("f65e3ac0-edba-4203-74e7-85463a60cfff"), "Letitia.Rodriguez@gmail.com", "Whitney Hudson", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("f80c5ec4-6249-9d05-1b92-fbfc89082547"), "Rasheed93@gmail.com", "Deborah Gislason", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" }
                });

            migrationBuilder.InsertData(
                table: "RoomReserves",
                columns: new[] { "Id", "AdditionalInfo", "EndBookDate", "ReserveNumber", "RoomId", "StartBookDate", "UserId" },
                values: new object[,]
                {
                    { 250, "Et dolorem et molestias.", new DateTime(2023, 10, 5, 23, 37, 43, 104, DateTimeKind.Local).AddTicks(644), 234082976, 208, new DateTime(2023, 9, 28, 14, 30, 57, 93, DateTimeKind.Local).AddTicks(1286), new Guid("af193761-42cb-3dae-aa73-f8656822efb2") },
                    { 251, "Assumenda et aut placeat a et qui numquam reiciendis.", new DateTime(2023, 10, 3, 23, 29, 47, 16, DateTimeKind.Local).AddTicks(1185), 664412777, 224, new DateTime(2023, 9, 30, 1, 23, 51, 807, DateTimeKind.Local).AddTicks(6752), new Guid("3e4ec52c-0059-f77e-8cba-60da7b02199f") },
                    { 252, "Eos omnis optio.", new DateTime(2023, 10, 7, 3, 54, 52, 917, DateTimeKind.Local).AddTicks(6132), 481305361, 238, new DateTime(2023, 10, 1, 1, 0, 14, 438, DateTimeKind.Local).AddTicks(9415), new Guid("7440edd9-2cab-4358-04f8-f808f5d50fc5") },
                    { 253, "Inventore necessitatibus doloremque quia ea.", new DateTime(2023, 10, 4, 9, 48, 34, 121, DateTimeKind.Local).AddTicks(6889), 827411475, 238, new DateTime(2023, 9, 29, 9, 23, 32, 182, DateTimeKind.Local).AddTicks(4538), new Guid("c7a6770d-3f78-fc23-5667-b84438d15f93") },
                    { 254, "Deserunt laudantium temporibus molestiae sint quo est quae.", new DateTime(2023, 10, 6, 23, 2, 43, 254, DateTimeKind.Local).AddTicks(4286), 456429641, 242, new DateTime(2023, 9, 30, 16, 49, 11, 488, DateTimeKind.Local).AddTicks(67), new Guid("22a282cb-82b4-2fd2-66ff-eccf775cc7b0") },
                    { 255, "Officiis error qui vitae.", new DateTime(2023, 10, 3, 22, 46, 20, 685, DateTimeKind.Local).AddTicks(3249), 816752251, 201, new DateTime(2023, 9, 30, 7, 37, 54, 99, DateTimeKind.Local).AddTicks(8088), new Guid("516903d2-1358-512a-96fd-4519adf6ff47") },
                    { 256, "Ut fuga asperiores.", new DateTime(2023, 10, 7, 6, 49, 41, 80, DateTimeKind.Local).AddTicks(3013), 220358955, 233, new DateTime(2023, 9, 28, 17, 22, 27, 262, DateTimeKind.Local).AddTicks(8037), new Guid("4a43ad7e-7918-386e-b333-611712a9f388") },
                    { 257, "Incidunt voluptatem tempora facere praesentium tempore at ducimus assumenda odio.", new DateTime(2023, 10, 5, 13, 47, 14, 704, DateTimeKind.Local).AddTicks(1669), 947969518, 205, new DateTime(2023, 9, 29, 5, 30, 4, 27, DateTimeKind.Local).AddTicks(1964), new Guid("0c18fada-9c82-9b9a-9218-6981da343366") },
                    { 258, "At maiores cupiditate.", new DateTime(2023, 10, 5, 1, 51, 38, 749, DateTimeKind.Local).AddTicks(4299), 175785984, 243, new DateTime(2023, 9, 28, 21, 46, 56, 178, DateTimeKind.Local).AddTicks(4409), new Guid("df460280-dc03-cc09-e074-9c50b9834fd4") },
                    { 259, "Sunt et ea eveniet commodi.", new DateTime(2023, 10, 5, 16, 33, 18, 580, DateTimeKind.Local).AddTicks(9645), 770980574, 214, new DateTime(2023, 9, 30, 5, 44, 18, 296, DateTimeKind.Local).AddTicks(1130), new Guid("7c619b4e-f8f3-2369-b8db-4752d49af18e") },
                    { 260, "Fugit natus dicta ratione.", new DateTime(2023, 10, 5, 22, 49, 3, 700, DateTimeKind.Local).AddTicks(7372), 636990286, 224, new DateTime(2023, 9, 29, 8, 11, 43, 632, DateTimeKind.Local).AddTicks(281), new Guid("458205d5-2b09-1152-61ae-8f065433ac71") },
                    { 261, "Facere dolor nihil cumque.", new DateTime(2023, 10, 6, 14, 58, 33, 424, DateTimeKind.Local).AddTicks(3706), 191065278, 204, new DateTime(2023, 9, 29, 17, 11, 43, 425, DateTimeKind.Local).AddTicks(4175), new Guid("7ffaf94c-6d99-4b6c-4771-4732eef20492") },
                    { 262, "Id id fuga.", new DateTime(2023, 10, 5, 12, 55, 31, 260, DateTimeKind.Local).AddTicks(7598), 553525333, 221, new DateTime(2023, 9, 29, 15, 35, 7, 454, DateTimeKind.Local).AddTicks(8829), new Guid("aabb629c-5146-8109-497a-dd19239bd994") },
                    { 263, "Nisi totam occaecati alias consequatur eius.", new DateTime(2023, 10, 5, 4, 58, 21, 455, DateTimeKind.Local).AddTicks(8367), 168110149, 225, new DateTime(2023, 9, 30, 22, 0, 59, 974, DateTimeKind.Local).AddTicks(8503), new Guid("1c0b5bf5-e9b0-3bf0-a193-3dcaef6c9d0f") },
                    { 264, "Velit explicabo quam cumque possimus nihil recusandae quia.", new DateTime(2023, 10, 7, 5, 3, 46, 298, DateTimeKind.Local).AddTicks(9198), 368919438, 238, new DateTime(2023, 9, 29, 11, 26, 13, 856, DateTimeKind.Local).AddTicks(3845), new Guid("336e8770-4f9c-0a5d-2522-d6685e93eb7f") },
                    { 265, "Ab id aliquam sapiente.", new DateTime(2023, 10, 5, 11, 59, 24, 217, DateTimeKind.Local).AddTicks(115), 699086804, 218, new DateTime(2023, 10, 2, 5, 55, 3, 23, DateTimeKind.Local).AddTicks(3835), new Guid("336e8770-4f9c-0a5d-2522-d6685e93eb7f") },
                    { 266, "In ipsum molestiae ea sed impedit voluptas reprehenderit in voluptatem.", new DateTime(2023, 10, 6, 20, 8, 50, 455, DateTimeKind.Local).AddTicks(7579), 495824693, 214, new DateTime(2023, 9, 28, 13, 16, 4, 332, DateTimeKind.Local).AddTicks(6511), new Guid("b473008f-e86e-dedc-6d43-c3f7e21c62a5") },
                    { 267, "Vitae ad voluptatum omnis consequatur vel.", new DateTime(2023, 10, 7, 2, 48, 41, 170, DateTimeKind.Local).AddTicks(969), 342828785, 211, new DateTime(2023, 9, 30, 3, 16, 27, 546, DateTimeKind.Local).AddTicks(3736), new Guid("b473008f-e86e-dedc-6d43-c3f7e21c62a5") },
                    { 268, "Omnis omnis nihil laudantium assumenda quo consequatur ducimus est consequatur.", new DateTime(2023, 10, 7, 9, 55, 5, 696, DateTimeKind.Local).AddTicks(9968), 443090176, 201, new DateTime(2023, 10, 1, 17, 47, 37, 95, DateTimeKind.Local).AddTicks(7400), new Guid("8203e558-9069-1317-e2a9-29446961b7b8") },
                    { 269, "Doloribus aut quo eius molestiae velit sapiente beatae aut consectetur.", new DateTime(2023, 10, 6, 0, 6, 5, 818, DateTimeKind.Local).AddTicks(3275), 671798583, 222, new DateTime(2023, 9, 28, 23, 16, 43, 361, DateTimeKind.Local).AddTicks(1796), new Guid("13b2b432-1bf4-f004-01c3-e1a66d98cdd9") },
                    { 270, "Vero nesciunt neque velit ipsam eos maiores ipsa ratione.", new DateTime(2023, 10, 4, 23, 2, 46, 161, DateTimeKind.Local).AddTicks(8945), 808993436, 207, new DateTime(2023, 9, 29, 8, 21, 28, 839, DateTimeKind.Local).AddTicks(640), new Guid("98d02b4f-15bc-618e-afc3-d55f8d05ef56") },
                    { 271, "Et tempore quia quia voluptas.", new DateTime(2023, 10, 4, 21, 18, 8, 116, DateTimeKind.Local).AddTicks(2567), 679193672, 237, new DateTime(2023, 10, 1, 23, 4, 15, 854, DateTimeKind.Local).AddTicks(6741), new Guid("c52afa4d-ebec-8a47-40da-4f4c3f336ef7") },
                    { 272, "Voluptas quidem unde occaecati qui nostrum exercitationem.", new DateTime(2023, 10, 6, 2, 29, 17, 906, DateTimeKind.Local).AddTicks(3939), 324168083, 224, new DateTime(2023, 9, 30, 19, 12, 35, 427, DateTimeKind.Local).AddTicks(4349), new Guid("8140a483-abe1-45b2-8124-d25704e6c0f5") },
                    { 273, "Sit et et reiciendis.", new DateTime(2023, 10, 5, 2, 59, 38, 710, DateTimeKind.Local).AddTicks(1099), 390689460, 244, new DateTime(2023, 10, 1, 15, 52, 16, 827, DateTimeKind.Local).AddTicks(3129), new Guid("f14febf6-d0f9-9575-d6df-c22de6e2dc0a") },
                    { 274, "Inventore voluptas nihil.", new DateTime(2023, 10, 4, 12, 13, 24, 380, DateTimeKind.Local).AddTicks(4074), 833649223, 212, new DateTime(2023, 10, 1, 14, 56, 22, 695, DateTimeKind.Local).AddTicks(4937), new Guid("d18056c7-a888-be0c-0397-65f2661cdd64") },
                    { 275, "Alias modi nam natus et delectus eum est quis.", new DateTime(2023, 10, 4, 3, 20, 46, 336, DateTimeKind.Local).AddTicks(5734), 913873212, 203, new DateTime(2023, 9, 29, 0, 48, 8, 951, DateTimeKind.Local).AddTicks(2546), new Guid("4d0dedf0-0131-69e3-6913-ea170d6a4c84") },
                    { 276, "Saepe asperiores consequatur adipisci alias atque.", new DateTime(2023, 10, 6, 2, 2, 17, 299, DateTimeKind.Local).AddTicks(7270), 860687362, 211, new DateTime(2023, 10, 1, 17, 31, 7, 21, DateTimeKind.Local).AddTicks(6832), new Guid("d18056c7-a888-be0c-0397-65f2661cdd64") },
                    { 277, "Et in cum qui tenetur cum a in.", new DateTime(2023, 10, 4, 11, 55, 48, 440, DateTimeKind.Local).AddTicks(8591), 532405323, 215, new DateTime(2023, 10, 1, 4, 25, 8, 955, DateTimeKind.Local).AddTicks(7048), new Guid("75234b4a-be28-4da9-dd01-6bd45a5f94f0") },
                    { 278, "Voluptatem sint expedita.", new DateTime(2023, 10, 4, 6, 38, 11, 960, DateTimeKind.Local).AddTicks(7049), 536008943, 240, new DateTime(2023, 10, 2, 1, 6, 48, 492, DateTimeKind.Local).AddTicks(2217), new Guid("4a43ad7e-7918-386e-b333-611712a9f388") },
                    { 279, "A ducimus saepe iure reiciendis.", new DateTime(2023, 10, 5, 10, 20, 19, 289, DateTimeKind.Local).AddTicks(8260), 581212203, 215, new DateTime(2023, 9, 29, 7, 19, 32, 38, DateTimeKind.Local).AddTicks(5060), new Guid("251196fb-f226-170a-35ee-973ca9ae84f6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomReserves_RoomId",
                table: "RoomReserves",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomReserves_UserId",
                table: "RoomReserves",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomReserves");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
