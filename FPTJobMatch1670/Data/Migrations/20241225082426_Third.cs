using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPTJobMatch1670.Data.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Seeker_SeekerId",
                table: "Application");

            migrationBuilder.DropTable(
                name: "Seeker");

            migrationBuilder.DropIndex(
                name: "IX_Application_SeekerId",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "SeekerId",
                table: "Application");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5a9dffe-4a0c-4c11-9b01-afb9edc207d8", "AQAAAAIAAYagAAAAEIawX8VBqgIA9hvvU3GmEokuxoqn7VUBnVqGTnnpL9bJmCvs35vkYRY7uZ2/RAz7ZQ==", "8bfac8ee-3eec-466c-a3f6-2dcdbaee4688" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employer-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db3327d2-6937-4b5f-88c2-04a35085f95b", "AQAAAAIAAYagAAAAEA3CTQ/zrfUDeKAaHH4Ylq7quJJYszo81svXjCR6LVzCTUp+HXijqCI6gkeP6lfLcw==", "521aba49-dd2d-4c5a-8f60-4cab9a5d4405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeker-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4fbd62c-adec-496a-805d-f3f26d8e189b", "AQAAAAIAAYagAAAAEBF+yMKltKhUICPm0qwt0pifOm5I3bu/dfJb5a48gCgY2iizL9UwxRY3SllAWqcXrA==", "5bc822b3-fecf-47b9-a361-6dc13f79ef1b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeekerId",
                table: "Application",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Seeker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seeker", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e2283b9-0142-48d3-9dbe-41a5788978e1", "AQAAAAIAAYagAAAAEMrkPC6TVs249KcFvNa28sY8bAX2wwOVkXd50VPgEf25Ta5Lh/V4RvY3Q7ll+MusEw==", "3f130f84-6852-41d5-8650-47897c248f6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employer-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f44d1593-765a-4d06-bbb6-80e59fc2586e", "AQAAAAIAAYagAAAAEGf8T/GiWooVqCAB/dLz7sQxsr+XhIXY9E3VsXQj0t+nL411cCpmk6ozccICakchmw==", "d8c20f25-0675-4fd4-9d8a-2945710db019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeker-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f10d7e1b-7218-46bd-9761-850dcdb5be8b", "AQAAAAIAAYagAAAAEAXIET59FNawQxWSJ8eKSTWsRQwdL36JIFt2vh6JncDKyiMMH6WvqJZH9GdhFWgUhg==", "19f2f660-291f-4182-8aa4-236978b29583" });

            migrationBuilder.CreateIndex(
                name: "IX_Application_SeekerId",
                table: "Application",
                column: "SeekerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Seeker_SeekerId",
                table: "Application",
                column: "SeekerId",
                principalTable: "Seeker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
