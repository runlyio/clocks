namespace Runly.Time;

/// <summary>
/// A clock that provides the current system time.
/// </summary>
public class SystemClock : IClock
{
    /// <summary>
    /// Gets the current time.
    /// </summary>
    public DateTimeOffset UtcNow => TimeProvider.System.GetUtcNow();
}
