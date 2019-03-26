using System;
using System.Data.Entity;

namespace dow.dowtest7878915.Data.Interface
{
    /// <summary>
    /// Interface of IUnitOfWork
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns></returns>
        int Save();

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        DbContext Context { get; }
    }

}
