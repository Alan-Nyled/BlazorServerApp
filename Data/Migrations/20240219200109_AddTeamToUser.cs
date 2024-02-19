﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team",
                table: "AspNetUsers");
        }
    }
}
