
using System.Reflection;

namespace api_base.Settings
{
    public static class AssemblyExtensions
    {
        public static List<IGrouping<string?, Type>> GetRepositories(this Assembly assembly)
        {
            return assembly.GetAssemblies("Repository");
        }

        public static List<IGrouping<string?, Type>> GetServices(this Assembly assembly)
        {
            return assembly.GetAssemblies("Service");
        }

        private static List<IGrouping<string?, Type>> GetAssemblies(this Assembly assembly, string name)
        {
            return assembly.DefinedTypes
                    .Where(t => t.Name.EndsWith(name))
                    .Select(t => t.AsType())
                    .OrderByDescending(t => t.IsInterface)
                    .GroupBy(t => t.Namespace)
                    .ToList();
        }

        public static List<Type> GetHandlers(this Assembly assembly)
        {
            return assembly.DefinedTypes
                    .Where(t => t.Name.EndsWith("Handler"))
                    .Select(t => t.AsType())
                    .ToList();
        }
    }
}