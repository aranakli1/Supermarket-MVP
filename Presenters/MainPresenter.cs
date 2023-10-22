using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_MVP.Models;
using Supermarket_MVP.Views;
using Supermarket_MVP._Repositories;

namespace Supermarket_MVP.Presenters
{
    internal class MainPresenter
    {
        public readonly IMainView mainView;
        public readonly string sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCategoriesView += ShowCategoriesView;
        }
        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
        private void ShowCategoriesView(object? sender, EventArgs e)
        {
            ICategoriesView view = CategoriesView.GetInstance((MainView)mainView);
            ICategoriesRepository repository = new CategoriesRepository(sqlConnectionString);
            new CategoriesPresenter(view, repository);
        }
    }
}
