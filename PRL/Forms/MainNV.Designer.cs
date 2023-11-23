namespace PRL.Forms
{
    partial class MainNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainNV));
            btn_DangXuat = new Button();
            btn_ThongKe = new Button();
            btn_BanHang = new Button();
            btn_HoaDon = new Button();
            lb_Username = new Label();
            panel2 = new Panel();
            lb_Welcome = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            btnCloseChildForm = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pn_ChucNang = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.Dock = DockStyle.Top;
            btn_DangXuat.FlatAppearance.BorderSize = 0;
            btn_DangXuat.FlatStyle = FlatStyle.Flat;
            btn_DangXuat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(0, 260);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(202, 45);
            btn_DangXuat.TabIndex = 9;
            btn_DangXuat.Text = "Log out";
            btn_DangXuat.UseVisualStyleBackColor = true;
            btn_DangXuat.Click += btn_DangXuat_Click;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.Dock = DockStyle.Top;
            btn_ThongKe.FlatAppearance.BorderSize = 0;
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThongKe.ForeColor = Color.White;
            btn_ThongKe.Location = new Point(0, 215);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(202, 45);
            btn_ThongKe.TabIndex = 6;
            btn_ThongKe.Text = "Statistics";
            btn_ThongKe.UseVisualStyleBackColor = true;
            btn_ThongKe.MouseEnter += btn_ThongKe_MouseEnter;
            btn_ThongKe.MouseLeave += btn_ThongKe_MouseLeave;
            // 
            // btn_BanHang
            // 
            btn_BanHang.Dock = DockStyle.Top;
            btn_BanHang.FlatAppearance.BorderSize = 0;
            btn_BanHang.FlatStyle = FlatStyle.Flat;
            btn_BanHang.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_BanHang.ForeColor = Color.White;
            btn_BanHang.Location = new Point(0, 170);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(202, 45);
            btn_BanHang.TabIndex = 5;
            btn_BanHang.Text = "Vending";
            btn_BanHang.UseVisualStyleBackColor = true;
            btn_BanHang.Click += btn_BanHang_Click;
            btn_BanHang.MouseEnter += btn_BanHang_MouseEnter;
            btn_BanHang.MouseLeave += btn_BanHang_MouseLeave;
            // 
            // btn_HoaDon
            // 
            btn_HoaDon.Dock = DockStyle.Top;
            btn_HoaDon.FlatAppearance.BorderSize = 0;
            btn_HoaDon.FlatStyle = FlatStyle.Flat;
            btn_HoaDon.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_HoaDon.ForeColor = Color.White;
            btn_HoaDon.Location = new Point(0, 125);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(202, 45);
            btn_HoaDon.TabIndex = 4;
            btn_HoaDon.Text = "Bill";
            btn_HoaDon.UseVisualStyleBackColor = true;
            btn_HoaDon.Click += btn_HoaDon_Click;
            btn_HoaDon.MouseEnter += btn_HoaDon_MouseEnter;
            btn_HoaDon.MouseLeave += btn_HoaDon_MouseLeave;
            // 
            // lb_Username
            // 
            lb_Username.AutoSize = true;
            lb_Username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Username.Location = new Point(12, 45);
            lb_Username.Name = "lb_Username";
            lb_Username.Size = new Size(114, 23);
            lb_Username.TabIndex = 1;
            lb_Username.Text = "User name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(lb_Username);
            panel2.Controls.Add(lb_Welcome);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 125);
            panel2.TabIndex = 0;
            // 
            // lb_Welcome
            // 
            lb_Welcome.AutoSize = true;
            lb_Welcome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Welcome.Location = new Point(12, 9);
            lb_Welcome.Name = "lb_Welcome";
            lb_Welcome.Size = new Size(165, 23);
            lb_Welcome.TabIndex = 0;
            lb_Welcome.Text = "Welcome back,";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_DangXuat);
            panel1.Controls.Add(btn_ThongKe);
            panel1.Controls.Add(btn_BanHang);
            panel1.Controls.Add(btn_HoaDon);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 653);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(btnCloseChildForm);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(202, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 125);
            panel3.TabIndex = 7;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseChildForm.ForeColor = Color.White;
            btnCloseChildForm.Location = new Point(37, 39);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(94, 39);
            btnCloseChildForm.TabIndex = 0;
            btnCloseChildForm.Text = "X";
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(461, 68);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 7;
            label2.Text = "Bring you a comfy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(420, 45);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 6;
            label1.Text = "Shirt Haven";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pn_ChucNang
            // 
            pn_ChucNang.Dock = DockStyle.Fill;
            pn_ChucNang.Location = new Point(202, 125);
            pn_ChucNang.Name = "pn_ChucNang";
            pn_ChucNang.Size = new Size(980, 528);
            pn_ChucNang.TabIndex = 8;
            // 
            // MainNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1182, 653);
            Controls.Add(pn_ChucNang);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "MainNV";
            Text = "MainNV";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_DangXuat;
        private Button btn_ThongKe;
        private Button btn_BanHang;
        private Button btn_HoaDon;
        private Label lb_Username;
        private Panel panel2;
        private Label lb_Welcome;
        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pn_ChucNang;
        private Button btnCloseChildForm;
    }
}