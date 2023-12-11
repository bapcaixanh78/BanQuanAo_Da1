namespace PRL.Forms
{
    partial class Admin_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Bill));
            dtg_Bill = new DataGridView();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btn_refresh = new Button();
            btn_dathanhtoan = new Button();
            btn_chuathanhtoan = new Button();
            lb_paid = new Label();
            lb_unpaid = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpk_end = new DateTimePicker();
            btn_Search = new Button();
            label1 = new Label();
            dtpk_start = new DateTimePicker();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Bill).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtg_Bill
            // 
            dtg_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Bill.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Bill.Dock = DockStyle.Fill;
            dtg_Bill.Location = new Point(3, 23);
            dtg_Bill.Name = "dtg_Bill";
            dtg_Bill.ReadOnly = true;
            dtg_Bill.RowHeadersWidth = 51;
            dtg_Bill.RowTemplate.Height = 29;
            dtg_Bill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Bill.Size = new Size(1781, 374);
            dtg_Bill.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtg_Bill);
            groupBox1.Location = new Point(0, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 400);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bill's information";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_refresh);
            panel2.Controls.Add(btn_dathanhtoan);
            panel2.Controls.Add(btn_chuathanhtoan);
            panel2.Controls.Add(lb_paid);
            panel2.Controls.Add(lb_unpaid);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpk_end);
            panel2.Controls.Add(btn_Search);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpk_start);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1787, 272);
            panel2.TabIndex = 0;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.Beige;
            btn_refresh.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Image = (Image)resources.GetObject("btn_refresh.Image");
            btn_refresh.Location = new Point(1571, 37);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(105, 83);
            btn_refresh.TabIndex = 57;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_dathanhtoan
            // 
            btn_dathanhtoan.BackColor = Color.LimeGreen;
            btn_dathanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dathanhtoan.ForeColor = SystemColors.ButtonFace;
            btn_dathanhtoan.Location = new Point(1363, 37);
            btn_dathanhtoan.Name = "btn_dathanhtoan";
            btn_dathanhtoan.Size = new Size(202, 83);
            btn_dathanhtoan.TabIndex = 55;
            btn_dathanhtoan.Text = "Payment completed";
            btn_dathanhtoan.UseVisualStyleBackColor = false;
            btn_dathanhtoan.Click += btn_dathanhtoan_Click;
            // 
            // btn_chuathanhtoan
            // 
            btn_chuathanhtoan.BackColor = Color.OrangeRed;
            btn_chuathanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_chuathanhtoan.Location = new Point(1155, 36);
            btn_chuathanhtoan.Name = "btn_chuathanhtoan";
            btn_chuathanhtoan.Size = new Size(202, 83);
            btn_chuathanhtoan.TabIndex = 56;
            btn_chuathanhtoan.Text = "Payment pending";
            btn_chuathanhtoan.UseVisualStyleBackColor = false;
            btn_chuathanhtoan.Click += btn_chuathanhtoan_Click;
            // 
            // lb_paid
            // 
            lb_paid.AutoSize = true;
            lb_paid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_paid.Location = new Point(695, 205);
            lb_paid.Name = "lb_paid";
            lb_paid.Size = new Size(23, 28);
            lb_paid.TabIndex = 54;
            lb_paid.Text = "0";
            // 
            // lb_unpaid
            // 
            lb_unpaid.AutoSize = true;
            lb_unpaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_unpaid.Location = new Point(695, 147);
            lb_unpaid.Name = "lb_unpaid";
            lb_unpaid.Size = new Size(23, 28);
            lb_unpaid.TabIndex = 53;
            lb_unpaid.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(391, 205);
            label4.Name = "label4";
            label4.Size = new Size(230, 28);
            label4.TabIndex = 52;
            label4.Text = "Number of paid invoices:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(391, 147);
            label3.Name = "label3";
            label3.Size = new Size(252, 28);
            label3.TabIndex = 51;
            label3.Text = "Number of unpaid invoices:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(391, 91);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 47;
            label2.Text = "End date:";
            // 
            // dtpk_end
            // 
            dtpk_end.Location = new Point(695, 93);
            dtpk_end.Name = "dtpk_end";
            dtpk_end.Size = new Size(285, 27);
            dtpk_end.TabIndex = 46;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.Beige;
            btn_Search.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Search.ForeColor = Color.White;
            btn_Search.Image = (Image)resources.GetObject("btn_Search.Image");
            btn_Search.Location = new Point(1029, 37);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(105, 82);
            btn_Search.TabIndex = 45;
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(391, 37);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 39;
            label1.Text = "Start date:";
            // 
            // dtpk_start
            // 
            dtpk_start.Location = new Point(695, 37);
            dtpk_start.Name = "dtpk_start";
            dtpk_start.Size = new Size(285, 27);
            dtpk_start.TabIndex = 38;
            dtpk_start.ValueChanged += dtpk_FilterByTime_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // Admin_Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1787, 678);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Name = "Admin_Bill";
            Text = "Admin_Bill";
            ((System.ComponentModel.ISupportInitialize)dtg_Bill).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtg_Bill;
        private GroupBox groupBox1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DateTimePicker dtpk_start;
        private Label label1;
        private ComboBox cmb_FilterbyStaff;
        private Button btn_Search;
        private Label label2;
        private DateTimePicker dtpk_end;
        private Label label4;
        private Label label3;
        private Label lb_paid;
        private Label lb_unpaid;
        private Button btn_dathanhtoan;
        private Button btn_chuathanhtoan;
        private Button btn_refresh;
    }
}