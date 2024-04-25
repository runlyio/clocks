# Runly.Time
An easily testable clock.

## Register an IClock
``` 
public void ConfigureServices(IServiceCollection services)
{
	// Use the system clock -- equivalent to using TimeProvider.System.GetUtcNow()
	services.AddSingleton<IClock, SystemClock>();

	// Or inject a test clock that can be manually manipulated in tests
	services.AddSingleton<IClock, TestClock>();
}
```

## Use IClock to get the time

```
public class MyClass
{
	private readonly IClock _clock;

	public DateTimeOffset CreatedAt { get; init; }
	public DateTimeOffset UpdatedAt { get; set; }

    public MyClass(IClock clock)
    {
		_clock = clock;

		CreatedAt = _clock.UtcNow;
		UpdatedAt = _clock.UtcNow;
	}

	public void SomeMethod()
	{
		UpdatedAt = _clock.UtcNow;
	}
}
```

## Make assertions about the time in tests

```
public class MyClassTests
{
	private readonly TestClock _clock;

	public MyClassTests(IClock clock)
	{
		// Replace the SystemClock with a TestClock for tests
		_clock = (TestClock)clock;
	}

	[Fact]
	public async Task SomeMethod_ShouldSetUpdatedAt()
	{
		var createdAt = _clock.UtcNow;

		var myClass = new MyClass(_clock);

		var updatedAt = _clock.AdvanceOneMinute();

		myClass.SomeMethod();

		// UpdatedAt should be one minute after CreatedAt
		Assert.Equal(createdAt, myClass.CreatedAt);
		Assert.Equal(updatedAt, myClass.UpdatedAt);
	}
}
```
