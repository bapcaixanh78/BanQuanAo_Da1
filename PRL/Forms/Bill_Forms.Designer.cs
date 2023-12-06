namespace PRL.Forms
{
    partial class Bill_Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Forms));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lb_NgayBan = new Label();
            dtg_Bill = new DataGridView();
            label6 = new Label();
            lb_TongTienPhaiTra = new Label();
            label8 = new Label();
            lb_TongTienGiam = new Label();
            label10 = new Label();
            lb_TienKhachTra = new Label();
            label12 = new Label();
            lb_TienThua = new Label();
            label14 = new Label();
            label15 = new Label();
            lb_NguoiBan = new Label();
            label17 = new Label();
            btn_XuatFile = new Button();
            btn_Out = new Button();
            label5 = new Label();
            lb_nguoimua = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Bill).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(436, 35);
            label1.Name = "label1";
            label1.Size = new Size(225, 39);
            label1.TabIndex = 1;
            label1.Text = "Shirt Haven";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(509, 86);
            label2.Name = "label2";
            label2.Size = new Size(223, 26);
            label2.TabIndex = 2;
            label2.Text = "Bring you a comfy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(332, 112);
            label3.Name = "label3";
            label3.Size = new Size(316, 46);
            label3.TabIndex = 3;
            label3.Text = "Hóa đơn bán hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 191);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 4;
            label4.Text = "Ngày bán : ";
            // 
            // lb_NgayBan
            // 
            lb_NgayBan.AutoSize = true;
            lb_NgayBan.Location = new Point(720, 191);
            lb_NgayBan.Name = "lb_NgayBan";
            lb_NgayBan.Size = new Size(50, 20);
            lb_NgayBan.TabIndex = 5;
            lb_NgayBan.Text = "label5";
            // 
            // dtg_Bill
            // 
            dtg_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Bill.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Bill.Location = new Point(12, 289);
            dtg_Bill.Name = "dtg_Bill";
            dtg_Bill.RowHeadersWidth = 51;
            dtg_Bill.RowTemplate.Height = 29;
            dtg_Bill.Size = new Size(939, 127);
            dtg_Bill.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 441);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 8;
            label6.Text = "Tổng tiền phải thanh toán : ";
            // 
            // lb_TongTienPhaiTra
            // 
            lb_TongTienPhaiTra.AutoSize = true;
            lb_TongTienPhaiTra.Location = new Point(720, 441);
            lb_TongTienPhaiTra.Name = "lb_TongTienPhaiTra";
            lb_TongTienPhaiTra.Size = new Size(50, 20);
            lb_TongTienPhaiTra.TabIndex = 9;
            lb_TongTienPhaiTra.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 481);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 10;
            label8.Text = "Tổng tiền đã giảm : ";
            // 
            // lb_TongTienGiam
            // 
            lb_TongTienGiam.AutoSize = true;
            lb_TongTienGiam.Location = new Point(720, 481);
            lb_TongTienGiam.Name = "lb_TongTienGiam";
            lb_TongTienGiam.Size = new Size(50, 20);
            lb_TongTienGiam.TabIndex = 11;
            lb_TongTienGiam.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 521);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 12;
            label10.Text = "Tiền khách trả : ";
            // 
            // lb_TienKhachTra
            // 
            lb_TienKhachTra.AutoSize = true;
            lb_TienKhachTra.Location = new Point(720, 521);
            lb_TienKhachTra.Name = "lb_TienKhachTra";
            lb_TienKhachTra.Size = new Size(58, 20);
            lb_TienKhachTra.TabIndex = 13;
            lb_TienKhachTra.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 561);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 14;
            label12.Text = "Tiền trả lại : ";
            // 
            // lb_TienThua
            // 
            lb_TienThua.AutoSize = true;
            lb_TienThua.Location = new Point(720, 561);
            lb_TienThua.Name = "lb_TienThua";
            lb_TienThua.Size = new Size(58, 20);
            lb_TienThua.TabIndex = 15;
            lb_TienThua.Text = "label13";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(315, 599);
            label14.Name = "label14";
            label14.Size = new Size(374, 56);
            label14.TabIndex = 16;
            label14.Text = "---Cảm ơn quý khách và hẹn gặp lại---\r\n\r\n";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 221);
            label15.Name = "label15";
            label15.Size = new Size(91, 20);
            label15.TabIndex = 17;
            label15.Text = "Người bán : ";
            // 
            // lb_NguoiBan
            // 
            lb_NguoiBan.AutoSize = true;
            lb_NguoiBan.Location = new Point(720, 221);
            lb_NguoiBan.Name = "lb_NguoiBan";
            lb_NguoiBan.Size = new Size(58, 20);
            lb_NguoiBan.TabIndex = 18;
            lb_NguoiBan.Text = "label16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(436, 644);
            label17.Name = "label17";
            label17.Size = new Size(141, 20);
            label17.TabIndex = 19;
            label17.Text = "Hotline : 123456789";
            // 
            // btn_XuatFile
            // 
            btn_XuatFile.Image = (Image)resources.GetObject("btn_XuatFile.Image");
            btn_XuatFile.ImageAlign = ContentAlignment.MiddleLeft;
            btn_XuatFile.Location = new Point(315, 678);
            btn_XuatFile.Name = "btn_XuatFile";
            btn_XuatFile.Size = new Size(109, 50);
            btn_XuatFile.TabIndex = 20;
            btn_XuatFile.Text = "Xuất file";
            btn_XuatFile.TextAlign = ContentAlignment.MiddleRight;
            btn_XuatFile.UseVisualStyleBackColor = true;
            btn_XuatFile.Click += btn_XuatFile_Click;
            // 
            // btn_Out
            // 
            btn_Out.Image = (Image)resources.GetObject("btn_Out.Image");
            btn_Out.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Out.Location = new Point(622, 678);
            btn_Out.Name = "btn_Out";
            btn_Out.Size = new Size(110, 50);
            btn_Out.TabIndex = 21;
            btn_Out.Text = "Đóng";
            btn_Out.TextAlign = ContentAlignment.MiddleRight;
            btn_Out.UseVisualStyleBackColor = true;
            btn_Out.Click += btn_Out_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 22;
            label5.Text = "Tên khách hàng:";
            // 
            // lb_nguoimua
            // 
            lb_nguoimua.AutoSize = true;
            lb_nguoimua.Location = new Point(720, 254);
            lb_nguoimua.Name = "lb_nguoimua";
            lb_nguoimua.Size = new Size(58, 20);
            lb_nguoimua.TabIndex = 23;
            lb_nguoimua.Text = "label16";
            // 
            // Bill_Forms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(962, 751);
            Controls.Add(lb_nguoimua);
            Controls.Add(label5);
            Controls.Add(btn_Out);
            Controls.Add(btn_XuatFile);
            Controls.Add(label17);
            Controls.Add(lb_NguoiBan);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(lb_TienThua);
            Controls.Add(label12);
            Controls.Add(lb_TienKhachTra);
            Controls.Add(label10);
            Controls.Add(lb_TongTienGiam);
            Controls.Add(label8);
            Controls.Add(lb_TongTienPhaiTra);
            Controls.Add(label6);
            Controls.Add(dtg_Bill);
            Controls.Add(lb_NgayBan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill_Forms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill_Forms";
            Load += Bill_Forms_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_Bill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lb_NgayBan;
        private DataGridView dtg_Bill;
        private Label label6;
        private Label lb_TongTienPhaiTra;
        private Label label8;
        private Label lb_TongTienGiam;
        private Label label10;
        private Label lb_TienKhachTra;
        private Label label12;
        private Label lb_TienThua;
        private Label label14;
        private Label label15;
        private Label lb_NguoiBan;
        private Label label17;
        private Button btn_XuatFile;
        private Button btn_Out;
        private Label label5;
        private Label lb_nguoimua;
    }
}