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
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).BeginInit();
            SuspendLayout();
            // 
            // dtg_SanPham
            // 
            dtg_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SanPham.Location = new Point(27, 394);
            dtg_SanPham.Name = "dtg_SanPham";
            dtg_SanPham.RowHeadersWidth = 51;
            dtg_SanPham.RowTemplate.Height = 29;
            dtg_SanPham.Size = new Size(740, 216);
            dtg_SanPham.TabIndex = 17;
            // 
            // txt_TimKiemSP
            // 
            txt_TimKiemSP.Location = new Point(69, 361);
            txt_TimKiemSP.Name = "txt_TimKiemSP";
            txt_TimKiemSP.PlaceholderText = "Search";
            txt_TimKiemSP.Size = new Size(269, 27);
            txt_TimKiemSP.TabIndex = 16;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(615, 92);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(117, 44);
            btn_Update.TabIndex = 15;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(615, 166);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(117, 44);
            btn_Del.TabIndex = 14;
            btn_Del.Text = "Delete";
            btn_Del.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(615, 11);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(117, 44);
            btn_Add.TabIndex = 13;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(237, 86);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(242, 27);
            txtGiaNhap.TabIndex = 12;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(237, 43);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(242, 27);
            txtTenHang.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 86);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 10;
            label2.Text = "Entry price : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 43);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 9;
            label1.Text = "Product's name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 129);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 18;
            label3.Text = "Price : ";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(237, 129);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(242, 27);
            txtGiaBan.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 172);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 20;
            label4.Text = "Quantity : ";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(237, 172);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(242, 27);
            txt_SoLuong.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 301);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 22;
            label5.Text = "Description :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 215);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 24;
            label6.Text = "Color :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 258);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 25;
            label7.Text = "Size :";
            // 
            // cmb_Color
            // 
            cmb_Color.FormattingEnabled = true;
            cmb_Color.Location = new Point(237, 215);
            cmb_Color.Name = "cmb_Color";
            cmb_Color.Size = new Size(242, 28);
            cmb_Color.TabIndex = 26;
            // 
            // cmb_Size
            // 
            cmb_Size.FormattingEnabled = true;
            cmb_Size.Location = new Point(237, 258);
            cmb_Size.Name = "cmb_Size";
            cmb_Size.Size = new Size(242, 28);
            cmb_Size.TabIndex = 27;
            // 
            // rtxt_MoTa
            // 
            rtxt_MoTa.Location = new Point(237, 300);
            rtxt_MoTa.Name = "rtxt_MoTa";
            rtxt_MoTa.Size = new Size(242, 40);
            rtxt_MoTa.TabIndex = 28;
            rtxt_MoTa.Text = "";
            // 
            // Admin_Products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 622);
            Controls.Add(rtxt_MoTa);
            Controls.Add(cmb_Size);
            Controls.Add(cmb_Color);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_SoLuong);
            Controls.Add(label4);
            Controls.Add(txtGiaBan);
            Controls.Add(label3);
            Controls.Add(dtg_SanPham);
            Controls.Add(txt_TimKiemSP);
            Controls.Add(btn_Update);
            Controls.Add(btn_Del);
            Controls.Add(btn_Add);
            Controls.Add(txtGiaNhap);
            Controls.Add(txtTenHang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Products";
            Text = "Admin_Products";
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}