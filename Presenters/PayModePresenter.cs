using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_MVP.Views;
using Supermarket_MVP.Models;

namespace Supermarket_MVP.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;
    }
    public PayModePresenter(IPayModeView view, IPayModeRepository repository)
    {
        this.payModeBindingSource = new BindingSource();

        this.view = view;
        this.repository = repository;

        this.view.SearchEvent += SearchPayMode;
        this.view.AddNewEvent += AddNewPayMode;
        this.view.EditEvent += LoadSelectPayModeToEdit;
        this.view.DeleteEvent += DeleteSelectedPayMode;
        this.view.SaveEvent += SavePayMode;
        this.view.CancelEvent += CancelAction;
    }
}
