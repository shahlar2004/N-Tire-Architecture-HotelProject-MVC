using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedSomeProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarCount",
                table: "RoomProperties");

            migrationBuilder.AddColumn<byte>(
                name: "StarCount",
                table: "Hotel",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "012fd23e-afff-4a5e-b01c-27719be1fd13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "3e43d9a9-9bec-461e-bcbb-33c493fe2ed0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "cf21c385-8902-4386-9116-94116ae1fe14");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c28f863-c7ef-4617-9406-afa7809b91c5", "AQAAAAIAAYagAAAAEC+8sgQPA3owTFRHSyfbzxFH4ucQRG9aFwMW13dMWCosao6vg0qgaZZ0CTNBvPbOQQ==", "8c709472-d696-4f94-b4ab-c811567e08ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aac94edc-0256-4f55-a57f-202c9542b868", "AQAAAAIAAYagAAAAELnuFCCTIhXzjG5OhHHHL2/B/5jqrJQEHoQy4/qFoC4blFu6L66fcDe9fUK0H4Nzmw==", "a9a542aa-e4f2-4b83-b106-2ceb7a57d125" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                columns: new[] { "CreatedDate", "StarCount" },
                values: new object[] { new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(1639), (byte)3 });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                columns: new[] { "CreatedDate", "StarCount" },
                values: new object[] { new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(1646), (byte)5 });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(5175));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarCount",
                table: "Hotel");

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
                columns: new[] { "CreatedDate", "StarCount" },
                values: new object[] { new DateTime(2024, 7, 9, 22, 51, 7, 577, DateTimeKind.Local).AddTicks(7445), (byte)3 });

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
    }
}
