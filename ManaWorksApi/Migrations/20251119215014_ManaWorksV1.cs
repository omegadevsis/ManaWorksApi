using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ManaWorksApi.Migrations
{
    /// <inheritdoc />
    public partial class ManaWorksV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidatestatus",
                columns: table => new
                {
                    CandidateStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatestatus", x => x.CandidateStatusId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "contracttypes",
                columns: table => new
                {
                    ContractTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contracttypes", x => x.ContractTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "educationtypes",
                columns: table => new
                {
                    EducationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationtypes", x => x.EducationTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "experiencetimes",
                columns: table => new
                {
                    ExperienceTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experiencetimes", x => x.ExperienceTimeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "functionworks",
                columns: table => new
                {
                    FunctionWorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_functionworks", x => x.FunctionWorkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "journeytypes",
                columns: table => new
                {
                    JourneyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_journeytypes", x => x.JourneyTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "maritals",
                columns: table => new
                {
                    MaritalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maritals", x => x.MaritalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "profiles",
                columns: table => new
                {
                    ProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProfileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profiles", x => x.ProfileId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "worktimes",
                columns: table => new
                {
                    WorkTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worktimes", x => x.WorkTimeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "worktypes",
                columns: table => new
                {
                    WorkTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worktypes", x => x.WorkTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidates",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birthday = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Childrens = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CandidateStatusId = table.Column<int>(type: "int", nullable: false),
                    MaritalId = table.Column<int>(type: "int", nullable: false),
                    SocialProfile = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidates", x => x.CandidateId);
                    table.ForeignKey(
                        name: "FK_candidates_candidatestatus_CandidateStatusId",
                        column: x => x.CandidateStatusId,
                        principalTable: "candidatestatus",
                        principalColumn: "CandidateStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_candidates_maritals_MaritalId",
                        column: x => x.MaritalId,
                        principalTable: "maritals",
                        principalColumn: "MaritalId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProfileId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Login = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_users_profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "profiles",
                        principalColumn: "ProfileId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vacancies",
                columns: table => new
                {
                    VacancyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ContractTypeId = table.Column<int>(type: "int", nullable: false),
                    JourneyTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Requirements = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vacancies", x => x.VacancyId);
                    table.ForeignKey(
                        name: "FK_vacancies_contracttypes_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "contracttypes",
                        principalColumn: "ContractTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vacancies_journeytypes_JourneyTypeId",
                        column: x => x.JourneyTypeId,
                        principalTable: "journeytypes",
                        principalColumn: "JourneyTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vacancies_worktypes_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "worktypes",
                        principalColumn: "WorkTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidateaddresses",
                columns: table => new
                {
                    CandidateAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Neighborhood = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complement = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ZipCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidateaddresses", x => x.CandidateAddressId);
                    table.ForeignKey(
                        name: "FK_candidateaddresses_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidatecontacts",
                columns: table => new
                {
                    CandidateContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatecontacts", x => x.CandidateContactId);
                    table.ForeignKey(
                        name: "FK_candidatecontacts_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidatecourses",
                columns: table => new
                {
                    CandidateCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Institution = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Conclusion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatecourses", x => x.CandidateCourseId);
                    table.ForeignKey(
                        name: "FK_candidatecourses_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidatedocuments",
                columns: table => new
                {
                    CandidateDocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rg = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatedocuments", x => x.CandidateDocumentId);
                    table.ForeignKey(
                        name: "FK_candidatedocuments_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidateeducations",
                columns: table => new
                {
                    CandidateEducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    EducationTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Conclusion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidateeducations", x => x.CandidateEducationId);
                    table.ForeignKey(
                        name: "FK_candidateeducations_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_candidateeducations_educationtypes_EducationTypeId",
                        column: x => x.EducationTypeId,
                        principalTable: "educationtypes",
                        principalColumn: "EducationTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidateexperiences",
                columns: table => new
                {
                    CandidateExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    ExperienceTimeId = table.Column<int>(type: "int", nullable: false),
                    Enterprise = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Activity = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReasonLeaving = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Position = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidateexperiences", x => x.CandidateExperienceId);
                    table.ForeignKey(
                        name: "FK_candidateexperiences_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_candidateexperiences_experiencetimes_ExperienceTimeId",
                        column: x => x.ExperienceTimeId,
                        principalTable: "experiencetimes",
                        principalColumn: "ExperienceTimeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CandidateFunction",
                columns: table => new
                {
                    CandidateFunctionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    FunctionId = table.Column<int>(type: "int", nullable: false),
                    ExperienceTimeId = table.Column<int>(type: "int", nullable: false),
                    FunctionWorkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateFunction", x => x.CandidateFunctionId);
                    table.ForeignKey(
                        name: "FK_CandidateFunction_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateFunction_experiencetimes_ExperienceTimeId",
                        column: x => x.ExperienceTimeId,
                        principalTable: "experiencetimes",
                        principalColumn: "ExperienceTimeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateFunction_functionworks_FunctionWorkId",
                        column: x => x.FunctionWorkId,
                        principalTable: "functionworks",
                        principalColumn: "FunctionWorkId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidateobjectives",
                columns: table => new
                {
                    CandidateObjectiveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    Period = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pretension = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    WorkSupermarket = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidateobjectives", x => x.CandidateObjectiveId);
                    table.ForeignKey(
                        name: "FK_candidateobjectives_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "candidateselections",
                columns: table => new
                {
                    CandidateSelectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CandidateId = table.Column<int>(type: "int", nullable: false),
                    DisponibilityTime = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    WorkTimeId = table.Column<int>(type: "int", nullable: true),
                    DisponibilityWeekend = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    MarketWorked = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    MarketWorkedDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DistanceHome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FunctionWorked = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrentlyWorking = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DisponibilityImediate = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    KnowingVacancy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pretension = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    FunctionExperience = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ExperienceTimeId = table.Column<int>(type: "int", nullable: true),
                    RelevanceFormation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidateselections", x => x.CandidateSelectionId);
                    table.ForeignKey(
                        name: "FK_candidateselections_candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_candidateselections_worktimes_WorkTimeId",
                        column: x => x.WorkTimeId,
                        principalTable: "worktimes",
                        principalColumn: "WorkTimeId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_candidateaddresses_CandidateId",
                table: "candidateaddresses",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidatecontacts_CandidateId",
                table: "candidatecontacts",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidatecourses_CandidateId",
                table: "candidatecourses",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_candidatedocuments_CandidateId",
                table: "candidatedocuments",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidateeducations_CandidateId",
                table: "candidateeducations",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_candidateeducations_EducationTypeId",
                table: "candidateeducations",
                column: "EducationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_candidateexperiences_CandidateId",
                table: "candidateexperiences",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_candidateexperiences_ExperienceTimeId",
                table: "candidateexperiences",
                column: "ExperienceTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateFunction_CandidateId",
                table: "CandidateFunction",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateFunction_ExperienceTimeId",
                table: "CandidateFunction",
                column: "ExperienceTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateFunction_FunctionWorkId",
                table: "CandidateFunction",
                column: "FunctionWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_candidateobjectives_CandidateId",
                table: "candidateobjectives",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidates_CandidateStatusId",
                table: "candidates",
                column: "CandidateStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_candidates_MaritalId",
                table: "candidates",
                column: "MaritalId");

            migrationBuilder.CreateIndex(
                name: "IX_candidateselections_CandidateId",
                table: "candidateselections",
                column: "CandidateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_candidateselections_WorkTimeId",
                table: "candidateselections",
                column: "WorkTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_users_ProfileId",
                table: "users",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_vacancies_ContractTypeId",
                table: "vacancies",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_vacancies_JourneyTypeId",
                table: "vacancies",
                column: "JourneyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_vacancies_WorkTypeId",
                table: "vacancies",
                column: "WorkTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidateaddresses");

            migrationBuilder.DropTable(
                name: "candidatecontacts");

            migrationBuilder.DropTable(
                name: "candidatecourses");

            migrationBuilder.DropTable(
                name: "candidatedocuments");

            migrationBuilder.DropTable(
                name: "candidateeducations");

            migrationBuilder.DropTable(
                name: "candidateexperiences");

            migrationBuilder.DropTable(
                name: "CandidateFunction");

            migrationBuilder.DropTable(
                name: "candidateobjectives");

            migrationBuilder.DropTable(
                name: "candidateselections");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "vacancies");

            migrationBuilder.DropTable(
                name: "educationtypes");

            migrationBuilder.DropTable(
                name: "experiencetimes");

            migrationBuilder.DropTable(
                name: "functionworks");

            migrationBuilder.DropTable(
                name: "candidates");

            migrationBuilder.DropTable(
                name: "worktimes");

            migrationBuilder.DropTable(
                name: "profiles");

            migrationBuilder.DropTable(
                name: "contracttypes");

            migrationBuilder.DropTable(
                name: "journeytypes");

            migrationBuilder.DropTable(
                name: "worktypes");

            migrationBuilder.DropTable(
                name: "candidatestatus");

            migrationBuilder.DropTable(
                name: "maritals");
        }
    }
}
