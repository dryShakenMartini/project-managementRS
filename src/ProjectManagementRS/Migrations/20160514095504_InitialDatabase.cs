using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace ProjectManagementRS.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_TimeSheet_Project_ProjectId", table: "TimeSheet");
            migrationBuilder.DropForeignKey(name: "FK_TimeSheet_User_UserId", table: "TimeSheet");
            migrationBuilder.DropForeignKey(name: "FK_UserProject_Project_ProjectId", table: "UserProject");
            migrationBuilder.DropForeignKey(name: "FK_UserProject_User_UserId", table: "UserProject");
            migrationBuilder.DropForeignKey(name: "FK_UserRole_Role_RoleId", table: "UserRole");
            migrationBuilder.DropForeignKey(name: "FK_UserRole_User_UserId", table: "UserRole");
            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_Project_ProjectId",
                table: "TimeSheet",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_User_UserId",
                table: "TimeSheet",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_Project_ProjectId",
                table: "UserProject",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_User_UserId",
                table: "UserProject",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_TimeSheet_Project_ProjectId", table: "TimeSheet");
            migrationBuilder.DropForeignKey(name: "FK_TimeSheet_User_UserId", table: "TimeSheet");
            migrationBuilder.DropForeignKey(name: "FK_UserProject_Project_ProjectId", table: "UserProject");
            migrationBuilder.DropForeignKey(name: "FK_UserProject_User_UserId", table: "UserProject");
            migrationBuilder.DropForeignKey(name: "FK_UserRole_Role_RoleId", table: "UserRole");
            migrationBuilder.DropForeignKey(name: "FK_UserRole_User_UserId", table: "UserRole");
            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_Project_ProjectId",
                table: "TimeSheet",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_User_UserId",
                table: "TimeSheet",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_Project_ProjectId",
                table: "UserProject",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_UserProject_User_UserId",
                table: "UserProject",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
