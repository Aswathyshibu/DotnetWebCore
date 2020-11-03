using Microsoft.EntityFrameworkCore.Migrations;

namespace webcore.Migrations
{
    public partial class spGetEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create procedure spGetEmployees
                               
                                as begin
                                select * from Employees 
                                end";

            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure spGetEmployees";
            migrationBuilder.Sql(procedure);
        }
    }
}
