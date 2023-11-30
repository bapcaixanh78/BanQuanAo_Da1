namespace PRL.Forms
{
    partial class Vending3
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
            Pn_ALL = new Panel();
            Pn_Up = new Panel();
            groupBox3 = new GroupBox();
            txt_SDT = new TextBox();
            txt_KhachHang = new TextBox();
            groupBox2 = new GroupBox();
            txt_name = new TextBox();
            cmb_Sale = new ComboBox();
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
            pn_Bottom = new Panel();
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
            Pn_ALL.SuspendLayout();
            Pn_Up.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Vending).BeginInit();
            pn_Bottom.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).BeginInit();
            SuspendLayout();
            // 
            // Pn_ALL
            // 
            Pn_ALL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pn_ALL.BackColor = SystemColors.ScrollBar;
            Pn_ALL.Controls.Add(Pn_Up);
            Pn_ALL.Controls.Add(pn_Bottom);
            Pn_ALL.Location = new Point(3, 2);
            Pn_ALL.Name = "Pn_ALL";
            Pn_ALL.Size = new Size(1572, 740);
            Pn_ALL.TabIndex = 0;
            // 
            // Pn_Up
            // 
            Pn_Up.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pn_Up.BackColor = SystemColors.ScrollBar;
            Pn_Up.Controls.Add(groupBox3);
            Pn_Up.Controls.Add(groupBox2);
            Pn_Up.Controls.Add(groupBox1);
            Pn_Up.Location = new Point(0, 0);
            Pn_Up.Name = "Pn_Up";
            Pn_Up.Size = new Size(1572, 333);
            Pn_Up.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_SDT);
            groupBox3.Controls.Add(txt_KhachHang);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(923, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(649, 104);
            groupBox3.TabIndex = 3;
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
            groupBox2.Controls.Add(txt_name);
            groupBox2.Controls.Add(cmb_Sale);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_SoLuong);
            groupBox2.Controls.Add(txt_Tong);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_Gia);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(587, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 333);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product details";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(84, 37);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(230, 27);
            txt_name.TabIndex = 28;
            // 
            // cmb_Sale
            // 
            cmb_Sale.FormattingEnabled = true;
            cmb_Sale.Location = new Point(84, 213);
            cmb_Sale.Name = "cmb_Sale";
            cmb_Sale.Size = new Size(230, 28);
            cmb_Sale.TabIndex = 27;
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
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(587, 333);
            groupBox1.TabIndex = 1;
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
            dtg_Vending.Size = new Size(581, 307);
            dtg_Vending.TabIndex = 2;
            // 
            // pn_Bottom
            // 
            pn_Bottom.BackColor = SystemColors.ActiveCaption;
            pn_Bottom.Controls.Add(groupBox4);
            pn_Bottom.Controls.Add(groupBox6);
            pn_Bottom.Controls.Add(groupBox5);
            pn_Bottom.Dock = DockStyle.Bottom;
            pn_Bottom.Location = new Point(0, 354);
            pn_Bottom.Name = "pn_Bottom";
            pn_Bottom.Size = new Size(1572, 386);
            pn_Bottom.TabIndex = 0;
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
            groupBox4.Size = new Size(649, 386);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Payment";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.ForestGreen;
            btn_ThanhToan.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.ForeColor = Color.White;
            btn_ThanhToan.Location = new Point(197, 178);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(243, 75);
            btn_ThanhToan.TabIndex = 26;
            btn_ThanhToan.Text = "Payment";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // lb_TienKhachTra
            // 
            lb_TienKhachTra.AutoSize = true;
            lb_TienKhachTra.Location = new Point(559, 77);
            lb_TienKhachTra.Name = "lb_TienKhachTra";
            lb_TienKhachTra.Size = new Size(17, 20);
            lb_TienKhachTra.TabIndex = 25;
            lb_TienKhachTra.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(297, 79);
            label12.Name = "label12";
            label12.Size = new Size(207, 20);
            label12.TabIndex = 24;
            label12.Text = "Cash received from customers";
            // 
            // lb_TienThua
            // 
            lb_TienThua.AutoSize = true;
            lb_TienThua.Location = new Point(559, 126);
            lb_TienThua.Name = "lb_TienThua";
            lb_TienThua.Size = new Size(17, 20);
            lb_TienThua.TabIndex = 23;
            lb_TienThua.Text = "0";
            // 
            // lb_TienPhaiTra
            // 
            lb_TienPhaiTra.AutoSize = true;
            lb_TienPhaiTra.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TienPhaiTra.Location = new Point(559, 33);
            lb_TienPhaiTra.Name = "lb_TienPhaiTra";
            lb_TienPhaiTra.Size = new Size(20, 23);
            lb_TienPhaiTra.TabIndex = 22;
            lb_TienPhaiTra.Text = "0";
            // 
            // lb_Sale
            // 
            lb_Sale.AutoSize = true;
            lb_Sale.Location = new Point(233, 128);
            lb_Sale.Name = "lb_Sale";
            lb_Sale.Size = new Size(17, 20);
            lb_Sale.TabIndex = 21;
            lb_Sale.Text = "0";
            // 
            // lb_Tong
            // 
            lb_Tong.AutoSize = true;
            lb_Tong.Location = new Point(233, 79);
            lb_Tong.Name = "lb_Tong";
            lb_Tong.Size = new Size(17, 20);
            lb_Tong.TabIndex = 20;
            lb_Tong.Text = "0";
            // 
            // lb_SoLuong
            // 
            lb_SoLuong.AutoSize = true;
            lb_SoLuong.Location = new Point(233, 37);
            lb_SoLuong.Name = "lb_SoLuong";
            lb_SoLuong.Size = new Size(17, 20);
            lb_SoLuong.TabIndex = 19;
            lb_SoLuong.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(297, 128);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 18;
            label11.Text = "Change";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(297, 35);
            label10.Name = "label10";
            label10.Size = new Size(173, 23);
            label10.TabIndex = 17;
            label10.Text = "Accounts receivable ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 127);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 16;
            label9.Text = "Sale";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 78);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 15;
            label8.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 36);
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
            groupBox6.Size = new Size(179, 386);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Services";
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Top;
            btn_clear.Location = new Point(3, 117);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(173, 47);
            btn_clear.TabIndex = 20;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Top;
            btn_delete.Location = new Point(3, 70);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(173, 47);
            btn_delete.TabIndex = 19;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Top;
            btn_Add.Location = new Point(3, 23);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(173, 47);
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
            groupBox5.Size = new Size(744, 386);
            groupBox5.TabIndex = 1;
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
            dtg_GioHang.Size = new Size(738, 360);
            dtg_GioHang.TabIndex = 13;
            // 
            // Vending3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1563, 690);
            Controls.Add(Pn_ALL);
            Name = "Vending3";
            Text = "Vending3";
            Pn_ALL.ResumeLayout(false);
            Pn_Up.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Vending).EndInit();
            pn_Bottom.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pn_ALL;
        private Panel pn_Bottom;
        private Panel Pn_Up;
        private GroupBox groupBox1;
        private DataGridView dtg_Vending;
        private GroupBox groupBox2;
        private ComboBox cmb_Sale;
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
        private GroupBox groupBox5;
        private DataGridView dtg_GioHang;
        private TextBox txt_name;
        private GroupBox groupBox6;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_Add;
        private GroupBox groupBox4;
        private Button btn_ThanhToan;
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
    }
}