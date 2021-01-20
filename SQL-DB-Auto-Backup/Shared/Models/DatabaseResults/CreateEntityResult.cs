using System;
using System.Collections.Generic;

namespace SQL_DB_Auto_Backup.Shared.Models.DatabaseResults
{
    /// <summary>
    /// Represents the result for creating a new entity.
    /// </summary>
    /// <typeparam name="EntityType">The type of the entity that will be created.</typeparam>
    public class CreateEntityResult<EntityType>
    {
        /// <summary>
        /// An error that will be full filled if there is an error occurred during the method. 
        /// </summary>
        Exception Exception { get; set; }

        /// <summary>
        /// Represents the database validation errors that may result when creating a new entity.
        /// </summary>
        List<string> Errors { get; set; }

        /// <summary>
        /// Determines if there is one or more validation error.
        /// </summary>
        public bool HasErrors => Errors.Count != 0;

        /// <summary>
        /// Indicates whether the creation of the entity succeeded or not. 
        /// </summary>
        bool Success { get; set; }

        /// <summary>
        /// The value of the created entity if the creation was succeeded. 
        /// </summary>
        EntityType Value { get; set; }

        public CreateEntityResult()
        {
            Errors = new List<string>();
        }
    }
}
