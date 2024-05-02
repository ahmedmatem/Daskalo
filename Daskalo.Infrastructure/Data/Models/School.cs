
using Daskalo.Infrastructure.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;

namespace Daskalo.Infrastructure.Data.Models
{
    /// <summary>
    /// The model of School.
    /// </summary>
    public class School : DataModel
    {
        /// <summary>
        /// Unique identifier of the school administrator.
        /// NULL means that the school has not administrator yet.
        /// </summary>
        [ForeignKey("SchoolAdmin")]
        [Comment("Unique identifier of the school administrator.")]
        public string? SchoolAdminId { get; set; }

        /// <summary>
        /// The name of the school.
        /// </summary>
        [Required]
        [MaxLength(SchoolNameMaxLength)]
        [Comment("School name.")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The type of the school.
        /// </summary>
        [Required]
        [MaxLength(SchoolTypeMaxLength)]
        [Comment("School type identifier - например: ОУ, ППМГ, ГПЕЧЕ.")]
        public string Type { get; set; } = String.Empty;

        /// <summary>
        /// The name of the city where school is located.
        /// </summary>
        [Required]
        [MaxLength(SchoolCityMaxLength)]
        [Comment("The name of the city where school is located.")]
        public string City { get; set; } = string.Empty;

        /**
         * Navigation properties
         **/

        public ApplicationUser? SchoolAdmin { get; set; }

        /// <summary>
        /// All members belonging to the school.
        /// </summary>
        public IList<ApplicationUser> Members { get; set; } = new List<ApplicationUser>();
    }
}
