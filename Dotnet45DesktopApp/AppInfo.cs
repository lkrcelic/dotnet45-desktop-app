using System;
using System.Reflection;

namespace Dotnet45DesktopApp
{
    /// <summary>
    /// Small piece of shared, UI-independent logic. Kept separate from the
    /// form so it can be reused by the headless self-test (and any future
    /// unit tests) without depending on System.Windows.Forms.
    /// </summary>
    public static class AppInfo
    {
        public static string Name
        {
            get { return "Dotnet45DesktopApp"; }
        }

        public static string Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public static string GetGreeting()
        {
            return string.Format(
                "Hello from {0} v{1} (.NET Framework 4.5) - built on {2:yyyy-MM-dd}",
                Name,
                Version,
                DateTime.Now);
        }
    }
}
