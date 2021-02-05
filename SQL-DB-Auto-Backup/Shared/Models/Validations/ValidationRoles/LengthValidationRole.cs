namespace SQL_DB_Auto_Backup.Shared.Models.Validations.ValidationRoles
{
    /// <summary>
    /// A validation role for a string property length.
    /// </summary>
    public class LengthValidationRole
    {
        /// <summary>
        /// Creates a new instance of <see cref="LengthValidationRole"/> with the specified min and max length.
        /// </summary>
        /// <param name="min">The minimum length of the property value.</param>
        /// <param name="max">The maximum length of the property value.</param>
        public LengthValidationRole(int min, int max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Gets the minimum length of the property value.
        /// </summary>
        public int Min { get; }

        /// <summary>
        /// Gets the maximum length of the property value.
        /// </summary>
        public int Max { get; }
    }
}
