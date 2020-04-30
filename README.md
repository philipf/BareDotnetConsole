# Bare .NET Console template

A quick .NET Core 3.1 template for a console app with DI configured.

## Quick setup
Copy and paste to get going quickly.

```bash
git clone --depth=1 --branch=master https://github.com/philipf/BareDotnetConsole.git ConsoleApp
rm -rf ./ConsoleApp/.git
cd ./ConsoleApp
dotnet build
code .
```

## Referenced libraries
Optional, install or run `dotnet restore`

```
 dotnet add package Microsoft.Extensions.DependencyInjection
 dotnet add package Microsoft.Extensions.Logging
 Microsoft.Extensions.Logging.Console
 ```