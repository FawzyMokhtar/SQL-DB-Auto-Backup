using System;

namespace SQL_DB_Auto_Backup.Shared.Models.Validations.ValidationRoles
{
    /// <summary>
    /// A validation role for a time-span property value range.
    /// </summary>
    public class TimeRangeValidationRole
    {
        /// <summary>
        /// Creates a new instance of <see cref="TimeRangeValidationRole"/> with the specified min and max value.
        /// </summary>
        /// <param name="min">The minimum value of the property value.</param>
        /// <param name="max">The maximum value of the property value.</param>
        public TimeRangeValidationRole(TimeSpan min, TimeSpan max)
        {
            Min = min;
            Max = max;
        }

        /// <summary>
        /// Creates a new instance of <see cref="TimeRangeValidationRole"/> with the specified min value.
        /// Omitting <see langword="max"/> value means that the <see langword="max"/> value 
        /// will be set to <see langword="new TimeSpan(24, 0, 0)"/>.
        /// </summary>
        /// <param name="min">The minimum value of the property value.</param>
        public TimeRangeValidationRole(TimeSpan min)
        {
            Min = min;
            Max = new TimeSpan(24, 0, 0);
        }

        /// <summary>
        /// Gets the minimum value of the property value.
        /// </summary>
        public TimeSpan Min { get; }

        /// <summary>
        /// Gets the maximum value of the property value.
        /// </summary>
        public TimeSpan Max { get; }
    }
}
