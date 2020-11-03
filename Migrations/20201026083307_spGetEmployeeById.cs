using Microsoft.EntityFrameworkCore.Migrations;

namespace webcore.Migrations
{
    public partial class spGetEmployeeById : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"create procedure spGetElementById
                               @Id int
                                as begin
                                select * from Employees where EmployeeId=@Id
                                end";

            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"drop procedure spGetElementById";
            migrationBuilder.Sql(procedure);
        }
       
    }
}
