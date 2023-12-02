using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoringApp.Data.Migrations
{
    public partial class AddIntroductionMessageToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IntroductionMessage",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9971fad-ea60-438a-9a0c-6de02a3a5d09", "AQAAAAEAACcQAAAAEKIReURW3XsU1609RmCTrAknE3KJb6BSDjalaTToeohl20PT22Z2jZ35kgcR6GjetA==", "a48f1ea1-2ffd-4406-b266-cd8973a3da46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b8b1db-23d7-4990-9846-4d7ff5524b9d", "AQAAAAEAACcQAAAAEDE3QyJttLbtW0NHerf27xVf6VrfdI+fvU1JnUfSlLrpldghkE7p+kUgVRWc6uaRXg==", "66c24a99-d83f-4a7e-a4c3-1e70aae18901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ff2b82-6ef0-4433-8292-ff608d540421", "AQAAAAEAACcQAAAAEAIZ6ZZ9v1kiOijzPs/rZ2pER3iwd5lMHf6xC6xct5WjYbGINMKRix0TaCudH3lJkQ==", "7955900b-f546-4a89-8c60-218556fefbb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "331a4737-7a7b-4721-acac-751e942d1d8b", "AQAAAAEAACcQAAAAEKxr9GeLnMMOgsDclWVww5XpdjZC2OJOMkdiCXtssw9Fuhtu1CNLmUCU5OufPzhSFw==", "3d78048b-7303-4889-901b-118861da61e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaee20c1-f964-430b-a14a-958be9c3811a", "AQAAAAEAACcQAAAAED64fNCYbLw71ItltZEO3oDhqsGy6POq8XcbAjX1z53XqWPNXO+f8ZuGweMGWTzSUA==", "3908d724-5876-457f-80bb-cd34e9f9ecb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324caaca-222e-4602-a83a-be3a4be17c97", "AQAAAAEAACcQAAAAECg6qTyrub1ZyBnnpz+h3/OZzQ9VSKUmQre8nIawqbWaAgW+Kbna+Ym9rcIiglNrlA==", "69a7869c-7818-4139-be17-8a29b9239536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "991da370-3a49-424f-8886-fa6a3de71476", "AQAAAAEAACcQAAAAEE/i6ZP7GXYOAA/+5sA3U4UZZ0k6Xx9J24Nkd0nbz6aeHezetyZWY1akBqAbX8yMLQ==", "d605123f-1320-480b-b13f-f2f942542fd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ee29577-c57f-41f0-93b1-70edbdbe9d12", "AQAAAAEAACcQAAAAECuXqnM9fA+cXNF3jRZXf6j3NaEK3Yx4Sk2kasojBBr58orKeFJf7HCFSid+Eu7B1Q==", "11a567f7-bdd0-44d8-8b8b-adc3ff85bde9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0473f87b-2e12-430f-86a3-dbef678bf0ef", "AQAAAAEAACcQAAAAEPQmRABPl9uYgzpKvk6Ab/9cfEou4a4wR0DNiumUu5zW+ozpkphAkyHxTOoHROPvBw==", "9bfdb0f5-6aef-49a5-8bc0-8e5fb383b2fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75f41748-6421-4f99-a757-5aebde568bfa", "AQAAAAEAACcQAAAAEDoWDN4gCQLqxGrQcm66iUkmt8dt2T7wRhWiWauNoAX4hKb0s6upKjeU0HTV3crPwQ==", "aecbf346-1825-410a-b5a1-2ee08e94cae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c71bf473-4479-4b05-b9b1-edb788a6b7fb", "AQAAAAEAACcQAAAAEC4755g/En4Ls6vf9vpxMycF9+CYnOGytgP+27L8ks7LpvflcSzSzt5hsvIalB0hWg==", "50d7d8dc-596b-48b9-8ff8-348578efd1c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7005aa6d-33a3-4b6e-aea4-269f3893dcd0", "AQAAAAEAACcQAAAAENw9jbQVcdgOpUZtViEZqVmCE5tCZBYXpHRn2HfffFPhLEauaks8uDP62MlJaKU+Lg==", "22c3be75-fcb6-4b35-af94-63af89e73820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51ff444a-9222-4394-848f-578ab3d6d351", "AQAAAAEAACcQAAAAEH3C6sfJL8Dd4iTCLud6WpUxLqRsPqWMzMM3MSqOAa/yp3pTzuzSgYMvgv25cn6kxQ==", "5fd25d4f-3408-45f7-b899-845e2c24e656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20252ba9-7eb7-4eb5-84fb-fe93d2e6ecae", "AQAAAAEAACcQAAAAED0uWeSyP25fxRgFCCxozqmmoXOsIvaKmHyFbai+iiv4cYKfbgjYbfL8RfpBg2rFzw==", "f76774de-d04d-49a8-b999-7e610da2abfc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntroductionMessage",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "858d0d11-9329-4a70-ae39-e70bcbbbbf6c", "AQAAAAEAACcQAAAAEM1TELzasec+eKyY6eyb0xS7cdfuFVF8YvwB0+QwcNUPhSJO5jRpdvlW0IiA1P7ysw==", "035eb834-4d35-418f-9eee-6ce3c86e9e76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e83e356-0556-487f-a8f6-d52f2cb6d5ba", "AQAAAAEAACcQAAAAEPI81jKWbBXrlJOIrJRQonecQrvAYZ0rfSKrUAMnQXUD8ENND7XsjrlTXkMaY54RyQ==", "cc18f574-0a15-46c2-a01f-c41a24dd1027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d72fca4d-c420-4d7f-a672-daabc175b7d3", "AQAAAAEAACcQAAAAELeSuD4rqp3mhib1HUK8uy+Pq8EXpl2hMNx9ca15m9YtRPOofqrWtZIBe8K0b3F0dg==", "a3fe1702-0689-4f35-9eb3-bc2ff6766950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c28ad7d1-92c4-4a76-b016-c1dc2cbfa313", "AQAAAAEAACcQAAAAED45PXM9nIbStMMul2soGNh2nZ+Y+/+0Nw7iQXg9dbuEoiW9JM+DnIjCaoQITAUHKw==", "e442d690-a743-445b-b932-49471c91f219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43040ed2-c80b-4fc0-8968-239f46fd7357", "AQAAAAEAACcQAAAAEPb3JnuM2MAySJjLC6kPCs0r9l7jENiqnKBMRmPFyWFkPD/f9bIyZ29Hyp8aAHp0NA==", "751cc180-dae6-491a-8c08-a272a831d452" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71c77fe9-ac2e-4f78-9a5c-db4b6e27d067", "AQAAAAEAACcQAAAAEM82Kn8eI5oi87+naRkf8XUmKTkqci3XudFl9OK8DCzBjtVQ9jqOWxb4NMbDyEfOOw==", "a7471ad1-405b-47a5-887d-22e779a17c70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d06cadda-2837-4a92-9d0c-0cb6e2a67df8", "AQAAAAEAACcQAAAAEEhR9uwmGE0JfdQMUo+U/kHBDgMM+zb2jiSa+dmlKhmcY9WSqAeYt7UL67uBZ5Lsyw==", "34fe558c-0e14-4c31-9d0e-04f212d81875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b84aec2-01d8-45c7-bc13-f52bcfa7b394", "AQAAAAEAACcQAAAAEHJ5OcEE/Va56BDeWmGqrcSSMmGF6tAP0BW+JJ/gGFS607akigGBi4NltSFYD+BuqQ==", "7c86c6e9-d289-4f2d-bf17-2ade670a06fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c8d3d3a-913b-4c87-b4cb-963ac65bba67", "AQAAAAEAACcQAAAAELfM+OUblDUY7YqOCKNnRk2f53C925/7JPxwfYzhunO56bvZWTht434yYaUjVZuznA==", "eebe1a85-6d02-425f-b5a4-518bce9bc521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d82a928-9a71-4468-8953-35b17afbbb15", "AQAAAAEAACcQAAAAEAtaZZRUBetbImXGJOZdxMJd9vrggIdasuaYHM9+f82bx7MSEULHLNkEbHws+I/u5w==", "101204ff-c10b-4e6b-91c6-9a14d7034dde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2de93bb8-17dc-4ba7-9442-70507fe20480", "AQAAAAEAACcQAAAAEP9sdtmjavdkC1QLuwjwWhwjyI263ISqe67rU3ZHRagahDc1SGx5u85bMML9EFM1YA==", "06120409-b562-4b7a-ab73-c42461cc77a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2a088b9-0fc8-40bf-b5a2-087a7d7cb32f", "AQAAAAEAACcQAAAAEP9QfQCA4gvn5ccme6s26XLNbyQH1GPu4M+q92o9qZzLBKODgVhuFY7oCQLPrMafeQ==", "b4b6979a-f5df-4c59-bd9f-164d7f65f3a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66eecb98-5be6-4498-92ae-94ad8eb54120", "AQAAAAEAACcQAAAAEIl5ch832vH97sf5hoCSl8bo3TZW4zATVTqSqum0apVcum2qIHyMDfELLoDX0STM4A==", "81ed11fc-336a-4df3-b473-98464967e8e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbb0a968-1d13-401d-844c-0050e96bba1c", "AQAAAAEAACcQAAAAEMY/TiJVHsjJ5mlvy2Wrn0TQkKqtu79aIQw51YdakEUqbQZ9SSSD3fGrPnl1eoGdxw==", "35ba807a-8454-4a9f-b781-9abf463c1a7e" });
        }
    }
}
