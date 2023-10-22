using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_MVP.Views;
using Supermarket_MVP.Models;

namespace Supermarket_MVP.Presenters
{
    internal class ProductsPresenter
    {
        private IProductsView view;
        private IProductsRepository repository;
        private BindingSource productsBindingSource;
        private IEnumerable<ProductsModel> productsList;
        public ProductsPresenter(IProductsView view, IProductsRepository repository)
        {
            this.productsBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProducts;
            this.view.AddNewEvent += AddNewProducts;
            this.view.EditEvent += LoadSelectProductsToEdit;
            this.view.DeleteEvent += DeleteSelectedProducts;
            this.view.SaveEvent += SaveProducts;
            this.view.CancelEvent += CancelAction;

            this.view.SetProductsListBildingSource(productsBindingSource);
            loadAllProductsList();
            this.view.Show();
        }
        private void loadAllProductsList()
        {
            productsList = repository.GetAll();
            productsBindingSource.DataSource = productsList;
        }
        private void SearchProducts(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productsList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productsList = repository.GetAll();
            }
            productsBindingSource.DataSource = productsList;
        }
        private void AddNewProducts(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectProductsToEdit(object? sender, EventArgs e)
        {
            var products = (ProductsModel)productsBindingSource.Current;
            view.ProductId = products.ProductId.ToString();
            view.ProductName = products.ProductName;
            view.ProductPrice = products.ProductPrice.ToString();
            view.ProductStock = products.ProductStock.ToString();
            view.ProductCatId = products.ProductCatId.ToString();
            view.IsEdit = true;
        }

        private void SaveProducts(object? sender, EventArgs e)
        {
            var products = new ProductsModel();
            products.ProductId = Convert.ToInt32(view.ProductId);
            products.ProductName = view.ProductName;
            products.ProductPrice = Convert.ToInt32(view.ProductPrice);
            products.ProductStock = Convert.ToInt32(view.ProductStock);
            products.ProductCatId = Convert.ToInt32(view.ProductCatId);
            try
            {
                new Common.ModelDataValidation().Validate(products);
                if (view.IsEdit)
                {
                    repository.Edit(products);
                    view.Message = "Info. Product edited successfully";
                }
                else
                {
                    repository.Add(products);
                    view.Message = "Info. Product added successfully";
                }
                view.IsSuccessful = true;
                loadAllProductsList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductName = "";
            view.ProductPrice = "";
            view.ProductStock = "";
            view.ProductCatId = "";
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedProducts(object? sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada del dataviewgrid
                var products = (ProductsModel)productsBindingSource.Current;
                // se invoca el metodo Delete del repositorio pasandole el ID del Pay MOde
                repository.Delete(products.ProductId);
                view.IsSuccessful = true;
                view.Message = "Info. Product deleted successfully";
                loadAllProductsList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error. An Error ocurred, could no delete products";
            }
        }
    }
}
