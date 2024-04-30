using LogbookLibrary;

namespace WF_WPF_13._Logbook_WF__MVP_
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
            IScheduleModel model = new FakeScheduleModel();
            var view = new Form1();
            var presenter = new SchedulePresnter(model, view);
            Application.Run(view);
        }
    }
}