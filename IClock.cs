namespace Runly.Time;

/// <summary>
/// A clock that tells time.
/// </summary>
public interface IClock
{
    /// <summary>
    /// Gets the current time.
    /// </summary>
    DateTimeOffset UtcNow { get; }
}
