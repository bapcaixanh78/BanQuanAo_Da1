namespace PRL.Forms
{
    partial class Admin_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Staff));
            btn_Update = new Button();
            btn_Lock = new Button();
            btn_Add = new Button();
            txt_TimKiemNV = new TextBox();
            dtg_NhanVien = new DataGridView();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            cmb_Roles = new ComboBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txt_Email = new TextBox();
            txt_MK = new TextBox();
            dtp_NgayTao = new DateTimePicker();
            txt_DiaChi = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            txt_TenNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtg_NhanVien).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Update
            // 
            btn_Update.Dock = DockStyle.Top;
            btn_Update.Location = new Point(4, 31);
            btn_Update.Margin = new Padding(4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(336, 62);
            btn_Update.TabIndex = 35;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Lock
            // 
            btn_Lock.Dock = DockStyle.Top;
            btn_Lock.Location = new Point(4, 155);
            btn_Lock.Margin = new Padding(4);
            btn_Lock.Name = "btn_Lock";
            btn_Lock.Size = new Size(336, 62);
            btn_Lock.TabIndex = 34;
            btn_Lock.Text = "Lock";
            btn_Lock.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Top;
            btn_Add.Location = new Point(4, 93);
            btn_Add.Margin = new Padding(4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(336, 62);
            btn_Add.TabIndex = 33;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemNV
            // 
            txt_TimKiemNV.BackColor = SystemColors.Info;
            txt_TimKiemNV.Dock = DockStyle.Bottom;
            txt_TimKiemNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiemNV.Location = new Point(4, 332);
            txt_TimKiemNV.Margin = new Padding(4);
            txt_TimKiemNV.Name = "txt_TimKiemNV";
            txt_TimKiemNV.PlaceholderText = "Search";
            txt_TimKiemNV.Size = new Size(336, 34);
            txt_TimKiemNV.TabIndex = 48;
            txt_TimKiemNV.TextChanged += txt_TimKiemNV_TextChanged;
            // 
            // dtg_NhanVien
            // 
            dtg_NhanVien.BackgroundColor = SystemColors.ActiveCaption;
            dtg_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_NhanVien.Dock = DockStyle.Fill;
            dtg_NhanVien.Location = new Point(4, 31);
            dtg_NhanVien.Margin = new Padding(4);
            dtg_NhanVien.Name = "dtg_NhanVien";
            dtg_NhanVien.RowHeadersWidth = 51;
            dtg_NhanVien.RowTemplate.Height = 29;
            dtg_NhanVien.Size = new Size(1779, 220);
            dtg_NhanVien.TabIndex = 49;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_NhanVien);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 423);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1787, 255);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff's information";
            // 
            // panel1
            // 
            panel1.Controls.Add(cmb_Roles);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(txt_MK);
            panel1.Controls.Add(dtp_NgayTao);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_TenNV);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 370);
            panel1.TabIndex = 51;
            // 
            // cmb_Roles
            // 
            cmb_Roles.FormattingEnabled = true;
            cmb_Roles.Location = new Point(963, 197);
            cmb_Roles.Name = "cmb_Roles";
            cmb_Roles.Size = new Size(265, 36);
            cmb_Roles.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(784, 189);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 28);
            label8.TabIndex = 59;
            label8.Text = "Role : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // txt_Email
            // 
            txt_Email.BackColor = SystemColors.Info;
            txt_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(440, 197);
            txt_Email.Margin = new Padding(4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(265, 34);
            txt_Email.TabIndex = 57;
            // 
            // txt_MK
            // 
            txt_MK.BackColor = SystemColors.Info;
            txt_MK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MK.Location = new Point(440, 137);
            txt_MK.Margin = new Padding(4);
            txt_MK.Name = "txt_MK";
            txt_MK.Size = new Size(265, 34);
            txt_MK.TabIndex = 56;
            // 
            // dtp_NgayTao
            // 
            dtp_NgayTao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_NgayTao.Location = new Point(963, 77);
            dtp_NgayTao.Margin = new Padding(4);
            dtp_NgayTao.Name = "dtp_NgayTao";
            dtp_NgayTao.Size = new Size(265, 34);
            dtp_NgayTao.TabIndex = 55;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.BackColor = SystemColors.Info;
            txt_DiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(963, 137);
            txt_DiaChi.Margin = new Padding(4);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(265, 34);
            txt_DiaChi.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(784, 137);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 53;
            label6.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(784, 77);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 28);
            label4.TabIndex = 52;
            label4.Text = "Creation date : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 189);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 51;
            label3.Text = "Email : ";
            // 
            // txt_TenNV
            // 
            txt_TenNV.BackColor = SystemColors.Info;
            txt_TenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenNV.Location = new Point(440, 77);
            txt_TenNV.Margin = new Padding(4);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(265, 34);
            txt_TenNV.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 49;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 48;
            label1.Text = "User's name : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_TimKiemNV);
            groupBox2.Controls.Add(btn_Lock);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(1443, 0);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(344, 370);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Services";
            // 
            // Admin_Staff
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 678);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Admin_Staff";
            Text = "Admin_Staff";
            ((System.ComponentModel.ISupportInitialize)dtg_NhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxt_MoTa;
        private ComboBox cmb_Size;
        private ComboBox cmb_Color;
        private Label label7;
        private Label label5;
        private TextBox txt_SoLuong;
        private TextBox txtGiaBan;
        private DataGridView dtg_SanPham;
        private TextBox txt_TimKiemSP;
        private Button btn_Update;
        private Button btn_Lock;
        private Button btn_Add;
        private TextBox txtGiaNhap;
        private TextBox txt_TimKiemNV;
        private DataGridView dtg_NhanVien;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private TextBox txt_Email;
        private TextBox txt_MK;
        private DateTimePicker dtp_NgayTao;
        private TextBox txt_DiaChi;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox txt_TenNV;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label8;
        private ComboBox cmb_Roles;
    }
}