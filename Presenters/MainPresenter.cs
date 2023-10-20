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
        }
        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
}
