using ASC.Models.BaseTypes;

namespace ASC.Models.Models
{
    public class Log : BaseEntity
    {
        public string Message { get; set; } = string.Empty;
    }
}
