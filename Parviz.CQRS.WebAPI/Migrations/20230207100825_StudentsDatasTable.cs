using Microsoft.EntityFrameworkCore.Migrations;

namespace Parviz.CQRS.WebAPI.Migrations
{
    public partial class StudentsDatasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 21, "Parviz", "Yunisli" },
                    { 2, 21, "Murad", "Aliyev" },
                    { 3, 21, "Xuraman", "Tagizade" },
                    { 4, 22, "Osman", "Bashirov" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
