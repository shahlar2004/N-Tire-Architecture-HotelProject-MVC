using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomPropertieSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "ca3d9b5d-856b-4b90-856d-2cbf8d8c6780");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "b895c89f-7c94-40bd-9b17-cf6c2f210510");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "0942942a-87db-4ca9-a08a-82670da78d28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a4bc066-77bd-43ed-b47c-2d59d1c24252", "AQAAAAIAAYagAAAAEJLgM/moNB36wZkga1zLeIMWedP8Fo9GK++Rlvughuvldn/oZY9eyEhTR1Nj6Hyi2A==", "563a87b6-19e2-4851-a89d-a69d7a0db323" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e703f96-6abd-4a46-9252-8f1b60e7ef83", "AQAAAAIAAYagAAAAENhySK0wdjoI5USL23jmUuCFtS/0XNQQETjod34nzQVSdL74EowFDceWZcn0DgPlWg==", "cf865db0-d264-4a36-b9c5-3d254eabf702" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 304, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 304, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 304, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"),
                columns: new[] { "CreatedDate", "isDeleted", "isInternet" },
                values: new object[] { new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(7502), false, true });

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(4093));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 37, 26, 321, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"),
                columns: new[] { "CreatedDate", "isDeleted", "isInternet" },
                values: new object[] { new DateTime(2024, 7, 5, 13, 37, 26, 322, DateTimeKind.Local).AddTicks(5012), true, false });

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
    }
}
