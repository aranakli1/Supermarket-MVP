using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Views
{
    internal interface IProductsView
    {
        int ProductId { get; set; }
        string ProductName { get; set; }
        int ProductPrice { get; set; }
        int ProductStock { get; set; }
        int ProductCatId { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPayModelListBildingSource(BindingSource ProductsList);
        void Show();
    }
}
