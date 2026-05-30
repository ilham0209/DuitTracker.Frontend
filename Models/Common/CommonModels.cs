namespace DuitTracker.Frontend.Models.Common;

public class ApiErrorResponse
{
    public string? Error { get; set; }
    public List<ValidationError> Errors { get; set; } = new();
}

public class ValidationError
{
    public string PropertyName { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;
}