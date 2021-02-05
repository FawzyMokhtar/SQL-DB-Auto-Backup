using System.Collections.Generic;

namespace SQL_DB_Auto_Backup.Shared.Models.Validations.ValidationRoles
{
    /// <summary>
    /// A validation role for a file.
    /// </summary>
    public class FileRole
    {
        /// <summary>
        /// Creates a new instance of <see cref="FileRole"/> with the specified maximum size and supported types.
        /// </summary>
        /// <param name="maxSize">The maximum size of this file, in bytes.</param>
        /// <param name="supportedTypes">The supported types for this file.</param>
        public FileRole(int maxSize, List<string> supportedTypes)
        {
            MaxSize = maxSize;
            SupportedTypes = supportedTypes;
        }

        /// <summary>
        /// Gets the maximum size of this file in bytes.
        /// </summary>
        public int MaxSize { get; }

        /// <summary>
        /// Gets the supported types for this file.
        /// </summary>
        public List<string> SupportedTypes { get; }
    }
}
