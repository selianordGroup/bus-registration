using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bus_registration.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellphoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Learners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LearnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnerCellPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Learners_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adminstrators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Initials = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LearnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminstrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adminstrators_Learners_LearnerId",
                        column: x => x.LearnerId,
                        principalTable: "Learners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BusNumber = table.Column<int>(type: "int", nullable: false),
                    PickUpNumber = table.Column<int>(type: "int", nullable: false),
                    DropOffNumber = table.Column<int>(type: "int", nullable: false),
                    PickUpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DropOffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickUpTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropOffTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusLimit = table.Column<int>(type: "int", nullable: false),
                    ApplicationsStatus = table.Column<bool>(type: "bit", nullable: false),
                    WaitingNumber = table.Column<int>(type: "int", nullable: false),
                    WaitingListDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LearnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buses_Learners_LearnerId",
                        column: x => x.LearnerId,
                        principalTable: "Learners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adminstrators_LearnerId",
                table: "Adminstrators",
                column: "LearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Buses_LearnerId",
                table: "Buses",
                column: "LearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Learners_ParentId",
                table: "Learners",
                column: "ParentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminstrators");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Learners");

            migrationBuilder.DropTable(
                name: "Parents");
        }
    }
}
