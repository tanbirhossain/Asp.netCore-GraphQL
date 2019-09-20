using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreGraphQL.Migrations
{
    public partial class CoreGraphQLEntitiesContextApplicationContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("56e87a0c-15bb-4f26-8ce2-147a37e242f4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5fbc5808-ae02-48b0-a60e-d73745404898"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6bab6517-a8e7-4738-b5fb-26184a084ae0"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("4b94cdb4-5350-49a3-a30f-1ef7e6a3b572"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e676d0c8-8e7f-499d-8df1-7ca69856b502"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("1dbcc8b7-ee10-4d0e-97ce-f4edfed39dcb"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("0480cd10-99f9-4af7-9224-3b262933d196"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("e338cc81-998d-4ed3-a483-4afd9fb2d01a"), "Cash account for our users", new Guid("1dbcc8b7-ee10-4d0e-97ce-f4edfed39dcb"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("cef5354e-0bfb-4840-964d-8cd34bc19888"), "Savings account for our users", new Guid("0480cd10-99f9-4af7-9224-3b262933d196"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("d49293f7-e78f-4fd1-ab65-50be715d31f1"), "Income account for our users", new Guid("0480cd10-99f9-4af7-9224-3b262933d196"), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cef5354e-0bfb-4840-964d-8cd34bc19888"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("d49293f7-e78f-4fd1-ab65-50be715d31f1"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e338cc81-998d-4ed3-a483-4afd9fb2d01a"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("0480cd10-99f9-4af7-9224-3b262933d196"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("1dbcc8b7-ee10-4d0e-97ce-f4edfed39dcb"));

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("4b94cdb4-5350-49a3-a30f-1ef7e6a3b572"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("e676d0c8-8e7f-499d-8df1-7ca69856b502"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("5fbc5808-ae02-48b0-a60e-d73745404898"), "Cash account for our users", new Guid("4b94cdb4-5350-49a3-a30f-1ef7e6a3b572"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("6bab6517-a8e7-4738-b5fb-26184a084ae0"), "Savings account for our users", new Guid("e676d0c8-8e7f-499d-8df1-7ca69856b502"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("56e87a0c-15bb-4f26-8ce2-147a37e242f4"), "Income account for our users", new Guid("e676d0c8-8e7f-499d-8df1-7ca69856b502"), 3 });
        }
    }
}
