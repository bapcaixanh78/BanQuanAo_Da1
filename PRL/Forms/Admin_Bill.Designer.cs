namespace PRL.Forms
{
    partial class Admin_Bill
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
            dtg_SanPham = new DataGridView();
            txt_TimKiemSP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).BeginInit();
            SuspendLayout();
            // 
            // dtg_SanPham
            // 
            dtg_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SanPham.Location = new Point(38, 75);
            dtg_SanPham.Name = "dtg_SanPham";
            dtg_SanPham.RowHeadersWidth = 51;
            dtg_SanPham.RowTemplate.Height = 29;
            dtg_SanPham.Size = new Size(740, 216);
            dtg_SanPham.TabIndex = 37;
            // 
            // txt_TimKiemSP
            // 
            txt_TimKiemSP.Location = new Point(38, 42);
            txt_TimKiemSP.Name = "txt_TimKiemSP";
            txt_TimKiemSP.PlaceholderText = "Search";
            txt_TimKiemSP.Size = new Size(367, 27);
            txt_TimKiemSP.TabIndex = 36;
            // 
            // Admin_Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 317);
            Controls.Add(dtg_SanPham);
            Controls.Add(txt_TimKiemSP);
            Name = "Admin_Bill";
            Text = "Admin_Bill";
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtg_SanPham;
        private TextBox txt_TimKiemSP;
    }
}