using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_MVP.Views;
using Supermarket_MVP.Models;

namespace Supermarket_MVP.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;
        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSelectedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);
            loadAllProvidersList();
            this.view.Show();
        }
        private void loadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }
        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }
        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            var providers = (ProvidersModel)providersBindingSource.Current;
            view.ProviderId = providers.ProviderId.ToString();
            view.ProviderDocNum = providers.ProviderDocNum;
            view.ProviderName = providers.ProviderName;
            view.ProviderAddress = providers.ProviderAddress;
            view.ProviderPhoneNum = providers.ProviderPhoneNum;
            view.ProvidereMail = providers.ProvidereMail;
            view.IsEdit = true;
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            var providers = new ProvidersModel();
            providers.ProviderId = Convert.ToInt32(view.ProviderId);
            providers.ProviderDocNum = view.ProviderDocNum;
            providers.ProviderName = view.ProviderName;
            providers.ProviderAddress = view.ProviderAddress;
            providers.ProviderPhoneNum = view.ProviderPhoneNum;
            providers.ProvidereMail = view.ProvidereMail;
            try
            {
                new Common.ModelDataValidation().Validate(providers);
                if (view.IsEdit)
                {
                    repository.Edit(providers);
                    view.Message = "Info. Provider edited successfully";
                }
                else
                {
                    repository.Add(providers);
                    view.Message = "Info. Provider added successfully";
                }
                view.IsSuccessful = true;
                loadAllProvidersList();
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
            view.ProviderId = "0";
            view.ProviderDocNum = "";
            view.ProviderName = "";
            view.ProviderAddress = "";
            view.ProviderPhoneNum = "";
            view.ProvidereMail = "";
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleteSelectedProviders(object? sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada del dataviewgrid
                var providers = (ProvidersModel)providersBindingSource.Current;
                // se invoca el metodo Delete del repositorio pasandole el ID del Pay MOde
                repository.Delete(providers.ProviderId);
                view.IsSuccessful = true;
                view.Message = "Info. Provider deleted successfully";
                loadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error. An Error ocurred, could no delete provider";
            }
        }
    }
}
