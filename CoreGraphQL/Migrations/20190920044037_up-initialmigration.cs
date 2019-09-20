using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreGraphQL.Migrations
{
    public partial class upinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("168a0f4c-3dc5-4372-8c88-a0fb59f98091"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("be34a409-476a-426e-b57d-d3f6d0d79bf9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fc167e87-b12e-45b0-aeae-4836c797ea91"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e460e195-704d-45dd-9d4e-43c83dd6697d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e8dbfd03-83b8-45ec-9da4-b55ba2ccd4e7"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("e8dbfd03-83b8-45ec-9da4-b55ba2ccd4e7"), "John Doe's address", "John Doe" });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[] { new Guid("e460e195-704d-45dd-9d4e-43c83dd6697d"), "Jane Doe's address", "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("168a0f4c-3dc5-4372-8c88-a0fb59f98091"), "Cash account for our users", new Guid("e8dbfd03-83b8-45ec-9da4-b55ba2ccd4e7"), 0 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("fc167e87-b12e-45b0-aeae-4836c797ea91"), "Savings account for our users", new Guid("e460e195-704d-45dd-9d4e-43c83dd6697d"), 1 });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Description", "OwnerId", "Type" },
                values: new object[] { new Guid("be34a409-476a-426e-b57d-d3f6d0d79bf9"), "Income account for our users", new Guid("e460e195-704d-45dd-9d4e-43c83dd6697d"), 3 });
        }
    }
}
