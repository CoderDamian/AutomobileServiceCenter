using ASC.Business.Contracts;

namespace ASC.Web.Logger
{
    public class AzureStorageLoggerProvider : ILoggerProvider
    {
        private readonly Func<string, LogLevel, bool> _filter;
        private readonly ILogDataOperations _logOperations;

        public AzureStorageLoggerProvider(Func<string, LogLevel, bool> filter, ILogDataOperations logOperations)
        {
            this._filter = filter;
            this._logOperations = logOperations;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new AzureStorageLogger(categoryName, _filter, _logOperations);
        }

        public void Dispose()
        {
        }
    }
}
