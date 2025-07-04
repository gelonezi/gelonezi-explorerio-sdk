namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

public class ServiceResult<T>
{
    public bool IsSuccess { get; }
    public T? Result { get; }
    public string? ErrorCode { get; }
    public string? ErrorMessage { get; }
    public Exception? InnerException { get; }

    private ServiceResult(T result)
    {
        IsSuccess = true;
        Result = result;
    }

    private ServiceResult(string errorCode, string errorMessage, Exception? innerException = null)
    {
        IsSuccess = false;
        ErrorCode = errorCode;
        ErrorMessage = errorMessage;
        InnerException = innerException;
    }

    public static ServiceResult<T> Success(T result) => new(result);

    public static ServiceResult<T> Failure(string errorCode, string errorMessage, Exception? innerException = null)
        => new(errorCode, errorMessage, innerException);
}