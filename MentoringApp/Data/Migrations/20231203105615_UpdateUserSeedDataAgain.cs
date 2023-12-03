using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoringApp.Data.Migrations
{
    public partial class UpdateUserSeedDataAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89bc6894-b311-4059-b438-bc9c5bcf51ba", "HARRY@EXAMPLE.COM", "HARRY@EXAMPLE.COM", "AQAAAAEAACcQAAAAEHwNYTm8vAjg33PFmJYIzLn1RXasE2tkkka82LoiLIqMawPaW4Rwb8rgPNyBf0dGqg==", "96209122-7b35-41b6-adf7-119f1f43f9b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd477394-5665-417f-a880-05b8d2a6c183", "BRUNO@EXAMPLE.COM", "BRUNO@EXAMPLE.COM", "AQAAAAEAACcQAAAAEBqO9/c3s/LwyTVPrazmSDolON72uqXV65OakeUx/vtWRvdoVArWuur2XwkaSkhfww==", "79ca90d0-24a2-4657-91df-c5dc0737129e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08cd13da-8fb8-4e86-81f8-e6bfb08fbf51", "CLAIRE@EXAMPLE.COM", "CLAIRE@EXAMPLE.COM", "AQAAAAEAACcQAAAAEPr833kh2CxMD2QZ+6oiJ0Bj4BlPsgGEkTouj6ITOsxfoHC3Kaf5vJ1Pd9fZtIaOZw==", "22402b1c-00fe-4e31-8601-1f11ecb4b6d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e7e9b25-2714-4c50-8b83-4ac651f06bfb", "QASIM@EXAMPLE.COM", "QASIM@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJuIOBa8P5/uBarzDn3usEjL+KhKbIWHGbzb7FQ3TIDAjv6GHNvVCXGxV3vaEuZp6w==", "89ba4f32-05ec-4b4b-a8d4-0b803124fb48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3b5b6fd-c021-4ebc-a9d7-472b87567d73", "MINHO@EXAMPLE.COM", "MINHO@EXAMPLE.COM", "AQAAAAEAACcQAAAAEGzrNzFiPd5KcT4CY6GvjN/qI/8QbyLN+NEujpDPRUn6mvUXN+HJ7FTttFIAON0CUw==", "824078b0-c76d-4c2a-8a68-d4af09c436d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd52168-170a-4054-b89e-f7be2a835c6b", "OLGA@EXAMPLE.COM", "OLGA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEOvw3d3vJeT0+v6ssDykNlYjwhE3TqXfvbP3ukLjDy3EEmaK6u69+S9pgivtsyLdFg==", "e82ce2ca-f7c4-4567-b8f2-0c22e63261bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "104e92f4-787c-4260-92e2-d14e8e67def5", "AQAAAAEAACcQAAAAEKYOzE0GD9E+Ke9eQFtzJRtnBRdYVbVuZ/h60psHIrVLj8YbhY5gexrLLy/CQGVieA==", "6440a666-d0d1-4e06-876a-75ed4c0ea804" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9e4e7c8-2f9b-44c1-a291-bc0d284bf874", "HAKEEM@EXAMPLE.COM", "HAKEEM@EXAMPLE.COM", "AQAAAAEAACcQAAAAELu0VXVCSMlaZgrfSLwzFYydwO82vxhJzjBk1zqrE2r9qNC5My30Q0vBV1QO/1Cb+A==", "3e20ef17-0399-4490-873e-6af5b45829ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8ede3c6-ac15-4f5b-a365-7089d9dd842c", "PRIYANKA@EXAMPLE.COM", "PRIYANKA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEEKRcNts66fku8zFMedvv43MWP4emihetJAkg+43IVO4rggxIz9hxXA/t6Fzd62yFQ==", "576c17b9-2113-442f-8a47-e746a7e14183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aba105d-918d-4b19-aabf-7b59f24f1bfc", "ROBIN@EXAMPLE.COM", "ROBIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAENGInZk2HDxZ/QAobAsPmtuL8JzobcjXDzsNXSyGjFJLvJM/EPJEEuZFEHWt3lGR2A==", "6c176318-6265-41a5-af06-0e77626134b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "302dc751-60f6-4461-a19c-e792f782e6e4", "JUN@EXAMPLE.COM", "JUN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJnuMFuRndIq+hYesXddU/92xzIScqx6P6BWBQi/Qy7Rp+ZyF6aB1+00ur+6+fC5uw==", "682369af-3bd3-4ea0-b288-efa5a2edc150" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1f2e13e-cef0-44c8-86fa-2cb6c66a5a61", "MARIA@EXAMPLE.COM", "MARIA@EXAMPLE.COM", "AQAAAAEAACcQAAAAEJsS5j2FN/CET/EE90DxTi33TAq1Q30QB/kr+0s7gFI7Zj1y/G5oB8q9//Zl4/sMew==", "dec9657e-65a7-42d9-a333-3e3f4c066457" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3e8f65b-2cf7-4174-bfa7-c663b7c49b37", "JOHN@EXAMPLE.COM", "JOHN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEB/sKj5aTB0OpLCf8yxOBj6lBRGITi3DBC9vIpN/4rmsdLGJxnrbNK+ZuTwxiQNNog==", "0117c45f-ebaa-402a-b89c-ddf182f9702c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0065ad0-53fc-4daf-818b-fb697c0e9b79", "EMILY@EXAMPLE.COM", "EMILY@EXAMPLE.COM", "AQAAAAEAACcQAAAAEP55VUpBq0scYDNSz+oCob/d7fd1WENJ1BvgLvh75SgTxj/vf5RjtD/JG7TVsnPKNg==", "c4ba4e2a-b9aa-4077-80c4-fc349a362635" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "612bc8ce-4088-4233-89be-973a62d45311", null, null, "AQAAAAEAACcQAAAAEOpPjWtagA70/7tsu2NwLTpPdAvlnRNA/bLQ1BbNtx2Yq6tNgkvkV5tNuTw15CecSg==", "a4bab67f-a8f9-4bbf-a0bd-2f264525dd32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28816701-b4de-4d64-a360-edd4d34301d1", null, null, "AQAAAAEAACcQAAAAELkDZTWPxhJt+CRvNlPyM6JSAFC2aTNOy705MBu4OzMi1P6Q+mj0VvG89E8iT1LFvA==", "de212718-b7e8-46f0-9aa3-e815baf855ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7906ef13-ad6a-4721-9b08-05aa9e27306d", null, null, "AQAAAAEAACcQAAAAEBr45zBvmsWvl6xrYUbuYvhmETFadKckKc7VkfuQD7pmsAqyIlH2jWNwub/J9OcGEw==", "719fe91b-2835-4cf7-8c40-e07c0a64af2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9374a66-29b7-4606-962d-5cbcd2e5c8e0", null, null, "AQAAAAEAACcQAAAAECCHx6TW+x5AoYYZ+UJlqUnDfZ7ubnn4t7+WHbLgVvyXT2gNTv3ivtM94vu/OZ9uKA==", "78a05e38-944f-4c82-96a3-680d00f2e9bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01b20924-23b1-46da-86ce-7fb4354db21f", null, null, "AQAAAAEAACcQAAAAEJWxQIgts0h1UOEnIs5D/uCdu/TSvnfdIfe/oT8r7SvKLGhlvb4Gw3zSvTmbG9CReQ==", "f765d6e0-df20-4580-a284-0e7cb931b8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ce0f38e-7b86-4ab0-a1d2-e5cebda7a75d", null, null, "AQAAAAEAACcQAAAAEG06n686rnm4/4IE/3ypctnDiWQxqHG3ccsOhOONHOYkE/C7+bl4RJ4l/MxrLUDCUg==", "859f460d-e790-41bd-8aef-7ac61abb0418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ea5a56a-6827-4fba-9dab-785db2d5696e", "AQAAAAEAACcQAAAAEI5uEFn7/RDZYP56oIJKnZKQDvQ4JmqI1+sN4gesoCQFmep04aw6030A3n1XVbVtKQ==", "882205c0-614d-4c19-b3fa-3ea046ed7fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e480aa-ff22-4ced-be60-6a1548edc8a3", null, null, "AQAAAAEAACcQAAAAELMEQKQNkRgGFc2BpfqzyiFx4jO+b0aIxwg60nxM0R+3S7XNty1Q8zXJ7RlDamYq2Q==", "b43dbf4d-afc2-47c1-a2ba-7e6e81740867" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00fcee52-10c1-466f-83b2-3d43968e8a12", null, null, "AQAAAAEAACcQAAAAEG7DZkGWSJ3n0ch6L4W9l5Nk7RKelqz5gW8sM72wu947IAeNJgUWgdUZObPZhS6GrQ==", "9e503760-ce2b-4a14-9812-db851d2381c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6426459-0e64-4a91-9750-fb64f91ccf55", null, null, "AQAAAAEAACcQAAAAELo4XFXnCn/93V7SDR6kOJxzS/bX6Fz7wThoqXOnjlhV5uBtH9AKbLBQBNMBs58YSg==", "d5e790c1-d651-4720-94bc-e7334df5f525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ba20631-be0e-4193-ac1c-36fe2ed79c8b", null, null, "AQAAAAEAACcQAAAAEPVk8cxm3eX6TVmj4YUhRSj/cR126BlnsV43AusYv3MGFKprRuKIILgiFCs72kPDhw==", "42bd9302-7ad1-4267-9d0f-9b8acf374073" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ba5ecbb-2e49-4796-920f-899420fe8047", null, null, "AQAAAAEAACcQAAAAEChUO2naeM6ABzeDlYyGa5sZQoLxxV+K2tG7efuKGwgrmdiRuO22NadCuVEsoisEig==", "aacf5e05-d244-420b-a188-819d840cdee0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c385cb27-c11a-4885-b8c5-d6a1627f29af", null, null, "AQAAAAEAACcQAAAAEECiGAsmsKPRvkhcPFi0gxCaL28ldcz7eA9vslrvKoZE4i+YiDp6go1grvZzn8g1WQ==", "efc77a72-7928-41f0-9a6f-4144ec0250cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "383c9ac7-e7d9-4e3a-879a-c901379617d6", null, null, "AQAAAAEAACcQAAAAEBRD/v7wAmldQqn5ej6BoYBcE3y7zqL/LCXjXi6jhZs/+15ZeSbQRjB389rve9ad0w==", "2ddfc326-71a9-4246-9668-b8214361e675" });
        }
    }
}
