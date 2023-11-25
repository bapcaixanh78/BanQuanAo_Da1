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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txt_Search = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dtg_KhachHang = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 302);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer's information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txt_Search
            // 
            txt_Search.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_Search.BackColor = SystemColors.Info;
            txt_Search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.Location = new Point(501, 96);
            txt_Search.Multiline = true;
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Type here";
            txt_Search.Size = new Size(906, 44);
            txt_Search.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(373, 96);
            label1.Name = "label1";
            label1.Size = new Size(122, 38);
            label1.TabIndex = 4;
            label1.Text = "Search : ";
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
        private TextBox txt_Search;
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