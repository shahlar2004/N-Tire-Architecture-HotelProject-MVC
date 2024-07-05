using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class reservedAded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Reserved",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reserved",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "d04fd421-3ca1-4e29-ac2b-3bd522ce8cab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "2af95436-c195-4034-8dfa-68e9c0901dd6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "71ec411c-b177-4f7e-bc6e-efeffddfc3bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cc72b32-579e-4a57-a9fb-a86044ffbde5", "AQAAAAIAAYagAAAAEFqIJ7L9jQofkRCALSY29+K1MeWC4IAJFPORBwayDJ8xzJK8pSEdDvn5jRTQ6eEH/Q==", "f59ec458-e018-4936-9723-b9cdab556a5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1441a0-90f1-4704-92b4-ddb680cf5d3c", "AQAAAAIAAYagAAAAEFKpBkZy8lU8GoZ8it1YY2DipBFujAD4/rHL6cSMVIK/PVLDa9Okw1Zq4H48vCpWhw==", "f624d0eb-ac9c-4ee9-bd83-dbbc7c189556" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 12, 18, 27, 918, DateTimeKind.Local).AddTicks(4454));
        }
    }
}
