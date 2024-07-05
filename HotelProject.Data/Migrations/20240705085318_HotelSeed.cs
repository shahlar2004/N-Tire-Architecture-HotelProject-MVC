using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class HotelSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "984d7628-4293-476c-9cd4-3697e8de9ef0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "aacd055e-1908-4547-b824-a7eaf2850065");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "d78e60ab-62d5-4046-bbb9-2301d03bdf46");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f834f8ae-b40f-4795-abee-47e0064102a9", "AQAAAAIAAYagAAAAEIeJToSv+cQfPZRT0J5DTzs/QrM1iDD344ct4xBwM/w24NTS7BkOR+d3hSAijfH84g==", "f195703f-6d8b-4d38-9d06-ba000fa3fbe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a4c5a9b-b152-47a4-9e41-69cc595395e5", "AQAAAAIAAYagAAAAEMrroGiWnGShD9Z/tOZCD2VQG0oUJC0SLNy7eg3dj2TF9xGdj3fP2cNihID3RDPcyg==", "aea52363-6dc3-469f-b784-1dbac275defc" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "CountryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "FaceBookLink", "HotelName", "InstaLink", "Location", "ModifiedBy", "ModifiedDate", "Number", "TwitterLink", "YoutubeLink", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"), new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"), "Undefined", new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(3428), null, null, "test@gmail.com", "#", "Test1", "#", "#", null, null, "+994509755489", "#", "#", false },
                    { new Guid("7612944d-845b-4ab3-9442-09805c12321f"), new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"), "Undefined", new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(3442), null, null, "test2@gmail.com", "#", "Test2", "#", "#", null, null, "+994519755489", "#", "#", false }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(7194));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"));

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "a05c43df-6f1e-427e-934a-b1d50a966c71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "8866c338-778b-4605-9ec0-349cb7b60774");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "3e1612bd-c53e-42aa-932e-c834730427c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50e9812f-90d7-4f7b-ad9f-93b3c946c78f", "AQAAAAIAAYagAAAAEIXNnTQpjqzaj//WUU3zPdjoCxTcMKz6Er/KIMiORQvzvzKaIZ/dBBdTVEdEhi5ZcQ==", "ae657858-2971-4dec-a70b-41fdabb7fcb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97707e94-1930-414e-8631-65af9453be82", "AQAAAAIAAYagAAAAEE+wFhOPtggrcwqPbW97YRkL0gtfVX1KU4MTQSBDWhDMyuMUzKx+YSNetCXyrZX9Rw==", "f8b81f39-977c-410b-996a-84991eb2c29f" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 33, 43, 902, DateTimeKind.Local).AddTicks(4136));
        }
    }
}
