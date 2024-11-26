namespace MHWSpeedrunTool
{
    internal static class Program
    {
        public static Form formWindow;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Constants.LoadConstantsFromJson();
            formWindow = new Form1();
            Application.Run(formWindow);
        }
    }
}