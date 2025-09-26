# learning C# for my job

## IMPORTANT STUFF

Check version
- dotnet --version

Set up project folder
- dotnet new console -n folder_name

Run C# folder
- dotnet run

## Basic format (barebone)

```csharp
using System;

namespace Proj{
    class MyClass{
        public void Main(string[] args){
            Console.WriteLine("Hello World!");
        }
    }
}
```