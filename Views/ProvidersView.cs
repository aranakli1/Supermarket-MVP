using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_MVP.Views
{
    public partial class ProvidersView : Form, IProvidersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProvidersDetail);
            BtnClose.Click += delegate { this.Close(); };
        }
        private void AssociateAndRaiseViewEvents()
        {
            // Boton Buscar, llamado a SearchEvent cuando hay click en BtnSearch
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Boton Nuevo, llamado a AddNewEvent cuando hay click en BtnNew
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                TxtProviderDocNum.Focus();
                TxtProviderDocNum.DeselectAll();
                tabPageProvidersDetail.Text = "Add new pay mode";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                TxtProviderDocNum.Focus();
                TxtProviderDocNum.DeselectAll();
                tabPageProvidersDetail.Text = "Edit new Providers";
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful) // Si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageProvidersDetail);
                    tabControl1.TabPages.Add(tabPageProvidersList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProvidersDetail);
                tabControl1.TabPages.Add(tabPageProvidersList);
            };
            BtnDelete.Click += delegate
            {
                var Result = MessageBox.Show(
                    "Info. Are you sure you want to delete the selected Pay Mode",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }
        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public string ProviderId
        {
            get { return TxtProviderId.Text; }
            set { TxtProviderId.Text = value; }
        }
        public string ProviderDocNum
        {
            get { return TxtProviderDocNum.Text; }
            set { TxtProviderDocNum.Text = value; }
        }
        public string ProviderName
        {
            get { return TxtProviderName.Text; }
            set { TxtProviderName.Text = value; }
        }
        public string ProviderAddress
        {
            get { return TxtProviderAddress.Text; }
            set { TxtProviderAddress.Text = value; }
        }
        public string ProviderPhoneNum
        {
            get { return TxtProviderPhoneNum.Text; }
            set { TxtProviderPhoneNum.Text = value; }
        }
        public string ProvidereMail
        {
            get { return TxtProvidereMail.Text; }
            set { TxtProvidereMail.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public void SetProvidersListBildingSource(BindingSource providersList)
        {
            DgProviders.DataSource = providersList;
        }
        private static ProvidersView instance;
        public static ProvidersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProvidersView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Maximized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}
