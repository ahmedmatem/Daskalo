
namespace Daskalo.Web.Areas.Teacher.Models.Group
{
    public class GroupCardViewModel
    {
        /// <summary>
        /// Unique group identifier.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Group name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Group short name.
        /// </summary>
        public string ShortName { get; set; } = string.Empty;

        /// <summary>
        /// Group image.
        /// </summary>
        public string Image { get; set; } = string.Empty;
    }
}
