using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPTJobMatch1670.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Application",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ae3e8d1-b6b6-4b29-8c57-89184078f91e", "AQAAAAIAAYagAAAAEG+MUfifslG8Qn2M6Vz2noI0t1S90Z0Ha0x3vggNFjO6GtTmADzCBPWMoOPiaau8Tw==", "00df0552-2ec4-46bf-859d-f36a19a39884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employer-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e1cc136-28d4-48a7-b40b-e227198e9d3f", "AQAAAAIAAYagAAAAEPFwP8NB+ee6y+qRyh8dxarxEITzuykvGlV1kdzaUeYRNWDDse9zfH1IDVlyKlrFLQ==", "03a16258-4e1c-4831-9e5f-f308ab609f55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeker-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3fd3d81-46de-4b70-b605-dfd91143b493", "AQAAAAIAAYagAAAAEIneLDFcbGKwF3U+U9C0PCqDmOF2xAZN50Ei4yxJsOff+ktbAO9qESyPdleybZ4TuA==", "ca6e87a0-eb58-4628-a89e-976ac3c99e30" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Application");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d55510-5c98-4419-9a36-b148bcbb39d0", "AQAAAAIAAYagAAAAENCXQXam838ZsZBcriW9jz+4KQQUsOtxEgsQV0xKWdNPGfd3FbUjfLP3sWfCtTiFsQ==", "1b70dad8-3148-4c8a-a46b-8f83b431a118" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employer-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b958e76-d44a-449a-bad4-64f03024b673", "AQAAAAIAAYagAAAAEFxj3y0dgNxbDzAcnDkCxXWhHVre8E2l4n/bgsvcVb+G2yifCuiloZRr0WPNF8yYFQ==", "5de3476c-c06d-412d-8255-6bab7ad3aaca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeker-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45a6444c-e50e-4324-8831-6f3e8625944b", "AQAAAAIAAYagAAAAEMJYLuQz/t44fi9E8CmkG6QS4Bh/7mpgQtSKcnN8O3bw/8hUEhqUNYqO3fPWeHNqWA==", "6ac9684c-8b4c-43d1-9641-c48ce963434f" });
        }
    }
}
