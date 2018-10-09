using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    HtmlUrl = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Blog = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PublicRepos = table.Column<int>(nullable: false),
                    Hireable = table.Column<bool>(nullable: true),
                    Followers = table.Column<int>(nullable: false),
                    Following = table.Column<int>(nullable: false),
                    PublicGists = table.Column<int>(nullable: false),
                    Collaborators = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Repositories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    NodeId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false),
                    OwnerId = table.Column<long>(nullable: false),
                    HtmlUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    GitUrl = table.Column<string>(nullable: true),
                    StargazersCount = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    ForksCount = table.Column<int>(nullable: false),
                    OpenIssuesCount = table.Column<int>(nullable: false),
                    LicenseName = table.Column<string>(nullable: true),
                    DefaultBranch = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repositories_Owner_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_OwnerId",
                table: "Repositories",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
