using System.Threading;
using System.Threading.Tasks;

namespace SQL_DB_Auto_Backup.Utils
{
    /// <summary>
    /// The concurrency handler.
    /// </summary>
    public static class ConcurrencyHandler
    {
        private readonly static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        /// <summary>
        /// Asynchronously waits to enter the critical section.
        /// </summary>
        /// <returns></returns>
        public static Task Wait() => semaphore.WaitAsync();

        /// <summary>
        /// Releases the semaphore to allow another thread to enter the critical section.
        /// </summary>
        public static int Release() => semaphore.Release();
    }
}
