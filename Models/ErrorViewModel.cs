namespace general_purpose_poc.Models;

/// <summary>
/// View model for errors
/// </summary>
public class ErrorViewModel
{
    /// <summary>
    /// String that represents the Request ID.
    /// </summary>
    /// <value></value>
    public string? RequestId { get; set; }

    /// <summary>
    /// Boolean value that represents whether the UI should show this or not. 
    /// </summary>
    /// <returns></returns>
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
