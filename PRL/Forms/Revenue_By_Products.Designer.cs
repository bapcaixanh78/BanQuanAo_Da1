namespace PRL.Forms
{
    partial class Revenue_By_Products
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
            dtg_Revenue_By_Products = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_Revenue_By_Products).BeginInit();
            SuspendLayout();
            // 
            // dtg_Revenue_By_Products
            // 
            dtg_Revenue_By_Products.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Revenue_By_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Revenue_By_Products.Dock = DockStyle.Fill;
            dtg_Revenue_By_Products.GridColor = SystemColors.ActiveCaptionText;
            dtg_Revenue_By_Products.Location = new Point(0, 0);
            dtg_Revenue_By_Products.Name = "dtg_Revenue_By_Products";
            dtg_Revenue_By_Products.RowHeadersVisible = false;
            dtg_Revenue_By_Products.RowHeadersWidth = 51;
            dtg_Revenue_By_Products.RowTemplate.Height = 29;
            dtg_Revenue_By_Products.Size = new Size(1769, 513);
            dtg_Revenue_By_Products.TabIndex = 0;
            // 
            // Revenue_By_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1769, 513);
            Controls.Add(dtg_Revenue_By_Products);
            Name = "Revenue_By_Products";
            Text = "Revenue_By_Products";
            ((System.ComponentModel.ISupportInitialize)dtg_Revenue_By_Products).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Revenue_By_Products;
    }
}