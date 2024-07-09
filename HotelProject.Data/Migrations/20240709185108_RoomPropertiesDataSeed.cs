using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RoomPropertiesDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "7c6c7e09-11ef-4819-a1ed-5720b6352ba0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "b31b197b-747a-44a8-a3d1-987db52a4075");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "ab6270ef-b57d-43e3-a17a-89c913a74efc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8ba70cf-e911-44fe-bbde-502bc11155fb", "AQAAAAIAAYagAAAAEGVMvItaRvMmaEBntT7HstbjTAIcEk1vtbAoUue7s58tZziDnqaz/lKTys5gw7GHYg==", "e489b897-1da4-42b1-8674-09826d0546ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "802761ac-6514-4818-80a4-37e73a6492e7", "AQAAAAIAAYagAAAAEPSOdiq3+D+XTg3iriDhqasNeomzJ4SziceZ6+cRKQCWhzTXGK8qG8SoiZYJOh4+Pw==", "588a0dfb-4300-4d0c-93a1-3c51779dc49a" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 575, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 575, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 575, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 575, DateTimeKind.Local).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 575, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 576, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"),
                columns: new[] { "BathCount", "BedCount", "CreatedDate", "StarCount" },
                values: new object[] { (byte)1, (byte)3, new DateTime(2024, 7, 9, 22, 51, 7, 577, DateTimeKind.Local).AddTicks(7445), (byte)3 });

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 576, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 576, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 51, 7, 576, DateTimeKind.Local).AddTicks(9682));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 22, 41, 45, 728, DateTimeKind.Local).AddTicks(4979));

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
    }
}
