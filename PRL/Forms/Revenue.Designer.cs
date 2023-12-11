namespace PRL.Forms
{
    partial class Revenue
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
            btn_By_Products = new Button();
            btn_Close = new Button();
            btn_ByStaff = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btn_By_Products);
            panel1.Controls.Add(btn_Close);
            panel1.Controls.Add(btn_ByStaff);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 72);
            panel1.TabIndex = 0;
            // 
            // btn_By_Products
            // 
            btn_By_Products.BackColor = Color.Black;
            btn_By_Products.Dock = DockStyle.Left;
            btn_By_Products.FlatAppearance.BorderSize = 0;
            btn_By_Products.FlatStyle = FlatStyle.Flat;
            btn_By_Products.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_By_Products.ForeColor = Color.White;
            btn_By_Products.Location = new Point(272, 0);
            btn_By_Products.Name = "btn_By_Products";
            btn_By_Products.Size = new Size(272, 72);
            btn_By_Products.TabIndex = 2;
            btn_By_Products.Text = "Revenue by products";
            btn_By_Products.UseVisualStyleBackColor = false;
            btn_By_Products.Click += btn_By_Products_Click;
            btn_By_Products.MouseEnter += btn_By_Products_MouseEnter;
            btn_By_Products.MouseLeave += btn_By_Products_MouseLeave;
            // 
            // btn_Close
            // 
            btn_Close.Dock = DockStyle.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.White;
            btn_Close.Location = new Point(1634, 0);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(153, 72);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "X";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_ByStaff
            // 
            btn_ByStaff.BackColor = Color.Black;
            btn_ByStaff.Dock = DockStyle.Left;
            btn_ByStaff.FlatAppearance.BorderSize = 0;
            btn_ByStaff.FlatStyle = FlatStyle.Flat;
            btn_ByStaff.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ByStaff.ForeColor = Color.White;
            btn_ByStaff.Location = new Point(0, 0);
            btn_ByStaff.Name = "btn_ByStaff";
            btn_ByStaff.Size = new Size(272, 72);
            btn_ByStaff.TabIndex = 0;
            btn_ByStaff.Text = "Revenue by staff";
            btn_ByStaff.UseVisualStyleBackColor = false;
            btn_ByStaff.Click += btn_AllProducts_Click;
            btn_ByStaff.MouseEnter += btn_AllProducts_MouseEnter;
            btn_ByStaff.MouseLeave += btn_AllProducts_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(1787, 606);
            panel2.TabIndex = 1;
            // 
            // Revenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 678);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Revenue";
            Text = "Revenue";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_ByStaff;
        private Panel panel2;
        private Button btn_Close;
        private Button btn_By_Products;
    }
}