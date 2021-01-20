using System;

namespace SQL_DB_Auto_Backup.Shared.Models.DatabaseResults
{
    /// <summary>
    /// Represents a result of querying the database looking for a single entity of a given type.
    /// </summary>
    /// <typeparam name="EntityType">The type of resulting entity.</typeparam>
    public class QuerySingleEntityResult<EntityType>
    {
        /// <summary>
        /// An error that will be full filled if there is an error occurred during the method. 
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Indicates whether if the entity was found in the database of not.
        /// </summary>
        public bool NotFound { get; set; }

        /// <summary>
        /// The value of the requested entity if it was found successfully in the database. 
        /// </summary>
        public EntityType Value { get; set; }
    }
}
