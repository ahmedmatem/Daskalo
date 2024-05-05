using Daskalo.Infrastructure.Data.Models;

namespace Daskalo.Core.Contracts
{
    public interface ISchoolService
    {
        /// <summary>
        /// Requests the number of all registered schools.
        /// </summary>
        /// <returns>Returns the number of all school excluding deleted ones.</returns>
        Task<int> GetSchoolsCountAsync();

        /// <summary>
        /// Requests the number of all blocked schools.
        /// </summary>
        /// <returns>Returns the number of all blocked(deleted) schools.</returns>
        Task<int> GetBlockedSchoolsCountAsync();

        /// <summary>
        /// Requests all schools from datasource.
        /// </summary>
        /// <returns>Returns all schools excluding deleted ones.</returns>
        Task<IEnumerable<School>> AllAsync();

        /// <summary>
        /// Requests all deleted schools from datasource.
        /// </summary>
        /// <returns>Returns all deleted schools.</returns>
        Task<IEnumerable<School>> AllBlockedAsync();

        /// <summary>
        /// Gets the school by id.
        /// </summary>
        /// <param name="schoolId">School unique identifier.</param>
        /// <returns>Return School Entity or null if not found.</returns>
        Task<School?> GetByIdAsync(string id);

        /// <summary>
        /// Adds administrator to the school. Adds school administrator to SchoolAdmin role
        /// and activates it creating custom authorization claim for user.
        /// </summary>
        /// <param name="schoolId">School unique identifier which the teacher becomes administrator on.</param>
        /// <param name="teacherId">Unique identifier of the teacher who will become administrator.</param>
        /// <returns></returns>
        Task<bool> TryAddSchoolAdminAsync(string schoolId, string teacherId);

        /// <summary>
        /// Add scholl in datasource.
        /// </summary>
        /// <param name="school">The school which will be added.</param>
        Task AddAsync(School school);

        /// <summary>
        /// Update scholl.
        /// </summary>
        /// <param name="school">Tracked entity with updated properties.</param>
        Task UpdateAsync(School school);
    }
}
