namespace Supermarket_MVP.Views
{
    partial class ProvidersView
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
            tabPageProvidersList = new TabPage();
            DgProviders = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnSearch = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            tabPageProvidersDetail = new TabPage();
            TxtProvidereMail = new TextBox();
            label8 = new Label();
            TxtProviderPhoneNum = new TextBox();
            label7 = new Label();
            TxtProviderAddress = new TextBox();
            label6 = new Label();
            TxtProviderName = new TextBox();
            label5 = new Label();
            TxtProviderDocNum = new TextBox();
            label4 = new Label();
            TxtProviderId = new TextBox();
            label3 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
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
            pictureBox1.BackgroundImage = Properties.Resources.providers;
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
            label1.Location = new Point(134, 43);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 0;
            label1.Text = "PROVIDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 325);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(TxtSearch);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Location = new Point(4, 29);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 292);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(6, 59);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.RowTemplate.Height = 29;
            DgProviders.Size = new Size(686, 225);
            DgProviders.TabIndex = 15;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(6, 26);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(642, 27);
            TxtSearch.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 13;
            label2.Text = "Search Providers";
            // 
            // BtnSearch
            // 
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
            BtnClose.Location = new Point(698, 235);
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
            BtnDelete.Location = new Point(698, 176);
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
            BtnEdit.Location = new Point(698, 117);
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
            BtnNew.Location = new Point(698, 58);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(88, 53);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(TxtProvidereMail);
            tabPageProvidersDetail.Controls.Add(label8);
            tabPageProvidersDetail.Controls.Add(TxtProviderPhoneNum);
            tabPageProvidersDetail.Controls.Add(label7);
            tabPageProvidersDetail.Controls.Add(TxtProviderAddress);
            tabPageProvidersDetail.Controls.Add(label6);
            tabPageProvidersDetail.Controls.Add(TxtProviderName);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(TxtProviderDocNum);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(TxtProviderId);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Location = new Point(4, 29);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 292);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Provider Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProvidereMail
            // 
            TxtProvidereMail.Location = new Point(6, 185);
            TxtProvidereMail.Name = "TxtProvidereMail";
            TxtProvidereMail.Size = new Size(436, 27);
            TxtProvidereMail.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(8, 162);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 20;
            label8.Text = "Provider eMail";
            // 
            // TxtProviderPhoneNum
            // 
            TxtProviderPhoneNum.Location = new Point(454, 79);
            TxtProviderPhoneNum.Name = "TxtProviderPhoneNum";
            TxtProviderPhoneNum.Size = new Size(174, 27);
            TxtProviderPhoneNum.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 56);
            label7.Name = "label7";
            label7.Size = new Size(178, 20);
            label7.TabIndex = 18;
            label7.Text = "Provider Phone Number";
            // 
            // TxtProviderAddress
            // 
            TxtProviderAddress.Location = new Point(8, 132);
            TxtProviderAddress.Name = "TxtProviderAddress";
            TxtProviderAddress.Size = new Size(436, 27);
            TxtProviderAddress.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 109);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 16;
            label6.Text = "Provider Address";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(6, 79);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.Size = new Size(436, 27);
            TxtProviderName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 56);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 14;
            label5.Text = "Provider Name";
            // 
            // TxtProviderDocNum
            // 
            TxtProviderDocNum.Location = new Point(454, 26);
            TxtProviderDocNum.Name = "TxtProviderDocNum";
            TxtProviderDocNum.Size = new Size(205, 27);
            TxtProviderDocNum.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(452, 3);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 12;
            label4.Text = "Provider Document Number";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(8, 26);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.Size = new Size(178, 27);
            TxtProviderId.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 3);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 10;
            label3.Text = "Provider Id";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(244, 230);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(124, 56);
            BtnCancel.TabIndex = 9;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(3, 230);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(124, 56);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "Providers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgProviders;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProviderAddress;
        private Label label6;
        private TextBox TxtProviderName;
        private Label label5;
        private TextBox TxtProviderDocNum;
        private Label label4;
        private TextBox TxtProviderId;
        private Label label3;
        private TextBox TxtProviderPhoneNum;
        private Label label7;
        private TextBox TxtProvidereMail;
        private Label label8;
    }
}