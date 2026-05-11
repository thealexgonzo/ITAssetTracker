namespace ITAssetTracker.Infrastructure.Entities;

/// <summary>
/// Represents the outcome of an operation, including its success status and an associated message.
/// </summary>
/// <remarks>Use the Result class to communicate whether an operation completed successfully and to provide
/// additional context or error information through the message. This class is commonly used for methods that need to
/// return both a success indicator and a descriptive message without throwing exceptions.</remarks>
public class Result
{
    /// <summary>
    /// Gets a value indicating whether the operation completed successfully.
    /// </summary>
    public bool Ok { get; }
    /// <summary>
    /// Gets the message content associated with this instance if the operation failed.
    /// </summary>
    public string Message { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Result class with the specified success state and message.
    /// </summary>
    /// <param name="success">A value indicating whether the operation was successful. Set to <see langword="true"/> if the operation
    /// succeeded; otherwise, <see langword="false"/>.</param>
    /// <param name="message">A message that provides additional information about the result. Can be used to convey error details or success
    /// confirmation.</param>
    public Result(bool success, string message)
    {
        Ok = success;
        Message = message;
    }
}

/// <summary>
/// Represents the result of an operation that returns a value of the specified type, along with a success indicator and
/// an optional message.
/// </summary>
/// <remarks>Use this class to encapsulate both the outcome and the data produced by an operation. This is useful
/// for methods that need to return a value as well as indicate whether the operation succeeded or failed. The base
/// Result class provides success and message information, while this generic version adds a strongly typed data
/// payload.</remarks>
/// <typeparam name="T">The type of the value returned by the operation.</typeparam>
public class Result<T> : Result
{
    /// <summary>
    /// Gets or sets the data value of the current result.
    /// </summary>
    public T? Data { get; set; }
    /// <summary>
    /// Initializes a new instance of the Result class with the specified data, success status, and message.
    /// </summary>
    /// <param name="data">The data associated with the result. This value is typically returned when the operation completes successfully.</param>
    /// <param name="success">A value indicating whether the operation was successful. Set to <see langword="true"/> if the operation
    /// succeeded; otherwise, <see langword="false"/>.</param>
    /// <param name="message">A message that provides additional information about the result, such as an error description or success note.</param>
    public Result(T data, bool success, string message) : base(success, message)
    {
        Data = data;        
    }
}

/// <summary>
/// Provides static factory methods for creating success and failure results, with or without associated data.
/// </summary>
/// <remarks>This class simplifies the creation of standardized result objects to represent operation outcomes. It
/// is typically used to encapsulate success or failure states, optionally including a message or data payload. All
/// methods are thread-safe and can be used in concurrent scenarios.</remarks>
public class ResultFactory
{
    /// <summary>
    /// Creates a new instance of the Result type that represents a successful operation.
    /// </summary>
    /// <returns>A Result instance indicating success.</returns>
    public static Result Success()
    {
        return new Result(true, string.Empty);
    }

    /// <summary>
    /// Creates a failed result with the specified error message.
    /// </summary>
    /// <param name="message">The error message that describes the reason for the failure. Cannot be null.</param>
    /// <returns>A result instance that represents a failure, containing the specified error message.</returns>
    public static Result Fail(string message)
    {
        return new Result(false, message);
    }

    /// <summary>
    /// Creates a successful result containing the specified data.
    /// </summary>
    /// <typeparam name="T">The type of the data to include in the result.</typeparam>
    /// <param name="data">The data to include in the successful result. Cannot be null if the result type does not allow null values.</param>
    /// <returns>A result object representing a successful operation, containing the provided data.</returns>
    public static Result<T> Success<T>(T data)
    {
        return new Result<T>(data, true, string.Empty);
    }

    /// <summary>
    /// Creates a failed result with the specified error message.
    /// </summary>
    /// <typeparam name="T">The type of the value that would be returned on success.</typeparam>
    /// <param name="message">The error message describing the reason for failure. Cannot be null.</param>
    /// <returns>A result object representing a failed operation, containing the specified error message.</returns>
    public static Result<T> Fail<T>(string message)
    {
        #pragma warning disable CS8604 // Possible null reference argument.
        return new Result<T>(default, false, message);
        #pragma warning restore CS8604 // Possible null reference argument.
    }
}
