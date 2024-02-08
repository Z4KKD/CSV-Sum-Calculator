namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize application configuration
            ApplicationConfiguration.Initialize();
            // Run the main form of the application
            Application.Run(new Form1());
        }
    }
}