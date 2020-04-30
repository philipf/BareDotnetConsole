# Bare .NET Console template

A quick .NET Core 3.1 template for a console app with DI configured.

![.NET Core](https://github.com/philipf/BareDotnetConsole/workflows/.NET%20Core/badge.svg)

## Quick setup
Copy and paste to get going quickly.

```bash
git clone --depth=1 --branch=master https://github.com/philipf/BareDotnetConsole.git ConsoleApp
rm -rf ./ConsoleApp/.git
cd ./ConsoleApp
dotnet build
code .
```

## Prerequisites
- Git
- .NET Core 3.1 SDK
- VS Code

## Referenced libraries
Optional, install or run `dotnet restore`

```
 dotnet add package Microsoft.Extensions.DependencyInjection
 dotnet add package Microsoft.Extensions.Logging
 Microsoft.Extensions.Logging.Console
 ```