namespace Supermarket_MVP.Views
{
    partial class CategoriesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textSearch = new TextBox();
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            tabPageCategoriesDetail = new TabPage();
            BtnSearch = new Button();
            DgCategories = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtCategoryId = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryDescription = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            tabPageCategoriesDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 39);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 0;
            label1.Text = "CATEGORIES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Categories;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "Search Category";
            // 
            // textSearch
            // 
            textSearch.Location = new Point(3, 26);
            textSearch.Name = "textSearch";
            textSearch.PlaceholderText = "Data to search";
            textSearch.Size = new Size(641, 27);
            textSearch.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 338);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(textSearch);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 29);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 305);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancel);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(TxtCategoryDescription);
            tabPageCategoriesDetail.Controls.Add(TxtCategoryName);
            tabPageCategoriesDetail.Controls.Add(TxtCategoryId);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 305);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = Properties.Resources.search_small;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(650, 22);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(40, 35);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(3, 59);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.RowTemplate.Height = 29;
            DgCategories.Size = new Size(687, 238);
            DgCategories.TabIndex = 4;
            // 
            // BtnClose
            // 
            BtnClose.AccessibleRole = AccessibleRole.None;
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(696, 236);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(88, 53);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.AccessibleRole = AccessibleRole.None;
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(696, 177);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(88, 53);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.AccessibleRole = AccessibleRole.None;
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(696, 118);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(88, 53);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.AccessibleRole = AccessibleRole.None;
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(696, 59);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(88, 53);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 0;
            label3.Text = "Category Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 66);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 1;
            label4.Text = "Category Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 130);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 2;
            label5.Text = "Category Description";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(6, 26);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.Size = new Size(125, 27);
            TxtCategoryId.TabIndex = 3;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(8, 89);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Category Name";
            TxtCategoryName.Size = new Size(228, 27);
            TxtCategoryName.TabIndex = 4;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(8, 153);
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.PlaceholderText = "Category Description";
            TxtCategoryDescription.Size = new Size(365, 27);
            TxtCategoryDescription.TabIndex = 5;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(249, 241);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(124, 56);
            BtnCancel.TabIndex = 9;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(8, 241);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(124, 56);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textSearch;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private DataGridView DgCategories;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtCategoryId;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtCategoryDescription;
        private TextBox TxtCategoryName;
        private Button BtnCancel;
        private Button BtnSave;
    }
}