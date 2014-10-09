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
[0]: https://github.com/damianh/LibLog
[1]: https://github.com/Topshelf/Topshelf
