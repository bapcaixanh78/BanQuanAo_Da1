namespace PRL.Forms
{
    partial class Statistics
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
            btn_Close = new Button();
            btn_AllProducts = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btn_Close);
            panel1.Controls.Add(btn_AllProducts);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 118);
            panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.White;
            btn_Close.Location = new Point(1589, 25);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(153, 63);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "X";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_AllProducts
            // 
            btn_AllProducts.Dock = DockStyle.Left;
            btn_AllProducts.FlatAppearance.BorderSize = 0;
            btn_AllProducts.FlatStyle = FlatStyle.Flat;
            btn_AllProducts.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AllProducts.ForeColor = Color.White;
            btn_AllProducts.Location = new Point(0, 0);
            btn_AllProducts.Name = "btn_AllProducts";
            btn_AllProducts.Size = new Size(205, 118);
            btn_AllProducts.TabIndex = 0;
            btn_AllProducts.Text = "All Products";
            btn_AllProducts.UseVisualStyleBackColor = true;
            btn_AllProducts.Click += btn_AllProducts_Click;
            btn_AllProducts.MouseEnter += btn_AllProducts_MouseEnter;
            btn_AllProducts.MouseLeave += btn_AllProducts_MouseLeave;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1787, 560);
            panel2.TabIndex = 1;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 678);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Statistics";
            Text = "Statistics";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_AllProducts;
        private Panel panel2;
        private Button btn_Close;
    }
}