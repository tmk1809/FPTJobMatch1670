using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FPTJobMatch1670.Data.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Application_Employer_EmployerId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId",
                table: "Job");

            migrationBuilder.DropTable(
                name: "Employer");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Application_EmployerId",
                table: "Application");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "EmployerId",
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

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "Description", "Location", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Develop and maintain web applications.", "New York, NY", "Software Engineer", 90000f },
                    { 2, "Plan and execute marketing campaigns.", "Los Angeles, CA", "Marketing Manager", 75000f },
                    { 3, "Analyze and interpret complex data sets.", "San Francisco, CA", "Data Analyst", 85000f },
                    { 4, "Manage employee relations and recruitment efforts.", "Chicago, IL", "Human Resources Specialist", 60000f },
                    { 5, "Oversee and coordinate project activities.", "Austin, TX", "Project Manager", 95000f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Job",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Application",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employer", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20afea43-21f3-4e1c-b6fe-314d4a160bc4", "AQAAAAIAAYagAAAAEE35f0saP5axnDPhUW6ZVN2sJfmQhzDyOl59jRMtdxzfT1xJJDHyLXNFjvTPAgdthA==", "01d36a4a-1e56-41ee-8fc5-b54f5063420c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employer-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5caccff-d811-4328-9332-e1f14d52b800", "AQAAAAIAAYagAAAAEEtLgUWjpquSQkTQ+3R/2tF4yMuJQH6eXC213IamrYrJnkM9h2pg4hOCzgZch4nWOw==", "82c09d26-623c-49ab-a403-89b6cde91fca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "seeker-account",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7489966-bb94-4f54-b443-b8a1755ddcc6", "AQAAAAIAAYagAAAAELlCD6uWVLXx9lKrZ3bcpHw27Mm2J9tQrUCgUZ01yrrsDavYHCoGVEitKenovuxwZQ==", "6b90572f-2150-4461-b72c-90d1d87d2969" });

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId",
                table: "Job",
                column: "EmployerId");

            migrationBuilder.CreateIndex(
                name: "IX_Application_EmployerId",
                table: "Application",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Employer_EmployerId",
                table: "Application",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Employer_EmployerId",
                table: "Job",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
