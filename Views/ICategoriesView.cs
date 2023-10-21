using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_MVP.Views
{
    internal interface ICategoriesView
    {
        string CategoriesId { get; set; }
        string CategoriesName { get; set; }
        string CategoriesObservations { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        event EventHandler SearchEvent;
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        void SatCategoriesListBildingSource(BindingSource categoriesList);
        void Show();
    }
}
