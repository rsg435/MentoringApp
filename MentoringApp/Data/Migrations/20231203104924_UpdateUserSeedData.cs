using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoringApp.Data.Migrations
{
    public partial class UpdateUserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "ConnectionRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "ConnectionRequests",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "612bc8ce-4088-4233-89be-973a62d45311", "AQAAAAEAACcQAAAAEOpPjWtagA70/7tsu2NwLTpPdAvlnRNA/bLQ1BbNtx2Yq6tNgkvkV5tNuTw15CecSg==", true, "a4bab67f-a8f9-4bbf-a0bd-2f264525dd32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "28816701-b4de-4d64-a360-edd4d34301d1", "AQAAAAEAACcQAAAAELkDZTWPxhJt+CRvNlPyM6JSAFC2aTNOy705MBu4OzMi1P6Q+mj0VvG89E8iT1LFvA==", true, "de212718-b7e8-46f0-9aa3-e815baf855ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "7906ef13-ad6a-4721-9b08-05aa9e27306d", "AQAAAAEAACcQAAAAEBr45zBvmsWvl6xrYUbuYvhmETFadKckKc7VkfuQD7pmsAqyIlH2jWNwub/J9OcGEw==", true, "719fe91b-2835-4cf7-8c40-e07c0a64af2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "c9374a66-29b7-4606-962d-5cbcd2e5c8e0", "AQAAAAEAACcQAAAAECCHx6TW+x5AoYYZ+UJlqUnDfZ7ubnn4t7+WHbLgVvyXT2gNTv3ivtM94vu/OZ9uKA==", true, "78a05e38-944f-4c82-96a3-680d00f2e9bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "01b20924-23b1-46da-86ce-7fb4354db21f", "AQAAAAEAACcQAAAAEJWxQIgts0h1UOEnIs5D/uCdu/TSvnfdIfe/oT8r7SvKLGhlvb4Gw3zSvTmbG9CReQ==", true, "f765d6e0-df20-4580-a284-0e7cb931b8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "5ce0f38e-7b86-4ab0-a1d2-e5cebda7a75d", "AQAAAAEAACcQAAAAEG06n686rnm4/4IE/3ypctnDiWQxqHG3ccsOhOONHOYkE/C7+bl4RJ4l/MxrLUDCUg==", true, "859f460d-e790-41bd-8aef-7ac61abb0418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "7ea5a56a-6827-4fba-9dab-785db2d5696e", "JIANG@EXAMPLE.COM", "JIANG@EXAMPLE.COM", "AQAAAAEAACcQAAAAEI5uEFn7/RDZYP56oIJKnZKQDvQ4JmqI1+sN4gesoCQFmep04aw6030A3n1XVbVtKQ==", true, "882205c0-614d-4c19-b3fa-3ea046ed7fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "31e480aa-ff22-4ced-be60-6a1548edc8a3", "AQAAAAEAACcQAAAAELMEQKQNkRgGFc2BpfqzyiFx4jO+b0aIxwg60nxM0R+3S7XNty1Q8zXJ7RlDamYq2Q==", true, "b43dbf4d-afc2-47c1-a2ba-7e6e81740867" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "00fcee52-10c1-466f-83b2-3d43968e8a12", "AQAAAAEAACcQAAAAEG7DZkGWSJ3n0ch6L4W9l5Nk7RKelqz5gW8sM72wu947IAeNJgUWgdUZObPZhS6GrQ==", true, "9e503760-ce2b-4a14-9812-db851d2381c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "d6426459-0e64-4a91-9750-fb64f91ccf55", "AQAAAAEAACcQAAAAELo4XFXnCn/93V7SDR6kOJxzS/bX6Fz7wThoqXOnjlhV5uBtH9AKbLBQBNMBs58YSg==", true, "d5e790c1-d651-4720-94bc-e7334df5f525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "0ba20631-be0e-4193-ac1c-36fe2ed79c8b", "AQAAAAEAACcQAAAAEPVk8cxm3eX6TVmj4YUhRSj/cR126BlnsV43AusYv3MGFKprRuKIILgiFCs72kPDhw==", true, "42bd9302-7ad1-4267-9d0f-9b8acf374073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "5ba5ecbb-2e49-4796-920f-899420fe8047", "AQAAAAEAACcQAAAAEChUO2naeM6ABzeDlYyGa5sZQoLxxV+K2tG7efuKGwgrmdiRuO22NadCuVEsoisEig==", true, "aacf5e05-d244-420b-a188-819d840cdee0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "c385cb27-c11a-4885-b8c5-d6a1627f29af", "AQAAAAEAACcQAAAAEECiGAsmsKPRvkhcPFi0gxCaL28ldcz7eA9vslrvKoZE4i+YiDp6go1grvZzn8g1WQ==", true, "efc77a72-7928-41f0-9a6f-4144ec0250cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "383c9ac7-e7d9-4e3a-879a-c901379617d6", "AQAAAAEAACcQAAAAEBRD/v7wAmldQqn5ej6BoYBcE3y7zqL/LCXjXi6jhZs/+15ZeSbQRjB389rve9ad0w==", true, "2ddfc326-71a9-4246-9668-b8214361e675" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "ConnectionRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "ConnectionRequests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "d9971fad-ea60-438a-9a0c-6de02a3a5d09", "AQAAAAEAACcQAAAAEKIReURW3XsU1609RmCTrAknE3KJb6BSDjalaTToeohl20PT22Z2jZ35kgcR6GjetA==", false, "a48f1ea1-2ffd-4406-b266-cd8973a3da46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "d7b8b1db-23d7-4990-9846-4d7ff5524b9d", "AQAAAAEAACcQAAAAEDE3QyJttLbtW0NHerf27xVf6VrfdI+fvU1JnUfSlLrpldghkE7p+kUgVRWc6uaRXg==", false, "66c24a99-d83f-4a7e-a4c3-1e70aae18901" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "15ff2b82-6ef0-4433-8292-ff608d540421", "AQAAAAEAACcQAAAAEAIZ6ZZ9v1kiOijzPs/rZ2pER3iwd5lMHf6xC6xct5WjYbGINMKRix0TaCudH3lJkQ==", false, "7955900b-f546-4a89-8c60-218556fefbb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "331a4737-7a7b-4721-acac-751e942d1d8b", "AQAAAAEAACcQAAAAEKxr9GeLnMMOgsDclWVww5XpdjZC2OJOMkdiCXtssw9Fuhtu1CNLmUCU5OufPzhSFw==", false, "3d78048b-7303-4889-901b-118861da61e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "eaee20c1-f964-430b-a14a-958be9c3811a", "AQAAAAEAACcQAAAAED64fNCYbLw71ItltZEO3oDhqsGy6POq8XcbAjX1z53XqWPNXO+f8ZuGweMGWTzSUA==", false, "3908d724-5876-457f-80bb-cd34e9f9ecb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "324caaca-222e-4602-a83a-be3a4be17c97", "AQAAAAEAACcQAAAAECg6qTyrub1ZyBnnpz+h3/OZzQ9VSKUmQre8nIawqbWaAgW+Kbna+Ym9rcIiglNrlA==", false, "69a7869c-7818-4139-be17-8a29b9239536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "991da370-3a49-424f-8886-fa6a3de71476", null, null, "AQAAAAEAACcQAAAAEE/i6ZP7GXYOAA/+5sA3U4UZZ0k6Xx9J24Nkd0nbz6aeHezetyZWY1akBqAbX8yMLQ==", false, "d605123f-1320-480b-b13f-f2f942542fd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "4ee29577-c57f-41f0-93b1-70edbdbe9d12", "AQAAAAEAACcQAAAAECuXqnM9fA+cXNF3jRZXf6j3NaEK3Yx4Sk2kasojBBr58orKeFJf7HCFSid+Eu7B1Q==", false, "11a567f7-bdd0-44d8-8b8b-adc3ff85bde9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "0473f87b-2e12-430f-86a3-dbef678bf0ef", "AQAAAAEAACcQAAAAEPQmRABPl9uYgzpKvk6Ab/9cfEou4a4wR0DNiumUu5zW+ozpkphAkyHxTOoHROPvBw==", false, "9bfdb0f5-6aef-49a5-8bc0-8e5fb383b2fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "75f41748-6421-4f99-a757-5aebde568bfa", "AQAAAAEAACcQAAAAEDoWDN4gCQLqxGrQcm66iUkmt8dt2T7wRhWiWauNoAX4hKb0s6upKjeU0HTV3crPwQ==", false, "aecbf346-1825-410a-b5a1-2ee08e94cae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "c71bf473-4479-4b05-b9b1-edb788a6b7fb", "AQAAAAEAACcQAAAAEC4755g/En4Ls6vf9vpxMycF9+CYnOGytgP+27L8ks7LpvflcSzSzt5hsvIalB0hWg==", false, "50d7d8dc-596b-48b9-8ff8-348578efd1c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "7005aa6d-33a3-4b6e-aea4-269f3893dcd0", "AQAAAAEAACcQAAAAENw9jbQVcdgOpUZtViEZqVmCE5tCZBYXpHRn2HfffFPhLEauaks8uDP62MlJaKU+Lg==", false, "22c3be75-fcb6-4b35-af94-63af89e73820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "51ff444a-9222-4394-848f-578ab3d6d351", "AQAAAAEAACcQAAAAEH3C6sfJL8Dd4iTCLud6WpUxLqRsPqWMzMM3MSqOAa/yp3pTzuzSgYMvgv25cn6kxQ==", false, "5fd25d4f-3408-45f7-b899-845e2c24e656" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "20252ba9-7eb7-4eb5-84fb-fe93d2e6ecae", "AQAAAAEAACcQAAAAED0uWeSyP25fxRgFCCxozqmmoXOsIvaKmHyFbai+iiv4cYKfbgjYbfL8RfpBg2rFzw==", false, "f76774de-d04d-49a8-b999-7e610da2abfc" });
        }
    }
}
