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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vending3));
            Pn_ALL = new Panel();
            Pn_Up = new Panel();
            groupBox7 = new GroupBox();
            dtg_Waitingbill = new DataGridView();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            Dtg_LstProduct = new DataGridView();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            txt_ID = new TextBox();
            txt_name = new TextBox();
            label2 = new Label();
            txt_SoLuong = new TextBox();
            txt_Tong = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txt_Gia = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            Picturebox_Product = new PictureBox();
            pn_Bottom = new Panel();
            groupBox4 = new GroupBox();
            groupBox6 = new GroupBox();
            btn_AddWaitingBill = new Button();
            btn_Delete = new Button();
            btn_clear = new Button();
            btn_update = new Button();
            btn_Add = new Button();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            txt_SDT = new TextBox();
            txt_KhachHang = new TextBox();
            cmb_Sale = new ComboBox();
            txt_CashReceived = new TextBox();
            label8 = new Label();
            btn_ThanhToan = new Button();
            label9 = new Label();
            label12 = new Label();
            label10 = new Label();
            lb_TienThua = new Label();
            label11 = new Label();
            lb_Totalaftersale = new Label();
            lb_Tong = new Label();
            groupBox5 = new GroupBox();
            dtg_Cart = new DataGridView();
            Pn_ALL.SuspendLayout();
            Pn_Up.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Waitingbill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dtg_LstProduct).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picturebox_Product).BeginInit();
            pn_Bottom.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Cart).BeginInit();
            SuspendLayout();
            // 
            // Pn_ALL
            // 
            Pn_ALL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pn_ALL.BackColor = SystemColors.ScrollBar;
            Pn_ALL.Controls.Add(Pn_Up);
            Pn_ALL.Controls.Add(pn_Bottom);
            Pn_ALL.Location = new Point(3, 3);
            Pn_ALL.Name = "Pn_ALL";
            Pn_ALL.Size = new Size(1891, 849);
            Pn_ALL.TabIndex = 0;
            // 
            // Pn_Up
            // 
            Pn_Up.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Pn_Up.BackColor = SystemColors.ScrollBar;
            Pn_Up.Controls.Add(groupBox7);
            Pn_Up.Controls.Add(groupBox1);
            Pn_Up.Controls.Add(groupBox2);
            Pn_Up.Location = new Point(0, 0);
            Pn_Up.Name = "Pn_Up";
            Pn_Up.Size = new Size(1865, 487);
            Pn_Up.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dtg_Waitingbill);
            groupBox7.Controls.Add(dataGridView1);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(858, 0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(616, 487);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Waiting bills";
            // 
            // dtg_Waitingbill
            // 
            dtg_Waitingbill.AllowUserToAddRows = false;
            dtg_Waitingbill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_Waitingbill.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Waitingbill.BorderStyle = BorderStyle.None;
            dtg_Waitingbill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Waitingbill.Dock = DockStyle.Fill;
            dtg_Waitingbill.GridColor = SystemColors.ActiveBorder;
            dtg_Waitingbill.Location = new Point(3, 23);
            dtg_Waitingbill.Name = "dtg_Waitingbill";
            dtg_Waitingbill.ReadOnly = true;
            dtg_Waitingbill.RowHeadersWidth = 51;
            dtg_Waitingbill.RowTemplate.Height = 29;
            dtg_Waitingbill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Waitingbill.Size = new Size(610, 461);
            dtg_Waitingbill.TabIndex = 1;
            dtg_Waitingbill.CellClick += dtg_Waitingbill_CellClick;
            dtg_Waitingbill.Leave += dtg_Waitingbill_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(610, 461);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Dtg_LstProduct);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 487);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "List product";
            // 
            // Dtg_LstProduct
            // 
            Dtg_LstProduct.BackgroundColor = SystemColors.ActiveCaption;
            Dtg_LstProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtg_LstProduct.Dock = DockStyle.Fill;
            Dtg_LstProduct.Location = new Point(3, 23);
            Dtg_LstProduct.Name = "Dtg_LstProduct";
            Dtg_LstProduct.ReadOnly = true;
            Dtg_LstProduct.RowHeadersWidth = 51;
            Dtg_LstProduct.RowTemplate.Height = 29;
            Dtg_LstProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dtg_LstProduct.Size = new Size(852, 461);
            Dtg_LstProduct.TabIndex = 2;
            Dtg_LstProduct.CellClick += Dtg_LstProduct_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel2);
            groupBox2.Controls.Add(panel1);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(1474, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(391, 487);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product details";
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_ID);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_SoLuong);
            panel2.Controls.Add(txt_Tong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_Gia);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 262);
            panel2.TabIndex = 3;
            // 
            // txt_ID
            // 
            txt_ID.Enabled = false;
            txt_ID.Location = new Point(110, 18);
            txt_ID.Name = "txt_ID";
            txt_ID.ReadOnly = true;
            txt_ID.Size = new Size(241, 27);
            txt_ID.TabIndex = 40;
            // 
            // txt_name
            // 
            txt_name.Enabled = false;
            txt_name.Location = new Point(110, 18);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(241, 27);
            txt_name.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 17);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 31;
            label2.Text = "Name:";
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(110, 58);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(241, 27);
            txt_SoLuong.TabIndex = 35;
            txt_SoLuong.TextChanged += txt_SoLuong_TextChanged_1;
            // 
            // txt_Tong
            // 
            txt_Tong.Enabled = false;
            txt_Tong.Location = new Point(110, 148);
            txt_Tong.Name = "txt_Tong";
            txt_Tong.ReadOnly = true;
            txt_Tong.Size = new Size(241, 27);
            txt_Tong.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 57);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 32;
            label3.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 145);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 34;
            label5.Text = "Total:";
            // 
            // txt_Gia
            // 
            txt_Gia.Enabled = false;
            txt_Gia.Location = new Point(110, 102);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.ReadOnly = true;
            txt_Gia.Size = new Size(241, 27);
            txt_Gia.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 100);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 33;
            label4.Text = "Price:";
            // 
            // panel1
            // 
            panel1.Controls.Add(Picturebox_Product);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 274);
            panel1.TabIndex = 33;
            // 
            // Picturebox_Product
            // 
            Picturebox_Product.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Picturebox_Product.Image = (Image)resources.GetObject("Picturebox_Product.Image");
            Picturebox_Product.Location = new Point(40, -3);
            Picturebox_Product.Name = "Picturebox_Product";
            Picturebox_Product.Size = new Size(311, 271);
            Picturebox_Product.SizeMode = PictureBoxSizeMode.StretchImage;
            Picturebox_Product.TabIndex = 32;
            Picturebox_Product.TabStop = false;
            // 
            // pn_Bottom
            // 
            pn_Bottom.BackColor = SystemColors.ActiveCaption;
            pn_Bottom.Controls.Add(groupBox4);
            pn_Bottom.Controls.Add(groupBox5);
            pn_Bottom.Dock = DockStyle.Bottom;
            pn_Bottom.Location = new Point(0, 519);
            pn_Bottom.Name = "pn_Bottom";
            pn_Bottom.Size = new Size(1891, 330);
            pn_Bottom.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(panel3);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(903, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(988, 330);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_AddWaitingBill);
            groupBox6.Controls.Add(btn_Delete);
            groupBox6.Controls.Add(btn_clear);
            groupBox6.Controls.Add(btn_update);
            groupBox6.Controls.Add(btn_Add);
            groupBox6.Location = new Point(6, 13);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(221, 378);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Services";
            // 
            // btn_AddWaitingBill
            // 
            btn_AddWaitingBill.Dock = DockStyle.Top;
            btn_AddWaitingBill.Location = new Point(3, 211);
            btn_AddWaitingBill.Name = "btn_AddWaitingBill";
            btn_AddWaitingBill.Size = new Size(215, 47);
            btn_AddWaitingBill.TabIndex = 24;
            btn_AddWaitingBill.Text = "Add Waiting Bill";
            btn_AddWaitingBill.UseVisualStyleBackColor = true;
            btn_AddWaitingBill.Click += btn_AddWaitingBill_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Dock = DockStyle.Top;
            btn_Delete.Location = new Point(3, 164);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(215, 47);
            btn_Delete.TabIndex = 22;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_clear
            // 
            btn_clear.Dock = DockStyle.Top;
            btn_clear.Location = new Point(3, 117);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(215, 47);
            btn_clear.TabIndex = 21;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_update
            // 
            btn_update.Dock = DockStyle.Top;
            btn_update.Location = new Point(3, 70);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(215, 47);
            btn_update.TabIndex = 20;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Top;
            btn_Add.Location = new Point(3, 23);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(215, 47);
            btn_Add.TabIndex = 19;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(cmb_Sale);
            panel3.Controls.Add(txt_CashReceived);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btn_ThanhToan);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lb_TienThua);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lb_Totalaftersale);
            panel3.Controls.Add(lb_Tong);
            panel3.Location = new Point(233, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 308);
            panel3.TabIndex = 29;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_SDT);
            groupBox3.Controls.Add(txt_KhachHang);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(639, 104);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Customer's information";
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(15, 26);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.PlaceholderText = "Phone Number";
            txt_SDT.Size = new Size(343, 27);
            txt_SDT.TabIndex = 3;
            txt_SDT.Leave += txt_SDT_Leave;
            // 
            // txt_KhachHang
            // 
            txt_KhachHang.Location = new Point(15, 66);
            txt_KhachHang.Name = "txt_KhachHang";
            txt_KhachHang.PlaceholderText = "Customer's name";
            txt_KhachHang.Size = new Size(343, 27);
            txt_KhachHang.TabIndex = 2;
            // 
            // cmb_Sale
            // 
            cmb_Sale.FormattingEnabled = true;
            cmb_Sale.Location = new Point(62, 161);
            cmb_Sale.Name = "cmb_Sale";
            cmb_Sale.Size = new Size(143, 28);
            cmb_Sale.TabIndex = 27;
            cmb_Sale.SelectedIndexChanged += cmb_Sale_SelectedIndexChanged;
            // 
            // txt_CashReceived
            // 
            txt_CashReceived.Location = new Point(443, 157);
            txt_CashReceived.Name = "txt_CashReceived";
            txt_CashReceived.Size = new Size(152, 27);
            txt_CashReceived.TabIndex = 28;
            txt_CashReceived.TextChanged += txt_CashReceived_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 115);
            label8.Name = "label8";
            label8.Size = new Size(49, 25);
            label8.TabIndex = 15;
            label8.Text = "Total";
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.BackColor = Color.ForestGreen;
            btn_ThanhToan.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ThanhToan.ForeColor = Color.White;
            btn_ThanhToan.Location = new Point(335, 237);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(241, 59);
            btn_ThanhToan.TabIndex = 26;
            btn_ThanhToan.Text = "Check out";
            btn_ThanhToan.UseVisualStyleBackColor = false;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 161);
            label9.Name = "label9";
            label9.Size = new Size(44, 25);
            label9.TabIndex = 16;
            label9.Text = "Sale";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(264, 155);
            label12.Name = "label12";
            label12.Size = new Size(120, 25);
            label12.TabIndex = 24;
            label12.Text = "Cash received";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(264, 115);
            label10.Name = "label10";
            label10.Size = new Size(128, 23);
            label10.TabIndex = 17;
            label10.Text = "Total after sale";
            // 
            // lb_TienThua
            // 
            lb_TienThua.AutoSize = true;
            lb_TienThua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TienThua.Location = new Point(451, 200);
            lb_TienThua.Name = "lb_TienThua";
            lb_TienThua.Size = new Size(22, 25);
            lb_TienThua.TabIndex = 23;
            lb_TienThua.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(264, 202);
            label11.Name = "label11";
            label11.Size = new Size(72, 25);
            label11.TabIndex = 18;
            label11.Text = "Change";
            // 
            // lb_Totalaftersale
            // 
            lb_Totalaftersale.AutoSize = true;
            lb_Totalaftersale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Totalaftersale.Location = new Point(451, 117);
            lb_Totalaftersale.Name = "lb_Totalaftersale";
            lb_Totalaftersale.Size = new Size(20, 23);
            lb_Totalaftersale.TabIndex = 22;
            lb_Totalaftersale.Text = "0";
            // 
            // lb_Tong
            // 
            lb_Tong.AutoSize = true;
            lb_Tong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Tong.Location = new Point(92, 115);
            lb_Tong.Name = "lb_Tong";
            lb_Tong.Size = new Size(22, 25);
            lb_Tong.TabIndex = 20;
            lb_Tong.Text = "0";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dtg_Cart);
            groupBox5.Dock = DockStyle.Left;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(903, 330);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Cart";
            // 
            // dtg_Cart
            // 
            dtg_Cart.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Cart.Dock = DockStyle.Fill;
            dtg_Cart.Location = new Point(3, 23);
            dtg_Cart.Name = "dtg_Cart";
            dtg_Cart.ReadOnly = true;
            dtg_Cart.RowHeadersWidth = 51;
            dtg_Cart.RowTemplate.Height = 29;
            dtg_Cart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Cart.Size = new Size(897, 304);
            dtg_Cart.TabIndex = 13;
            dtg_Cart.CellClick += dtg_Cart_CellClick;
            // 
            // Vending3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1882, 853);
            Controls.Add(Pn_ALL);
            Name = "Vending3";
            Text = "Vending3";
            Load += Vending3_Load;
            Pn_ALL.ResumeLayout(false);
            Pn_Up.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Waitingbill).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Dtg_LstProduct).EndInit();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Picturebox_Product).EndInit();
            pn_Bottom.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Cart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pn_ALL;
        private Panel pn_Bottom;
        private Panel Pn_Up;
        private GroupBox groupBox1;
        private DataGridView Dtg_LstProduct;
        private GroupBox groupBox2;
        private ComboBox cmb_Sale;
        private GroupBox groupBox3;
        private TextBox txt_SDT;
        private TextBox txt_KhachHang;
        private GroupBox groupBox5;
        private DataGridView dtg_Cart;
        private GroupBox groupBox6;
        private Button btn_update;
        private Button btn_Add;
        private GroupBox groupBox4;
        private Button btn_ThanhToan;
        private Label label12;
        private Label lb_TienThua;
        private Label lb_Totalaftersale;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox Picturebox_Product;
        private TextBox txt_CashReceived;
        private Label lb_Tong;
        private Label label8;
        private Button btn_clear;
        private Button btn_Delete;
        private Button btn_addwaitingcart;
        private Button btn_AddWaitingBill;
        private Panel panel2;
        private TextBox txt_ID;
        private TextBox txt_name;
        private Label label2;
        private TextBox txt_SoLuong;
        private TextBox txt_Tong;
        private Label label3;
        private Label label5;
        private TextBox txt_Gia;
        private Label label4;
        private Panel panel1;
        private GroupBox groupBox7;
        private DataGridView dataGridView1;
        private Panel panel3;
        private DataGridView dtg_Waitingbill;
    }
}