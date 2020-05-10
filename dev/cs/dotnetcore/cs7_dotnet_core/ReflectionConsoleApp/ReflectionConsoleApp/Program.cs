using System;
using System.Linq;
using System.Reflection;

namespace ReflectionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Xml.XmlReader reader;
            System.Xml.Linq.XElement element;
            System.Net.Http.HttpClient client;
            
            // loop through the assemblies that this Console App references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                // load the assembly to read its details
                var a = Assembly.Load(new AssemblyName(r.Name));

                int methodCount = 0;

                // loop through all types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }

                Console.WriteLine($"{a.DefinedTypes.Count():N0} types " +
                    $"with {methodCount:N0} methods in {r.Name} assembly.");
            }

            Console.ReadKey();
        }
    }
}
