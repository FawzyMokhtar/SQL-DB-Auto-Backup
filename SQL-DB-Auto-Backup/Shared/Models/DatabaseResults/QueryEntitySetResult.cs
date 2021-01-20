using System;
using System.Collections.Generic;

namespace SQL_DB_Auto_Backup.Shared.Models.DatabaseResults
{
    /// <summary>
    /// Represents a result of querying the database looking for one or more entity of a given type.
    /// </summary>
    /// <typeparam name="EntityType">The type of resulting entity.</typeparam>
    public class QueryEntitySetResult<EntityType>
    {
        /// <summary>
        /// An error that will be full filled if there is an error occurred during the method. 
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// The list of entities resulting from the query. 
        /// </summary>
        public List<EntityType> Values { get; set; }
    }
}
