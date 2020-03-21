using System;

namespace dotnetcore
{
	    // INFO:
			// Read more about .NET Core CLI Tools telemetry: https://aka.ms/dotnet-cli-telemetry
			// Explore documentation: https://aka.ms/dotnet-docs
			// Report issues and find source on GitHub: https://github.com/dotnet/core
			// Find out what's new: https://aka.ms/dotnet-whats-new
			// Learn about the installed HTTPS developer cert: https://aka.ms/aspnet-core-https
			// Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli-docs
			// Write your first app: https://aka.ms/first-net-core-app
	
		// COMPILATION
			// Roslyn converts code into IL, and stored in assembly (EXE or DLL)
			// At runtime, the CoreCLR peforms JIT compiation into native CPU instructions
			// key benefit of this 2 step compilation process, is that there's 
			// CLRs for Windows, Linux and macOS => achieves platform indepedence
			// Summary 
			// 	Roslyn converts code to IL (this is what's stored in assemblies)
			// 	CoreCLR performs JITs based on platform
			// NOTE: 
			//	IL is not created with .NET native; which uses AoT (ahead-of-time) compilation,
			// 	which sacrifice portability for performance
			// 	AoT used in: UWP, ASP.NET Core and Console apps
	
		// STEPS:
			// dotnet --version (3.1.101)
			// dotnet new console
			// dotnet restore (downloads depdendecies for the project)
			// dotnet run
		
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello .NET Core 3.1");
        }
    }
}
