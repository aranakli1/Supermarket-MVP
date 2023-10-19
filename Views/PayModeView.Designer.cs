namespace Supermarket_MVP.Views
{
    partial class PayModeView
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
            tabPage1 = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            label4 = new Label();
            TxtPayModeName = new TextBox();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPage2.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(140, 43);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 0;
            label1.Text = "PAY MODE";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 344);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BtnClose);
            tabPage1.Controls.Add(BtnDelete);
            tabPage1.Controls.Add(BtnEdit);
            tabPage1.Controls.Add(BtnNew);
            tabPage1.Controls.Add(DgPayMode);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(TxtSearch);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 302);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pay Mode List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(696, 236);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(88, 53);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(696, 177);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(88, 53);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(696, 118);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(88, 53);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(696, 59);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(88, 53);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(8, 59);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.RowTemplate.Height = 29;
            DgPayMode.Size = new Size(682, 235);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(652, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 42);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 26);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(638, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 3);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(BtnCancel);
            tabPage2.Controls.Add(BtnSave);
            tabPage2.Controls.Add(TxtPayModeObservation);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(TxtPayModeName);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TxtPayModeId);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pay Mode Detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 3);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(8, 26);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(215, 27);
            TxtPayModeId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 65);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(8, 88);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(365, 27);
            TxtPayModeName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 127);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(8, 150);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(365, 85);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(8, 241);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(124, 56);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(249, 241);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(124, 56);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 469);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Label label4;
        private TextBox TxtPayModeId;
        private Label label3;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Button BtnCancel;
        private Button BtnSave;
    }
}