Topshelf.LibLog
===============

This integration library adds support for [LibLog][0] to [Topshelf][1]. LibLog enables dependency free logging. It contains transparent builtin support for NLog, Log4Net, EntLib Logging and SeriLog or allows the user to define a custom provider. Works with .NET 4 and higher.

### Usage
To hookup LibLog to Topshelf, just one line of code is needed when configuring Topshelf
```csharp
HostFactory.New(x =>
{
    x.UseLibLog();
});
```
LibLog will automatically scan for the following frameworks, NLog, Log4Net, EntLib Logging and SeriLog. If it cannot find any of these frameworks, logging is automatically disabled. 

### Custom logging
If you want to implement custom logging, you need to create a custom log provider and set it before the Topshelf Host is configured.

```csharp
Topshelf.LibLog.Logging.LogProvider.SetCurrentLogProvider(new CustomLogProvider());
```
```csharp
public class CustomLogProvider : Topshelf.LibLog.Logging.ILogProvider
{
	public Topshelf.LibLog.Logging.ILog GetLogger(string name)
	{
		return new CustomLogger(name);
	}
}
```
The customlogger should implement Topshelf.LibLog.Logging.ILog

```csharp
public class CustomLogger : Topshelf.LibLog.Logging.ILog
{
	public CustomLogger(string name)
	{
		....
	}
	
	public bool Log(Topshelf.LibLog.Logging.LogLevel logLevel, Func<string> messageFunc)
	{
		if (messageFunc != null)
		{
			// Call to your own custom methods
			Log(messageFunc());
		}
		return true;
	}

	public void Log<TException>(Topshelf.LibLog.Logging.LogLevel logLevel, Func<string> messageFunc, TException exception) where TException : Exception
	{
		// Call to your own custom methods
		Log(messageFunc(), exception);
	}
}
```
[0]: https://github.com/damianh/LibLog
[1]: https://github.com/Topshelf/Topshelf
