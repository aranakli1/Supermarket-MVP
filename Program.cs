using Microsoft.Data.SqlClient;
using Supermarket_MVP.Properties;
using Supermarket_MVP._Repositories;
using Supermarket_MVP.Models;
using Supermarket_MVP.Views;
using Supermarket_MVP.Presenters;

namespace Supermarket_MVP
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
            string sqlConnectionString = Settings.Default.SqlConnection; 
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
            Application.Run(new PayModeView());
        }
    }
}