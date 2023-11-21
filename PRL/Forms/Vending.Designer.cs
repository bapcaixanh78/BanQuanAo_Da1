namespace PRL.Forms
{
    partial class Vending
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
            panel1 = new Panel();
            txt_TimKiemVending = new TextBox();
            dtg_Vending = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rtxt_Name = new RichTextBox();
            txt_IDVending = new TextBox();
            txt_SoLuong = new TextBox();
            txt_Gia = new TextBox();
            txt_Tong = new TextBox();
            dtg_GioHang = new DataGridView();
            btn_Add = new Button();
            label6 = new Label();
            cmb_Sale = new ComboBox();
            btn_clear = new Button();
            btn_ClearAll = new Button();
            panel2 = new Panel();
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
            txt_SDT = new TextBox();
            txt_KhachHang = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Vending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(txt_TimKiemVending);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1787, 49);
            panel1.TabIndex = 0;
            // 
            // txt_TimKiemVending
            // 
            txt_TimKiemVending.Location = new Point(12, 12);
            txt_TimKiemVending.Name = "txt_TimKiemVending";
            txt_TimKiemVending.PlaceholderText = "Search";
            txt_TimKiemVending.Size = new Size(288, 27);
            txt_TimKiemVending.TabIndex = 0;
            // 
            // dtg_Vending
            // 
            dtg_Vending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Vending.Location = new Point(314, 68);
            dtg_Vending.Name = "dtg_Vending";
            dtg_Vending.RowHeadersWidth = 51;
            dtg_Vending.RowTemplate.Height = 29;
            dtg_Vending.Size = new Size(368, 125);
            dtg_Vending.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 267);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 2;
            label1.Text = "ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 267);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 267);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantity :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(670, 267);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(855, 267);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Total :";
            // 
            // rtxt_Name
            // 
            rtxt_Name.Location = new Point(230, 267);
            rtxt_Name.Name = "rtxt_Name";
            rtxt_Name.Size = new Size(221, 72);
            rtxt_Name.TabIndex = 7;
            rtxt_Name.Text = "";
            // 
            // txt_IDVending
            // 
            txt_IDVending.Location = new Point(46, 267);
            txt_IDVending.Name = "txt_IDVending";
            txt_IDVending.Size = new Size(125, 27);
            txt_IDVending.TabIndex = 8;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(535, 267);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(125, 27);
            txt_SoLuong.TabIndex = 9;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(724, 267);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(125, 27);
            txt_Gia.TabIndex = 10;
            // 
            // txt_Tong
            // 
            txt_Tong.Location = new Point(910, 267);
            txt_Tong.Name = "txt_Tong";
            txt_Tong.Size = new Size(125, 27);
            txt_Tong.TabIndex = 11;
            // 
            // dtg_GioHang
            // 
            dtg_GioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_GioHang.Location = new Point(11, 365);
            dtg_GioHang.Name = "dtg_GioHang";
            dtg_GioHang.RowHeadersWidth = 51;
            dtg_GioHang.RowTemplate.Height = 29;
            dtg_GioHang.Size = new Size(1024, 193);
            dtg_GioHang.TabIndex = 12;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(1160, 365);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(98, 69);
            btn_Add.TabIndex = 13;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1058, 270);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 14;
            label6.Text = "Sale";
            // 
            // cmb_Sale
            // 
            cmb_Sale.FormattingEnabled = true;
            cmb_Sale.Location = new Point(1107, 270);
            cmb_Sale.Name = "cmb_Sale";
            cmb_Sale.Size = new Size(151, 28);
            cmb_Sale.TabIndex = 15;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(1160, 464);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(98, 69);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_ClearAll
            // 
            btn_ClearAll.Location = new Point(1160, 563);
            btn_ClearAll.Name = "btn_ClearAll";
            btn_ClearAll.Size = new Size(98, 69);
            btn_ClearAll.TabIndex = 17;
            btn_ClearAll.Text = "Clear All";
            btn_ClearAll.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_ThanhToan);
            panel2.Controls.Add(lb_TienKhachTra);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lb_TienThua);
            panel2.Controls.Add(lb_TienPhaiTra);
            panel2.Controls.Add(lb_Sale);
            panel2.Controls.Add(lb_Tong);
            panel2.Controls.Add(lb_SoLuong);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_SDT);
            panel2.Controls.Add(txt_KhachHang);
            panel2.Location = new Point(1301, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 629);
            panel2.TabIndex = 18;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.ForestGreen;
            btn_ThanhToan.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.ForeColor = Color.White;
            btn_ThanhToan.Location = new Point(191, 342);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(206, 142);
            btn_ThanhToan.TabIndex = 14;
            btn_ThanhToan.Text = "Payment";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            // 
            // lb_TienKhachTra
            // 
            lb_TienKhachTra.AutoSize = true;
            lb_TienKhachTra.Location = new Point(332, 242);
            lb_TienKhachTra.Name = "lb_TienKhachTra";
            lb_TienKhachTra.Size = new Size(17, 20);
            lb_TienKhachTra.TabIndex = 13;
            lb_TienKhachTra.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 242);
            label12.Name = "label12";
            label12.Size = new Size(207, 20);
            label12.TabIndex = 12;
            label12.Text = "Cash received from customers";
            // 
            // lb_TienThua
            // 
            lb_TienThua.AutoSize = true;
            lb_TienThua.Location = new Point(332, 291);
            lb_TienThua.Name = "lb_TienThua";
            lb_TienThua.Size = new Size(17, 20);
            lb_TienThua.TabIndex = 11;
            lb_TienThua.Text = "0";
            // 
            // lb_TienPhaiTra
            // 
            lb_TienPhaiTra.AutoSize = true;
            lb_TienPhaiTra.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_TienPhaiTra.Location = new Point(332, 198);
            lb_TienPhaiTra.Name = "lb_TienPhaiTra";
            lb_TienPhaiTra.Size = new Size(20, 23);
            lb_TienPhaiTra.TabIndex = 10;
            lb_TienPhaiTra.Text = "0";
            // 
            // lb_Sale
            // 
            lb_Sale.AutoSize = true;
            lb_Sale.Location = new Point(332, 162);
            lb_Sale.Name = "lb_Sale";
            lb_Sale.Size = new Size(17, 20);
            lb_Sale.TabIndex = 9;
            lb_Sale.Text = "0";
            // 
            // lb_Tong
            // 
            lb_Tong.AutoSize = true;
            lb_Tong.Location = new Point(332, 124);
            lb_Tong.Name = "lb_Tong";
            lb_Tong.Size = new Size(17, 20);
            lb_Tong.TabIndex = 8;
            lb_Tong.Text = "0";
            // 
            // lb_SoLuong
            // 
            lb_SoLuong.AutoSize = true;
            lb_SoLuong.Location = new Point(332, 88);
            lb_SoLuong.Name = "lb_SoLuong";
            lb_SoLuong.Size = new Size(17, 20);
            lb_SoLuong.TabIndex = 7;
            lb_SoLuong.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 291);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 6;
            label11.Text = "Change";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 198);
            label10.Name = "label10";
            label10.Size = new Size(173, 23);
            label10.TabIndex = 5;
            label10.Text = "Accounts receivable ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 162);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 4;
            label9.Text = "Sale";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 124);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 3;
            label8.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 88);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 2;
            label7.Text = "Quantity ";
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(12, 39);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.PlaceholderText = "Phone Number";
            txt_SDT.Size = new Size(318, 27);
            txt_SDT.TabIndex = 1;
            // 
            // txt_KhachHang
            // 
            txt_KhachHang.Location = new Point(12, 6);
            txt_KhachHang.Name = "txt_KhachHang";
            txt_KhachHang.PlaceholderText = "Customer's name";
            txt_KhachHang.Size = new Size(318, 27);
            txt_KhachHang.TabIndex = 0;
            // 
            // Vending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1787, 678);
            Controls.Add(panel2);
            Controls.Add(btn_ClearAll);
            Controls.Add(btn_clear);
            Controls.Add(cmb_Sale);
            Controls.Add(label6);
            Controls.Add(btn_Add);
            Controls.Add(dtg_GioHang);
            Controls.Add(txt_Tong);
            Controls.Add(txt_Gia);
            Controls.Add(txt_SoLuong);
            Controls.Add(txt_IDVending);
            Controls.Add(rtxt_Name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_Vending);
            Controls.Add(panel1);
            Name = "Vending";
            Text = "Vending";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Vending).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_GioHang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txt_TimKiemVending;
        private DataGridView dtg_Vending;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox rtxt_Name;
        private TextBox txt_IDVending;
        private TextBox txt_SoLuong;
        private TextBox txt_Gia;
        private TextBox txt_Tong;
        private DataGridView dtg_GioHang;
        private Button btn_Add;
        private Label label6;
        private ComboBox cmb_Sale;
        private Button btn_clear;
        private Button btn_ClearAll;
        private Panel panel2;
        private Label label7;
        private TextBox txt_SDT;
        private TextBox txt_KhachHang;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lb_TienThua;
        private Label lb_TienPhaiTra;
        private Label lb_Sale;
        private Label lb_Tong;
        private Label lb_SoLuong;
        private Label lb_TienKhachTra;
        private Label label12;
        private Button btn_ThanhToan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}