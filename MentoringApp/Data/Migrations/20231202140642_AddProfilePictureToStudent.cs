using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoringApp.Data.Migrations
{
    public partial class AddProfilePictureToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "858d0d11-9329-4a70-ae39-e70bcbbbbf6c", "AQAAAAEAACcQAAAAEM1TELzasec+eKyY6eyb0xS7cdfuFVF8YvwB0+QwcNUPhSJO5jRpdvlW0IiA1P7ysw==", "1234567890", "035eb834-4d35-418f-9eee-6ce3c86e9e76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2e83e356-0556-487f-a8f6-d52f2cb6d5ba", "AQAAAAEAACcQAAAAEPI81jKWbBXrlJOIrJRQonecQrvAYZ0rfSKrUAMnQXUD8ENND7XsjrlTXkMaY54RyQ==", "1234567890", "cc18f574-0a15-46c2-a01f-c41a24dd1027" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "d72fca4d-c420-4d7f-a672-daabc175b7d3", "AQAAAAEAACcQAAAAELeSuD4rqp3mhib1HUK8uy+Pq8EXpl2hMNx9ca15m9YtRPOofqrWtZIBe8K0b3F0dg==", "1234567890", "a3fe1702-0689-4f35-9eb3-bc2ff6766950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "c28ad7d1-92c4-4a76-b016-c1dc2cbfa313", "AQAAAAEAACcQAAAAED45PXM9nIbStMMul2soGNh2nZ+Y+/+0Nw7iQXg9dbuEoiW9JM+DnIjCaoQITAUHKw==", "1234567890", "e442d690-a743-445b-b932-49471c91f219" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "43040ed2-c80b-4fc0-8968-239f46fd7357", "AQAAAAEAACcQAAAAEPb3JnuM2MAySJjLC6kPCs0r9l7jENiqnKBMRmPFyWFkPD/f9bIyZ29Hyp8aAHp0NA==", "1234567890", "751cc180-dae6-491a-8c08-a272a831d452" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "71c77fe9-ac2e-4f78-9a5c-db4b6e27d067", "AQAAAAEAACcQAAAAEM82Kn8eI5oi87+naRkf8XUmKTkqci3XudFl9OK8DCzBjtVQ9jqOWxb4NMbDyEfOOw==", "1234567890", "a7471ad1-405b-47a5-887d-22e779a17c70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "d06cadda-2837-4a92-9d0c-0cb6e2a67df8", "AQAAAAEAACcQAAAAEEhR9uwmGE0JfdQMUo+U/kHBDgMM+zb2jiSa+dmlKhmcY9WSqAeYt7UL67uBZ5Lsyw==", "1234567890", "34fe558c-0e14-4c31-9d0e-04f212d81875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "9b84aec2-01d8-45c7-bc13-f52bcfa7b394", "AQAAAAEAACcQAAAAEHJ5OcEE/Va56BDeWmGqrcSSMmGF6tAP0BW+JJ/gGFS607akigGBi4NltSFYD+BuqQ==", "1234567890", "7c86c6e9-d289-4f2d-bf17-2ade670a06fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4c8d3d3a-913b-4c87-b4cb-963ac65bba67", "AQAAAAEAACcQAAAAELfM+OUblDUY7YqOCKNnRk2f53C925/7JPxwfYzhunO56bvZWTht434yYaUjVZuznA==", "1234567890", "eebe1a85-6d02-425f-b5a4-518bce9bc521" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "1d82a928-9a71-4468-8953-35b17afbbb15", "AQAAAAEAACcQAAAAEAtaZZRUBetbImXGJOZdxMJd9vrggIdasuaYHM9+f82bx7MSEULHLNkEbHws+I/u5w==", "1234567890", "101204ff-c10b-4e6b-91c6-9a14d7034dde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "2de93bb8-17dc-4ba7-9442-70507fe20480", "AQAAAAEAACcQAAAAEP9sdtmjavdkC1QLuwjwWhwjyI263ISqe67rU3ZHRagahDc1SGx5u85bMML9EFM1YA==", "1234567890", "06120409-b562-4b7a-ab73-c42461cc77a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "a2a088b9-0fc8-40bf-b5a2-087a7d7cb32f", "AQAAAAEAACcQAAAAEP9QfQCA4gvn5ccme6s26XLNbyQH1GPu4M+q92o9qZzLBKODgVhuFY7oCQLPrMafeQ==", "1234567890", "b4b6979a-f5df-4c59-bd9f-164d7f65f3a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "66eecb98-5be6-4498-92ae-94ad8eb54120", "AQAAAAEAACcQAAAAEIl5ch832vH97sf5hoCSl8bo3TZW4zATVTqSqum0apVcum2qIHyMDfELLoDX0STM4A==", "1234567890", "81ed11fc-336a-4df3-b473-98464967e8e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "cbb0a968-1d13-401d-844c-0050e96bba1c", "AQAAAAEAACcQAAAAEMY/TiJVHsjJ5mlvy2Wrn0TQkKqtu79aIQw51YdakEUqbQZ9SSSD3fGrPnl1eoGdxw==", "1234567890", "35ba807a-8454-4a9f-b781-9abf463c1a7e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b8e7054e-6d3e-4217-8c6d-8875da35e752", "AQAAAAEAACcQAAAAEKmwPZweXVTpd2JYCrJwoZwE8MDWvrKMr3vxuZe4tKnVvqvrl6eNTfoaTosz1F9Fzg==", null, "d1c00913-7bef-49e5-873c-de643cc1cb65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "79831ba1-066d-4380-83c8-fec22ac1c4dc", "AQAAAAEAACcQAAAAEJV6kytuUbn8YuaJV1mPukksMg14O/v6K5zNookMatG1QIB4EytKi+tdO9mjhWJIBQ==", null, "a7ba0115-4e27-4341-8d81-f25c3d64093f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "80a8b3fd-5ff2-47cd-bd93-adf873bf4e83", "AQAAAAEAACcQAAAAEDGdzhzuVKCRmJybocO/1CKCTLTf7XSH47zLQ+/pllGt3YgeyyMjRbOO2lf5g3GedQ==", null, "1a6e74ea-a354-465a-937c-b9990c92bd27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "4b40dc96-3611-4d15-9be0-a37cd9325e37", "AQAAAAEAACcQAAAAEKhDbkIFKegW+mDrqDxlc4B5mnTt9/gchjEWqY65qFW8SNvizakeX77KPjS4apCkjw==", null, "2ad6adc7-b8cf-423a-b3ff-866ce386d02b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "c827b27f-4bcf-4237-a387-a85606ae98c9", "AQAAAAEAACcQAAAAECxg4t4u86ZoTQOpJpgtMdxmigiKPLLT5o8jeuppKFQXeExESemJpTrv9zrTjKO0oQ==", null, "dab5d16d-9493-423c-a96b-eb76989e76bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "c43e65ee-82b0-45af-89a8-8638dd02f6aa", "AQAAAAEAACcQAAAAEOkLg1tV4mRVMbIIB17RzDZaTxNIY3s6zzDiL3HM5QMZWjTMxRrgLdBf43UpgMt/MQ==", null, "b1d36170-6ee5-434d-bfb3-200b6c71353e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "515d40c5-2add-443d-8bfb-b8df31971594", "AQAAAAEAACcQAAAAEFjBbO+kiYJE70DOX4U4PRarIGL8f6bwU1S+toBVNaOaLpbieNuyUuZe8UclV+UwiA==", null, "1060e075-a8c2-4f78-b83b-23b0f38c18ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "83fa59b2-b883-4b53-ac24-7c73336729c2", "AQAAAAEAACcQAAAAEJ9LqJStzDFYHMui/rPbbgvxHmD7ZI4YhN7z+FB3NGcD1KirPKZnLJjdGBJ9kq7J0Q==", null, "e1162ce9-85e9-4461-8473-0d5ae2f968da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "85474181-25a7-4f2c-9710-bd878e995d26", "AQAAAAEAACcQAAAAEHMm829ayaM4KZaE92v32Tmipq+vk+LqZAESfMPGYJsmKAFsHE5gN1/Ctf8hH+Qi6Q==", null, "983ac23c-7a54-4871-904f-ba5027bce1bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "1f2cf332-2646-417a-9f3c-d7c3f5a6003b", "AQAAAAEAACcQAAAAEAZZiXk5XwThSjaHzv75TZsikpMHfrqyt5B0QZ7mKSA5S0+6b5LcFODrjuOG9gCLbw==", null, "3ca12b0b-93ba-4cc2-a942-071263c3e158" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "71a6940c-ae2a-4c25-87ae-88acc4e203b7", "AQAAAAEAACcQAAAAEDVAcP7aVwXtTfHKUVGN/7NGIVXMI5LgxfeUtin2zY1gDFxRfQUtLdXyUFIHy47ezg==", null, "9dac025e-81b1-44f0-8597-3bd151866108" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f590d3b4-2bf3-4f41-84b4-9f7ca2cf0dfe", "AQAAAAEAACcQAAAAEOePfX0fYaJnwSzPl0XvLoo2v1O674ns6MJzskyM1pHev2Ov2NIw2S8G77WUJz4ODg==", null, "1b8e5e05-724c-48b3-8d7e-f332b816c308" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "cda61413-3003-40b6-9865-0c90a01cfd5a", "AQAAAAEAACcQAAAAEAYkNDHAhkE0Qff7rBl1uzi9xOsnHaAOjvF0p8r6ieGBPM5aFqZWUEuStsOZKlQuBw==", null, "9827f29d-5579-4567-8fee-a33c39c329b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "0f08e65b-1959-4d67-b8b6-7b86aa4235aa", "AQAAAAEAACcQAAAAEEKirlFwpGNSLCTXb35nO2I/YIL73WAhXr2TvlQs1v622AtW0mXj4hDKLsCZW7k8gA==", null, "d8af407c-4621-4c32-9da1-8198d4ef01e8" });
        }
    }
}
