using System;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnitLite;

namespace nunit.runner
{
	public class Program
	{
		static int Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("Usage:");
				Console.WriteLine("   nunit.runner <testassembly> <options>");
				return 0;
			}

			var fileInfo = new FileInfo(args[0]);
			if(!fileInfo.Exists) throw new ArgumentException($"Invalid parameter for test assembly: {args[0]}. Make sure that first parameter is valid test assembly name and it exists.");

			var assembly = Assembly.LoadFile(fileInfo.FullName);
			return new AutoRun(assembly).Execute(args.Skip(1).ToArray());
		}
	}
}
