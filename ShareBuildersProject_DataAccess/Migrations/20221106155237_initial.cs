using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShareBuildersProject_DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AffiliateComposites",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false),
                    AffiliateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffiliateComposites", x => new { x.StationId, x.AffiliateId });
                });

            migrationBuilder.CreateTable(
                name: "Affiliates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affiliates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BroadcastTypeComposites",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false),
                    BroadcastTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadcastTypeComposites", x => new { x.StationId, x.BroadcastTypeId });
                });

            migrationBuilder.CreateTable(
                name: "BroadcastTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroadcastTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketComposites",
                columns: table => new
                {
                    StationId = table.Column<int>(type: "int", nullable: false),
                    MarketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketComposites", x => new { x.StationId, x.MarketId });
                });

            migrationBuilder.CreateTable(
                name: "Markets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CallLetters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserComposites",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComposites", x => new { x.UserId, x.StationId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AffiliateComposites",
                columns: new[] { "AffiliateId", "StationId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Affiliates",
                columns: new[] { "Id", "City", "Name", "ShortName", "State" },
                values: new object[,]
                {
                    { 1, "New York City", "National Broadcasting Company", "NBC", "New York" },
                    { 2, "Burbank", "American Broadcasting Company", "ABC", "California" },
                    { 3, "New York City", "Columbia Broadcasting System", "CBS", "New York" },
                    { 4, "London", "British Broadcasting Corporation", "BBC", "England" }
                });

            migrationBuilder.InsertData(
                table: "BroadcastTypeComposites",
                columns: new[] { "BroadcastTypeId", "StationId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "BroadcastTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Radio" },
                    { 2, "Television" },
                    { 3, "Streaming" }
                });

            migrationBuilder.InsertData(
                table: "MarketComposites",
                columns: new[] { "MarketId", "StationId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Markets",
                columns: new[] { "Id", "Name", "State" },
                values: new object[,]
                {
                    { 1, "New York", "New York" },
                    { 2, "Los Angeles", "California" },
                    { 3, "Las Vegas", "Nevada" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CallLetters", "Format", "Owner" },
                values: new object[,]
                {
                    { 1, "KTLA", "Local Television", "Nextar Media Group" },
                    { 2, "KABC", "Local Television", "ABC Owned Television Stations" },
                    { 3, "KSNE", "Adult Contemporary", "IHeartMedia" }
                });

            migrationBuilder.InsertData(
                table: "UserComposites",
                columns: new[] { "StationId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, null, "Mike", "Jones" },
                    { 2, null, "Bob", "Smith" },
                    { 3, null, "Sarah", "Parker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffiliateComposites");

            migrationBuilder.DropTable(
                name: "Affiliates");

            migrationBuilder.DropTable(
                name: "BroadcastTypeComposites");

            migrationBuilder.DropTable(
                name: "BroadcastTypes");

            migrationBuilder.DropTable(
                name: "MarketComposites");

            migrationBuilder.DropTable(
                name: "Markets");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "UserComposites");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
