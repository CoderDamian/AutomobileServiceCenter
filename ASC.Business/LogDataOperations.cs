using ASC.Business.Contracts;
using ASC.DataAccess.Interfaces;
using ASC.Models.Models;

namespace ASC.Business
{
    public class LogDataOperations : ILogDataOperations
    {
        private readonly IUnitOfWork _unitOfWork;

        public LogDataOperations(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task CreateExceptionLogAsync(string message, string stackTrace)
        {
            using (_unitOfWork)
            {
                await _unitOfWork.Repository<ExceptionLog>().AddAsync(new ExceptionLog()
                {
                    Message = message,
                    StackTrace = stackTrace
                });

                _unitOfWork.CommitTransaction();
            }
        }

        public async Task CreateLogAsync(string category, string message)
        {
            using (_unitOfWork)
            {
                await _unitOfWork.Repository<Log>().AddAsync(new Log()
                {
                    Message = message
                });

                _unitOfWork.CommitTransaction();
            }
        }
    }
}