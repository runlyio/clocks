namespace Runly.Time;

public static class UnixDateTime
{
    /// <summary>
    /// Converts unix time into a <see cref="DateTimeOffset"/>.
    /// </summary>
    /// <param name="unixtime">A unix time value.</param>
    /// <returns>A <see cref="DateTimeOffset"/> representation of <paramref name="unixtime"/>.</returns>
    public static DateTimeOffset Parse(string unixtime) => Parse(long.Parse(unixtime));

    /// <summary>
    /// Converts unix time into a <see cref="DateTimeOffset"/>.
    /// </summary>
    /// <param name="unixtime">A unix time value.</param>
    /// <returns>A <see cref="DateTimeOffset"/> representation of <paramref name="unixtime"/>.</returns>
    public static DateTimeOffset Parse(long unixtime) =>
        new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero).AddSeconds(unixtime).ToUniversalTime();
}