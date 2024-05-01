namespace Daskalo.Infrastructure.Data.Constants
{
    /// <summary>
    /// Contains constants about the data models.
    /// </summary>
    public static class DataConstants
    {
        public const int UserFullNameMinLength = 5;
        public const int UserFullNameMaxLength = 40;

        public const int GroupNameMinLength = 2;
        public const int GroupNameMaxLength = 100;
        public const int GroupShortNameMinLength = 2;
        public const int GroupShortNameMaxLength = 10;
        public const int GroupDescriptionMaxLength = 200;

        public const int ResourceTextToDisplayMinLength = 3;
        public const int ResourceTextToDisplayMaxLength = 70;

        public const int SchoolNameMinLength = 10;
        public const int SchoolNameMaxLength = 150;
        public const int SchoolTypeMinLength = 2;
        public const int SchoolTypeMaxLength = 7;
        public const int SchoolCityMinLength = 3;
        public const int SchoolCityMaxLength = 15;

        public const int TopicNameMinLength = 2;
        public const int TopicNameMaxLength = 100;
        public const int TopicDescriptionMaxLength = 200;
    }
}
