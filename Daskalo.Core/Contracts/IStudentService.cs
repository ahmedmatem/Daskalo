
namespace Daskalo.Core.Contracts
{
    public interface IStudentService
    {
        /// <summary>
        /// Gets all students count.
        /// </summary>
        Task<int> GetStudentsCountAsync();

        /// <summary>
        /// Gets all students in school.
        /// </summary>
        /// <param name="schoolId">School unique identifier.</param>
        Task<int> GetStudentsCountInSchoolAsync(string schoolId);
    }
}
