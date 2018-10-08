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
                    GravatarId = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    HtmlUrl = table.Column<string>(nullable: true),
                    FollowersUrl = table.Column<string>(nullable: true),
                    FollowingUrl = table.Column<string>(nullable: true),
                    GistsUrl = table.Column<string>(nullable: true),
                    StarredUrl = table.Column<string>(nullable: true),
                    SubscriptionsUrl = table.Column<string>(nullable: true),
                    OrganizationsUrl = table.Column<string>(nullable: true),
                    ReposUrl = table.Column<string>(nullable: true),
                    EventsUrl = table.Column<string>(nullable: true),
                    ReceivedEventsUrl = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    SiteAdmin = table.Column<bool>(nullable: false)
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
                    Fork = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ForksUrl = table.Column<string>(nullable: true),
                    KeysUrl = table.Column<string>(nullable: true),
                    CollaboratorsUrl = table.Column<string>(nullable: true),
                    TeamsUrl = table.Column<string>(nullable: true),
                    HooksUrl = table.Column<string>(nullable: true),
                    IssueEventsUrl = table.Column<string>(nullable: true),
                    EventsUrl = table.Column<string>(nullable: true),
                    AssigneesUrl = table.Column<string>(nullable: true),
                    BranchesUrl = table.Column<string>(nullable: true),
                    TagsUrl = table.Column<string>(nullable: true),
                    BlobsUrl = table.Column<string>(nullable: true),
                    GitTagsUrl = table.Column<string>(nullable: true),
                    GitRefsUrl = table.Column<string>(nullable: true),
                    TreesUrl = table.Column<string>(nullable: true),
                    StatusesUrl = table.Column<string>(nullable: true),
                    LanguagesUrl = table.Column<string>(nullable: true),
                    StargazersUrl = table.Column<string>(nullable: true),
                    ContributorsUrl = table.Column<string>(nullable: true),
                    SubscribersUrl = table.Column<string>(nullable: true),
                    SubscriptionUrl = table.Column<string>(nullable: true),
                    CommitsUrl = table.Column<string>(nullable: true),
                    GitCommitsUrl = table.Column<string>(nullable: true),
                    CommentsUrl = table.Column<string>(nullable: true),
                    IssueCommentUrl = table.Column<string>(nullable: true),
                    ContentsUrl = table.Column<string>(nullable: true),
                    CompareUrl = table.Column<string>(nullable: true),
                    MergesUrl = table.Column<string>(nullable: true),
                    ArchiveUrl = table.Column<string>(nullable: true),
                    DownloadsUrl = table.Column<string>(nullable: true),
                    IssuesUrl = table.Column<string>(nullable: true),
                    PullsUrl = table.Column<string>(nullable: true),
                    MilestonesUrl = table.Column<string>(nullable: true),
                    NotificationsUrl = table.Column<string>(nullable: true),
                    LabelsUrl = table.Column<string>(nullable: true),
                    ReleasesUrl = table.Column<string>(nullable: true),
                    DeploymentsUrl = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    PushedAt = table.Column<DateTime>(nullable: false),
                    GitUrl = table.Column<string>(nullable: true),
                    SshUrl = table.Column<string>(nullable: true),
                    CloneUrl = table.Column<string>(nullable: true),
                    SvnUrl = table.Column<string>(nullable: true),
                    Homepage = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    StargazersCount = table.Column<int>(nullable: false),
                    WatchersCount = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    HasIssues = table.Column<bool>(nullable: false),
                    HasProjects = table.Column<bool>(nullable: false),
                    HasDownloads = table.Column<bool>(nullable: false),
                    HasWiki = table.Column<bool>(nullable: false),
                    HasPages = table.Column<bool>(nullable: false),
                    ForksCount = table.Column<int>(nullable: false),
                    Archived = table.Column<bool>(nullable: false),
                    OpenIssuesCount = table.Column<int>(nullable: false),
                    Forks = table.Column<int>(nullable: false),
                    OpenIssues = table.Column<int>(nullable: false),
                    Watchers = table.Column<int>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "License",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Key = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SpdxId = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    NodeId = table.Column<string>(nullable: true),
                    RepositoriesId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.Id);
                    table.ForeignKey(
                        name: "FK_License_Repositories_RepositoriesId",
                        column: x => x.RepositoriesId,
                        principalTable: "Repositories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false),
                    Admin = table.Column<bool>(nullable: false),
                    Push = table.Column<bool>(nullable: false),
                    Pull = table.Column<bool>(nullable: false),
                    RepositoriesId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissions_Repositories_RepositoriesId",
                        column: x => x.RepositoriesId,
                        principalTable: "Repositories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_License_RepositoriesId",
                table: "License",
                column: "RepositoriesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_RepositoriesId",
                table: "Permissions",
                column: "RepositoriesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repositories_OwnerId",
                table: "Repositories",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "License");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Repositories");

            migrationBuilder.DropTable(
                name: "Owner");
        }
    }
}
