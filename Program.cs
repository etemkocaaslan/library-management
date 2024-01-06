namespace LibraryManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeApplication();
            RunApplication();
        }

        /// <summary>
        /// Initializes application configurations.
        /// </summary>
        private static void InitializeApplication()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Additional initialization can go here
        }

        /// <summary>
        /// Runs the application.
        /// </summary>
        private static void RunApplication()
        {
            Application.Run(new Login());
        }
    }
}
