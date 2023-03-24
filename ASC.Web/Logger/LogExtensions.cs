using ASC.Business.Contracts;

namespace ASC.Web.Logger
{
    public class LogExtensions
    {

    }

    public static class EmailLoggerExtensions
    {
        public static ILoggerFactory AddAzureTableStorageLog(this ILoggerFactory factory, ILogDataOperations logOperations, Func<string, LogLevel, bool> filter = null)
        {
            factory.AddProvider(new AzureStorageLoggerProvider(filter, logOperations));
            return factory;
        }
    }
}
