using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomPropertieSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "9f49dc74-47ae-48f0-b14d-87e7db5f84d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "53a3332d-0085-4cd8-9305-008e033ec52e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "c8a48494-cf64-4cb2-b2fa-5abdd234e16c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e22c21b-386a-4fca-9e62-523a61d8ccac", "AQAAAAIAAYagAAAAEMuc7f4uX13ohYFJKuKkMBrgZyWd2Afzhe1H86ESkK3spNUQNgZTu7lRqMpLk9Gtdg==", "7d8538b8-f316-4e0e-ac6d-ac1c0355f7a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54787927-212f-4679-bb46-339a7c0440fa", "AQAAAAIAAYagAAAAEC3JJnESSVbeLgd751OFgCX1VSLH6A4sp4ji008ueJJxqT79Ho5JbMSSpitAyJdG6A==", "003517db-8237-4748-8006-efbacea68356" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                columns: new[] { "CreatedDate", "HotelName" },
                values: new object[] { new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(8607), "Hotel1" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                columns: new[] { "CreatedDate", "HotelName" },
                values: new object[] { new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(8616), "Hotel2" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.InsertData(
                table: "RoomProperties",
                columns: new[] { "Id", "AdultCount", "ChildCount", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "HotelId", "ModifiedBy", "ModifiedDate", "PricePerNight", "RoomCategoryId", "RoomCommanName", "RoomCount", "isDeleted", "isInternet" },
                values: new object[] { new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"), 2, 2, "Undefined", new DateTime(2024, 7, 5, 13, 37, 26, 322, DateTimeKind.Local).AddTicks(5012), null, null, "Good Luck!", new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"), null, null, 100, new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"), "1A", 4, true, false });

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 322, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 322, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 322, DateTimeKind.Local).AddTicks(2211));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"));

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

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                columns: new[] { "CreatedDate", "HotelName" },
                values: new object[] { new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(3428), "Test1" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                columns: new[] { "CreatedDate", "HotelName" },
                values: new object[] { new DateTime(2024, 7, 5, 12, 53, 17, 904, DateTimeKind.Local).AddTicks(3442), "Test2" });

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
    }
}
