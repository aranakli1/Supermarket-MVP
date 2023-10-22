namespace Supermarket_MVP.Views
{
    partial class MainView
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
            BtnCategories = new PictureBox();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnProducts = new PictureBox();
            BtnProviders = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnProviders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnProviders);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnCategories);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 450);
            panel1.TabIndex = 0;
            // 
            // BtnCategories
            // 
            BtnCategories.BackgroundImage = Properties.Resources.Categories;
            BtnCategories.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategories.Location = new Point(3, 139);
            BtnCategories.Name = "BtnCategories";
            BtnCategories.Size = new Size(125, 62);
            BtnCategories.TabIndex = 2;
            BtnCategories.TabStop = false;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.exit512;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 388);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(143, 62);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(3, 71);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(125, 62);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.products;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(3, 207);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(125, 62);
            BtnProducts.TabIndex = 2;
            BtnProducts.TabStop = false;
            // 
            // BtnProviders
            // 
            BtnProviders.BackgroundImage = Properties.Resources.providers;
            BtnProviders.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProviders.Location = new Point(3, 275);
            BtnProviders.Name = "BtnProviders";
            BtnProviders.Size = new Size(125, 62);
            BtnProviders.TabIndex = 2;
            BtnProviders.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BtnCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnProviders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private PictureBox BtnCategories;
        private PictureBox BtnProviders;
        private PictureBox BtnProducts;
    }
}