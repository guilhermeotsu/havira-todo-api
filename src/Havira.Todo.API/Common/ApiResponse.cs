namespace Havira.Todo.API.Common;

public class ApiResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public IEnumerable<ValidationErrorDetail> Errors { get; set; } = [];
}

public class ApiResponseWithData<T> : ApiResponse
{
    public T? Data { get; set; }
}

