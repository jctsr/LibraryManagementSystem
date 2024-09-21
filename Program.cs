using System.Runtime.InteropServices;

namespace LibraryManagementSystem
{
  internal static class Program
  {
    // Import the SetProcessDPIAware function from user32.dll to disable DPI scaling
    [DllImport("user32.dll")]
    private static extern bool SetProcessDPIAware();

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // Call this method to disable DPI scaling and make the app behave as if it's at 100% scale
      SetProcessDPIAware();
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new LoadingScreen());
    }
  }
}