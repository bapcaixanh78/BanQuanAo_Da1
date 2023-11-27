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
            btn_Del = new Button();
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
            groupBox3 = new GroupBox();
            cmb_Material = new ComboBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // btn_Del
            // 
            btn_Del.Dock = DockStyle.Top;
            btn_Del.Location = new Point(3, 111);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(335, 44);
            btn_Del.TabIndex = 14;
            btn_Del.Text = "Delete";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
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
            txtGiaNhap.Location = new Point(839, 88);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(329, 27);
            txtGiaNhap.TabIndex = 12;
            // 
            // txtTenHang
            // 
            txtTenHang.BackColor = SystemColors.Info;
            txtTenHang.Location = new Point(839, 44);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(329, 27);
            txtTenHang.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(648, 87);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 10;
            label2.Text = "Entry price : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(648, 43);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 9;
            label1.Text = "Product's name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(648, 131);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 18;
            label3.Text = "Price : ";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BackColor = SystemColors.Info;
            txtGiaBan.Location = new Point(839, 132);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(329, 27);
            txtGiaBan.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(648, 175);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 20;
            label4.Text = "Quantity : ";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.BackColor = SystemColors.Info;
            txt_SoLuong.Location = new Point(839, 176);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(329, 27);
            txt_SoLuong.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(646, 351);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 22;
            label5.Text = "Description :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(648, 219);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 24;
            label6.Text = "Color :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(648, 263);
            label7.Name = "label7";
            label7.Size = new Size(56, 28);
            label7.TabIndex = 25;
            label7.Text = "Size :";
            // 
            // cmb_Color
            // 
            cmb_Color.BackColor = SystemColors.Info;
            cmb_Color.FormattingEnabled = true;
            cmb_Color.Location = new Point(839, 219);
            cmb_Color.Name = "cmb_Color";
            cmb_Color.Size = new Size(329, 28);
            cmb_Color.TabIndex = 26;
            // 
            // cmb_Size
            // 
            cmb_Size.BackColor = SystemColors.Info;
            cmb_Size.FormattingEnabled = true;
            cmb_Size.Location = new Point(839, 263);
            cmb_Size.Name = "cmb_Size";
            cmb_Size.Size = new Size(329, 28);
            cmb_Size.TabIndex = 27;
            // 
            // rtxt_MoTa
            // 
            rtxt_MoTa.BackColor = SystemColors.Info;
            rtxt_MoTa.Location = new Point(839, 351);
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
            groupBox2.Controls.Add(btn_Del);
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
            // groupBox3
            // 
            groupBox3.Controls.Add(cmb_Material);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(pictureBox1);
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
            // cmb_Material
            // 
            cmb_Material.BackColor = SystemColors.Info;
            cmb_Material.FormattingEnabled = true;
            cmb_Material.Location = new Point(839, 307);
            cmb_Material.Name = "cmb_Material";
            cmb_Material.Size = new Size(329, 28);
            cmb_Material.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(648, 307);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 32;
            label8.Text = "Material :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(221, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
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
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Top;
            btn_clear.Location = new Point(3, 155);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(335, 44);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "Clear Form";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // Admin_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtg_SanPham;
        private TextBox txt_TimKiemSP;
        private Button btn_Update;
        private Button btn_Del;
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
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label8;
        private ComboBox cmb_Material;
        private Button btn_clear;
    }
}