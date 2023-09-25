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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReserveDateIntervals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReserveNumber = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    StartBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndBookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveDateIntervals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReserveDateIntervals_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReserveDateIntervals_Users_UserId",
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
                    { 200, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 292 },
                    { 201, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, 363 },
                    { 202, 0, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, 157 },
                    { 203, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 356 },
                    { 204, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 296 },
                    { 205, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 194 },
                    { 206, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 276 },
                    { 207, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, 283 },
                    { 208, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 209 },
                    { 209, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 186 },
                    { 210, 0, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 477 },
                    { 211, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 308 },
                    { 212, 0, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 482 },
                    { 213, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 243 },
                    { 214, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, 335 },
                    { 215, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 480 },
                    { 216, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 332 },
                    { 217, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 183 },
                    { 218, 0, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 157 },
                    { 219, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, 160 },
                    { 220, 0, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 489 },
                    { 221, 0, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, 491 },
                    { 222, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, 334 },
                    { 223, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, 455 },
                    { 224, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, 239 },
                    { 225, 0, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 260 },
                    { 226, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, 119 },
                    { 227, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, 267 },
                    { 228, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 273 },
                    { 229, 0, "The Football Is Good For Training And Recreational Purposes", 1, 226 },
                    { 230, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 359 },
                    { 231, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 236 },
                    { 232, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 244 },
                    { 233, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 322 },
                    { 234, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 128 },
                    { 235, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 185 },
                    { 236, 0, "The Football Is Good For Training And Recreational Purposes", 2, 454 },
                    { 237, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 398 },
                    { 238, 0, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 420 },
                    { 239, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, 514 },
                    { 240, 1, "The Football Is Good For Training And Recreational Purposes", 2, 450 },
                    { 241, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 373 },
                    { 242, 0, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 519 },
                    { 243, 0, "The Football Is Good For Training And Recreational Purposes", 4, 511 },
                    { 244, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 156 },
                    { 245, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 324 },
                    { 246, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 240 },
                    { 247, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, 260 },
                    { 248, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, 331 },
                    { 249, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, 155 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone", "UserDescription" },
                values: new object[,]
                {
                    { new Guid("00cc3b5d-491f-0653-ff52-cd888e7fda10"), "Adele_Cartwright@hotmail.com", "Irving McClure", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("01004997-3b8d-9c82-42b7-aba45cea6ebb"), "Cindy_Goodwin84@gmail.com", "Lesley Von", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("047316e7-a989-c810-2a3a-c0b29e807ce1"), "Emmet_Cummerata@yahoo.com", "Autumn Hayes", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("0a3e15f2-7c94-0326-8bfe-6b31f71a8b8c"), "Christ_Jakubowski@yahoo.com", "Andreane Zieme", "en", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { new Guid("13f7a25b-77c5-87af-ad8e-da0f41e6e977"), "Shea.OReilly30@yahoo.com", "Julianne Daniel", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("16d47301-a097-2bb9-dda4-2024ebe75fe5"), "Milford2@gmail.com", "Kole Rodriguez", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("2448d271-3551-6d82-4c92-92e109bd8e15"), "Loyce_Johns15@hotmail.com", "Kathryne Mann", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("26b7ccbf-3d85-71b7-d6f9-259d64b90591"), "Eveline39@gmail.com", "Vincent Pouros", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("33f1f5e6-a7c9-12f8-df75-da95c4c828a9"), "Pearlie32@yahoo.com", "Dina Koch", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("34ef4eaf-fd02-6dd4-9bbe-6a13f70439aa"), "Hillard41@hotmail.com", "Elroy Kemmer", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("3e7435d3-515d-76ee-e1ef-148e57fbde34"), "Madie98@yahoo.com", "Itzel Rippin", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("40777ab4-9d58-1d07-eaff-07c84f6659fb"), "Dewitt.Bogisich@hotmail.com", "Geo Ondricka", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("427a2d73-09f6-8a94-7b75-bacc8d5d3f78"), "Kraig_McKenzie10@hotmail.com", "Zoie Hilll", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("434fb61a-243e-0efa-1b98-98c299753aa8"), "Neoma_Bogisich59@yahoo.com", "Cassie Krajcik", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("4bc8dc7e-3d7a-308f-fa78-e745109195b5"), "Jonathon6@yahoo.com", "Dean Gleichner", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("4cabcb15-7728-0b5f-4f8a-67608d0e7f77"), "Charity23@gmail.com", "Johnathon Brakus", "en", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016" },
                    { new Guid("4e87e18c-4dc3-9737-bb87-f401dc41316a"), "Buford.Watsica@hotmail.com", "Leonardo Waelchi", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("4eb81be8-c4a1-d131-10a4-40cc3531b6d4"), "Eleanore52@yahoo.com", "Bailee Beier", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("52016dfd-56aa-f68f-7842-cdc19ab007b5"), "Ona_Haley@hotmail.com", "Reyes Gottlieb", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("53e99ab1-9f01-2369-71ff-b41b7c433ea6"), "Lina.Murray@gmail.com", "Rubye Buckridge", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("550380c3-ca8f-86d7-e009-71f7df4308f8"), "Leonor_McLaughlin@gmail.com", "Jamarcus Pfeffer", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("5ef8445a-b3fd-8cc9-0cd6-1c56be27ed03"), "Paul_Leffler@yahoo.com", "Onie Huel", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("651be192-5aa6-1a3b-97d0-cda1db4d1524"), "Lucienne45@hotmail.com", "Enola Gleichner", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("6a599e8f-b3da-6223-0f3e-1735e48e4435"), "Bettye25@hotmail.com", "Lonie McCullough", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("70004bb4-af13-1c73-baec-dad8b8cfbe66"), "Petra59@yahoo.com", "Dortha Collins", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("729ecf93-7447-100b-d630-3605cec8f89b"), "Eduardo_Torp42@yahoo.com", "Ubaldo McKenzie", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("73a66fed-623c-cf11-454f-31dd4d27b10a"), "Mavis94@yahoo.com", "Edmund Harvey", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("7991101b-dd54-1898-9168-df9b3ea8e726"), "Osbaldo_Hirthe49@yahoo.com", "Marlin Hettinger", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("7a05e7a7-a98c-90e5-d40c-785a2d7751ec"), "Darrel_McGlynn@hotmail.com", "Erik Feest", "en", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients" },
                    { new Guid("7cca1a4b-263a-ce54-8e88-416c018b5d1a"), "Nash.Fahey@gmail.com", "Jevon Kessler", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("87d97a0e-1b41-4bf0-8680-eab62820410c"), "Andreane.Schaefer29@yahoo.com", "Beaulah Willms", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("886fc39a-68f2-5020-2b80-89e3cb6b3d6c"), "Elias11@yahoo.com", "Diego Kunze", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("8bf6c776-186f-0ff6-83b1-5c5646eef071"), "Eunice39@hotmail.com", "Hillary Feeney", "en", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { new Guid("8f4dd10d-9fff-5257-be4c-73d8826b172f"), "Shad_Nikolaus@yahoo.com", "Vella Rempel", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("8f5bd60d-7153-eafe-ca72-43e23a21f8ea"), "Zion.Von@yahoo.com", "Elisa Wilderman", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("8fe65be8-f988-e11d-dbc9-7e25e2673153"), "Cale_Rowe@gmail.com", "Remington Hauck", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("969401c8-9890-5ba2-0780-0d23467bc909"), "Adrianna_OKon32@gmail.com", "Sven Nienow", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("97a6c36b-19ff-6f82-4628-292a2707533a"), "Ulises.Monahan91@yahoo.com", "Jocelyn Jacobson", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("9daeb3a9-ab2b-b2b4-9005-8ff5d2c1acb5"), "Alden.Torphy@hotmail.com", "Leilani Hoppe", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("a13d70b5-b6c0-10fb-2da2-4c84035409cf"), "Marshall_Kertzmann@gmail.com", "Cruz Muller", "en", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart" },
                    { new Guid("aa25bebc-0b07-d5cc-2f0c-e459bfb51274"), "Gregory70@gmail.com", "Lucious Dickens", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("ae225792-9eb3-e14f-7788-840df89bc18a"), "Mozell85@yahoo.com", "Oswaldo Weimann", "en", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J" },
                    { new Guid("af874ea1-c33c-b234-715d-29c06b0143ae"), "Tabitha.Swift@gmail.com", "Jeff Cruickshank", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("b07a06ff-72f4-18da-94fd-e25394afd6da"), "Ferne26@yahoo.com", "Calista Upton", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("b34b119c-ec37-aa2b-cf8b-6cbf22223761"), "Kenny_Bartoletti10@hotmail.com", "Kade Morissette", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("b620183a-4422-3b9c-4ad9-b2d0f6c615fd"), "Kale.Runte19@hotmail.com", "Jodie Hessel", "en", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support" },
                    { new Guid("bd2b577b-b3c2-d620-cc57-2f3f42cbeedd"), "Lina.Dicki@gmail.com", "Urban Stehr", "en", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality" },
                    { new Guid("bdb1a7e8-8075-beaf-e6b2-e1e41313a58d"), "Helga82@hotmail.com", "Bobbie Blick", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("c4ed5f5b-d22d-adf8-c3c1-45291e805636"), "Kristoffer.Parisian7@yahoo.com", "Keagan Shanahan", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("c674d53a-dd95-a264-5977-350200ec86de"), "Wellington_Kreiger9@gmail.com", "Rodrick Casper", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("cc45e6ed-1830-7fe9-7b3d-385977d54736"), "Annamae77@hotmail.com", "Domingo Walsh", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" },
                    { new Guid("d35375bc-c08b-d27b-d8b3-2fc6dec7b790"), "Ellie.Konopelski@yahoo.com", "Peyton Skiles", "en", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles" },
                    { new Guid("da9fc4a8-a176-1dd9-3290-158a3879b4fb"), "Candace75@yahoo.com", "Alejandrin Bruen", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("e1a2e03e-e187-fe1b-9c3d-9cc867e56dd1"), "Bernardo22@gmail.com", "Marina Beer", "en", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit" },
                    { new Guid("e2a33b09-5555-6453-5a21-2029d34c4f4d"), "Ressie_Parker62@yahoo.com", "Kasey McCullough", "en", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive" },
                    { new Guid("ea4da663-0bfe-2474-1125-980c2c1e0519"), "Chad.Crooks51@yahoo.com", "Tessie D'Amore", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("f49946f9-4384-2c67-e201-e74bf1275acf"), "Hellen28@gmail.com", "Hugh Lind", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("f4e14888-4302-43a5-0dce-ea9d30fac86c"), "Jana_Kovacek24@gmail.com", "Vernie Stokes", "en", "The Football Is Good For Training And Recreational Purposes" },
                    { new Guid("fac14815-1dbc-edc8-480f-64a09a60ed0b"), "Dimitri47@gmail.com", "Eda Rogahn", "en", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals" },
                    { new Guid("fc79119c-64dd-182d-9ada-c211a8f5a7a6"), "Torey_Purdy@hotmail.com", "Darrick Lindgren", "en", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design" }
                });

            migrationBuilder.InsertData(
                table: "ReserveDateIntervals",
                columns: new[] { "Id", "EndBookDate", "ReserveNumber", "RoomId", "StartBookDate", "UserId" },
                values: new object[,]
                {
                    { 250, new DateTime(2023, 10, 1, 17, 55, 3, 663, DateTimeKind.Local).AddTicks(7496), 402867881, 209, new DateTime(2023, 9, 28, 13, 5, 10, 153, DateTimeKind.Local).AddTicks(4100), new Guid("3e7435d3-515d-76ee-e1ef-148e57fbde34") },
                    { 251, new DateTime(2023, 10, 3, 3, 17, 13, 990, DateTimeKind.Local).AddTicks(2337), 636150619, 217, new DateTime(2023, 9, 28, 8, 42, 54, 242, DateTimeKind.Local).AddTicks(2588), new Guid("8f4dd10d-9fff-5257-be4c-73d8826b172f") },
                    { 252, new DateTime(2023, 10, 4, 5, 54, 50, 963, DateTimeKind.Local).AddTicks(6032), 124985454, 206, new DateTime(2023, 9, 27, 18, 51, 23, 843, DateTimeKind.Local).AddTicks(6525), new Guid("16d47301-a097-2bb9-dda4-2024ebe75fe5") },
                    { 253, new DateTime(2023, 10, 3, 9, 35, 20, 562, DateTimeKind.Local).AddTicks(4685), 625687639, 200, new DateTime(2023, 9, 27, 7, 53, 19, 319, DateTimeKind.Local).AddTicks(4977), new Guid("e2a33b09-5555-6453-5a21-2029d34c4f4d") },
                    { 254, new DateTime(2023, 10, 3, 15, 38, 30, 610, DateTimeKind.Local).AddTicks(9355), 621140258, 214, new DateTime(2023, 9, 26, 18, 8, 27, 531, DateTimeKind.Local).AddTicks(8613), new Guid("16d47301-a097-2bb9-dda4-2024ebe75fe5") },
                    { 255, new DateTime(2023, 10, 4, 14, 14, 18, 529, DateTimeKind.Local).AddTicks(7828), 450220778, 210, new DateTime(2023, 9, 27, 7, 51, 32, 594, DateTimeKind.Local).AddTicks(9263), new Guid("9daeb3a9-ab2b-b2b4-9005-8ff5d2c1acb5") },
                    { 256, new DateTime(2023, 10, 2, 3, 27, 46, 981, DateTimeKind.Local).AddTicks(8415), 650484819, 206, new DateTime(2023, 9, 29, 11, 3, 59, 630, DateTimeKind.Local).AddTicks(1905), new Guid("01004997-3b8d-9c82-42b7-aba45cea6ebb") },
                    { 257, new DateTime(2023, 10, 2, 15, 10, 21, 949, DateTimeKind.Local).AddTicks(668), 734233739, 236, new DateTime(2023, 9, 29, 1, 51, 55, 560, DateTimeKind.Local).AddTicks(5324), new Guid("34ef4eaf-fd02-6dd4-9bbe-6a13f70439aa") },
                    { 258, new DateTime(2023, 10, 2, 0, 28, 51, 34, DateTimeKind.Local).AddTicks(6561), 414850620, 236, new DateTime(2023, 9, 25, 23, 0, 58, 985, DateTimeKind.Local).AddTicks(2147), new Guid("16d47301-a097-2bb9-dda4-2024ebe75fe5") },
                    { 259, new DateTime(2023, 10, 1, 3, 31, 3, 137, DateTimeKind.Local).AddTicks(7753), 100863539, 249, new DateTime(2023, 9, 29, 1, 11, 38, 712, DateTimeKind.Local).AddTicks(4310), new Guid("729ecf93-7447-100b-d630-3605cec8f89b") },
                    { 260, new DateTime(2023, 10, 3, 16, 33, 33, 544, DateTimeKind.Local).AddTicks(1311), 892020265, 214, new DateTime(2023, 9, 28, 14, 34, 9, 858, DateTimeKind.Local).AddTicks(5043), new Guid("4bc8dc7e-3d7a-308f-fa78-e745109195b5") },
                    { 261, new DateTime(2023, 10, 1, 2, 3, 42, 337, DateTimeKind.Local).AddTicks(9820), 287359861, 207, new DateTime(2023, 9, 28, 15, 3, 14, 992, DateTimeKind.Local).AddTicks(5260), new Guid("4bc8dc7e-3d7a-308f-fa78-e745109195b5") },
                    { 262, new DateTime(2023, 10, 1, 16, 15, 31, 770, DateTimeKind.Local).AddTicks(8292), 490396209, 224, new DateTime(2023, 9, 25, 18, 6, 41, 556, DateTimeKind.Local).AddTicks(4581), new Guid("7cca1a4b-263a-ce54-8e88-416c018b5d1a") },
                    { 263, new DateTime(2023, 10, 3, 10, 39, 40, 220, DateTimeKind.Local).AddTicks(8532), 430642999, 227, new DateTime(2023, 9, 27, 13, 46, 35, 307, DateTimeKind.Local).AddTicks(5936), new Guid("886fc39a-68f2-5020-2b80-89e3cb6b3d6c") },
                    { 264, new DateTime(2023, 10, 1, 22, 51, 35, 781, DateTimeKind.Local).AddTicks(2765), 868571628, 241, new DateTime(2023, 9, 26, 0, 19, 50, 879, DateTimeKind.Local).AddTicks(3333), new Guid("f4e14888-4302-43a5-0dce-ea9d30fac86c") },
                    { 265, new DateTime(2023, 9, 30, 22, 13, 49, 737, DateTimeKind.Local).AddTicks(773), 206730630, 218, new DateTime(2023, 9, 27, 2, 56, 34, 269, DateTimeKind.Local).AddTicks(8944), new Guid("fc79119c-64dd-182d-9ada-c211a8f5a7a6") },
                    { 266, new DateTime(2023, 9, 30, 18, 41, 6, 456, DateTimeKind.Local).AddTicks(847), 323625045, 239, new DateTime(2023, 9, 28, 1, 34, 8, 6, DateTimeKind.Local).AddTicks(7928), new Guid("af874ea1-c33c-b234-715d-29c06b0143ae") },
                    { 267, new DateTime(2023, 10, 2, 11, 42, 16, 796, DateTimeKind.Local).AddTicks(9624), 250078850, 211, new DateTime(2023, 9, 28, 11, 44, 52, 860, DateTimeKind.Local).AddTicks(6472), new Guid("70004bb4-af13-1c73-baec-dad8b8cfbe66") },
                    { 268, new DateTime(2023, 10, 3, 7, 17, 55, 462, DateTimeKind.Local).AddTicks(5939), 416780063, 248, new DateTime(2023, 9, 28, 11, 38, 29, 819, DateTimeKind.Local).AddTicks(7119), new Guid("aa25bebc-0b07-d5cc-2f0c-e459bfb51274") },
                    { 269, new DateTime(2023, 10, 3, 10, 57, 41, 531, DateTimeKind.Local).AddTicks(7021), 293795575, 228, new DateTime(2023, 9, 29, 4, 5, 25, 36, DateTimeKind.Local).AddTicks(9698), new Guid("f4e14888-4302-43a5-0dce-ea9d30fac86c") },
                    { 270, new DateTime(2023, 9, 30, 22, 25, 39, 960, DateTimeKind.Local).AddTicks(8270), 100756061, 200, new DateTime(2023, 9, 28, 1, 35, 36, 144, DateTimeKind.Local).AddTicks(1939), new Guid("969401c8-9890-5ba2-0780-0d23467bc909") },
                    { 271, new DateTime(2023, 10, 1, 19, 42, 18, 585, DateTimeKind.Local).AddTicks(5095), 864470094, 220, new DateTime(2023, 9, 26, 21, 52, 34, 337, DateTimeKind.Local).AddTicks(1687), new Guid("87d97a0e-1b41-4bf0-8680-eab62820410c") },
                    { 272, new DateTime(2023, 10, 1, 5, 35, 56, 185, DateTimeKind.Local).AddTicks(3439), 793342651, 222, new DateTime(2023, 9, 28, 1, 17, 33, 938, DateTimeKind.Local).AddTicks(7634), new Guid("886fc39a-68f2-5020-2b80-89e3cb6b3d6c") },
                    { 273, new DateTime(2023, 10, 2, 16, 18, 48, 660, DateTimeKind.Local).AddTicks(8386), 533797988, 202, new DateTime(2023, 9, 27, 22, 17, 21, 321, DateTimeKind.Local).AddTicks(6724), new Guid("70004bb4-af13-1c73-baec-dad8b8cfbe66") },
                    { 274, new DateTime(2023, 10, 1, 1, 14, 10, 702, DateTimeKind.Local).AddTicks(4505), 758044915, 201, new DateTime(2023, 9, 25, 18, 32, 29, 958, DateTimeKind.Local).AddTicks(7781), new Guid("bd2b577b-b3c2-d620-cc57-2f3f42cbeedd") },
                    { 275, new DateTime(2023, 10, 3, 13, 22, 41, 175, DateTimeKind.Local).AddTicks(5325), 840561790, 201, new DateTime(2023, 9, 27, 6, 26, 16, 778, DateTimeKind.Local).AddTicks(2501), new Guid("bd2b577b-b3c2-d620-cc57-2f3f42cbeedd") },
                    { 276, new DateTime(2023, 10, 2, 5, 26, 57, 217, DateTimeKind.Local).AddTicks(8314), 467123831, 232, new DateTime(2023, 9, 26, 14, 50, 6, 91, DateTimeKind.Local).AddTicks(6195), new Guid("26b7ccbf-3d85-71b7-d6f9-259d64b90591") },
                    { 277, new DateTime(2023, 10, 2, 19, 27, 59, 301, DateTimeKind.Local).AddTicks(3518), 711428566, 206, new DateTime(2023, 9, 26, 14, 1, 56, 99, DateTimeKind.Local).AddTicks(3492), new Guid("729ecf93-7447-100b-d630-3605cec8f89b") },
                    { 278, new DateTime(2023, 10, 3, 11, 23, 43, 96, DateTimeKind.Local).AddTicks(3773), 625515964, 211, new DateTime(2023, 9, 28, 9, 24, 31, 354, DateTimeKind.Local).AddTicks(7278), new Guid("8bf6c776-186f-0ff6-83b1-5c5646eef071") },
                    { 279, new DateTime(2023, 10, 3, 21, 5, 4, 831, DateTimeKind.Local).AddTicks(1443), 356053867, 200, new DateTime(2023, 9, 28, 23, 59, 1, 265, DateTimeKind.Local).AddTicks(471), new Guid("73a66fed-623c-cf11-454f-31dd4d27b10a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReserveDateIntervals_RoomId",
                table: "ReserveDateIntervals",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ReserveDateIntervals_UserId",
                table: "ReserveDateIntervals",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReserveDateIntervals");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
