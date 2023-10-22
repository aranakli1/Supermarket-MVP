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
    public partial class CategoriesView : Form, ICategoriesView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategoriesView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategoriesDetail);
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
                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                TxtCategoryName.Focus();
                TxtCategoryName.DeselectAll();
                tabPageCategoriesDetail.Text = "Add new Categories";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoriesList);
                tabControl1.TabPages.Add(tabPageCategoriesDetail);
                TxtCategoryName.Focus();
                TxtCategoryName.DeselectAll();
                tabPageCategoriesDetail.Text = "Edit Category";
            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful) // Si grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                    tabControl1.TabPages.Add(tabPageCategoriesList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoriesDetail);
                tabControl1.TabPages.Add(tabPageCategoriesList);
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
        public string CategoriesId
        {
            get { return TxtCategoryId.Text; }
            set { TxtCategoryId.Text = value; }
        }
        public string CategoriesName
        {
            get { return TxtCategoryName.Text; }
            set { TxtCategoryName.Text = value; }
        }
        public string CategoriesDescription
        {
            get { return TxtCategoryDescription.Text; }
            set { TxtCategoryDescription.Text = value; }
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

        public void SetCategoriesListBildingSource(BindingSource categoriesList)
        {
            DgCategories.DataSource = categoriesList;
        }
        private static CategoriesView instance;
        public static CategoriesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoriesView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
