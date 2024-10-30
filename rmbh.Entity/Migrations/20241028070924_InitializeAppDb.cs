﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rmbh.Entity.Migrations
{
    public partial class InitializeAppDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    StudyDeckType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decks_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClasses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClassStatistic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSpent = table.Column<long>(type: "bigint", nullable: true),
                    MasteryScore = table.Column<int>(type: "int", nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClassStatistic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClassStatistic_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserClassStatistic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionImg = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AnswerImg = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    QuestionClarifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerClarifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionFootnote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerFootnote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeckId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDeckStatistic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSpent = table.Column<long>(type: "bigint", nullable: true),
                    MasteryScore = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeckId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDeckStatistic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDeckStatistic_Decks_DeckId",
                        column: x => x.DeckId,
                        principalTable: "Decks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDeckStatistic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCardStatistic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSpent = table.Column<long>(type: "bigint", nullable: true),
                    MasteryScore = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<int>(type: "int", nullable: true),
                    Month = table.Column<int>(type: "int", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCardStatistic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCardStatistic_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCardStatistic_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedDate", "Description", "Logo", "ModifiedDate", "Title", "Visibility" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 28, 14, 9, 24, 536, DateTimeKind.Local).AddTicks(8218), "ReactJS is a JavaScript library by Facebook for building interactive user interfaces with reusable components. Students will learn concepts like JSX and component lifecycle, enhancing their ability to create efficient applications.", null, new DateTime(2024, 10, 28, 14, 9, 24, 536, DateTimeKind.Local).AddTicks(8218), "ReactJS", 2 },
                    { 2, new DateTime(2024, 10, 28, 14, 9, 24, 536, DateTimeKind.Local).AddTicks(8218), "ASP.NET Core MVC is a Microsoft framework that uses the Model-View-Controller (MVC) pattern to separate application logic from user interface. Students will learn to build APIs and manage data with Entity Framework Core while ensuring application security.", null, new DateTime(2024, 10, 28, 14, 9, 24, 536, DateTimeKind.Local).AddTicks(8218), "ASP.NET Core MVC", 1 },
                    { 3, new DateTime(2024, 10, 28, 14, 9, 24, 536, DateTimeKind.Local).AddTicks(8218), "Tailwind CSS is a utility-first framework that allows for rapid and flexible UI design using utility classes. Students will discover how to integrate it into projects and customize layouts efficiently.", null, new DateTime(2024, 10, 28, 14, 9, 24, 536, DateTimeKind.Local).AddTicks(8218), "TailwindCSS", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "Bio", "CreatedDate", "Email", "FirstName", "LastName", "ModifiedDate", "Password", "Role" },
                values: new object[,]
                {
                    { new Guid("0a647a8e-eeaf-4d96-8263-566cb883c994"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoa@gmail.com", "Pham", "Minh Hoa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 1 },
                    { new Guid("139fcb97-bd85-4ee0-9849-cb77aeaa67da"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamnhung@gmail.com", "Pham", "Nhung K", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("1b8df37b-80cf-4182-8cc9-12de166b46e2"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phuocnam@gmail.com", "Phuoc", "Nam S", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("22c115dd-c912-4fb2-8d57-037d89e4b5e4"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamngoc@gmail.com", "Pham", "Ngoc E", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("237b98a8-9d2c-4dd7-8058-06a7c4909a6d"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lehong@gmail.com", "Le", "Hong T", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("2a9ffb7d-89fd-4784-b7eb-1a1245d30ae6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "doviet@gmail.com", "Do", "Viet L", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("3d1f9f41-8ac9-4c36-b85f-bcbe68d0f58c"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vominh@gmail.com", "Vo", "Minh H", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("4b6519a1-21ae-44b7-874a-0da82c60ad59"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "duc@gmail.com", "Pham", "Van Duc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("5afbead9-e4a2-4e34-8eb9-ec9989ac31b5"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "leminh@gmail.com", "Le", "Minh M", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("5e5a20e3-3a49-48fc-8e7a-14d476403e94"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenkim@gmail.com", "Nguyen", "Kim F", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("701e1774-9993-44fe-b377-aae0f51e0231"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trieu@gmail.com", "Phan", "Minh Trieu", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 1 },
                    { new Guid("7d3e98b2-8825-476e-b230-63a7d8d6500b"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ngochai@gmail.com", "Ngo", "Hai J", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("8ad18a18-2e0a-44a3-8898-ff2da1e6e6a4"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dangquan@gmail.com", "Dang", "Quan N", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("995dd243-3d72-44fc-b8f6-dfe9b1f4abaf"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "buihieu@gmail.com", "Bui", "Hieu O", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("9b12349d-16b4-43fc-945c-b1632f0bcbb1"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranv@gmail.com", "Tran", "Van C", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("9c0de9d9-1022-419e-9828-e8c7cc6e77c7"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "van@gmail.com", "Nguyen", "Ngoc Khanh Van", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 1 },
                    { new Guid("b2e1073e-5c78-4bbf-9a23-0d3a799a4f81"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vana@gmail.com", "Nguyen", "Van A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("bb7be635-3f9e-4af2-96d1-f232a717b39e"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truonganh@gmail.com", "Truong", "Anh P", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("c876965b-b849-4f4b-b1ae-4c78e5f9b3df"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenanh@gmail.com", "Nguyen", "Anh U", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("cb00a417-417f-4d69-9ad1-e9c04e4f3d11"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "danghoa@gmail.com", "Dang", "Hoa Q", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("d5c1b63d-cd34-47a6-9d18-9b0c5e457d2f"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "thib@gmail.com", "Tran", "Thi B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("deb20833-0427-4520-b0b9-2916b5d42d91"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ngothanh@gmail.com", "Ngo", "Thanh R", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("f12b876c-0e2d-4d39-b878-4d5b45e93557"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lehoang@gmail.com", "Le", "Hoang D", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lamthanh@gmail.com", "Lam", "Thanh I", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 },
                    { new Guid("ff127b02-7f94-4ebd-8d99-91e69f4ab6ba"), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongtuan@gmail.com", "Truong", "Tuan G", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserClasses",
                columns: new[] { "Id", "ClassId", "JoinedDate", "Role", "UserId" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("f8d170a5-02f7-4ff4-8c12-4eb83451fcd6") });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_DeckId",
                table: "Cards",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_ClassId",
                table: "Decks",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCardStatistic_CardId",
                table: "UserCardStatistic",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCardStatistic_UserId",
                table: "UserCardStatistic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_ClassId",
                table: "UserClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClasses_UserId",
                table: "UserClasses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClassStatistic_ClassId",
                table: "UserClassStatistic",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClassStatistic_UserId",
                table: "UserClassStatistic",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeckStatistic_DeckId",
                table: "UserDeckStatistic",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDeckStatistic_UserId",
                table: "UserDeckStatistic",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCardStatistic");

            migrationBuilder.DropTable(
                name: "UserClasses");

            migrationBuilder.DropTable(
                name: "UserClassStatistic");

            migrationBuilder.DropTable(
                name: "UserDeckStatistic");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}