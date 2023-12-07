namespace PRL.Forms
{
    partial class Admin_Revenue_By_Staff
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
            dtg_revenuebystaff = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_revenuebystaff).BeginInit();
            SuspendLayout();
            // 
            // dtg_revenuebystaff
            // 
            dtg_revenuebystaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_revenuebystaff.BackgroundColor = SystemColors.ActiveCaption;
            dtg_revenuebystaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_revenuebystaff.Dock = DockStyle.Fill;
            dtg_revenuebystaff.GridColor = SystemColors.ActiveCaptionText;
            dtg_revenuebystaff.Location = new Point(0, 0);
            dtg_revenuebystaff.Name = "dtg_revenuebystaff";
            dtg_revenuebystaff.ReadOnly = true;
            dtg_revenuebystaff.RowHeadersWidth = 51;
            dtg_revenuebystaff.RowTemplate.Height = 29;
            dtg_revenuebystaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_revenuebystaff.Size = new Size(1769, 513);
            dtg_revenuebystaff.TabIndex = 0;
            // 
            // Admin_Revenue_By_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1769, 513);
            Controls.Add(dtg_revenuebystaff);
            Name = "Admin_Revenue_By_Staff";
            Text = "Revenue by staff";
            ((System.ComponentModel.ISupportInitialize)dtg_revenuebystaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_revenuebystaff;
    }
}