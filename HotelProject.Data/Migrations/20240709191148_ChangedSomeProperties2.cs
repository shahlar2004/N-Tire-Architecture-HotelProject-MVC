using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedSomeProperties2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "86e5d134-2a0f-4f1b-96fa-c357a28f215c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "78d8c65c-72ea-45d3-8087-6fc21f85ac56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "8843b818-c4cf-488a-afd2-25e3691d2847");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a525badf-2c87-495e-8adf-f5b744e41c3e", "AQAAAAIAAYagAAAAEDslTjooW22dZ8B9OAF57kehcvxaZufA8QwkRtFE/dFwttOmn4Us26h1uspniFxLGg==", "ec4261cd-b0a1-4c84-9c83-d92cff222640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b426c158-3469-4c09-a2db-7cdc6c0470e6", "AQAAAAIAAYagAAAAEMdr5e0h9oJCwk2nVvmV5he6jTeMMn4evGdJFIvzI3cjIrkaybfbdTJAW7J4dwR3Og==", "2a2c6641-f9c2-4228-a8d3-02f131615aa1" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("28abfeea-3e87-4cbe-8809-4dcb111ea3fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "RoomProperties",
                keyColumn: "Id",
                keyValue: new Guid("069ff25a-4962-42cf-b099-2635b6b172ff"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 11, 47, 884, DateTimeKind.Local).AddTicks(5665));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: new Guid("7612944d-845b-4ab3-9442-09805c12321f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 9, 23, 9, 9, 413, DateTimeKind.Local).AddTicks(1646));

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
    }
}
