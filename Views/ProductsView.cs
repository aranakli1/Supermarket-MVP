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
    public partial class ProductsView : Form, IProductsView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductsDetail);
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
                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                TxtProductName.Focus();
                TxtProductName.DeselectAll();
                tabPageProductsDetail.Text = "Add new Product";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductsList);
                tabControl1.TabPages.Add(tabPageProductsDetail);
                TxtProductName.Focus();
                TxtProductName.DeselectAll();
                tabPageProductsDetail.Text = "Edit new Products";
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful) // Si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageProductsDetail);
                    tabControl1.TabPages.Add(tabPageProductsList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductsDetail);
                tabControl1.TabPages.Add(tabPageProductsList);
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
        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductPrice
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value; }
        }
        public string ProductStock
        {
            get { return TxtProductStock.Text; }
            set { TxtProductStock.Text = value; }
        }
        public string ProductCatId
        {
            get { return TxtProductCatId.Text; }
            set { TxtProductCatId.Text = value; }
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
        public void SetProductsListBildingSource(BindingSource productsList)
        {
            DgProducts.DataSource = productsList;
        }
        private static ProductsView instance;
        public static ProductsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductsView();
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

        public void SetPayModelListBildingSource(BindingSource ProductsList)
        {
            throw new NotImplementedException();
        }
    }
}
