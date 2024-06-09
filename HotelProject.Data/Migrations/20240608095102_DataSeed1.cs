using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "35e2bde1-b5fd-4f0f-8383-bf39c662daa1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "3bbaadf8-f6a2-47ac-8a01-30508d6869a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "1e4561ca-2618-4261-8ff1-6371a5e73886");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce414079-0331-4128-a34f-a90458e9f04a", "AQAAAAIAAYagAAAAEIRdUXX854+xEpbC3mmqhz81l1KNbchFVG/WLuzkZLrd+XLX79AOGyqAxxhOxjrrGg==", "17b4829b-e691-41f8-8990-63499aca3735" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96e4b82a-ae3e-4ac4-9fb4-fb0942a3e1fd", "AQAAAAIAAYagAAAAEA5A5DnMcQdbxYEzFx8L7mQ74eL0xeuEo6zrzFMFaMcbQT8aOIBttqieGcjAh4p/Og==", "31afdd84-1f06-4c85-b506-06e2bcfddf09" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"), "Undefined", new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(4046), null, null, null, null, "Rusiya", false },
                    { new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"), "Undefined", new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(4014), null, null, null, null, "Azərbaycan", false },
                    { new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"), "Undefined", new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(4047), null, null, null, null, "Türkiyə", false }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.InsertData(
                table: "RoomsCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("5024e694-bf92-4659-b456-cf664623efe4"), "Undefined", new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(7786), null, null, null, null, "Executive Suite", false },
                    { new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"), "Undefined", new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(7778), null, null, null, null, "Junior Suite", false },
                    { new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"), "Undefined", new DateTime(2024, 6, 8, 13, 51, 1, 903, DateTimeKind.Local).AddTicks(7787), null, null, null, null, "Super Deluxe", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("640d6fbf-72af-4eb1-a276-fcaf7bedf870"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f2d337ca-74ff-41cd-aeae-8c152e818759"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faa451a4-2ca8-4553-ad86-82607a771eb6"));

            migrationBuilder.DeleteData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("5024e694-bf92-4659-b456-cf664623efe4"));

            migrationBuilder.DeleteData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("c44363be-74a2-43e8-b8be-6a5a69f49a7f"));

            migrationBuilder.DeleteData(
                table: "RoomsCategory",
                keyColumn: "Id",
                keyValue: new Guid("d529881b-6d1c-40fc-9ea3-0c29e4ef0691"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("26c34f97-7d52-452b-8e70-48135d3756cd"),
                column: "ConcurrencyStamp",
                value: "dd0ee23c-6bf6-4355-ba92-8472599d6bc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4380fcf7-df75-485f-888a-d7715be71026"),
                column: "ConcurrencyStamp",
                value: "d8c515ee-de98-4b30-9f1b-6f6d410c7507");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("81d91823-eb61-4d17-a1fc-8a286f88f6d4"),
                column: "ConcurrencyStamp",
                value: "da207bc8-833e-441f-9ef9-75ad0c5534a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b5c0033f-e7f1-4610-a19c-fa970c039602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79083a5d-6f72-446e-a650-d3de48ef1549", "AQAAAAIAAYagAAAAEBzLkAVJ41qBDvRrCBXmjr2VGRqeNqKdIIU68taH2pHbkkZB0W9KhizG21dPP3sA0A==", "d57a86b6-5e8d-436e-8d86-1d14426c90f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e0c8114c-578e-4d0a-84d9-d936e0f34a7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c0dd479-a780-4cf9-841c-e3643625a406", "AQAAAAIAAYagAAAAEHsSumBWN1N+MF3fU/qQhM+TsmJ0VTYBWxPHbWO+uVLvHf1YW4kHWrOgZqCEOKdMOg==", "e96ebed1-59c4-48b4-8ede-4dd89a2bdb47" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("53c70e42-4494-47e0-8391-43aed02dadd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 7, 11, 11, 1, 841, DateTimeKind.Local).AddTicks(2321));
        }
    }
}
