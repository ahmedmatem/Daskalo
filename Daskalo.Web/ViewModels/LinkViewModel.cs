namespace Daskalo.Web.ViewModels
{
    public class LinkViewModel
    {
        /// <summary>
        /// Area the link leads.
        /// </summary>
        public string Area { get; set; } = string.Empty;

        /// <summary>
        /// Link controller.
        /// </summary>
        public string Controller { get; set; } = string.Empty;

        /// <summary>
        /// Link action.
        /// </summary>
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// Text to display that represents the link.
        /// </summary>
        public string Text { get; set; } = string.Empty;
    }
}
