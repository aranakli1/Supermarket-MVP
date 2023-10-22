namespace Supermarket_MVP.Views
{
    partial class ProductsView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductsList = new TabPage();
            DgProducts = new DataGridView();
            BtnSearch = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProductsDetail = new TabPage();
            TxtProductCatId = new TextBox();
            label7 = new Label();
            TxtProductStock = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductsDetail.SuspendLayout();
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.products;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 119);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 39);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductsList);
            tabControl1.Controls.Add(tabPageProductsDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductsList
            // 
            tabPageProductsList.Controls.Add(DgProducts);
            tabPageProductsList.Controls.Add(BtnSearch);
            tabPageProductsList.Controls.Add(BtnClose);
            tabPageProductsList.Controls.Add(BtnDelete);
            tabPageProductsList.Controls.Add(BtnEdit);
            tabPageProductsList.Controls.Add(BtnNew);
            tabPageProductsList.Controls.Add(TxtSearch);
            tabPageProductsList.Controls.Add(label2);
            tabPageProductsList.Location = new Point(4, 29);
            tabPageProductsList.Name = "tabPageProductsList";
            tabPageProductsList.Padding = new Padding(3);
            tabPageProductsList.Size = new Size(792, 292);
            tabPageProductsList.TabIndex = 0;
            tabPageProductsList.Text = "Products List";
            tabPageProductsList.UseVisualStyleBackColor = true;
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(6, 59);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.RowHeadersWidth = 51;
            DgProducts.RowTemplate.Height = 29;
            DgProducts.Size = new Size(686, 227);
            DgProducts.TabIndex = 13;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(654, 11);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 42);
            BtnSearch.TabIndex = 12;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.AccessibleRole = AccessibleRole.None;
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(698, 233);
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
            BtnDelete.Location = new Point(698, 174);
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
            BtnEdit.Location = new Point(698, 115);
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
            BtnNew.Location = new Point(698, 56);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(88, 53);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(6, 26);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(642, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Products";
            // 
            // tabPageProductsDetail
            // 
            tabPageProductsDetail.Controls.Add(TxtProductCatId);
            tabPageProductsDetail.Controls.Add(label7);
            tabPageProductsDetail.Controls.Add(TxtProductStock);
            tabPageProductsDetail.Controls.Add(TxtProductPrice);
            tabPageProductsDetail.Controls.Add(TxtProductName);
            tabPageProductsDetail.Controls.Add(TxtProductId);
            tabPageProductsDetail.Controls.Add(BtnCancel);
            tabPageProductsDetail.Controls.Add(BtnSave);
            tabPageProductsDetail.Controls.Add(label6);
            tabPageProductsDetail.Controls.Add(label5);
            tabPageProductsDetail.Controls.Add(label4);
            tabPageProductsDetail.Controls.Add(label3);
            tabPageProductsDetail.Location = new Point(4, 29);
            tabPageProductsDetail.Name = "tabPageProductsDetail";
            tabPageProductsDetail.Padding = new Padding(3);
            tabPageProductsDetail.Size = new Size(792, 292);
            tabPageProductsDetail.TabIndex = 1;
            tabPageProductsDetail.Text = "Product Detail";
            tabPageProductsDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductCatId
            // 
            TxtProductCatId.Location = new Point(6, 132);
            TxtProductCatId.Name = "TxtProductCatId";
            TxtProductCatId.Size = new Size(125, 27);
            TxtProductCatId.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(8, 109);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 14;
            label7.Text = "Product Category Id";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(573, 79);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(172, 27);
            TxtProductStock.TabIndex = 13;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(573, 26);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(172, 27);
            TxtProductPrice.TabIndex = 12;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(8, 79);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(460, 27);
            TxtProductName.TabIndex = 11;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(5, 26);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(125, 27);
            TxtProductId.TabIndex = 10;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(247, 230);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(124, 56);
            BtnCancel.TabIndex = 9;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(6, 230);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(124, 56);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(573, 56);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 4;
            label6.Text = "Product Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(571, 3);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 3;
            label5.Text = "Product Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 2;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 1;
            label3.Text = "Product Id";
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductsView";
            Text = "Products Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductsList.ResumeLayout(false);
            tabPageProductsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductsDetail.ResumeLayout(false);
            tabPageProductsDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageProductsList;
        private TabPage tabPageProductsDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private DataGridView DgProducts;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private TextBox TxtProductCatId;
        private Label label7;
        private TextBox TxtProductStock;
        private TextBox TxtProductPrice;
    }
}