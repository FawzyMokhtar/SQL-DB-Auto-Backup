
using SQL_DB_Auto_Backup.Shared.Models.Validations.ValidationRoles;

namespace SQL_DB_Auto_Backup.Shared.Models.Models.Validations
{
    /// <summary>
    /// Contains all validation roles.
    /// </summary>
    public class ValidationModel
    {
        /// <summary>
        /// Represents the length validation role.
        /// </summary>
        public LengthValidationRole Length { get; set; }

        /// <summary>
        /// Represents the validation role for a file.
        /// </summary>
        public FileRole File { get; set; }

        /// <summary>
        /// Represents the range validation role.
        /// </summary>
        public RangeValidationRole Range { get; set; }

        /// <summary>
        /// Represents the time-range validation role.
        /// </summary>
        public TimeRangeValidationRole TimeRange { get; set; }
    }
}
