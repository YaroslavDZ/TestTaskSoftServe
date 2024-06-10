using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestTaskSoftServe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedExpirationDateForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("06a75fb1-0b59-4907-9ffc-222548311684"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("294b4ff1-2a54-462c-80da-c324b3647ad6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("29828ec6-3890-437b-8a87-89bb4890e5e5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2b9cc3b9-62ab-410e-b21a-5dc65e722e00"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2e69a572-63b5-401e-ba11-a08006a518b8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2f0b3f5b-a129-4568-a229-8c19e810ff40"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("350e3b62-7f72-4e75-a2f2-8a5229864ba8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("41eab40b-f4c1-44fb-8ca6-9384ad8b8e34"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("44bf0c42-ffb2-45ca-ac0e-8d2a7d17d8cd"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("45b09f1f-e7ad-4f20-afcc-eb09b171b765"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5508581b-aebd-45bb-9db0-be61545fa8d3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5af59633-6e41-405a-aaca-94da44e843b1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("69adcb06-034b-4651-9006-d615a33042a0"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6ee88dd5-4e86-436c-b25a-d6e8dc1aacd5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("71428de3-b153-41db-aadb-725169e5602a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9546f6c9-41cb-4a2b-8a22-636f0b93eee1"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9b3c7645-b621-4ca0-a819-653fba481bac"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("ad9b7ea5-1d0d-4a57-a241-005f1398f1b3"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b7eac20b-9f15-4ad9-8463-abb20e390479"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c13c20dc-f0f6-4d5d-b24a-cca5d3a58590"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("1fdd4289-315b-42c3-9c65-f4abe766c739"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("21dc435f-3b04-4cbb-ad87-228d4c74b411"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("3e4ea4ac-ddfc-434d-abdc-a5136d19cb2b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("43786dc2-9025-42d0-9e3a-f9f5a3dddd98"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("5becd8e8-85fb-4312-a9b9-d49137e87f94"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("8d7aad17-847d-4061-be43-5680849b6df5"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("97206f88-6722-4493-9724-fa620563abf1"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9ae9be50-2781-4a3c-af73-bc11c673e237"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("9b058a28-df23-41a1-88ad-7d61788b573b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("ede7d796-ad5a-45f7-a233-87c35798d4c4"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("1194fcfc-6176-4397-b58f-5e0ed7d910ce"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("299c8444-7ae9-4e3b-a678-b2edc2bb1165"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2df720fd-efe2-4f69-b353-7c723888f99b"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("338ff14f-5d1c-4dbd-a425-eb5426bed2bd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3bbd5298-1a1b-43a7-b88e-fd3af61c6acd"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("5573471d-b765-4349-b529-ee90ce9bd804"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("abb04b91-fdc1-48d3-9b28-f66ad32c9b46"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("b44beef0-5237-4c3b-bdcf-968058ba2109"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("cbcf53ef-082e-4806-a823-b69b76eb7332"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("e1681851-b3de-4e08-b0fa-05cbd4cc7b78"));

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpirationDateTime",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("0f36f97b-f000-4d25-8967-1456927db432"), "Description 18", "Course 18" },
                    { new Guid("2a86b21b-d7c6-43a9-b2f0-79d03283037a"), "Description 17", "Course 17" },
                    { new Guid("341b29a7-0e51-4644-a597-68a966253b5d"), "Description 20", "Course 20" },
                    { new Guid("3852a934-af96-46e7-a5d8-c86a9923d054"), "Description 13", "Course 13" },
                    { new Guid("4d8444e3-33d4-4683-a5bf-0771786213ee"), "Description 11", "Course 11" },
                    { new Guid("59b218c6-8e06-4614-a61a-a0b2c4f5037e"), "Description 3", "Course 3" },
                    { new Guid("5ac091da-a966-4f65-a671-cdef33fa17e9"), "Description 1", "Course 1" },
                    { new Guid("5ff13a15-bbde-498f-b456-4ad399665ad8"), "Description 15", "Course 15" },
                    { new Guid("6a5232bf-d055-4e5d-9007-959076aff117"), "Description 14", "Course 14" },
                    { new Guid("7bb50a13-a1d1-4b4e-a637-8a12b5b94280"), "Description 19", "Course 19" },
                    { new Guid("8e408633-a43f-4e31-a596-14d2a87b2e8a"), "Description 10", "Course 10" },
                    { new Guid("a40aef7f-6f73-4e0e-b2e3-2905324272c4"), "Description 5", "Course 5" },
                    { new Guid("afd2bc30-d83d-46d0-acc7-ef7c180d6221"), "Description 2", "Course 2" },
                    { new Guid("b3c3cd66-20a2-4c44-8b05-940e2c9edb2f"), "Description 4", "Course 4" },
                    { new Guid("b4f955ad-0961-4388-bece-329275d02a3f"), "Description 8", "Course 8" },
                    { new Guid("b72bd0ef-0c70-42ca-ab57-8cfb4548ea1b"), "Description 7", "Course 7" },
                    { new Guid("d26feeb7-1a9c-4706-a4f5-e41b02d45a90"), "Description 9", "Course 9" },
                    { new Guid("d5a4724e-b4b2-4c15-936f-83cd0217d9d5"), "Description 6", "Course 6" },
                    { new Guid("d9cf4fde-7035-486b-b675-e25c2c9cfb58"), "Description 16", "Course 16" },
                    { new Guid("f58eb51e-faa3-4b5f-9866-1006b679eb7a"), "Description 12", "Course 12" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Group", "Name", "StudyYear", "Surname" },
                values: new object[,]
                {
                    { new Guid("006fcd1d-ce66-4455-9dce-7d05b475cd36"), 25, "Group 7", "Student's name 7", 4, "Student's surname 7" },
                    { new Guid("043e5fbb-94cf-436d-bc68-f9abd1133c54"), 91, "Group 10", "Student's name 10", 22, "Student's surname 10" },
                    { new Guid("16ffa2d5-cb4e-4f8e-9f2b-cf8e7b61dc3b"), 41, "Group 1", "Student's name 1", 1, "Student's surname 1" },
                    { new Guid("23d68fd5-ac3c-4707-9dc6-0f1eb21cd264"), 64, "Group 6", "Student's name 6", 14, "Student's surname 6" },
                    { new Guid("306ea955-fc44-4cdf-918a-d0bf2bdd550e"), 32, "Group 9", "Student's name 9", 26, "Student's surname 9" },
                    { new Guid("7fb5119d-6bc5-41c6-baa8-77c8591a8d53"), 103, "Group 8", "Student's name 8", 3, "Student's surname 8" },
                    { new Guid("95c95bdc-b739-4a58-b7bd-fd0e8da308a9"), 51, "Group 5", "Student's name 5", 7, "Student's surname 5" },
                    { new Guid("d80c2c21-4603-4da9-b857-89286adf5cfd"), 33, "Group 3", "Student's name 3", 0, "Student's surname 3" },
                    { new Guid("dd4e2eaa-f972-4ae9-bd4e-f35a5e37b074"), 32, "Group 2", "Student's name 2", 5, "Student's surname 2" },
                    { new Guid("f0e9d527-3ea5-4ce9-9f7f-fc832466c1c0"), 34, "Group 4", "Student's name 4", 0, "Student's surname 4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Experience", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("066ddf41-46c7-48e3-8493-a3550db85b1c"), 34, 20, "Teacher's name 9", "Teacher's surname 9" },
                    { new Guid("06b957ee-f78b-4c66-8876-f7b5f126add6"), 64, 8, "Teacher's name 3", "Teacher's surname 3" },
                    { new Guid("12de37db-5368-49f3-b58c-272d23cf16a1"), 64, 0, "Teacher's name 2", "Teacher's surname 2" },
                    { new Guid("2d27802d-f8ce-42ad-aab6-c8551e2fa1c7"), 26, 14, "Teacher's name 7", "Teacher's surname 7" },
                    { new Guid("3d2e5aa0-c3ed-47d1-8faf-15741bbf6175"), 62, 17, "Teacher's name 8", "Teacher's surname 8" },
                    { new Guid("3dd35bf3-7621-4d53-b6b2-bc11f967c41f"), 33, 12, "Teacher's name 6", "Teacher's surname 6" },
                    { new Guid("55079f63-0c36-4b91-934d-3afd33ad3f48"), 40, 14, "Teacher's name 5", "Teacher's surname 5" },
                    { new Guid("7a834bcc-5f60-4321-85f9-ad8f88a30624"), 59, 0, "Teacher's name 4", "Teacher's surname 4" },
                    { new Guid("9704f246-4e39-4d97-84da-ae386fbafe39"), 51, 8, "Teacher's name 10", "Teacher's surname 10" },
                    { new Guid("ace82b6c-fd2f-4406-a8ba-2c7f179c9bb3"), 35, 1, "Teacher's name 1", "Teacher's surname 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0f36f97b-f000-4d25-8967-1456927db432"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("2a86b21b-d7c6-43a9-b2f0-79d03283037a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("341b29a7-0e51-4644-a597-68a966253b5d"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("3852a934-af96-46e7-a5d8-c86a9923d054"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("4d8444e3-33d4-4683-a5bf-0771786213ee"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("59b218c6-8e06-4614-a61a-a0b2c4f5037e"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5ac091da-a966-4f65-a671-cdef33fa17e9"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("5ff13a15-bbde-498f-b456-4ad399665ad8"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6a5232bf-d055-4e5d-9007-959076aff117"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7bb50a13-a1d1-4b4e-a637-8a12b5b94280"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8e408633-a43f-4e31-a596-14d2a87b2e8a"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("a40aef7f-6f73-4e0e-b2e3-2905324272c4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("afd2bc30-d83d-46d0-acc7-ef7c180d6221"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b3c3cd66-20a2-4c44-8b05-940e2c9edb2f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b4f955ad-0961-4388-bece-329275d02a3f"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("b72bd0ef-0c70-42ca-ab57-8cfb4548ea1b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d26feeb7-1a9c-4706-a4f5-e41b02d45a90"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d5a4724e-b4b2-4c15-936f-83cd0217d9d5"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d9cf4fde-7035-486b-b675-e25c2c9cfb58"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f58eb51e-faa3-4b5f-9866-1006b679eb7a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("006fcd1d-ce66-4455-9dce-7d05b475cd36"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("043e5fbb-94cf-436d-bc68-f9abd1133c54"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("16ffa2d5-cb4e-4f8e-9f2b-cf8e7b61dc3b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("23d68fd5-ac3c-4707-9dc6-0f1eb21cd264"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("306ea955-fc44-4cdf-918a-d0bf2bdd550e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("7fb5119d-6bc5-41c6-baa8-77c8591a8d53"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("95c95bdc-b739-4a58-b7bd-fd0e8da308a9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("d80c2c21-4603-4da9-b857-89286adf5cfd"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("dd4e2eaa-f972-4ae9-bd4e-f35a5e37b074"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: new Guid("f0e9d527-3ea5-4ce9-9f7f-fc832466c1c0"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("066ddf41-46c7-48e3-8493-a3550db85b1c"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("06b957ee-f78b-4c66-8876-f7b5f126add6"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("12de37db-5368-49f3-b58c-272d23cf16a1"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("2d27802d-f8ce-42ad-aab6-c8551e2fa1c7"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3d2e5aa0-c3ed-47d1-8faf-15741bbf6175"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("3dd35bf3-7621-4d53-b6b2-bc11f967c41f"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("55079f63-0c36-4b91-934d-3afd33ad3f48"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("7a834bcc-5f60-4321-85f9-ad8f88a30624"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("9704f246-4e39-4d97-84da-ae386fbafe39"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: new Guid("ace82b6c-fd2f-4406-a8ba-2c7f179c9bb3"));

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpirationDateTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("06a75fb1-0b59-4907-9ffc-222548311684"), "Description 1", "Course 1" },
                    { new Guid("294b4ff1-2a54-462c-80da-c324b3647ad6"), "Description 17", "Course 17" },
                    { new Guid("29828ec6-3890-437b-8a87-89bb4890e5e5"), "Description 18", "Course 18" },
                    { new Guid("2b9cc3b9-62ab-410e-b21a-5dc65e722e00"), "Description 11", "Course 11" },
                    { new Guid("2e69a572-63b5-401e-ba11-a08006a518b8"), "Description 10", "Course 10" },
                    { new Guid("2f0b3f5b-a129-4568-a229-8c19e810ff40"), "Description 2", "Course 2" },
                    { new Guid("350e3b62-7f72-4e75-a2f2-8a5229864ba8"), "Description 7", "Course 7" },
                    { new Guid("41eab40b-f4c1-44fb-8ca6-9384ad8b8e34"), "Description 13", "Course 13" },
                    { new Guid("44bf0c42-ffb2-45ca-ac0e-8d2a7d17d8cd"), "Description 3", "Course 3" },
                    { new Guid("45b09f1f-e7ad-4f20-afcc-eb09b171b765"), "Description 12", "Course 12" },
                    { new Guid("5508581b-aebd-45bb-9db0-be61545fa8d3"), "Description 6", "Course 6" },
                    { new Guid("5af59633-6e41-405a-aaca-94da44e843b1"), "Description 15", "Course 15" },
                    { new Guid("69adcb06-034b-4651-9006-d615a33042a0"), "Description 4", "Course 4" },
                    { new Guid("6ee88dd5-4e86-436c-b25a-d6e8dc1aacd5"), "Description 9", "Course 9" },
                    { new Guid("71428de3-b153-41db-aadb-725169e5602a"), "Description 19", "Course 19" },
                    { new Guid("9546f6c9-41cb-4a2b-8a22-636f0b93eee1"), "Description 20", "Course 20" },
                    { new Guid("9b3c7645-b621-4ca0-a819-653fba481bac"), "Description 16", "Course 16" },
                    { new Guid("ad9b7ea5-1d0d-4a57-a241-005f1398f1b3"), "Description 14", "Course 14" },
                    { new Guid("b7eac20b-9f15-4ad9-8463-abb20e390479"), "Description 5", "Course 5" },
                    { new Guid("c13c20dc-f0f6-4d5d-b24a-cca5d3a58590"), "Description 8", "Course 8" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Group", "Name", "StudyYear", "Surname" },
                values: new object[,]
                {
                    { new Guid("1fdd4289-315b-42c3-9c65-f4abe766c739"), 56, "Group 7", "Student's name 7", 16, "Student's surname 7" },
                    { new Guid("21dc435f-3b04-4cbb-ad87-228d4c74b411"), 99, "Group 4", "Student's name 4", 5, "Student's surname 4" },
                    { new Guid("3e4ea4ac-ddfc-434d-abdc-a5136d19cb2b"), 22, "Group 2", "Student's name 2", 1, "Student's surname 2" },
                    { new Guid("43786dc2-9025-42d0-9e3a-f9f5a3dddd98"), 24, "Group 3", "Student's name 3", 4, "Student's surname 3" },
                    { new Guid("5becd8e8-85fb-4312-a9b9-d49137e87f94"), 99, "Group 5", "Student's name 5", 14, "Student's surname 5" },
                    { new Guid("8d7aad17-847d-4061-be43-5680849b6df5"), 102, "Group 6", "Student's name 6", 8, "Student's surname 6" },
                    { new Guid("97206f88-6722-4493-9724-fa620563abf1"), 63, "Group 8", "Student's name 8", 23, "Student's surname 8" },
                    { new Guid("9ae9be50-2781-4a3c-af73-bc11c673e237"), 69, "Group 9", "Student's name 9", 16, "Student's surname 9" },
                    { new Guid("9b058a28-df23-41a1-88ad-7d61788b573b"), 102, "Group 1", "Student's name 1", 0, "Student's surname 1" },
                    { new Guid("ede7d796-ad5a-45f7-a233-87c35798d4c4"), 32, "Group 10", "Student's name 10", 5, "Student's surname 10" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Age", "Experience", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("1194fcfc-6176-4397-b58f-5e0ed7d910ce"), 21, 22, "Teacher's name 9", "Teacher's surname 9" },
                    { new Guid("299c8444-7ae9-4e3b-a678-b2edc2bb1165"), 25, 9, "Teacher's name 5", "Teacher's surname 5" },
                    { new Guid("2df720fd-efe2-4f69-b353-7c723888f99b"), 22, 2, "Teacher's name 1", "Teacher's surname 1" },
                    { new Guid("338ff14f-5d1c-4dbd-a425-eb5426bed2bd"), 18, 15, "Teacher's name 6", "Teacher's surname 6" },
                    { new Guid("3bbd5298-1a1b-43a7-b88e-fd3af61c6acd"), 30, 2, "Teacher's name 2", "Teacher's surname 2" },
                    { new Guid("5573471d-b765-4349-b529-ee90ce9bd804"), 41, 23, "Teacher's name 10", "Teacher's surname 10" },
                    { new Guid("abb04b91-fdc1-48d3-9b28-f66ad32c9b46"), 40, 4, "Teacher's name 3", "Teacher's surname 3" },
                    { new Guid("b44beef0-5237-4c3b-bdcf-968058ba2109"), 36, 15, "Teacher's name 8", "Teacher's surname 8" },
                    { new Guid("cbcf53ef-082e-4806-a823-b69b76eb7332"), 48, 8, "Teacher's name 4", "Teacher's surname 4" },
                    { new Guid("e1681851-b3de-4e08-b0fa-05cbd4cc7b78"), 57, 5, "Teacher's name 7", "Teacher's surname 7" }
                });
        }
    }
}
