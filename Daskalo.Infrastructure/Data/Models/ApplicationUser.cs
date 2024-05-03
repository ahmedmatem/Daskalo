
using Daskalo.Infrastructure.Data.Contracts;
using Daskalo.Infrastructure.Data.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Daskalo.Infrastructure.Data.Constants.DataConstants;
using static Daskalo.Infrastructure.Data.Constants.ErrorMessages;

namespace Daskalo.Infrastructure.Data.Models
{
    /// <summary>
    /// Extended identity user model.
    /// </summary>
    public class ApplicationUser : IdentityUser, IDeletable
    {
        /// <summary>
        /// Unique identifier of school the user wants to participate in.
        /// </summary>
        [Required]
        [Comment("Unique identifier of school the user wants to participate in.")]
        public string SchoolId { get; set; } = string.Empty;

        /// <summary>
        /// User full name.
        /// </summary>
        [Required]
        [MaxLength(UserFullNameMaxLength, ErrorMessage = MaxLengthErrorMessage)]
        [Comment("User full name.")]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// The <see cref="Role"/> of the user in school.
        /// </summary>
        [Comment("The role of the user in school - teacher or student")]
        public Role Role { get; set; }

        /**
         * Navigation properties.
         **/

        /// <summary>
        /// The list of the groups which the user participate in.
        /// </summary>
        public IList<Group> Groups { get; set; } = new List<Group>();

        /// <summary>
        /// The school the user participate in.
        /// </summary>]
        public School School { get; set; } = null!;

        public bool IsDeleted { get; set ; }
        public DateTime? DeletedOn { get; set; }
    }
}
