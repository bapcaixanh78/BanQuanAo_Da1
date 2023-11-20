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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_Update = new Button();
            btn_Lock = new Button();
            btn_Add = new Button();
            txt_TenNV = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_DiaChi = new TextBox();
            dtp_NgayTao = new DateTimePicker();
            txt_MK = new TextBox();
            txt_Email = new TextBox();
            txt_TimKiemNV = new TextBox();
            dtg_NhanVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_NhanVien).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 217);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 43;
            label6.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 174);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 40;
            label4.Text = "Creation date : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 131);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 38;
            label3.Text = "Email : ";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(618, 94);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(117, 44);
            btn_Update.TabIndex = 35;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Lock
            // 
            btn_Lock.Location = new Point(618, 168);
            btn_Lock.Name = "btn_Lock";
            btn_Lock.Size = new Size(117, 44);
            btn_Lock.TabIndex = 34;
            btn_Lock.Text = "Lock";
            btn_Lock.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(618, 13);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(117, 44);
            btn_Add.TabIndex = 33;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(240, 45);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(242, 27);
            txt_TenNV.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 88);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 30;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 45);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 29;
            label1.Text = "User's name : ";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(240, 217);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(242, 27);
            txt_DiaChi.TabIndex = 44;
            // 
            // dtp_NgayTao
            // 
            dtp_NgayTao.Location = new Point(240, 174);
            dtp_NgayTao.Name = "dtp_NgayTao";
            dtp_NgayTao.Size = new Size(242, 27);
            dtp_NgayTao.TabIndex = 45;
            // 
            // txt_MK
            // 
            txt_MK.Location = new Point(240, 88);
            txt_MK.Name = "txt_MK";
            txt_MK.Size = new Size(242, 27);
            txt_MK.TabIndex = 46;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(240, 131);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(242, 27);
            txt_Email.TabIndex = 47;
            // 
            // txt_TimKiemNV
            // 
            txt_TimKiemNV.Location = new Point(72, 312);
            txt_TimKiemNV.Name = "txt_TimKiemNV";
            txt_TimKiemNV.PlaceholderText = "Search";
            txt_TimKiemNV.Size = new Size(242, 27);
            txt_TimKiemNV.TabIndex = 48;
            // 
            // dtg_NhanVien
            // 
            dtg_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_NhanVien.Location = new Point(72, 345);
            dtg_NhanVien.Name = "dtg_NhanVien";
            dtg_NhanVien.RowHeadersWidth = 51;
            dtg_NhanVien.RowTemplate.Height = 29;
            dtg_NhanVien.Size = new Size(663, 303);
            dtg_NhanVien.TabIndex = 49;
            // 
            // Admin_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 660);
            Controls.Add(dtg_NhanVien);
            Controls.Add(txt_TimKiemNV);
            Controls.Add(txt_Email);
            Controls.Add(txt_MK);
            Controls.Add(dtp_NgayTao);
            Controls.Add(txt_DiaChi);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_Update);
            Controls.Add(btn_Lock);
            Controls.Add(btn_Add);
            Controls.Add(txt_TenNV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Staff";
            Text = "Admin_Staff";
            ((System.ComponentModel.ISupportInitialize)dtg_NhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxt_MoTa;
        private ComboBox cmb_Size;
        private ComboBox cmb_Color;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_SoLuong;
        private Label label4;
        private TextBox txtGiaBan;
        private Label label3;
        private DataGridView dtg_SanPham;
        private TextBox txt_TimKiemSP;
        private Button btn_Update;
        private Button btn_Lock;
        private Button btn_Add;
        private TextBox txtGiaNhap;
        private TextBox txt_TenNV;
        private Label label2;
        private Label label1;
        private TextBox txt_DiaChi;
        private DateTimePicker dtp_NgayTao;
        private TextBox txt_MK;
        private TextBox txt_Email;
        private TextBox txt_TimKiemNV;
        private DataGridView dtg_NhanVien;
    }
}