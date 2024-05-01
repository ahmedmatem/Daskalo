using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Daskalo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddQuizModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "The name of the Quiz"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                },
                comment: "Quiz data model.");

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    QuizId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of the Quiz the question belongs to."),
                    OrderNumber = table.Column<int>(type: "int", nullable: false, comment: "The number of order in the sequence of questions in the quiz."),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Text representing the content of the question."),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image that could be attached to the text content of the question."),
                    MultipleAnswers = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the question allows multiple answers or not."),
                    Points = table.Column<int>(type: "int", nullable: false, comment: "The question points."),
                    ShuffleOptions = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates if the options in the question must be shuffled or not."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Question data model.");

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique data model identifier."),
                    QuestionId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Unique identifier of the option."),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Text represents the  content of the option."),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Image that could be attached to the option of the question."),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: false, comment: "Indicates whether the option is the question correct answer."),
                    Message = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, comment: "Message for those who choose this option."),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Indicate a record in table as deleted or not."),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of deleting the record in the table."),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of created the record on in the table."),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Mark the date of last modifing the record in the table.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Question option data model.");

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");
        }
    }
}
