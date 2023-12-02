using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MentoringApp.Data.Migrations
{
    public partial class SeedStudentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AreaOfStudy", "ConcurrencyStamp", "CourseName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "MentorId", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UniversityId", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "Technology", "b8e7054e-6d3e-4217-8c6d-8875da35e752", "MSc Computing", "harry@example.com", false, false, null, null, "Harry Smith", null, null, "AQAAAAEAACcQAAAAEKmwPZweXVTpd2JYCrJwoZwE8MDWvrKMr3vxuZe4tKnVvqvrl6eNTfoaTosz1F9Fzg==", null, false, 0, "d1c00913-7bef-49e5-873c-de643cc1cb65", false, 1, "harry@example.com" },
                    { "10", 0, "Technology", "79831ba1-066d-4380-83c8-fec22ac1c4dc", "MSc IT Management", "bruno@example.com", false, false, null, null, "Bruno Silva", null, null, "AQAAAAEAACcQAAAAEJV6kytuUbn8YuaJV1mPukksMg14O/v6K5zNookMatG1QIB4EytKi+tdO9mjhWJIBQ==", null, false, 1, "a7ba0115-4e27-4341-8d81-f25c3d64093f", false, 1, "bruno@example.com" },
                    { "11", 0, "Technology", "80a8b3fd-5ff2-47cd-bd93-adf873bf4e83", "BSc Computer Science for Games", "emily@example.com", false, false, null, null, "Claire Martin", null, null, "AQAAAAEAACcQAAAAEDGdzhzuVKCRmJybocO/1CKCTLTf7XSH47zLQ+/pllGt3YgeyyMjRbOO2lf5g3GedQ==", null, false, 1, "1a6e74ea-a354-465a-937c-b9990c92bd27", false, 1, "claire@example.com" },
                    { "12", 0, "Technology", "4b40dc96-3611-4d15-9be0-a37cd9325e37", "BSc Artificial Intelligence", "qasim@example.com", false, false, null, null, "Qasim Khan", null, null, "AQAAAAEAACcQAAAAEKhDbkIFKegW+mDrqDxlc4B5mnTt9/gchjEWqY65qFW8SNvizakeX77KPjS4apCkjw==", null, false, 1, "2ad6adc7-b8cf-423a-b3ff-866ce386d02b", false, 2, "qasim@example.com" },
                    { "13", 0, "Business", "c827b27f-4bcf-4237-a387-a85606ae98c9", "BSc Chemistry", "minho@example.com", false, false, null, null, "Min-ho Lee", null, null, "AQAAAAEAACcQAAAAECxg4t4u86ZoTQOpJpgtMdxmigiKPLLT5o8jeuppKFQXeExESemJpTrv9zrTjKO0oQ==", null, false, 1, "dab5d16d-9493-423c-a96b-eb76989e76bd", false, 2, "minho@example.com" },
                    { "14", 0, "Creative Arts", "c43e65ee-82b0-45af-89a8-8638dd02f6aa", "BA Printmaking", "olga@example.com", false, false, null, null, "Olga Nowak", null, null, "AQAAAAEAACcQAAAAEOkLg1tV4mRVMbIIB17RzDZaTxNIY3s6zzDiL3HM5QMZWjTMxRrgLdBf43UpgMt/MQ==", null, false, 1, "b1d36170-6ee5-434d-bfb3-200b6c71353e", false, 3, "olga@example.com" },
                    { "2", 0, "Technology", "515d40c5-2add-443d-8bfb-b8df31971594", "BSc Computer Science", "jiang@example.com", false, false, null, null, "Shuying Jiang", null, null, "AQAAAAEAACcQAAAAEFjBbO+kiYJE70DOX4U4PRarIGL8f6bwU1S+toBVNaOaLpbieNuyUuZe8UclV+UwiA==", null, false, 0, "1060e075-a8c2-4f78-b83b-23b0f38c18ab", false, 1, "jiang@example.com" },
                    { "3", 0, "Technology", "83fa59b2-b883-4b53-ac24-7c73336729c2", "MSc Big Data Analytics", "hakeem@example.com", false, false, null, null, "Hakeem Kae-Kazim", null, null, "AQAAAAEAACcQAAAAEJ9LqJStzDFYHMui/rPbbgvxHmD7ZI4YhN7z+FB3NGcD1KirPKZnLJjdGBJ9kq7J0Q==", null, false, 0, "e1162ce9-85e9-4461-8473-0d5ae2f968da", false, 1, "hakeem@example.com" },
                    { "4", 0, "Arts and Humanities", "85474181-25a7-4f2c-9710-bd878e995d26", "BA History", "priyanka@example.com", false, false, null, null, "Priyanka Chopra", null, null, "AQAAAAEAACcQAAAAEHMm829ayaM4KZaE92v32Tmipq+vk+LqZAESfMPGYJsmKAFsHE5gN1/Ctf8hH+Qi6Q==", null, false, 0, "983ac23c-7a54-4871-904f-ba5027bce1bf", false, 3, "priyanka@example.com" },
                    { "5", 0, "Arts and Humanities", "1f2cf332-2646-417a-9f3c-d7c3f5a6003b", "BA Politics", "robin@example.com", false, false, null, null, "Robin Hawthorn", null, null, "AQAAAAEAACcQAAAAEAZZiXk5XwThSjaHzv75TZsikpMHfrqyt5B0QZ7mKSA5S0+6b5LcFODrjuOG9gCLbw==", null, false, 0, "3ca12b0b-93ba-4cc2-a942-071263c3e158", false, 3, "robin@example.com" },
                    { "6", 0, "Business", "71a6940c-ae2a-4c25-87ae-88acc4e203b7", "BSc Management Studies", "jun@example.com", false, false, null, null, "Jun Matsumoto", null, null, "AQAAAAEAACcQAAAAEDVAcP7aVwXtTfHKUVGN/7NGIVXMI5LgxfeUtin2zY1gDFxRfQUtLdXyUFIHy47ezg==", null, false, 0, "9dac025e-81b1-44f0-8597-3bd151866108", false, 2, "jun@example.com" },
                    { "7", 0, "Science", "f590d3b4-2bf3-4f41-84b4-9f7ca2cf0dfe", "BSc Zoology", "maria@example.com", false, false, null, null, "Maria Spiridakos", null, null, "AQAAAAEAACcQAAAAEOePfX0fYaJnwSzPl0XvLoo2v1O674ns6MJzskyM1pHev2Ov2NIw2S8G77WUJz4ODg==", null, false, 0, "1b8e5e05-724c-48b3-8d7e-f332b816c308", false, 2, "maria@example.com" },
                    { "8", 0, "Business", "cda61413-3003-40b6-9865-0c90a01cfd5a", "MSc Business Analytics", "john@example.com", false, false, null, null, "John Doe", null, null, "AQAAAAEAACcQAAAAEAYkNDHAhkE0Qff7rBl1uzi9xOsnHaAOjvF0p8r6ieGBPM5aFqZWUEuStsOZKlQuBw==", null, false, 0, "9827f29d-5579-4567-8fee-a33c39c329b4", false, 1, "john@example.com" },
                    { "9", 0, "Science", "0f08e65b-1959-4d67-b8b6-7b86aa4235aa", "BSc Chemistry", "emily@example.com", false, false, null, null, "Emily White", null, null, "AQAAAAEAACcQAAAAEEKirlFwpGNSLCTXb35nO2I/YIL73WAhXr2TvlQs1v622AtW0mXj4hDKLsCZW7k8gA==", null, false, 0, "d8af407c-4621-4c32-9da1-8198d4ef01e8", false, 2, "emily@example.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");
        }
    }
}
