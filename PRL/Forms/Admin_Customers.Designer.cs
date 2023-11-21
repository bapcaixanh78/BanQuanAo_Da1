namespace PRL.Forms
{
    partial class Admin_Customers
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
            label1 = new Label();
            label2 = new Label();
            txtTenKhachHang = new TextBox();
            txtSDT = new TextBox();
            btn_Del = new Button();
            btn_Update = new Button();
            txt_TimKiemKH = new TextBox();
            dtg_KhachHang = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer's name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone number : ";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BackColor = SystemColors.Info;
            txtTenKhachHang.Location = new Point(184, 29);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(411, 44);
            txtTenKhachHang.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = SystemColors.Info;
            txtSDT.Location = new Point(184, 98);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(411, 41);
            txtSDT.TabIndex = 3;
            // 
            // btn_Del
            // 
            btn_Del.Dock = DockStyle.Top;
            btn_Del.Location = new Point(3, 23);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(332, 44);
            btn_Del.TabIndex = 5;
            btn_Del.Text = "Delete";
            btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Dock = DockStyle.Top;
            btn_Update.Location = new Point(3, 67);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(332, 44);
            btn_Update.TabIndex = 6;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemKH
            // 
            txt_TimKiemKH.BackColor = SystemColors.Info;
            txt_TimKiemKH.Dock = DockStyle.Bottom;
            txt_TimKiemKH.Location = new Point(3, 127);
            txt_TimKiemKH.Multiline = true;
            txt_TimKiemKH.Name = "txt_TimKiemKH";
            txt_TimKiemKH.PlaceholderText = "Search";
            txt_TimKiemKH.Size = new Size(332, 38);
            txt_TimKiemKH.TabIndex = 7;
            // 
            // dtg_KhachHang
            // 
            dtg_KhachHang.BackgroundColor = SystemColors.ActiveCaption;
            dtg_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_KhachHang.Dock = DockStyle.Fill;
            dtg_KhachHang.Location = new Point(3, 23);
            dtg_KhachHang.Name = "dtg_KhachHang";
            dtg_KhachHang.RowHeadersWidth = 51;
            dtg_KhachHang.RowTemplate.Height = 29;
            dtg_KhachHang.Size = new Size(1781, 357);
            dtg_KhachHang.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 194);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(txt_TimKiemKH);
            groupBox2.Controls.Add(btn_Del);
            groupBox2.Location = new Point(1446, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 168);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Services";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(panel1);
            groupBox4.Location = new Point(3, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1781, 234);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(dtg_KhachHang);
            groupBox3.Location = new Point(0, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1787, 383);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customers's information";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTenKhachHang);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 208);
            panel1.TabIndex = 4;
            // 
            // Admin_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 678);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "Admin_Customers";
            Text = "Admin_Customers";
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTenKhachHang;
        private TextBox txtSDT;
        private Button btn_Del;
        private Button btn_Update;
        private TextBox txt_TimKiemKH;
        private DataGridView dtg_KhachHang;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Panel panel1;
    }
}