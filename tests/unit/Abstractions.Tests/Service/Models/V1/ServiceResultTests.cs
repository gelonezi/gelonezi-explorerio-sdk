using FluentAssertions;
using Gelonezi.ExplorerIO.Sdk.Abstractions.Service.Models.V1;
using Xunit;

namespace Gelonezi.ExplorerIO.Sdk.Abstractions.Tests.Service.Models.V1;

public class ServiceResultTests
{
    [Fact]
    public void Success_ServiceResult_Should_Initialize_With_Default_Values()
    {
        // Arrange
        const string result = "Test Result";

        // Act
        var serviceResult = ServiceResult<string>.Success(result);

        // Assert
        serviceResult.IsSuccess.Should().BeTrue();
        serviceResult.Result.Should().Be(result);
        serviceResult.ErrorCode.Should().BeNull();
        serviceResult.ErrorMessage.Should().BeNull();
        serviceResult.InnerException.Should().BeNull();
    }

    [Fact]
    public void Failure_ServiceResult_Should_Initialize_With_Error_Details()
    {
        // Arrange
        const string errorCode = "Error123";
        const string errorMessage = "An error occurred";
        var innerException = new Exception("Inner exception");

        // Act
        var serviceResult = ServiceResult<string>.Failure(errorCode, errorMessage, innerException);

        // Assert
        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Result.Should().BeNull();
        serviceResult.ErrorCode.Should().Be(errorCode);
        serviceResult.ErrorMessage.Should().Be(errorMessage);
        serviceResult.InnerException.Should().Be(innerException);
    }
    
    [Fact]
    public void Failure_ServiceResult_Should_Initialize_Without_Error_Details()
    {
        // Arrange
        const string errorCode = "Error123";
        const string errorMessage = "An error occurred";

        // Act
        var serviceResult = ServiceResult<string>.Failure(errorCode, errorMessage);

        // Assert
        serviceResult.IsSuccess.Should().BeFalse();
        serviceResult.Result.Should().BeNull();
        serviceResult.ErrorCode.Should().Be(errorCode);
        serviceResult.ErrorMessage.Should().Be(errorMessage);
    }
}