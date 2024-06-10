using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestTaskSoftServe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("105c6f3f-dbbf-4df3-97f1-272bd988c1e6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("29a7c329-7c2a-4311-b9d3-1664929db4ca"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2d90d7b4-187d-4625-99e4-9ffce997e26a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("324a22f3-3c5e-4e42-97c5-203abd8ba03e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3c2948fb-fef2-47b0-92da-d8fbbca27fca"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("466d87d5-06fd-4c92-914f-5c5c4adfc3d9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5798cd04-ca2a-4d13-a80b-ce504c62d5f9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("75e32b4d-22ae-47e7-888e-0548d802903a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("89dfcfdd-3eea-4a1a-99d8-00ed79e6f506"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9039133d-c013-4b91-9664-d193e0d67830"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("90661fbe-5533-4e92-938f-3387ede54d05"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c23bedfb-d070-43c3-8554-ba627502b820"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c5515509-0d62-44f9-89ca-d9d7f796f478"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d0e34392-7b21-49ae-964a-8b98a5506e5c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d7a00e5f-ae29-4195-af17-b1450a24c429"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dddd3fa6-32d6-489f-a3a5-28df94e1fbd9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e349fd9b-297f-4e04-8349-399b66b5ec9e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f18293bf-ba2d-406f-9b04-c78a5190504e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f58cf47f-34e3-4eec-85f8-ac472b2bb594"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fcd7b1af-a9b3-493e-b43d-7c41fd3a7666"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("144440a7-07fd-4762-b001-e50f8485b151"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("16c4e638-d049-4c91-87d1-9a7a8f856706"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("170423fb-907c-46ba-8c4d-89fff5f84b43"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6275f4ac-70ce-4bd3-b446-ba27dc37fb3e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ba8911cd-b330-4de5-a0a9-fb79d6224ac5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c9952b3f-bbcb-49dd-a547-a5a8b68c91a4"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c9fdd8ab-6827-42cf-a269-1a330e2bbd40"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d19d02f5-4eb7-432e-9de9-3e3a9c40f16e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d97b1c40-a546-4fd6-9392-4466adbee4d0"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("df778a58-8e85-4510-a25e-76af54282209"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2920ea02-f7f3-415b-915a-4448117d6ddf"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2e672988-007c-4d59-8cd4-8c31ab637265"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("71e26009-f453-46c0-a4f9-df6556a368d3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("895ae290-1f8a-4450-9ef4-40f7dc8725c3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bb8b413b-d9b3-48ef-b243-651004c995ec"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("bd2172b3-eec6-4346-8de5-508beeb4c070"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e37a28b7-8252-425c-af62-3f39399c9fa1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e96afaee-92fa-43bd-85e0-b34cb8f7502f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ec6ae8b7-54ea-4fa5-8665-40b4b3a09f4d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("fb8e8494-26ef-475f-a4da-fd630fd59117"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16a2491a-d4e4-4816-8c16-26cfa91df356"), null, "User", "USER" },
                    { new Guid("1b0ba6d9-bf8f-46a6-89b4-0a5ce1661fa1"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonName", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpirationDateTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("70a0ed61-be00-4372-93a1-7e36d7a0af76"), 0, "c4e29003-d057-43d2-a12c-fba1e30a4c89", "Admin", true, false, null, "ADMIN", "ADMIN", "AQAAAAIAAYagAAAAEI67HUJrYUUv74dFbtooGnlCA/GjWiFpuRZKOkswzcXI2tm/bn01ERB7XIE9AM3QjA==", null, null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "68c0c738-25cd-4545-bbfc-a69ab111002d", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("454c2bdc-2ab6-4983-88e3-2a92d8f135e9"), "Description 18", "Course 18" },
                    { new Guid("470c5936-0fc8-4c12-b2b4-8a39fa5d87a5"), "Description 19", "Course 19" },
                    { new Guid("554d947c-6515-4cc7-a7a7-78472ecb25aa"), "Description 12", "Course 12" },
                    { new Guid("5cb013ae-0ac2-456c-924c-1b2001fb5a78"), "Description 3", "Course 3" },
                    { new Guid("674461f7-3ddd-4f8a-9265-dd711de014d3"), "Description 8", "Course 8" },
                    { new Guid("6ab614cd-3131-4bdc-9119-f21943020ed4"), "Description 9", "Course 9" },
                    { new Guid("70fbee91-6f6f-4b80-9b50-3d5dd751cf3d"), "Description 20", "Course 20" },
                    { new Guid("73229c4b-16c8-4751-9193-f78e9c5dc173"), "Description 15", "Course 15" },
                    { new Guid("851a2516-9a41-4410-9edf-4ce4b7da7b41"), "Description 13", "Course 13" },
                    { new Guid("86066ef7-0e03-43c7-8430-23f2a453935c"), "Description 10", "Course 10" },
                    { new Guid("9ed56794-fd3d-41ff-93fb-51b39c5e12d8"), "Description 7", "Course 7" },
                    { new Guid("af8cdace-e2fd-482e-a038-ab2b0ba951eb"), "Description 2", "Course 2" },
                    { new Guid("b5e7fed5-016b-4432-ab8f-66b253d23f18"), "Description 11", "Course 11" },
                    { new Guid("b8df8e9a-c93a-4f41-a116-dfcb6605652f"), "Description 5", "Course 5" },
                    { new Guid("c1d63cb7-6696-45a7-b864-79e3aee7de2a"), "Description 17", "Course 17" },
                    { new Guid("dbcbfa72-d496-4111-bdde-4a566072a965"), "Description 16", "Course 16" },
                    { new Guid("e6dc39fb-f3eb-4a5e-a57e-82f83c3d917e"), "Description 14", "Course 14" },
                    { new Guid("ea8f8a96-bd6c-4663-9a56-4dab8c0c4fb0"), "Description 1", "Course 1" },
                    { new Guid("f4c59848-f229-41ab-b78f-0fa811ac22c9"), "Description 4", "Course 4" },
                    { new Guid("fe5b4947-cf26-41d6-9603-a166d7c06017"), "Description 6", "Course 6" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Group", "Name", "StudyYear", "Surname" },
                values: new object[,]
                {
                    { new Guid("00f6eead-7014-4f06-94c6-757893050993"), 78, "Group 4", "Student's name 4", 9, "Student's surname 4" },
                    { new Guid("24d5d9fc-9a33-4923-9a33-b489b8952c48"), 99, "Group 1", "Student's name 1", 2, "Student's surname 1" },
                    { new Guid("4a5facf3-a08c-478a-bb15-f42ae89a996f"), 40, "Group 7", "Student's name 7", 7, "Student's surname 7" },
                    { new Guid("4e7adf3b-027b-4b88-bcd9-2ff7f873d7a9"), 46, "Group 2", "Student's name 2", 4, "Student's surname 2" },
                    { new Guid("6431cc82-8f79-4360-a003-67a955b7db5e"), 32, "Group 3", "Student's name 3", 5, "Student's surname 3" },
                    { new Guid("93469f3b-fa89-4ee1-a6c7-d8c04ad01c4f"), 94, "Group 6", "Student's name 6", 5, "Student's surname 6" },
                    { new Guid("c1d8b68f-2f8d-4e63-bedf-d132e81c8307"), 70, "Group 10", "Student's name 10", 5, "Student's surname 10" },
                    { new Guid("c9062ef1-ae96-410c-a215-56c153852fc5"), 49, "Group 5", "Student's name 5", 0, "Student's surname 5" },
                    { new Guid("f3dd87e7-9222-4e21-8ff7-d202d5c045e8"), 60, "Group 8", "Student's name 8", 16, "Student's surname 8" },
                    { new Guid("fa7dfd04-4824-49c2-9398-1a6b2eb80ae8"), 60, "Group 9", "Student's name 9", 9, "Student's surname 9" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Experience", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("10e98920-24ae-4612-90d4-8eccfdb9c9a2"), 26, 9, "Teacher's name 6", "Teacher's surname 6" },
                    { new Guid("2d4000c6-b611-4d2a-b48f-09576f31552d"), 61, 3, "Teacher's name 4", "Teacher's surname 4" },
                    { new Guid("36593933-ba68-44af-b058-e5fd04380dba"), 50, 4, "Teacher's name 2", "Teacher's surname 2" },
                    { new Guid("58f9ea3d-548a-47c4-9ced-d4250064c64d"), 35, 0, "Teacher's name 3", "Teacher's surname 3" },
                    { new Guid("68eb2508-cbfe-47f8-9894-66d4776f345a"), 44, 21, "Teacher's name 10", "Teacher's surname 10" },
                    { new Guid("954b8de0-3721-4c70-9807-4a5d4a982acc"), 52, 15, "Teacher's name 7", "Teacher's surname 7" },
                    { new Guid("99be3cbe-2852-4e03-a107-5bbaeebb9b59"), 26, 17, "Teacher's name 8", "Teacher's surname 8" },
                    { new Guid("a319384b-0a29-478f-bc19-6e699d612e59"), 21, 2, "Teacher's name 1", "Teacher's surname 1" },
                    { new Guid("c03b169d-b7a4-449d-9c62-f56730242e07"), 22, 18, "Teacher's name 9", "Teacher's surname 9" },
                    { new Guid("cb4b44a6-c286-472a-acea-b0f44ff2cb2b"), 18, 8, "Teacher's name 5", "Teacher's surname 5" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1b0ba6d9-bf8f-46a6-89b4-0a5ce1661fa1"), new Guid("70a0ed61-be00-4372-93a1-7e36d7a0af76") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16a2491a-d4e4-4816-8c16-26cfa91df356"));

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1b0ba6d9-bf8f-46a6-89b4-0a5ce1661fa1"), new Guid("70a0ed61-be00-4372-93a1-7e36d7a0af76") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("454c2bdc-2ab6-4983-88e3-2a92d8f135e9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("470c5936-0fc8-4c12-b2b4-8a39fa5d87a5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("554d947c-6515-4cc7-a7a7-78472ecb25aa"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5cb013ae-0ac2-456c-924c-1b2001fb5a78"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("674461f7-3ddd-4f8a-9265-dd711de014d3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6ab614cd-3131-4bdc-9119-f21943020ed4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("70fbee91-6f6f-4b80-9b50-3d5dd751cf3d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("73229c4b-16c8-4751-9193-f78e9c5dc173"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("851a2516-9a41-4410-9edf-4ce4b7da7b41"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("86066ef7-0e03-43c7-8430-23f2a453935c"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9ed56794-fd3d-41ff-93fb-51b39c5e12d8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("af8cdace-e2fd-482e-a038-ab2b0ba951eb"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b5e7fed5-016b-4432-ab8f-66b253d23f18"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b8df8e9a-c93a-4f41-a116-dfcb6605652f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c1d63cb7-6696-45a7-b864-79e3aee7de2a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("dbcbfa72-d496-4111-bdde-4a566072a965"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("e6dc39fb-f3eb-4a5e-a57e-82f83c3d917e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ea8f8a96-bd6c-4663-9a56-4dab8c0c4fb0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f4c59848-f229-41ab-b78f-0fa811ac22c9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("fe5b4947-cf26-41d6-9603-a166d7c06017"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("00f6eead-7014-4f06-94c6-757893050993"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("24d5d9fc-9a33-4923-9a33-b489b8952c48"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4a5facf3-a08c-478a-bb15-f42ae89a996f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("4e7adf3b-027b-4b88-bcd9-2ff7f873d7a9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("6431cc82-8f79-4360-a003-67a955b7db5e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("93469f3b-fa89-4ee1-a6c7-d8c04ad01c4f"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c1d8b68f-2f8d-4e63-bedf-d132e81c8307"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("c9062ef1-ae96-410c-a215-56c153852fc5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f3dd87e7-9222-4e21-8ff7-d202d5c045e8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("fa7dfd04-4824-49c2-9398-1a6b2eb80ae8"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("10e98920-24ae-4612-90d4-8eccfdb9c9a2"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2d4000c6-b611-4d2a-b48f-09576f31552d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("36593933-ba68-44af-b058-e5fd04380dba"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("58f9ea3d-548a-47c4-9ced-d4250064c64d"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("68eb2508-cbfe-47f8-9894-66d4776f345a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("954b8de0-3721-4c70-9807-4a5d4a982acc"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("99be3cbe-2852-4e03-a107-5bbaeebb9b59"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("a319384b-0a29-478f-bc19-6e699d612e59"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("c03b169d-b7a4-449d-9c62-f56730242e07"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cb4b44a6-c286-472a-acea-b0f44ff2cb2b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1b0ba6d9-bf8f-46a6-89b4-0a5ce1661fa1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("70a0ed61-be00-4372-93a1-7e36d7a0af76"));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("105c6f3f-dbbf-4df3-97f1-272bd988c1e6"), "Description 8", "Course 8" },
                    { new Guid("29a7c329-7c2a-4311-b9d3-1664929db4ca"), "Description 15", "Course 15" },
                    { new Guid("2d90d7b4-187d-4625-99e4-9ffce997e26a"), "Description 14", "Course 14" },
                    { new Guid("324a22f3-3c5e-4e42-97c5-203abd8ba03e"), "Description 16", "Course 16" },
                    { new Guid("3c2948fb-fef2-47b0-92da-d8fbbca27fca"), "Description 3", "Course 3" },
                    { new Guid("466d87d5-06fd-4c92-914f-5c5c4adfc3d9"), "Description 18", "Course 18" },
                    { new Guid("5798cd04-ca2a-4d13-a80b-ce504c62d5f9"), "Description 17", "Course 17" },
                    { new Guid("75e32b4d-22ae-47e7-888e-0548d802903a"), "Description 2", "Course 2" },
                    { new Guid("89dfcfdd-3eea-4a1a-99d8-00ed79e6f506"), "Description 20", "Course 20" },
                    { new Guid("9039133d-c013-4b91-9664-d193e0d67830"), "Description 4", "Course 4" },
                    { new Guid("90661fbe-5533-4e92-938f-3387ede54d05"), "Description 5", "Course 5" },
                    { new Guid("c23bedfb-d070-43c3-8554-ba627502b820"), "Description 1", "Course 1" },
                    { new Guid("c5515509-0d62-44f9-89ca-d9d7f796f478"), "Description 10", "Course 10" },
                    { new Guid("d0e34392-7b21-49ae-964a-8b98a5506e5c"), "Description 7", "Course 7" },
                    { new Guid("d7a00e5f-ae29-4195-af17-b1450a24c429"), "Description 13", "Course 13" },
                    { new Guid("dddd3fa6-32d6-489f-a3a5-28df94e1fbd9"), "Description 11", "Course 11" },
                    { new Guid("e349fd9b-297f-4e04-8349-399b66b5ec9e"), "Description 12", "Course 12" },
                    { new Guid("f18293bf-ba2d-406f-9b04-c78a5190504e"), "Description 6", "Course 6" },
                    { new Guid("f58cf47f-34e3-4eec-85f8-ac472b2bb594"), "Description 9", "Course 9" },
                    { new Guid("fcd7b1af-a9b3-493e-b43d-7c41fd3a7666"), "Description 19", "Course 19" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Group", "Name", "StudyYear", "Surname" },
                values: new object[,]
                {
                    { new Guid("144440a7-07fd-4762-b001-e50f8485b151"), 72, "Group 5", "Student's name 5", 14, "Student's surname 5" },
                    { new Guid("16c4e638-d049-4c91-87d1-9a7a8f856706"), 21, "Group 10", "Student's name 10", 27, "Student's surname 10" },
                    { new Guid("170423fb-907c-46ba-8c4d-89fff5f84b43"), 28, "Group 1", "Student's name 1", 1, "Student's surname 1" },
                    { new Guid("6275f4ac-70ce-4bd3-b446-ba27dc37fb3e"), 47, "Group 8", "Student's name 8", 18, "Student's surname 8" },
                    { new Guid("ba8911cd-b330-4de5-a0a9-fb79d6224ac5"), 93, "Group 9", "Student's name 9", 15, "Student's surname 9" },
                    { new Guid("c9952b3f-bbcb-49dd-a547-a5a8b68c91a4"), 65, "Group 7", "Student's name 7", 4, "Student's surname 7" },
                    { new Guid("c9fdd8ab-6827-42cf-a269-1a330e2bbd40"), 33, "Group 2", "Student's name 2", 4, "Student's surname 2" },
                    { new Guid("d19d02f5-4eb7-432e-9de9-3e3a9c40f16e"), 66, "Group 3", "Student's name 3", 0, "Student's surname 3" },
                    { new Guid("d97b1c40-a546-4fd6-9392-4466adbee4d0"), 56, "Group 6", "Student's name 6", 13, "Student's surname 6" },
                    { new Guid("df778a58-8e85-4510-a25e-76af54282209"), 109, "Group 4", "Student's name 4", 0, "Student's surname 4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Experience", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("2920ea02-f7f3-415b-915a-4448117d6ddf"), 20, 1, "Teacher's name 3", "Teacher's surname 3" },
                    { new Guid("2e672988-007c-4d59-8cd4-8c31ab637265"), 62, 12, "Teacher's name 7", "Teacher's surname 7" },
                    { new Guid("71e26009-f453-46c0-a4f9-df6556a368d3"), 53, 2, "Teacher's name 1", "Teacher's surname 1" },
                    { new Guid("895ae290-1f8a-4450-9ef4-40f7dc8725c3"), 30, 23, "Teacher's name 9", "Teacher's surname 9" },
                    { new Guid("bb8b413b-d9b3-48ef-b243-651004c995ec"), 49, 11, "Teacher's name 4", "Teacher's surname 4" },
                    { new Guid("bd2172b3-eec6-4346-8de5-508beeb4c070"), 52, 6, "Teacher's name 5", "Teacher's surname 5" },
                    { new Guid("e37a28b7-8252-425c-af62-3f39399c9fa1"), 45, 10, "Teacher's name 6", "Teacher's surname 6" },
                    { new Guid("e96afaee-92fa-43bd-85e0-b34cb8f7502f"), 50, 5, "Teacher's name 2", "Teacher's surname 2" },
                    { new Guid("ec6ae8b7-54ea-4fa5-8665-40b4b3a09f4d"), 64, 28, "Teacher's name 10", "Teacher's surname 10" },
                    { new Guid("fb8e8494-26ef-475f-a4da-fd630fd59117"), 25, 0, "Teacher's name 8", "Teacher's surname 8" }
                });
        }
    }
}
