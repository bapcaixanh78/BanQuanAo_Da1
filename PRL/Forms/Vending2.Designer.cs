namespace PRL.Forms
{
    partial class Vending2
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
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            txt_SDT = new TextBox();
            txt_KhachHang = new TextBox();
            groupBox2 = new GroupBox();
            cmb_Sale = new ComboBox();
            rtxt_Name = new RichTextBox();
            label2 = new Label();
            label6 = new Label();
            txt_SoLuong = new TextBox();
            txt_Tong = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txt_Gia = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            dtg_Vending = new DataGridView();
            panel4 = new Panel();
            groupBox4 = new GroupBox();
            btn_ThanhToan = new Button();
            lb_TienKhachTra = new Label();
            label12 = new Label();
            lb_TienThua = new Label();
            lb_TienPhaiTra = new Label();
            lb_Sale = new Label();
            lb_Tong = new Label();
            lb_SoLuong = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox6 = new GroupBox();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_Add = new Button();
            groupBox5 = new GroupBox();
            dtg_GioHang = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Vending).BeginInit();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1563, 711);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(43, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(1520, 301);
            panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_SDT);
            groupBox3.Controls.Add(txt_KhachHang);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1520, 104);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer's information";
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(6, 59);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.PlaceholderText = "Phone Number";
            txt_SDT.Size = new Size(318, 27);
            txt_SDT.TabIndex = 3;
            // 
            // txt_KhachHang
            // 
            txt_KhachHang.Location = new Point(6, 26);
            txt_KhachHang.Name = "txt_KhachHang";
            txt_KhachHang.PlaceholderText = "Customer's name";
            txt_KhachHang.Size = new Size(318, 27);
            txt_KhachHang.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmb_Sale);
            groupBox2.Controls.Add(rtxt_Name);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_SoLuong);
            groupBox2.Controls.Add(txt_Tong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_Gia);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(593, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 302);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product details";
            // 
            // cmb_Sale
            // 
            cmb_Sale.FormattingEnabled = true;
            cmb_Sale.Location = new Point(84, 213);
            cmb_Sale.Name = "cmb_Sale";
            cmb_Sale.Size = new Size(230, 28);
            cmb_Sale.TabIndex = 27;
            // 
            // rtxt_Name
            // 
            rtxt_Name.Location = new Point(84, 37);
            rtxt_Name.Name = "rtxt_Name";
            rtxt_Name.Size = new Size(230, 27);
            rtxt_Name.TabIndex = 21;
            rtxt_Name.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 17;
            label2.Text = "Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 216);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 26;
            label6.Text = "Sale";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(84, 77);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(230, 27);
            txt_SoLuong.TabIndex = 23;
            // 
            // txt_Tong
            // 
            txt_Tong.Location = new Point(84, 166);
            txt_Tong.Name = "txt_Tong";
            txt_Tong.Size = new Size(230, 27);
            txt_Tong.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 18;
            label3.Text = "Quantity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 166);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 20;
            label5.Text = "Total :";
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(84, 117);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(230, 27);
            txt_Gia.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 120);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 19;
            label4.Text = "Price :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_Vending);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List product";
            // 
            // dtg_Vending
            // 
            dtg_Vending.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Vending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Vending.Dock = DockStyle.Fill;
            dtg_Vending.Location = new Point(3, 23);
            dtg_Vending.Name = "dtg_Vending";
            dtg_Vending.RowHeadersWidth = 51;
            dtg_Vending.RowTemplate.Height = 29;
            dtg_Vending.Size = new Size(581, 231);
            dtg_Vending.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(groupBox4);
            panel4.Controls.Add(groupBox6);
            panel4.Controls.Add(groupBox5);
            panel4.Location = new Point(0, 365);
            panel4.Name = "panel4";
            panel4.Size = new Size(1563, 346);
            panel4.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_ThanhToan);
            groupBox4.Controls.Add(lb_TienKhachTra);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(lb_TienThua);
            groupBox4.Controls.Add(lb_TienPhaiTra);
            groupBox4.Controls.Add(lb_Sale);
            groupBox4.Controls.Add(lb_Tong);
            groupBox4.Controls.Add(lb_SoLuong);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(923, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(640, 346);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Payment";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.ForestGreen;
            btn_ThanhToan.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.ForeColor = Color.White;
            btn_ThanhToan.Location = new Point(269, 174);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(232, 93);
            btn_ThanhToan.TabIndex = 26;
            btn_ThanhToan.Text = "Payment";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // lb_TienKhachTra
            // 
            lb_TienKhachTra.AutoSize = true;
            lb_TienKhachTra.Location = new Point(571, 86);
            lb_TienKhachTra.Name = "lb_TienKhachTra";
            lb_TienKhachTra.Size = new Size(17, 20);
            lb_TienKhachTra.TabIndex = 25;
            lb_TienKhachTra.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(309, 88);
            label12.Name = "label12";
            label12.Size = new Size(207, 20);
            label12.TabIndex = 24;
            label12.Text = "Cash received from customers";
            // 
            // lb_TienThua
            // 
            lb_TienThua.AutoSize = true;
            lb_TienThua.Location = new Point(571, 135);
            lb_TienThua.Name = "lb_TienThua";
            lb_TienThua.Size = new Size(17, 20);
            lb_TienThua.TabIndex = 23;
            lb_TienThua.Text = "0";
            // 
            // lb_TienPhaiTra
            // 
            lb_TienPhaiTra.AutoSize = true;
            lb_TienPhaiTra.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TienPhaiTra.Location = new Point(571, 42);
            lb_TienPhaiTra.Name = "lb_TienPhaiTra";
            lb_TienPhaiTra.Size = new Size(20, 23);
            lb_TienPhaiTra.TabIndex = 22;
            lb_TienPhaiTra.Text = "0";
            // 
            // lb_Sale
            // 
            lb_Sale.AutoSize = true;
            lb_Sale.Location = new Point(245, 137);
            lb_Sale.Name = "lb_Sale";
            lb_Sale.Size = new Size(17, 20);
            lb_Sale.TabIndex = 21;
            lb_Sale.Text = "0";
            // 
            // lb_Tong
            // 
            lb_Tong.AutoSize = true;
            lb_Tong.Location = new Point(245, 88);
            lb_Tong.Name = "lb_Tong";
            lb_Tong.Size = new Size(17, 20);
            lb_Tong.TabIndex = 20;
            lb_Tong.Text = "0";
            // 
            // lb_SoLuong
            // 
            lb_SoLuong.AutoSize = true;
            lb_SoLuong.Location = new Point(245, 46);
            lb_SoLuong.Name = "lb_SoLuong";
            lb_SoLuong.Size = new Size(17, 20);
            lb_SoLuong.TabIndex = 19;
            lb_SoLuong.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(309, 137);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 18;
            label11.Text = "Change";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(309, 44);
            label10.Name = "label10";
            label10.Size = new Size(173, 23);
            label10.TabIndex = 17;
            label10.Text = "Accounts receivable ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 136);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 16;
            label9.Text = "Sale";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 87);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 15;
            label8.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 45);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 14;
            label7.Text = "Quantity ";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_clear);
            groupBox6.Controls.Add(btn_delete);
            groupBox6.Controls.Add(btn_Add);
            groupBox6.Dock = DockStyle.Left;
            groupBox6.Location = new Point(744, 0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(179, 346);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Services";
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Top;
            btn_clear.Location = new Point(3, 149);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(173, 63);
            btn_clear.TabIndex = 20;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Top;
            btn_delete.Location = new Point(3, 86);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(173, 63);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Top;
            btn_Add.Location = new Point(3, 23);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(173, 63);
            btn_Add.TabIndex = 18;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtg_GioHang);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(744, 346);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Cart";
            // 
            // dtg_GioHang
            // 
            dtg_GioHang.BackgroundColor = SystemColors.ActiveCaption;
            dtg_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_GioHang.Dock = DockStyle.Fill;
            dtg_GioHang.Location = new Point(3, 23);
            dtg_GioHang.Name = "dtg_GioHang";
            dtg_GioHang.RowHeadersWidth = 51;
            dtg_GioHang.RowTemplate.Height = 29;
            dtg_GioHang.Size = new Size(738, 320);
            dtg_GioHang.TabIndex = 13;
            // 
            // Vending2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 711);
            Controls.Add(panel2);
            Name = "Vending2";
            Text = "Vending2";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Vending).EndInit();
            panel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dtg_Vending;
        private GroupBox groupBox2;
        private ComboBox cmb_Sale;
        private RichTextBox rtxt_Name;
        private Label label2;
        private Label label6;
        private TextBox txt_SoLuong;
        private TextBox txt_Tong;
        private Label label3;
        private Label label5;
        private TextBox txt_Gia;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txt_SDT;
        private TextBox txt_KhachHang;
        private GroupBox groupBox4;
        private Label lb_TienKhachTra;
        private Label label12;
        private Label lb_TienThua;
        private Label lb_TienPhaiTra;
        private Label lb_Sale;
        private Label lb_Tong;
        private Label lb_SoLuong;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btn_ThanhToan;
        private Panel panel4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private DataGridView dtg_GioHang;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_Add;
    }
}