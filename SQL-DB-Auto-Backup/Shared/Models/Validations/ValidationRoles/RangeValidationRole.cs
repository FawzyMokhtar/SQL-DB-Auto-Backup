namespace SQL_DB_Auto_Backup.Shared.Models.Validations.ValidationRoles
{
    /// <summary>
    /// A validation role for a numeric property value range.
    /// </summary>
    public class RangeValidationRole
    {
        /// <summary>
        /// Creates a new instance of <see cref="RangeValidationRole"/> with the specified min and max value.
        /// </summary>
        /// <param name="min">The minimum value of the property value.</param>
        /// <param name="max">The maximum value of the property value.</param>
        public RangeValidationRole(double min, double max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Creates a new instance of <see cref="RangeValidationRole"/> with the specified min value.
        /// Omitting <see langword="max"/> value means that the <see langword="max"/> value 
        /// will be set to <see langword="double.MaxValue"/>.
        /// </summary>
        /// <param name="min">The minimum value of the property value.</param>
        public RangeValidationRole(double min)
        {
            Min = min;
            Max = double.MaxValue;
        }

        /// <summary>
        /// Gets the minimum value of the property value.
        /// </summary>
        public double Min { get; }

        /// <summary>
        /// Gets the maximum value of the property value.
        /// </summary>
        public double Max { get; }
    }
}
