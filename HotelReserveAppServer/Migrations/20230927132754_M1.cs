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
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Class", "Description", "MaxAmountOfPeople", "Number" },
                values: new object[,]
                {
                    { 200, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 365 },
                    { 201, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 359 },
                    { 202, 3, "The Football Is Good For Training And Recreational Purposes", 2, 220 },
                    { 203, 0, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 266 },
                    { 204, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 371 },
                    { 205, 2, "The Football Is Good For Training And Recreational Purposes", 5, 126 },
                    { 206, 0, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 287 },
                    { 207, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 390 },
                    { 208, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 322 },
                    { 209, 3, "The Football Is Good For Training And Recreational Purposes", 6, 284 },
                    { 210, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 430 },
                    { 211, 0, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 515 },
                    { 212, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, 410 },
                    { 213, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 486 },
                    { 214, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 457 },
                    { 215, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, 415 },
                    { 216, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 163 },
                    { 217, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 191 },
                    { 218, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 184 },
                    { 219, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 411 },
                    { 220, 0, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 472 },
                    { 221, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, 240 },
                    { 222, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 164 },
                    { 223, 0, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 153 },
                    { 224, 0, "The Football Is Good For Training And Recreational Purposes", 6, 152 },
                    { 225, 3, "The Football Is Good For Training And Recreational Purposes", 1, 271 },
                    { 226, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 335 },
                    { 227, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 475 },
                    { 228, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 508 },
                    { 229, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 268 },
                    { 230, 3, "The Football Is Good For Training And Recreational Purposes", 1, 199 },
                    { 231, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 424 },
                    { 232, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, 107 },
                    { 233, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, 509 },
                    { 234, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 164 },
                    { 235, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 171 },
                    { 236, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, 452 },
                    { 237, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 497 },
                    { 238, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 469 },
                    { 239, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 360 },
                    { 240, 0, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 426 },
                    { 241, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 503 },
                    { 242, 1, "The Football Is Good For Training And Recreational Purposes", 4, 429 },
                    { 243, 0, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, 398 },
                    { 244, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, 415 },
                    { 245, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, 149 },
                    { 246, 0, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 456 },
                    { 247, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 515 },
                    { 248, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 137 },
                    { 249, 1, "The Football Is Good For Training And Recreational Purposes", 5, 368 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("05d6602e-2587-6aa9-984e-78f7c27f18e6"), "Lindsey.Jacobson84@hotmail.com", "Teresa Ratke", "1-848-333-6600 x178" },
                    { new Guid("0995a8d0-41b6-fbf1-57c3-787eb8f3da23"), "Michel_Gaylord@hotmail.com", "Arvel Gutmann", "840-394-6626 x73403" },
                    { new Guid("0a0f6e51-64c8-4279-0a76-28e0599e27e8"), "Adan.Gottlieb51@yahoo.com", "Valentina Hegmann", "662-255-2543" },
                    { new Guid("1069d293-a62e-c413-abdc-f8e35545865d"), "Tito.Stoltenberg@yahoo.com", "Gerard Roob", "957.813.3287 x7768" },
                    { new Guid("16b7ff57-2639-4833-1927-2c09264eed96"), "Phoebe.Fritsch@gmail.com", "Kylee Oberbrunner", "(760) 536-8579" },
                    { new Guid("1da1b08e-3f44-e30e-7b35-255aa9c87879"), "Keshaun.Carter67@gmail.com", "Shyann Schuster", "211-561-7346 x58319" },
                    { new Guid("2864e86c-7311-2523-8416-29b846f4f258"), "Anahi_Heaney60@hotmail.com", "Yvonne Olson", "764.727.5736 x042" },
                    { new Guid("2a067fc5-c680-cced-fc81-9dd72b0ac453"), "Lauryn.Haley97@gmail.com", "Elenora Larson", "1-764-883-4443" },
                    { new Guid("2a3e215c-d52b-0f32-74f0-773d3688f729"), "Sage.Mante@gmail.com", "Ned Rath", "1-424-753-0536 x3671" },
                    { new Guid("2ba913f8-75e4-8927-20b6-5363b2272497"), "Durward.Bechtelar@hotmail.com", "General Lubowitz", "337.616.3810" },
                    { new Guid("2c69cb74-3172-5b78-42b9-55dad7bdd9d3"), "Annabelle76@gmail.com", "Maryse McKenzie", "(605) 743-6767 x773" },
                    { new Guid("2d2db7af-4fdf-d5c2-a5d2-78a81d06db52"), "Candida.Lueilwitz@hotmail.com", "Heidi Fisher", "626-799-9186" },
                    { new Guid("301f6b8f-b0e6-acd6-77ac-d1cb814ec4bb"), "Eduardo_Tremblay@gmail.com", "Fletcher Zemlak", "742-617-9912" },
                    { new Guid("31ffabaa-aad1-e0ad-769a-720d4596c479"), "Clare96@yahoo.com", "Jacey Harvey", "324-329-6844" },
                    { new Guid("326d0d7e-5648-20c2-df30-8fb3b9848611"), "Ashtyn_Rolfson@gmail.com", "Zion Crona", "(498) 689-1441" },
                    { new Guid("3382e1a3-9c29-5ad2-89a2-7850df352f40"), "Madison_Graham@hotmail.com", "Francisca Grady", "(656) 902-5785 x2201" },
                    { new Guid("36c683a0-9d39-5aad-6010-ef615fa8a13d"), "Loraine.Hansen93@gmail.com", "Misty Nader", "331.363.4012 x660" },
                    { new Guid("387d57a1-5db9-2c43-07d8-f5791de895ca"), "Kimberly99@yahoo.com", "Maddison Waelchi", "(884) 715-2778 x734" },
                    { new Guid("3908f980-87ab-bf50-0865-df7d03d6a76b"), "Jerome_Hegmann@yahoo.com", "Makayla Okuneva", "1-577-204-4283 x204" },
                    { new Guid("3ce42bb1-add6-669d-6738-15398c0f20e2"), "Irving_Swift72@yahoo.com", "Waldo Fisher", "938.680.1967 x692" },
                    { new Guid("406c8a2a-2200-1ab7-7e98-d4d859fc98e4"), "Dannie.Bruen91@hotmail.com", "Monserrate Buckridge", "342.877.7164 x94351" },
                    { new Guid("440d27e8-af1f-eb57-892c-b7aa51baa431"), "Conor_Mitchell77@yahoo.com", "Rosanna Kuhn", "332.339.7024" },
                    { new Guid("472340dc-2379-2da3-6f5b-c31c77d42679"), "Shyann.Stroman@gmail.com", "Estefania O'Conner", "955-210-3339 x346" },
                    { new Guid("48f7f533-3865-99bf-8896-e413964cb90a"), "Louvenia.Fadel44@gmail.com", "Flavio Feeney", "654.469.3792 x9004" },
                    { new Guid("5379cefc-3ca2-f341-03ef-99354befd137"), "Claudie42@hotmail.com", "Molly Murazik", "804.834.5246 x947" },
                    { new Guid("548aea95-6c0a-5a10-ee77-fb44cf1b41cf"), "Lazaro.Koepp@gmail.com", "Ayden Padberg", "959-911-8992 x53601" },
                    { new Guid("54f32fd5-cbc6-ad9b-9713-ab52c09df94b"), "Maximillia76@hotmail.com", "Craig Auer", "(818) 341-4482 x41826" },
                    { new Guid("562deb07-ac26-5451-ad53-804d96ee049c"), "Grayson75@yahoo.com", "Enos Romaguera", "(973) 614-8529 x207" },
                    { new Guid("587f2784-18a0-27a5-c444-364b48c21984"), "Robyn43@yahoo.com", "Burnice Funk", "582-730-1298 x896" },
                    { new Guid("5d64a3a9-4ec1-d098-a192-e1cf1d1cabdd"), "Ottis31@yahoo.com", "Rosendo Simonis", "540-755-1670 x9243" },
                    { new Guid("62d0d675-a8ec-4426-6b66-2b92b0adcfa5"), "Providenci.Volkman@hotmail.com", "Gerald Bode", "(263) 972-1008" },
                    { new Guid("66478e62-d40e-789a-b8ab-cc2bdc79e342"), "Alverta.Murazik25@hotmail.com", "Forest Ferry", "641-336-0379 x4322" },
                    { new Guid("673941a4-ef1a-e208-c2c2-376925c67788"), "Dejon.Bogan49@gmail.com", "Reilly Daniel", "(461) 463-5538 x385" },
                    { new Guid("6ab27978-5a9e-d6e0-b65a-3db61b4c9ba5"), "Joel_Yundt@hotmail.com", "Hunter Carroll", "(334) 444-7136" },
                    { new Guid("6ee61463-73f9-6222-a33c-904f05f9bfb6"), "Helga12@yahoo.com", "Anabel Towne", "886-563-7673 x9714" },
                    { new Guid("71eef133-3ef7-49cc-0c42-4eaaccc89705"), "Ronaldo.Metz@yahoo.com", "Carmen Labadie", "(662) 999-1018 x4604" },
                    { new Guid("89196c93-907f-d373-6dc8-0e2ef31099a5"), "Frederique_Runolfsson@hotmail.com", "Buck Reilly", "587-396-4500" },
                    { new Guid("89f2361c-b854-0d97-9fe1-572c86b33a5b"), "Cristal.Brown@hotmail.com", "Arnoldo Towne", "730-557-1986 x1256" },
                    { new Guid("8b38ffb3-4948-249f-f254-1e0930f4dd94"), "Rosalyn_Muller@gmail.com", "Nicole Schulist", "(824) 956-2040 x69453" },
                    { new Guid("8e41ef3a-562a-c29a-b177-45cd59651579"), "Kallie.Glover@gmail.com", "Nels Heathcote", "302-828-8487" },
                    { new Guid("8ed46c73-8ce8-85b7-c133-fdf77b3dcc72"), "Madelyn.Abernathy@yahoo.com", "Nayeli Sanford", "1-921-368-1598" },
                    { new Guid("9c6fffd2-a06d-6c70-e989-c2ea46fed991"), "Vivien53@yahoo.com", "Sam Grant", "1-391-908-6676 x903" },
                    { new Guid("a48a8775-b3d3-e2b3-f72e-a5c1a381d52c"), "Murphy.Tillman@hotmail.com", "Sigrid Pouros", "687-958-0771" },
                    { new Guid("a9e86e7d-a75e-c926-6ba7-ff0811536b60"), "Vladimir_Torphy@yahoo.com", "Tony Abshire", "996.963.2456 x035" },
                    { new Guid("aad6457c-9eb8-a840-7f54-189a0af67c91"), "Linnie_Carter97@hotmail.com", "Bianka Boyle", "941.769.3064 x73607" },
                    { new Guid("b5285536-a394-d62c-6336-7e34acd1b74b"), "Karina50@yahoo.com", "Donnell Schroeder", "773-922-9774 x75045" },
                    { new Guid("b73aea00-de4f-e828-915c-64f1a2c5a4a5"), "Lane.Runolfsdottir@yahoo.com", "Jarrell Nitzsche", "946.466.6049 x2090" },
                    { new Guid("b92d4a6b-a12c-4598-dcd4-871e6d2c934f"), "Kattie29@hotmail.com", "Ubaldo Turner", "1-610-319-9092 x3222" },
                    { new Guid("bc43d721-27c9-65e6-a1f7-05e6efa2a91b"), "Lavinia_Hammes@gmail.com", "Alberto Stoltenberg", "1-531-934-5988" },
                    { new Guid("c280a1a1-85c4-18f5-0fb4-6f762e6cfc54"), "Judy_Doyle@hotmail.com", "Arvel Heathcote", "1-559-477-4919 x78267" },
                    { new Guid("c75353e1-4897-1cdd-4316-3209d80c7194"), "Viva_Jacobson@yahoo.com", "Alvah Stracke", "342-364-8947" },
                    { new Guid("cc0c698d-5962-4d57-2b83-5bfe4003d056"), "Marjorie.Hahn24@hotmail.com", "Audie O'Connell", "790-375-3330" },
                    { new Guid("d2594fcb-4366-4953-53bc-fd2444cd9feb"), "Jude.Harber81@hotmail.com", "Clement Feeney", "(676) 738-2242" },
                    { new Guid("daedd527-085a-f1f3-66a9-c672f836ca44"), "Kylee.Nolan21@gmail.com", "Chanelle Wisozk", "1-998-656-5447" },
                    { new Guid("e4d28bcd-c9dc-bb3e-f45c-a8fc1998a306"), "Bo83@yahoo.com", "Ottilie Morar", "251-662-9197" },
                    { new Guid("eae7cd06-ca5b-a64d-061d-c20426daa476"), "Solon_Nicolas@yahoo.com", "Piper Grimes", "1-593-452-9503 x9259" },
                    { new Guid("eb6a362a-3355-f30e-18f9-dc5d373048a6"), "Abner_Kunde@yahoo.com", "Aurelio Donnelly", "(251) 463-9554 x4710" },
                    { new Guid("ed28bdfc-ad3e-7851-6767-f6e975701306"), "Elmo_Padberg82@yahoo.com", "Cale Wuckert", "(349) 390-0755 x3842" },
                    { new Guid("f1049081-1403-0488-9fa4-f95b69f1b191"), "Ricardo.OReilly73@yahoo.com", "Billie Gaylord", "1-664-554-9537 x17393" },
                    { new Guid("f47da34c-dc91-ea31-9081-5a86b22cc753"), "Branson_Barton@yahoo.com", "Kellen Monahan", "704-224-9691 x086" }
                });

            migrationBuilder.InsertData(
                table: "RoomReserves",
                columns: new[] { "Id", "AdditionalInfo", "EndBookDate", "ReserveNumber", "RoomId", "StartBookDate", "UserId" },
                values: new object[,]
                {
                    { 250, "Non odit libero.", new DateTime(2023, 10, 5, 5, 27, 10, 71, DateTimeKind.Local).AddTicks(9284), 710020228, 229, new DateTime(2023, 9, 29, 21, 25, 21, 157, DateTimeKind.Local).AddTicks(4190), new Guid("2c69cb74-3172-5b78-42b9-55dad7bdd9d3") },
                    { 251, "Laborum quis rerum culpa sed saepe dolores iure saepe alias.", new DateTime(2023, 10, 6, 3, 4, 3, 579, DateTimeKind.Local).AddTicks(4597), 666015383, 217, new DateTime(2023, 10, 1, 23, 52, 26, 281, DateTimeKind.Local).AddTicks(8246), new Guid("05d6602e-2587-6aa9-984e-78f7c27f18e6") },
                    { 252, "Consequatur porro illo.", new DateTime(2023, 10, 3, 18, 28, 48, 377, DateTimeKind.Local).AddTicks(3143), 275963118, 226, new DateTime(2023, 9, 29, 5, 40, 11, 752, DateTimeKind.Local).AddTicks(924), new Guid("05d6602e-2587-6aa9-984e-78f7c27f18e6") },
                    { 253, "Sed est ab dolorum et soluta quos temporibus voluptatem.", new DateTime(2023, 10, 7, 14, 14, 44, 499, DateTimeKind.Local).AddTicks(2874), 515996064, 235, new DateTime(2023, 9, 30, 5, 39, 57, 351, DateTimeKind.Local).AddTicks(2108), new Guid("2a3e215c-d52b-0f32-74f0-773d3688f729") },
                    { 254, "Laboriosam sit velit consequatur magnam rerum natus sequi consequatur et.", new DateTime(2023, 10, 3, 19, 49, 8, 446, DateTimeKind.Local).AddTicks(9172), 453474922, 229, new DateTime(2023, 9, 29, 17, 43, 49, 349, DateTimeKind.Local).AddTicks(8578), new Guid("6ee61463-73f9-6222-a33c-904f05f9bfb6") },
                    { 255, "Consectetur dolorum pariatur id.", new DateTime(2023, 10, 4, 7, 1, 9, 987, DateTimeKind.Local).AddTicks(3979), 120450893, 242, new DateTime(2023, 10, 2, 4, 58, 48, 277, DateTimeKind.Local).AddTicks(3732), new Guid("2864e86c-7311-2523-8416-29b846f4f258") },
                    { 256, "Ipsa accusantium dicta nesciunt aut tempore pariatur nemo.", new DateTime(2023, 10, 4, 7, 17, 59, 152, DateTimeKind.Local).AddTicks(6106), 606429931, 226, new DateTime(2023, 9, 30, 4, 44, 14, 91, DateTimeKind.Local).AddTicks(7513), new Guid("eb6a362a-3355-f30e-18f9-dc5d373048a6") },
                    { 257, "Qui officiis rerum dolor alias rerum consequuntur rerum fuga.", new DateTime(2023, 10, 4, 3, 1, 53, 265, DateTimeKind.Local).AddTicks(4122), 236698866, 220, new DateTime(2023, 10, 2, 7, 0, 10, 350, DateTimeKind.Local).AddTicks(2237), new Guid("a9e86e7d-a75e-c926-6ba7-ff0811536b60") },
                    { 258, "Id ab hic aut aliquid veniam rem quibusdam.", new DateTime(2023, 10, 5, 7, 33, 23, 847, DateTimeKind.Local).AddTicks(1482), 203333518, 226, new DateTime(2023, 10, 1, 12, 36, 59, 776, DateTimeKind.Local).AddTicks(5966), new Guid("440d27e8-af1f-eb57-892c-b7aa51baa431") },
                    { 259, "Debitis dignissimos repudiandae cupiditate dignissimos.", new DateTime(2023, 10, 6, 11, 19, 37, 910, DateTimeKind.Local).AddTicks(1332), 299898343, 228, new DateTime(2023, 9, 30, 16, 46, 54, 778, DateTimeKind.Local).AddTicks(6025), new Guid("8b38ffb3-4948-249f-f254-1e0930f4dd94") },
                    { 260, "Quam magnam voluptatem numquam et sapiente tenetur occaecati.", new DateTime(2023, 10, 5, 23, 48, 36, 767, DateTimeKind.Local).AddTicks(404), 946509156, 200, new DateTime(2023, 9, 30, 3, 34, 4, 987, DateTimeKind.Local).AddTicks(2171), new Guid("2c69cb74-3172-5b78-42b9-55dad7bdd9d3") },
                    { 261, "Dolore consectetur aut molestiae natus.", new DateTime(2023, 10, 3, 22, 57, 9, 404, DateTimeKind.Local).AddTicks(7522), 187968718, 203, new DateTime(2023, 9, 30, 15, 35, 49, 376, DateTimeKind.Local).AddTicks(323), new Guid("a9e86e7d-a75e-c926-6ba7-ff0811536b60") },
                    { 262, "Inventore voluptas sed alias qui perspiciatis architecto dolores.", new DateTime(2023, 10, 4, 3, 27, 4, 570, DateTimeKind.Local).AddTicks(9857), 949679359, 226, new DateTime(2023, 10, 1, 14, 45, 5, 530, DateTimeKind.Local).AddTicks(981), new Guid("5379cefc-3ca2-f341-03ef-99354befd137") },
                    { 263, "Itaque accusamus et labore ut et ut non.", new DateTime(2023, 10, 6, 10, 39, 37, 59, DateTimeKind.Local).AddTicks(6687), 425053910, 249, new DateTime(2023, 9, 30, 21, 19, 32, 146, DateTimeKind.Local).AddTicks(969), new Guid("2a3e215c-d52b-0f32-74f0-773d3688f729") },
                    { 264, "Autem ut possimus assumenda nemo omnis consequuntur.", new DateTime(2023, 10, 4, 15, 18, 50, 473, DateTimeKind.Local).AddTicks(2608), 537595299, 200, new DateTime(2023, 9, 29, 20, 33, 17, 972, DateTimeKind.Local).AddTicks(1921), new Guid("562deb07-ac26-5451-ad53-804d96ee049c") },
                    { 265, "Consectetur id qui aperiam et iste.", new DateTime(2023, 10, 4, 21, 27, 53, 594, DateTimeKind.Local).AddTicks(6352), 880799972, 207, new DateTime(2023, 10, 1, 9, 14, 55, 638, DateTimeKind.Local).AddTicks(9914), new Guid("387d57a1-5db9-2c43-07d8-f5791de895ca") },
                    { 266, "Ut aliquid voluptatibus inventore numquam velit eveniet.", new DateTime(2023, 10, 4, 14, 19, 34, 153, DateTimeKind.Local).AddTicks(4139), 806055730, 208, new DateTime(2023, 10, 2, 3, 51, 49, 410, DateTimeKind.Local).AddTicks(2644), new Guid("3908f980-87ab-bf50-0865-df7d03d6a76b") },
                    { 267, "Ut ullam aut dicta quia nulla sint unde et ipsam.", new DateTime(2023, 10, 7, 12, 44, 35, 547, DateTimeKind.Local).AddTicks(3860), 724885667, 215, new DateTime(2023, 9, 30, 21, 39, 24, 63, DateTimeKind.Local).AddTicks(8025), new Guid("387d57a1-5db9-2c43-07d8-f5791de895ca") },
                    { 268, "Nihil blanditiis expedita recusandae beatae vitae unde qui sequi distinctio.", new DateTime(2023, 10, 3, 21, 18, 42, 28, DateTimeKind.Local).AddTicks(2759), 264566886, 242, new DateTime(2023, 10, 2, 1, 44, 53, 726, DateTimeKind.Local).AddTicks(6086), new Guid("301f6b8f-b0e6-acd6-77ac-d1cb814ec4bb") },
                    { 269, "In iste repudiandae.", new DateTime(2023, 10, 3, 18, 1, 34, 90, DateTimeKind.Local).AddTicks(2111), 549521613, 210, new DateTime(2023, 10, 1, 0, 42, 14, 608, DateTimeKind.Local).AddTicks(3692), new Guid("6ab27978-5a9e-d6e0-b65a-3db61b4c9ba5") },
                    { 270, "At debitis qui est minus.", new DateTime(2023, 10, 3, 22, 16, 25, 257, DateTimeKind.Local).AddTicks(3368), 564137944, 218, new DateTime(2023, 10, 1, 15, 47, 6, 210, DateTimeKind.Local).AddTicks(4193), new Guid("89f2361c-b854-0d97-9fe1-572c86b33a5b") },
                    { 271, "Ut voluptas doloremque quod quisquam vel cumque ut dolores vitae.", new DateTime(2023, 10, 6, 4, 51, 3, 721, DateTimeKind.Local).AddTicks(5594), 822669786, 212, new DateTime(2023, 10, 2, 8, 22, 54, 819, DateTimeKind.Local).AddTicks(9307), new Guid("301f6b8f-b0e6-acd6-77ac-d1cb814ec4bb") },
                    { 272, "Porro ad nesciunt sit iste magnam voluptatum exercitationem est.", new DateTime(2023, 10, 7, 9, 4, 17, 866, DateTimeKind.Local).AddTicks(6753), 441861603, 203, new DateTime(2023, 9, 29, 10, 30, 25, 327, DateTimeKind.Local).AddTicks(9816), new Guid("6ab27978-5a9e-d6e0-b65a-3db61b4c9ba5") },
                    { 273, "Aut quia omnis cum adipisci quaerat.", new DateTime(2023, 10, 3, 23, 31, 16, 950, DateTimeKind.Local).AddTicks(7903), 578133688, 229, new DateTime(2023, 9, 29, 6, 46, 31, 909, DateTimeKind.Local).AddTicks(814), new Guid("0995a8d0-41b6-fbf1-57c3-787eb8f3da23") },
                    { 274, "Dolorem consequatur aut.", new DateTime(2023, 10, 6, 5, 14, 17, 867, DateTimeKind.Local).AddTicks(4564), 408254191, 215, new DateTime(2023, 9, 29, 18, 30, 26, 510, DateTimeKind.Local).AddTicks(2373), new Guid("6ee61463-73f9-6222-a33c-904f05f9bfb6") },
                    { 275, "Fugiat sint nisi a et minus.", new DateTime(2023, 10, 6, 5, 31, 32, 872, DateTimeKind.Local).AddTicks(5032), 706727970, 241, new DateTime(2023, 9, 30, 11, 27, 35, 275, DateTimeKind.Local).AddTicks(794), new Guid("2ba913f8-75e4-8927-20b6-5363b2272497") },
                    { 276, "Officiis eaque eligendi omnis ut.", new DateTime(2023, 10, 6, 1, 25, 23, 216, DateTimeKind.Local).AddTicks(7167), 678401239, 219, new DateTime(2023, 10, 1, 23, 33, 43, 386, DateTimeKind.Local).AddTicks(9288), new Guid("c280a1a1-85c4-18f5-0fb4-6f762e6cfc54") },
                    { 277, "Cum quia sint.", new DateTime(2023, 10, 4, 14, 58, 31, 408, DateTimeKind.Local).AddTicks(6705), 206568806, 247, new DateTime(2023, 10, 1, 1, 59, 31, 605, DateTimeKind.Local).AddTicks(666), new Guid("440d27e8-af1f-eb57-892c-b7aa51baa431") },
                    { 278, "Illum sit corrupti a.", new DateTime(2023, 10, 6, 17, 57, 33, 263, DateTimeKind.Local).AddTicks(8387), 693153840, 227, new DateTime(2023, 9, 29, 8, 23, 52, 968, DateTimeKind.Local).AddTicks(6479), new Guid("ed28bdfc-ad3e-7851-6767-f6e975701306") },
                    { 279, "Blanditiis architecto qui quia at.", new DateTime(2023, 10, 5, 5, 16, 42, 23, DateTimeKind.Local).AddTicks(8179), 495161670, 247, new DateTime(2023, 9, 28, 23, 26, 49, 523, DateTimeKind.Local).AddTicks(6635), new Guid("b92d4a6b-a12c-4598-dcd4-871e6d2c934f") }
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
