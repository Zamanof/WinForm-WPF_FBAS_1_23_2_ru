using WF_WPF_13._MVP_Example__multi_window_.Models;
using WF_WPF_13._MVP_Example__multi_window_.Presenters;
using WF_WPF_13._MVP_Example__multi_window_.Services;

namespace WF_WPF_13._MVP_Example__multi_window_
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
            var scheduleView = new MainForm();
            var scheduleModel = new FakeScheduleModel();
            var schedulePresenter = new SchedulePresenter(scheduleModel, scheduleView);

            ServiceLocator.Instance.Add(() =>
            {
                return schedulePresenter;
            });

            ServiceLocator.Instance.Add(() =>
            {
                var addView = new AddForm();
                var addPresenter = new AddPresenter(scheduleModel, addView);
                return addPresenter;
            });

            Application.Run(scheduleView);
        }
    }
}