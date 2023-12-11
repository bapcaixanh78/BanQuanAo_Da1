namespace PRL.Forms
{
    partial class Admin_Revenue_By_Quantity
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
            dtg_Revenue_By_Quantity = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_Revenue_By_Quantity).BeginInit();
            SuspendLayout();
            // 
            // dtg_Revenue_By_Quantity
            // 
            dtg_Revenue_By_Quantity.AllowUserToAddRows = false;
            dtg_Revenue_By_Quantity.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Revenue_By_Quantity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Revenue_By_Quantity.Dock = DockStyle.Fill;
            dtg_Revenue_By_Quantity.GridColor = SystemColors.ActiveCaptionText;
            dtg_Revenue_By_Quantity.Location = new Point(0, 0);
            dtg_Revenue_By_Quantity.Name = "dtg_Revenue_By_Quantity";
            dtg_Revenue_By_Quantity.RowHeadersWidth = 51;
            dtg_Revenue_By_Quantity.RowTemplate.Height = 29;
            dtg_Revenue_By_Quantity.Size = new Size(1769, 513);
            dtg_Revenue_By_Quantity.TabIndex = 0;
            // 
            // Admin_Revenue_By_Quantity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1769, 513);
            Controls.Add(dtg_Revenue_By_Quantity);
            Name = "Admin_Revenue_By_Quantity";
            Text = "Admin_Revenue_By_Quantity";
            ((System.ComponentModel.ISupportInitialize)dtg_Revenue_By_Quantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_Revenue_By_Quantity;
    }
}