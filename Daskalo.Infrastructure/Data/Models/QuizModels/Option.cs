using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;

namespace Daskalo.Infrastructure.Data.Models.QuizModels
{
    /// <summary>
    /// Question option data model.
    /// </summary>
    [Comment("Question option data model.")]
    public class Option : DataModel
    {
        /// <summary>
        /// Unique identifier of the option.
        /// </summary>
        [Comment("Unique identifier of the option.")]
        public string QuestionId { get; set; } = string.Empty;

        /// <summary>
        /// Text represents the  content of the option.
        /// </summary>
        [Comment("Text represents the  content of the option.")]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Image that could be attached to the option of the question.
        /// </summary>
        [Comment("Image that could be attached to the option of the question.")]
        public string Image { get; set; } = string.Empty;

        /// <summary>
        /// Indicates whether the option is the question correct answer.
        /// </summary>
        [Comment("Indicates whether the option is the question correct answer.")]
        public bool CorrectAnswer { get; set; }

        /// <summary>
        /// Message for those who choose this option.
        /// </summary>
        [Comment("Message for those who choose this option.")]
        [MaxLength(OptionMessageMaxLength)]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Question the option belongs to.
        /// </summary>
        [Comment("Question the option belongs to.")]
        [ForeignKey("QuestionId")]
        public Question Question { get; set; } = null!;
    }
}
