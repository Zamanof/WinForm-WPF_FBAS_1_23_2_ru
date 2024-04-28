namespace WF_WPF_12._MVP_Sample
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var view = new Form1();
            var presnter = new Presenter(view);
            Application.Run(view);
        }
    }
}