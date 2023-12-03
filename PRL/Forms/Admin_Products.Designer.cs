namespace PRL.Forms
{
    partial class Admin_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Products));
            dtg_SanPham = new DataGridView();
            txt_TimKiemSP = new TextBox();
            btn_Update = new Button();
            btn_Add = new Button();
            txtGiaNhap = new TextBox();
            txtTenHang = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtGiaBan = new TextBox();
            label4 = new Label();
            txt_SoLuong = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmb_Color = new ComboBox();
            cmb_Size = new ComboBox();
            rtxt_MoTa = new RichTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_clear = new Button();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            lb_filter = new Label();
            cmb_statusFilter = new ComboBox();
            cmb_colorFIlter = new ComboBox();
            cmb_sizeFilter = new ComboBox();
            cmb_list = new ComboBox();
            label9 = new Label();
            txt_ImgPath = new TextBox();
            btn_browser = new Button();
            cmb_Material = new ComboBox();
            label8 = new Label();
            Picturebox_Product = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picturebox_Product).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_SanPham
            // 
            dtg_SanPham.BackgroundColor = SystemColors.ActiveCaption;
            dtg_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SanPham.Dock = DockStyle.Fill;
            dtg_SanPham.Location = new Point(3, 23);
            dtg_SanPham.Name = "dtg_SanPham";
            dtg_SanPham.RowHeadersWidth = 51;
            dtg_SanPham.RowTemplate.Height = 29;
            dtg_SanPham.Size = new Size(1781, 186);
            dtg_SanPham.TabIndex = 17;
            dtg_SanPham.CellClick += dtg_SanPham_CellClick;
            dtg_SanPham.CellLeave += dtg_SanPham_CellLeave;
            // 
            // txt_TimKiemSP
            // 
            txt_TimKiemSP.BackColor = SystemColors.Info;
            txt_TimKiemSP.Dock = DockStyle.Bottom;
            txt_TimKiemSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiemSP.Location = new Point(3, 396);
            txt_TimKiemSP.Multiline = true;
            txt_TimKiemSP.Name = "txt_TimKiemSP";
            txt_TimKiemSP.PlaceholderText = "Search";
            txt_TimKiemSP.Size = new Size(335, 42);
            txt_TimKiemSP.TabIndex = 16;
            txt_TimKiemSP.TextChanged += txt_TimKiemSP_TextChanged;
            // 
            // btn_Update
            // 
            btn_Update.Dock = DockStyle.Top;
            btn_Update.Location = new Point(3, 67);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(335, 44);
            btn_Update.TabIndex = 15;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Top;
            btn_Add.Location = new Point(3, 23);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(335, 44);
            btn_Add.TabIndex = 13;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.BackColor = SystemColors.Info;
            txtGiaNhap.Location = new Point(839, 83);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(329, 27);
            txtGiaNhap.TabIndex = 12;
            // 
            // txtTenHang
            // 
            txtTenHang.BackColor = SystemColors.Info;
            txtTenHang.Location = new Point(839, 40);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(329, 27);
            txtTenHang.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(648, 82);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 10;
            label2.Text = "Entry price : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(648, 39);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 9;
            label1.Text = "Product's name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(648, 125);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 18;
            label3.Text = "Price : ";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = SystemColors.Info;
            txtGiaBan.Location = new Point(839, 126);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(329, 27);
            txtGiaBan.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(648, 168);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 20;
            label4.Text = "Quantity : ";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.BackColor = SystemColors.Info;
            txt_SoLuong.Location = new Point(839, 169);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(329, 27);
            txt_SoLuong.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(646, 383);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 22;
            label5.Text = "Description :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(648, 211);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 24;
            label6.Text = "Color :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(648, 254);
            label7.Name = "label7";
            label7.Size = new Size(56, 28);
            label7.TabIndex = 25;
            label7.Text = "Size :";
            // 
            // cmb_Color
            // 
            cmb_Color.BackColor = SystemColors.Info;
            cmb_Color.FormattingEnabled = true;
            cmb_Color.Location = new Point(839, 211);
            cmb_Color.Name = "cmb_Color";
            cmb_Color.Size = new Size(329, 28);
            cmb_Color.TabIndex = 26;
            // 
            // cmb_Size
            // 
            cmb_Size.BackColor = SystemColors.Info;
            cmb_Size.FormattingEnabled = true;
            cmb_Size.Location = new Point(839, 254);
            cmb_Size.Name = "cmb_Size";
            cmb_Size.Size = new Size(329, 28);
            cmb_Size.TabIndex = 27;
            // 
            // rtxt_MoTa
            // 
            rtxt_MoTa.BackColor = SystemColors.Info;
            rtxt_MoTa.Location = new Point(839, 387);
            rtxt_MoTa.Name = "rtxt_MoTa";
            rtxt_MoTa.Size = new Size(329, 41);
            rtxt_MoTa.TabIndex = 28;
            rtxt_MoTa.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtg_SanPham);
            groupBox1.Location = new Point(0, 466);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 212);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information products";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(txt_TimKiemSP);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(1446, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 441);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Services";
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Top;
            btn_clear.Location = new Point(3, 111);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(335, 44);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "Clear Form";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lb_filter);
            groupBox3.Controls.Add(cmb_statusFilter);
            groupBox3.Controls.Add(cmb_colorFIlter);
            groupBox3.Controls.Add(cmb_sizeFilter);
            groupBox3.Controls.Add(cmb_list);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txt_ImgPath);
            groupBox3.Controls.Add(btn_browser);
            groupBox3.Controls.Add(cmb_Material);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(Picturebox_Product);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(rtxt_MoTa);
            groupBox3.Controls.Add(txtGiaNhap);
            groupBox3.Controls.Add(cmb_Size);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cmb_Color);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtTenHang);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txt_SoLuong);
            groupBox3.Controls.Add(txtGiaBan);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1446, 441);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1196, 288);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 44;
            label12.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1202, 198);
            label11.Name = "label11";
            label11.Size = new Size(45, 20);
            label11.TabIndex = 43;
            label11.Text = "Color";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1202, 101);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 42;
            label10.Text = "Size";
            // 
            // lb_filter
            // 
            lb_filter.AutoSize = true;
            lb_filter.Location = new Point(1205, 43);
            lb_filter.Name = "lb_filter";
            lb_filter.Size = new Size(42, 20);
            lb_filter.TabIndex = 41;
            lb_filter.Text = "Filter";
            // 
            // cmb_statusFilter
            // 
            cmb_statusFilter.BackColor = SystemColors.Info;
            cmb_statusFilter.FormattingEnabled = true;
            cmb_statusFilter.Location = new Point(1196, 320);
            cmb_statusFilter.Name = "cmb_statusFilter";
            cmb_statusFilter.Size = new Size(123, 28);
            cmb_statusFilter.TabIndex = 40;
            cmb_statusFilter.SelectedIndexChanged += cmb_statusFilter_SelectedIndexChanged;
            // 
            // cmb_colorFIlter
            // 
            cmb_colorFIlter.BackColor = SystemColors.Info;
            cmb_colorFIlter.FormattingEnabled = true;
            cmb_colorFIlter.Location = new Point(1196, 234);
            cmb_colorFIlter.Name = "cmb_colorFIlter";
            cmb_colorFIlter.Size = new Size(123, 28);
            cmb_colorFIlter.TabIndex = 39;
            cmb_colorFIlter.SelectedIndexChanged += cmb_colorFIlter_SelectedIndexChanged;
            // 
            // cmb_sizeFilter
            // 
            cmb_sizeFilter.BackColor = SystemColors.Info;
            cmb_sizeFilter.FormattingEnabled = true;
            cmb_sizeFilter.Location = new Point(1196, 144);
            cmb_sizeFilter.Name = "cmb_sizeFilter";
            cmb_sizeFilter.Size = new Size(123, 28);
            cmb_sizeFilter.TabIndex = 38;
            cmb_sizeFilter.SelectedIndexChanged += cmb_sizeFilter_SelectedIndexChanged;
            // 
            // cmb_list
            // 
            cmb_list.BackColor = SystemColors.Info;
            cmb_list.FormattingEnabled = true;
            cmb_list.Location = new Point(839, 340);
            cmb_list.Name = "cmb_list";
            cmb_list.Size = new Size(329, 28);
            cmb_list.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(648, 340);
            label9.Name = "label9";
            label9.Size = new Size(50, 28);
            label9.TabIndex = 36;
            label9.Text = "List :";
            // 
            // txt_ImgPath
            // 
            txt_ImgPath.BackColor = SystemColors.Info;
            txt_ImgPath.Location = new Point(159, 331);
            txt_ImgPath.Name = "txt_ImgPath";
            txt_ImgPath.Size = new Size(285, 27);
            txt_ImgPath.TabIndex = 35;
            // 
            // btn_browser
            // 
            btn_browser.Location = new Point(198, 373);
            btn_browser.Name = "btn_browser";
            btn_browser.Size = new Size(211, 46);
            btn_browser.TabIndex = 34;
            btn_browser.Text = "Browser";
            btn_browser.UseVisualStyleBackColor = true;
            btn_browser.Click += btn_browser_Click;
            // 
            // cmb_Material
            // 
            cmb_Material.BackColor = SystemColors.Info;
            cmb_Material.FormattingEnabled = true;
            cmb_Material.Location = new Point(839, 297);
            cmb_Material.Name = "cmb_Material";
            cmb_Material.Size = new Size(329, 28);
            cmb_Material.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(648, 297);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 32;
            label8.Text = "Material :";
            // 
            // Picturebox_Product
            // 
            Picturebox_Product.Image = (Image)resources.GetObject("Picturebox_Product.Image");
            Picturebox_Product.Location = new Point(159, 43);
            Picturebox_Product.Name = "Picturebox_Product";
            Picturebox_Product.Size = new Size(285, 265);
            Picturebox_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            Picturebox_Product.TabIndex = 31;
            Picturebox_Product.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 441);
            panel1.TabIndex = 32;
            // 
            // Admin_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1787, 678);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_Products";
            Text = "Admin_Products";
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Picturebox_Product).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_SanPham;
        private TextBox txt_TimKiemSP;
        private Button btn_Update;
        private Button btn_Add;
        private TextBox txtGiaNhap;
        private TextBox txtTenHang;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtGiaBan;
        private Label label4;
        private TextBox txt_SoLuong;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmb_Color;
        private ComboBox cmb_Size;
        private RichTextBox rtxt_MoTa;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox Picturebox_Product;
        private Panel panel1;
        private Label label8;
        private ComboBox cmb_Material;
        private Button btn_clear;
        private Button btn_browser;
        private TextBox txt_ImgPath;
        private ComboBox cmb_list;
        private Label label9;
        private Label lb_filter;
        private ComboBox cmb_statusFilter;
        private ComboBox cmb_colorFIlter;
        private ComboBox cmb_sizeFilter;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}