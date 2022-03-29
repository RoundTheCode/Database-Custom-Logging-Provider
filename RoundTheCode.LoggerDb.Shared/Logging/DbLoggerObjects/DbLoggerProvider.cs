using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RoundTheCode.LoggerDb.Shared.Logging.DbLoggerObjects.RoundTheCode.LoggerDb.Shared.Logging.DbLoggerObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode.LoggerDb.Shared.Logging.DbLoggerObjects
{
    [ProviderAlias("Database")]
    public class DbLoggerProvider : ILoggerProvider
    {
        public readonly DbLoggerOptions Options;

        public DbLoggerProvider(IOptions<DbLoggerOptions> _options)
        {
            Options = _options.Value; // Stores all the options.
        }

        /// <summary>
        /// Creates a new instance of the db logger.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <returns></returns>
        public ILogger CreateLogger(string categoryName)
        {
            return new DbLogger(this);
        }

        public void Dispose()
        {
        }
    }
}
