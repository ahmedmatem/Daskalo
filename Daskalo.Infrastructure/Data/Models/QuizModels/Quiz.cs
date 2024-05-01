using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;

namespace Daskalo.Infrastructure.Data.Models.QuizModels
{
    /// <summary>
    /// Quiz data model
    /// </summary>
    [Comment("Quiz data model.")]
    public class Quiz : DataModel
    {
        /// <summary>
        /// The name of the Quiz
        /// </summary>
        [Comment("The name of the Quiz")]
        [MaxLength(QuizNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Collection of <see cref="Question"/>s belonging to the Quiz.
        /// </summary>
        [Comment("Collection of questions belonging to the Quiz.")]
        public IList<Question> Questions { get; set; } = new List<Question>();
    }
}
