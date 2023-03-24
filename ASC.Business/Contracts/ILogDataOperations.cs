namespace ASC.Business.Contracts
{
    public interface ILogDataOperations
    {
        Task CreateLogAsync(string category, string message);
        Task CreateExceptionLogAsync(string message, string stackTrace);
    }
}
