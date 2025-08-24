using System.Diagnostics.CodeAnalysis;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;

/// <summary>
/// Represents the result of a service operation, indicating success or failure.
/// </summary>
/// <typeparam name="T">The type of the result returned on success.</typeparam>
[ExcludeFromCodeCoverage]
public class ServiceResult<T>
{
    /// <summary>
    /// Indicates whether the operation was successful.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// The result returned on success. Null if the operation failed.
    /// </summary>
    public T? Result { get; }

    /// <summary>
    /// The error code if the operation failed. Null if successful.
    /// </summary>
    public string? ErrorCode { get; }

    /// <summary>
    /// The error message if the operation failed. Null if successful.
    /// </summary>
    public string? ErrorMessage { get; }

    /// <summary>
    /// The inner exception associated with the error, if any.
    /// </summary>
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

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    /// <param name="result">The result value to return.</param>
    /// <returns>An instance of <see cref="ServiceResult{T}"/> indicating success.</returns>
    public static ServiceResult<T> Success(T result) => new(result);

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    /// <param name="errorCode">The error code.</param>
    /// <param name="errorMessage">A descriptive error message.</param>
    /// <param name="innerException">The inner exception, if any.</param>
    /// <returns>An instance of <see cref="ServiceResult{T}"/> indicating failure.</returns>
    public static ServiceResult<T> Failure(string errorCode, string errorMessage, Exception? innerException = null)
        => new(errorCode, errorMessage, innerException);
}