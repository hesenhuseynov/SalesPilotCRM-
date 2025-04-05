namespace SalesPilotCRM.API.Models
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }

        public static ApiResponse<T> Ok(T data) =>
            new ApiResponse<T> { Success = true, Data = data };

        public static ApiResponse<T> Fail(List<string> errors) =>
            new ApiResponse<T> { Success = false, Errors = errors };

        public static ApiResponse<T> Fail(string error) =>
            new ApiResponse<T> { Success = false, Errors = new List<string> { error } };
    }
}
