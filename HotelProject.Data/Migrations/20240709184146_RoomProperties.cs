using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "BathCount",
                table: "RoomProperties",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "BedCount",
                table: "RoomProperties",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "StarCount",
                table: "RoomProperties",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "488999ba-ffb1-44db-b4da-c47cc69ca83a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "a69f8884-b4ef-49db-9a4e-2c323ddd5736");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "3790c0a5-c417-4975-8b4b-c7e5d21a2171");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64b04894-b85f-4433-9a16-af05239c4e8e", "AQAAAAIAAYagAAAAEHjiU+Olx/izba1Qrau0m4JR1yEo+Z2i2x8B4NobDFtCbq97CXQkmwaNbbLecrMfqw==", "dd7ffc8b-a4e6-4eeb-9407-58af22c5de39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc0b1717-d74c-4fb6-9489-cb98e46e7559", "AQAAAAIAAYagAAAAEIMUcN6Nkw2OGru/VOOW2eWFoo1kRjc5MuPPcmJXPTJtWDyKF3xQ4h73a8dYtpDVFA==", "06fe3297-dc0e-484a-a7c0-3accbeed9123" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(4966), "hotel1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(4979), "hotel2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"),
                columns: new[] { "BathCount", "BedCount", "CreatedDate", "StarCount" },
                values: new object[] { (byte)0, (byte)0, new DateTime(2024, 7, 9, 22, 41, 45, 729, DateTimeKind.Local).AddTicks(5302), (byte)0 });

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 729, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 729, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 729, DateTimeKind.Local).AddTicks(628));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BathCount",
                table: "RoomProperties");

            migrationBuilder.DropColumn(
                name: "BedCount",
                table: "RoomProperties");

            migrationBuilder.DropColumn(
                name: "StarCount",
                table: "RoomProperties");

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
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(269), "test@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                columns: new[] { "CreatedDate", "Email" },
                values: new object[] { new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(280), "test2@gmail.com" });

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
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 13, 43, 29, 305, DateTimeKind.Local).AddTicks(7502));

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
    }
}
