using SalesPilotCRM.Application.Common.Enums;

namespace SalesPilotCRM.Application.Common.Models
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }
        public ResultStatus Status { get; set; } = ResultStatus.Success;

        public static Result<T> Ok(T data, string? message = null)
        {
            return new Result<T>
            {
                Success = true,
                Data = data,
                Message = message,
                Status = ResultStatus.Success
            };
        }

        public static Result<T> Fail(string error, ResultStatus status = ResultStatus.ValidationError)
        {
            return new Result<T>
            {
                Success = false,
                Errors = new List<string> { error },
                Status = status
            };
        }
        public static Result<T> Fail(List<string> errors, ResultStatus status = ResultStatus.ValidationError)
        {
            return new Result<T>
            {
                Success = false,
                Errors = errors,
                Status = status
            };
        }
    }
}
