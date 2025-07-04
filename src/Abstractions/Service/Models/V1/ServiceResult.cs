namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

public class ServiceResult<T>
{
    public bool IsSuccess { get; }
    public IEnumerable<T>? Results { get; }
    public string? ErrorCode { get; }
    public string? ErrorMessage { get; }
    public Exception? Exception { get; }

    private ServiceResult(IEnumerable<T> results)
    {
        IsSuccess = true;
        Results = results;
    }

    private ServiceResult(string errorCode, string errorMessage, Exception? exception = null)
    {
        IsSuccess = false;
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
        Exception = exception;
    }

    public static ServiceResult<T> Success(IEnumerable<T> results) => new(results);

    public static ServiceResult<T> Failure(string errorCode, string errorMessage, Exception? exception = null)
        => new(errorCode, errorMessage, exception);
}