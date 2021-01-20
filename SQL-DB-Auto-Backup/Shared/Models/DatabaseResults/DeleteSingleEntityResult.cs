using System;

namespace SQL_DB_Auto_Backup.Shared.Models.DatabaseResults
{
    /// <summary>
    /// Represents the result for deleting a single entity from the database.
    /// There should be nothing that depends on this entity.
    /// </summary>
    /// <typeparam name="EntityType">The type of entity that will be deleted.</typeparam>
    public class DeleteSingleEntityResult<EntityType>
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
        /// Indicates whether if the entity is connected to another entities that must be deleted first.
        /// </summary>
        public bool CanNotDelete { get; set; }

        /// <summary>
        /// Indicates whether the deletion of the entity succeeded or not. 
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The value of the requested entity if it was found successfully in the database. 
        /// </summary>
        public EntityType Value { get; set; }
    }
}
