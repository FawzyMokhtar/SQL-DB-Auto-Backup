using System.Data.Entity;

namespace SQL_DB_Auto_Backup.DataSource.DbContexts
{
    /// <summary>
    /// A partial <see cref="DatabaseContext"/> class that extends the features of the base <see cref="DatabaseContext"/> class.
    /// </summary>
    public partial class DatabaseContext : DbContext
    {
        /// <summary>
        /// Adding the ability to read the connectionString from the default connectionString 
        /// located in the Web.config file.
        /// </summary>
        /// <param name="forOverloading">A flag that differentiates this overloads from the base overload,
        /// it's not useful in any thing else.</param>
        public DatabaseContext(bool forOverloading) : base()
        {
            // Disable the lazyLoading feature that is enabled by default
            // Lazy loading and serialization don’t mix well
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
