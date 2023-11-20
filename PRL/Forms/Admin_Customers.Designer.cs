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
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 38);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer's name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone number : ";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(206, 31);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(242, 27);
            txtTenKhachHang.TabIndex = 2;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(206, 78);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(242, 27);
            txtSDT.TabIndex = 3;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(584, 111);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(117, 44);
            btn_Del.TabIndex = 5;
            btn_Del.Text = "Delete";
            btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(584, 31);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(117, 44);
            btn_Update.TabIndex = 6;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiemKH
            // 
            txt_TimKiemKH.Location = new Point(38, 217);
            txt_TimKiemKH.Name = "txt_TimKiemKH";
            txt_TimKiemKH.PlaceholderText = "Search";
            txt_TimKiemKH.Size = new Size(269, 27);
            txt_TimKiemKH.TabIndex = 7;
            // 
            // dtg_KhachHang
            // 
            dtg_KhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_KhachHang.Location = new Point(38, 250);
            dtg_KhachHang.Name = "dtg_KhachHang";
            dtg_KhachHang.RowHeadersWidth = 51;
            dtg_KhachHang.RowTemplate.Height = 29;
            dtg_KhachHang.Size = new Size(663, 205);
            dtg_KhachHang.TabIndex = 8;
            // 
            // Admin_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(dtg_KhachHang);
            Controls.Add(txt_TimKiemKH);
            Controls.Add(btn_Update);
            Controls.Add(btn_Del);
            Controls.Add(txtSDT);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Customers";
            Text = "Admin_Customers";
            ((System.ComponentModel.ISupportInitialize)dtg_KhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}