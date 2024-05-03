namespace Daskalo.Web.ViewModels
{
    public class CardLinkViewModel
    {
        /// <summary>
        /// Source of the image that will be shown in the card.
        /// </summary>
        public string ImageSource { get; set; } = string.Empty;

        /// <summary>
        /// Card link
        /// </summary>
        public LinkViewModel Link { get; set; } = null!;

        /// <summary>
        /// Text to display value on the card.
        /// </summary>
        public string Value { get; set; } = string.Empty;
    }
}
