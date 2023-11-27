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
            txt_email = new TextBox();
            label5 = new Label();
            label8 = new Label();
            cbb_role = new ComboBox();
            pictureBox1 = new PictureBox();
            txt_Password = new TextBox();
            txt_Account = new TextBox();
            txt_DiaChi = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txt_TenNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btn_Clear = new Button();
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
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Lock
            // 
            btn_Lock.Dock = DockStyle.Top;
            btn_Lock.Location = new Point(4, 155);
            btn_Lock.Margin = new Padding(4);
            btn_Lock.Name = "btn_Lock";
            btn_Lock.Size = new Size(336, 62);
            btn_Lock.TabIndex = 34;
            btn_Lock.Text = "Lock/Unlock";
            btn_Lock.UseVisualStyleBackColor = true;
            btn_Lock.Click += btn_Lock_Click;
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
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_TimKiemNV
            // 
            txt_TimKiemNV.BackColor = SystemColors.Info;
            txt_TimKiemNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiemNV.Location = new Point(4, 306);
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
            dtg_NhanVien.CellClick += dtg_NhanVien_CellClick;
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
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbb_role);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(txt_Account);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(label6);
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
            // txt_email
            // 
            txt_email.BackColor = SystemColors.Info;
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(961, 194);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(265, 34);
            txt_email.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(782, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 63;
            label5.Text = "Email: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(782, 143);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 60;
            label8.Text = "Role:";
            // 
            // cbb_role
            // 
            cbb_role.BackColor = SystemColors.Info;
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cbb_role.Location = new Point(961, 137);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(265, 36);
            cbb_role.TabIndex = 59;
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
            // txt_Password
            // 
            txt_Password.BackColor = SystemColors.Info;
            txt_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(440, 197);
            txt_Password.Margin = new Padding(4);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(265, 34);
            txt_Password.TabIndex = 57;
            // 
            // txt_Account
            // 
            txt_Account.BackColor = SystemColors.Info;
            txt_Account.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Account.Location = new Point(440, 137);
            txt_Account.Margin = new Padding(4);
            txt_Account.Name = "txt_Account";
            txt_Account.Size = new Size(265, 34);
            txt_Account.TabIndex = 56;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.BackColor = SystemColors.Info;
            txt_DiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DiaChi.Location = new Point(961, 77);
            txt_DiaChi.Margin = new Padding(4);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(265, 34);
            txt_DiaChi.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(782, 77);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 53;
            label6.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 200);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 51;
            label3.Text = "Password: ";
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
            label2.Size = new Size(88, 28);
            label2.TabIndex = 49;
            label2.Text = "Account:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 48;
            label1.Text = "Full name: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Clear);
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
            // btn_Clear
            // 
            btn_Clear.Dock = DockStyle.Top;
            btn_Clear.Location = new Point(4, 217);
            btn_Clear.Margin = new Padding(4);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(336, 62);
            btn_Clear.TabIndex = 49;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
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
            Load += Admin_Staff_Load;
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
        private TextBox txt_Password;
        private TextBox txt_Account;
        private TextBox txt_DiaChi;
        private Label label6;
        private Label label3;
        private TextBox txt_TenNV;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox cbb_role;
        private Label label8;
        private TextBox txt_email;
        private Label label5;
        private Button btn_Clear;
    }
}