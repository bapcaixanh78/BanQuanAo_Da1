namespace PRL.Forms
{
    partial class Admin_Customers2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Customers2));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            btn_Update = new Button();
            txt_TimKiemKH = new TextBox();
            btn_Del = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtTenKhachHang = new TextBox();
            txtSDT = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dtg_KhachHang = new DataGridView();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 302);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(txt_TimKiemKH);
            groupBox2.Controls.Add(btn_Del);
            groupBox2.Location = new Point(1292, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 302);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Services";
            // 
            // btn_Update
            // 
            btn_Update.Dock = DockStyle.Top;
            btn_Update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.Location = new Point(3, 67);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(489, 44);
            btn_Update.TabIndex = 9;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemKH
            // 
            txt_TimKiemKH.BackColor = SystemColors.Info;
            txt_TimKiemKH.Dock = DockStyle.Bottom;
            txt_TimKiemKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiemKH.Location = new Point(3, 247);
            txt_TimKiemKH.Multiline = true;
            txt_TimKiemKH.Name = "txt_TimKiemKH";
            txt_TimKiemKH.PlaceholderText = "Search";
            txt_TimKiemKH.Size = new Size(489, 52);
            txt_TimKiemKH.TabIndex = 10;
            // 
            // btn_Del
            // 
            btn_Del.Dock = DockStyle.Top;
            btn_Del.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Del.Location = new Point(3, 23);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(489, 44);
            btn_Del.TabIndex = 8;
            btn_Del.Text = "Delete";
            btn_Del.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtTenKhachHang);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1292, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer's information";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTenKhachHang.BackColor = SystemColors.Info;
            txtTenKhachHang.Location = new Point(501, 96);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(411, 44);
            txtTenKhachHang.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSDT.BackColor = SystemColors.Info;
            txtSDT.Location = new Point(501, 165);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(411, 41);
            txtSDT.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(333, 165);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 5;
            label2.Text = "Phone number : ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(333, 96);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 4;
            label1.Text = "Customer's name : ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtg_KhachHang);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 302);
            panel2.Name = "panel2";
            panel2.Size = new Size(1787, 376);
            panel2.TabIndex = 1;
            // 
            // dtg_KhachHang
            // 
            dtg_KhachHang.BackgroundColor = SystemColors.ActiveCaption;
            dtg_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_KhachHang.Dock = DockStyle.Fill;
            dtg_KhachHang.Location = new Point(0, 0);
            dtg_KhachHang.Name = "dtg_KhachHang";
            dtg_KhachHang.RowHeadersWidth = 51;
            dtg_KhachHang.RowTemplate.Height = 29;
            dtg_KhachHang.Size = new Size(1787, 376);
            dtg_KhachHang.TabIndex = 9;
            // 
            // Admin_Customers2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 678);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_Customers2";
            Text = "Admin_Customers2";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private TextBox txtTenKhachHang;
        private TextBox txtSDT;
        private Label label2;
        private Label label1;
        private Button btn_Update;
        private TextBox txt_TimKiemKH;
        private Button btn_Del;
        private PictureBox pictureBox1;
        private DataGridView dtg_KhachHang;
    }
}