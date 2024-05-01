using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Daskalo.Infrastructure.Data.Models.QuizModels
{
    /// <summary>
    /// Question data model.
    /// </summary>
    [Comment("Question data model.")]
    public class Question : DataModel
    {
        /// <summary>
        /// Unique identifier of the Quiz the question belongs to.
        /// </summary>
        [Comment("Unique identifier of the Quiz the question belongs to.")]
        public string QuizId { get; set; } = string.Empty;

        /// <summary>
        /// The number of order in the sequence of questions in the quiz.
        /// </summary>
        [Comment("The number of order in the sequence of questions in the quiz.")]
        public int OrderNumber { get; set; }

        /// <summary>
        /// Text representing the content of the question.
        /// </summary>
        [Comment("Text representing the content of the question.")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Image that could be attached to the text content of the question.
        /// </summary>
        [Comment("Image that could be attached to the text content of the question.")]
        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// Indicates if the question allows multiple answers or not.
        /// </summary>
        [Comment("Indicates if the question allows multiple answers or not.")]
        public bool MultipleAnswers { get; set; }

        /// <summary>
        /// The question points.
        /// </summary>
        [Comment("The question points.")]
        public int Points { get; set; }

        /// <summary>
        /// Indicates if the options in the question must be shuffled or not.
        /// </summary>
        [Comment("Indicates if the options in the question must be shuffled or not.")]
        public bool ShuffleOptions { get; set; }

        /// <summary>
        /// Quiz the question belongs to.
        /// </summary>
        [Comment("Quiz the question belongs to.")]
        [ForeignKey("QuizId")]
        public Quiz Quiz { get; set; } = null!;

        /// <summary>
        /// Collection of options belonging to the question.
        /// </summary>
        [Comment("Collection of options belonging to the question.")]
        public ICollection<Option> Options { get; set; } = new HashSet<Option>();
    }
}