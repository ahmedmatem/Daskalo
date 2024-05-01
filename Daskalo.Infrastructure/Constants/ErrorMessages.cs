
namespace Daskalo.Infrastructure.Constants
{
    public static class ErrorMessages
    {
        public const string StringLengthErrorMessage = "Полето {0} трябва да има дължина от {2} до {1} символа.";
        public const string MaxLengthErrorMessage = "Полето {0} трябва да има поне {1} символа.";
        public const string RequiredErrorMessage = "Полето {0} е задължително.";

        public const string SchoolEntityNotFoundErrorMessage = "Училище с id: {0} не беше открито.";

        public const string FileITypeErrorMessage = "Грешен тип на файл: {0}.";
        public const string FileISizeErrorMessage = "Размерът на файла трябва да е до {0}KB.";

    }
}
