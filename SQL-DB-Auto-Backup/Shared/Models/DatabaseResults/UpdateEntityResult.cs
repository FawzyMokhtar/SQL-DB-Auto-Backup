using System.Collections.Generic;

namespace SQL_DB_Auto_Backup.Shared.Models.DatabaseResults
{
    /// <summary>
    /// Represents the result for updating an existing entity.
    /// </summary>
    /// <typeparam name="EntityType">The type of the entity that will be updated.</typeparam>
    public class IUpdateEntityResult<EntityType>
    {
        /// <summary>
        /// Represents the database validation errors that may result when updating the entity.
        /// </summary>
        List<string> Errors { get; set; }

        /// <summary>
        /// Determines if there is one or more validation error.
        /// </summary>
        public bool HasErrors => Errors.Count != 0;

        /// <summary>
        /// Indicates whether if the entity was found in the database of not.
        /// </summary>
        bool NotFound { get; set; }

        /// <summary>
        /// Indicates whether the updating of the entity succeeded or not. 
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// The value of the updated entity if the updating was succeeded. 
        /// </summary>
        EntityType Value { get; set; }

        public IUpdateEntityResult()
        {
            Errors = new List<string>();
        }
    }
}
