﻿namespace PRL.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            btn_DangXuat = new Button();
            btn_KhuyenMai = new Button();
            btn_VaiTro = new Button();
            btn_ThongKe = new Button();
            btn_BanHang = new Button();
            btn_HoaDon = new Button();
            btn_NhanVien = new Button();
            btn_SanPham = new Button();
            btn_KhachHang = new Button();
            panel2 = new Panel();
            lb_Username = new Label();
            lb_Welcome = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(btn_DangXuat);
            panel1.Controls.Add(btn_KhuyenMai);
            panel1.Controls.Add(btn_VaiTro);
            panel1.Controls.Add(btn_ThongKe);
            panel1.Controls.Add(btn_BanHang);
            panel1.Controls.Add(btn_HoaDon);
            panel1.Controls.Add(btn_NhanVien);
            panel1.Controls.Add(btn_SanPham);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 653);
            panel1.TabIndex = 0;
            // 
            // btn_DangXuat
            // 
            btn_DangXuat.Dock = DockStyle.Top;
            btn_DangXuat.FlatAppearance.BorderSize = 0;
            btn_DangXuat.FlatStyle = FlatStyle.Flat;
            btn_DangXuat.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangXuat.ForeColor = Color.White;
            btn_DangXuat.Location = new Point(0, 485);
            btn_DangXuat.Name = "btn_DangXuat";
            btn_DangXuat.Size = new Size(250, 45);
            btn_DangXuat.TabIndex = 9;
            btn_DangXuat.Text = "Log out";
            btn_DangXuat.UseVisualStyleBackColor = true;
            btn_DangXuat.MouseEnter += btn_DangXuat_MouseEnter;
            btn_DangXuat.MouseLeave += btn_DangXuat_MouseLeave;
            // 
            // btn_KhuyenMai
            // 
            btn_KhuyenMai.Dock = DockStyle.Top;
            btn_KhuyenMai.FlatAppearance.BorderSize = 0;
            btn_KhuyenMai.FlatStyle = FlatStyle.Flat;
            btn_KhuyenMai.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_KhuyenMai.ForeColor = Color.White;
            btn_KhuyenMai.Location = new Point(0, 440);
            btn_KhuyenMai.Name = "btn_KhuyenMai";
            btn_KhuyenMai.Size = new Size(250, 45);
            btn_KhuyenMai.TabIndex = 8;
            btn_KhuyenMai.Text = "Sale";
            btn_KhuyenMai.UseVisualStyleBackColor = true;
            btn_KhuyenMai.MouseEnter += btn_KhuyenMai_MouseEnter;
            btn_KhuyenMai.MouseLeave += btn_KhuyenMai_MouseLeave;
            // 
            // btn_VaiTro
            // 
            btn_VaiTro.Dock = DockStyle.Top;
            btn_VaiTro.FlatAppearance.BorderSize = 0;
            btn_VaiTro.FlatStyle = FlatStyle.Flat;
            btn_VaiTro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_VaiTro.ForeColor = Color.White;
            btn_VaiTro.Location = new Point(0, 395);
            btn_VaiTro.Name = "btn_VaiTro";
            btn_VaiTro.Size = new Size(250, 45);
            btn_VaiTro.TabIndex = 7;
            btn_VaiTro.Text = "Role";
            btn_VaiTro.UseVisualStyleBackColor = true;
            btn_VaiTro.MouseEnter += btn_VaiTro_MouseEnter;
            btn_VaiTro.MouseLeave += btn_VaiTro_MouseLeave;
            // 
            // btn_ThongKe
            // 
            btn_ThongKe.Dock = DockStyle.Top;
            btn_ThongKe.FlatAppearance.BorderSize = 0;
            btn_ThongKe.FlatStyle = FlatStyle.Flat;
            btn_ThongKe.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ThongKe.ForeColor = Color.White;
            btn_ThongKe.Location = new Point(0, 350);
            btn_ThongKe.Name = "btn_ThongKe";
            btn_ThongKe.Size = new Size(250, 45);
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
            btn_BanHang.Location = new Point(0, 305);
            btn_BanHang.Name = "btn_BanHang";
            btn_BanHang.Size = new Size(250, 45);
            btn_BanHang.TabIndex = 5;
            btn_BanHang.Text = "Vending";
            btn_BanHang.UseVisualStyleBackColor = true;
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
            btn_HoaDon.Location = new Point(0, 260);
            btn_HoaDon.Name = "btn_HoaDon";
            btn_HoaDon.Size = new Size(250, 45);
            btn_HoaDon.TabIndex = 4;
            btn_HoaDon.Text = "Bill";
            btn_HoaDon.UseVisualStyleBackColor = true;
            btn_HoaDon.MouseEnter += btn_HoaDon_MouseEnter;
            btn_HoaDon.MouseLeave += btn_HoaDon_MouseLeave;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.Dock = DockStyle.Top;
            btn_NhanVien.FlatAppearance.BorderSize = 0;
            btn_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_NhanVien.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_NhanVien.ForeColor = Color.White;
            btn_NhanVien.Location = new Point(0, 215);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Size = new Size(250, 45);
            btn_NhanVien.TabIndex = 3;
            btn_NhanVien.Text = "Staff";
            btn_NhanVien.UseVisualStyleBackColor = true;
            btn_NhanVien.MouseEnter += btn_NhanVien_MouseEnter;
            btn_NhanVien.MouseLeave += btn_NhanVien_MouseLeave;
            // 
            // btn_SanPham
            // 
            btn_SanPham.Dock = DockStyle.Top;
            btn_SanPham.FlatAppearance.BorderSize = 0;
            btn_SanPham.FlatStyle = FlatStyle.Flat;
            btn_SanPham.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SanPham.ForeColor = Color.White;
            btn_SanPham.Location = new Point(0, 170);
            btn_SanPham.Name = "btn_SanPham";
            btn_SanPham.Size = new Size(250, 45);
            btn_SanPham.TabIndex = 2;
            btn_SanPham.Text = "Products";
            btn_SanPham.UseVisualStyleBackColor = true;
            btn_SanPham.MouseEnter += btn_SanPham_MouseEnter;
            btn_SanPham.MouseLeave += btn_SanPham_MouseLeave;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Dock = DockStyle.Top;
            btn_KhachHang.FlatAppearance.BorderSize = 0;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_KhachHang.ForeColor = Color.White;
            btn_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.Location = new Point(0, 125);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(250, 45);
            btn_KhachHang.TabIndex = 1;
            btn_KhachHang.Text = "Customers";
            btn_KhachHang.UseVisualStyleBackColor = true;
            btn_KhachHang.Click += btn_KhachHang_Click;
            btn_KhachHang.MouseEnter += btn_KhachHang_MouseEnter;
            btn_KhachHang.MouseLeave += btn_KhachHang_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(lb_Username);
            panel2.Controls.Add(lb_Welcome);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 0;
            // 
            // lb_Username
            // 
            lb_Username.AutoSize = true;
            lb_Username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Username.Location = new Point(43, 45);
            lb_Username.Name = "lb_Username";
            lb_Username.Size = new Size(114, 23);
            lb_Username.TabIndex = 1;
            lb_Username.Text = "User name";
            // 
            // lb_Welcome
            // 
            lb_Welcome.AutoSize = true;
            lb_Welcome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Welcome.Location = new Point(43, 9);
            lb_Welcome.Name = "lb_Welcome";
            lb_Welcome.Size = new Size(165, 23);
            lb_Welcome.TabIndex = 0;
            lb_Welcome.Text = "Welcome back,";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Shirt Haven";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_KhachHang;
        private Button btn_DangXuat;
        private Button btn_KhuyenMai;
        private Button btn_VaiTro;
        private Button btn_ThongKe;
        private Button btn_BanHang;
        private Button btn_HoaDon;
        private Button btn_NhanVien;
        private Button btn_SanPham;
        private Label lb_Username;
        private Label lb_Welcome;
    }
}