﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Views
{
    internal interface IProductsView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductPrice { get; set; }
        string ProductStock { get; set; }
        string ProductCatId { get; set; }

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

        void SetProductsListBildingSource(BindingSource productsList);
        void Show();
    }
}
