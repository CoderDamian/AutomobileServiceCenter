using ASC.Models.BaseTypes;

namespace ASC.Models.Models
{
    public class ExceptionLog : BaseEntity
    {
        public string Message { get; set; } = string.Empty;
        public string StackTrace { get; set; } = string.Empty;
    }
}
