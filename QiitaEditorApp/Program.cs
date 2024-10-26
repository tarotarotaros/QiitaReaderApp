using QiitaEditorApp.Presenters;
using QiitaEditorApp.View;

namespace QiitaEditorApp
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
            
            var v = new StartView();
            var p = new StartPresenter(v);

            Application.Run(v);
        }
    }
}