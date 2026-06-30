using System;
using System.Linq;
using System.Windows.Forms;

namespace Dotnet45DesktopApp
{
    /// <summary>
    /// Application entry point.
    ///
    /// Normally launches the WinForms UI. When started with a "--selftest"
    /// (or "--ci") argument it runs a headless smoke test and exits without
    /// opening a window, which makes the app usable as a step in a CI/CD
    /// pipeline that has no interactive desktop session.
    /// </summary>
    internal static class Program
    {
        [STAThread]
        private static int Main(string[] args)
        {
            if (args.Any(a =>
                    a.Equals("--selftest", StringComparison.OrdinalIgnoreCase) ||
                    a.Equals("--ci", StringComparison.OrdinalIgnoreCase)))
            {
                return RunSelfTest();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            return 0;
        }

        /// <summary>
        /// Headless verification used by the build pipeline. Exercises the
        /// core logic without creating any UI and returns 0 on success.
        /// </summary>
        private static int RunSelfTest()
        {
            Console.WriteLine("Dotnet45DesktopApp self-test starting...");
            string message = AppInfo.GetGreeting();
            Console.WriteLine(message);

            if (string.IsNullOrEmpty(message))
            {
                Console.Error.WriteLine("Self-test FAILED: greeting was empty.");
                return 1;
            }

            Console.WriteLine("Self-test PASSED.");
            return 0;
        }
    }
}
