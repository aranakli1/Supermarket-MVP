using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_MVP.Views;
using Supermarket_MVP.Models;

namespace Supermarket_MVP.Presenters
{
    internal class CategoriesPresenter
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;
        public CategoriesPresenter(ICategoriesView view, ICategoriesRepository repository)
        {
            this.categoriesBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategories;
            this.view.AddNewEvent += AddNewCategories;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);
            loadAllCategoriesList();
            this.view.Show();
        }
        private void SearchCategories(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }
        private void loadAllCategoriesList()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }
        private void SaveCategories(object? sender, EventArgs e)
        {
            var categories = new CategoriesModel();
            categories.CatId = Convert.ToInt32(view.CategoriesId);
            categories.CatName = view.CategoriesName;
            categories.CatDescription = view.CategoriesDescription;
            try
            {
                new Common.ModelDataValidation().Validate(categories);
                if (view.IsEdit)
                {
                    repository.Edit(categories);
                    view.Message = "Info. Categories edited successfully";
                }
                else
                {
                    repository.Add(categories);
                    view.Message = "Info. Categories added successfully";
                }
                view.IsSuccessful = true;
                loadAllCategoriesList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void AddNewCategories(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            var categories = (CategoriesModel)categoriesBindingSource.Current;
            view.CategoriesId = categories.CatId.ToString();
            view.CategoriesName = categories.CatName;
            view.CategoriesDescription = categories.CatDescription;
            view.IsEdit = true;
        }
        private void CleanViewFields()
        {
            view.CategoriesId = "0";
            view.CategoriesName = "";
            view.CategoriesDescription = "";
        }
        private void CancelAction()
        {
            CleanViewFields();
        }
        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada del dataviewgrid
                var categories = (CategoriesModel)categoriesBindingSource.Current;
                // se invoca el metodo Delete del repositorio pasandole el ID del Pay MOde
                repository.Delete(categories.CatId);
                view.IsSuccessful = true;
                view.Message = "Info. Category deleted successfully";
                loadAllCategoriesList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error. An Error ocurred, could no delete category";
            }
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
