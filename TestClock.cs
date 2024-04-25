namespace Runly.Time;

/// <summary>
/// A clock that does not advance on its own.
/// </summary>
public class TestClock : IClock
{
    /// <summary>
    /// Gets the current time.
    /// </summary>
    public DateTimeOffset UtcNow { get; private set; }

    /// <summary>
    /// Initializes a new <see cref="TestClock"/> set at the current system time.
    /// </summary>
    public TestClock() => SetTime(TimeProvider.System.GetUtcNow());

    /// <summary>
    /// Initializes a new <see cref="TestClock"/> set at the <paramref name="time"/> specified.
    /// </summary>
    /// <param name="time"></param>
    public TestClock(DateTimeOffset time) => SetTime(time);

    /// <summary>
    /// Sets the clock by the <paramref name="time"/> specified.
    /// </summary>
    /// <returns>The time after setting the clock.</returns>
    public DateTimeOffset SetTime(DateTimeOffset time)
    {
        UtcNow = time.ToUniversalTime();
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock by the <paramref name="timeSpan"/> specified.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceTime(TimeSpan timeSpan)
    {
        UtcNow = UtcNow.Add(timeSpan);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock by the number of <paramref name="seconds"/> specified.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceSeconds(double seconds)
    {
        UtcNow = UtcNow.AddSeconds(seconds);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock by the number of <paramref name="minutes"/> specified.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceMinutes(double minutes)
    {
        UtcNow = UtcNow.AddMinutes(minutes);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock by the number of <paramref name="hours"/> specified.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceHours(double hours)
    {
        UtcNow = UtcNow.AddHours(hours);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock by the number of <paramref name="days"/> specified.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceDays(double days)
    {
        UtcNow = UtcNow.AddDays(days);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock one second.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceOneSecond()
    {
        UtcNow = UtcNow.AddSeconds(1);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock one minute.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceOneMinute()
    {
        UtcNow = UtcNow.AddMinutes(1);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock one hour.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceOneHour()
    {
        UtcNow = UtcNow.AddHours(1);
        return UtcNow;
    }

    /// <summary>
    /// Advances the clock one day.
    /// </summary>
    /// <returns>The time after advancing the clock.</returns>
    public DateTimeOffset AdvanceOneDay()
    {
        UtcNow = UtcNow.AddDays(1);
        return UtcNow;
    }
}
