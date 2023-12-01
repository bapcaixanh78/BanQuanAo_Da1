namespace PRL.Forms
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            panel1 = new Panel();
            txt_MoTa = new TextBox();
            label5 = new Label();
            dtpk_EndDate = new DateTimePicker();
            dtpk_StartDate = new DateTimePicker();
            pictureBox1 = new PictureBox();
            txt_MinBill = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_TenSale = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtg_Sale = new DataGridView();
            groupBox2 = new GroupBox();
            btn_Delete = new Button();
            btn_Add = new Button();
            btn_Update = new Button();
            txt_Search = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Sale).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_MoTa);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpk_EndDate);
            panel1.Controls.Add(dtpk_StartDate);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txt_MinBill);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_TenSale);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1344, 360);
            panel1.TabIndex = 0;
            // 
            // txt_MoTa
            // 
            txt_MoTa.Location = new Point(470, 243);
            txt_MoTa.Name = "txt_MoTa";
            txt_MoTa.Size = new Size(336, 27);
            txt_MoTa.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 246);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 76;
            label5.Text = "Mô tả:";
            // 
            // dtpk_EndDate
            // 
            dtpk_EndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_EndDate.Location = new Point(470, 128);
            dtpk_EndDate.Margin = new Padding(4);
            dtpk_EndDate.Name = "dtpk_EndDate";
            dtpk_EndDate.Size = new Size(336, 34);
            dtpk_EndDate.TabIndex = 75;
            // 
            // dtpk_StartDate
            // 
            dtpk_StartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_StartDate.Location = new Point(470, 75);
            dtpk_StartDate.Margin = new Padding(4);
            dtpk_StartDate.Name = "dtpk_StartDate";
            dtpk_StartDate.Size = new Size(336, 34);
            dtpk_StartDate.TabIndex = 74;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // txt_MinBill
            // 
            txt_MinBill.BackColor = SystemColors.Info;
            txt_MinBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MinBill.Location = new Point(470, 181);
            txt_MinBill.Margin = new Padding(4);
            txt_MinBill.Name = "txt_MinBill";
            txt_MinBill.Size = new Size(336, 34);
            txt_MinBill.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 65;
            label4.Text = "Min bill : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 64;
            label3.Text = "End date : ";
            // 
            // txt_TenSale
            // 
            txt_TenSale.BackColor = SystemColors.Info;
            txt_TenSale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TenSale.Location = new Point(470, 26);
            txt_TenSale.Margin = new Padding(4);
            txt_TenSale.Name = "txt_TenSale";
            txt_TenSale.Size = new Size(336, 34);
            txt_TenSale.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 62;
            label2.Text = "Start date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 61;
            label1.Text = "Sales' name : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_Sale);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 378);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 300);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales' information";
            // 
            // dtg_Sale
            // 
            dtg_Sale.BackgroundColor = SystemColors.ActiveCaption;
            dtg_Sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Sale.Dock = DockStyle.Fill;
            dtg_Sale.Location = new Point(3, 30);
            dtg_Sale.Name = "dtg_Sale";
            dtg_Sale.RowHeadersWidth = 51;
            dtg_Sale.RowTemplate.Height = 29;
            dtg_Sale.Size = new Size(1781, 267);
            dtg_Sale.TabIndex = 0;
            dtg_Sale.CellClick += dtg_Sale_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Delete);
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(txt_Search);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1374, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 378);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Services";
            // 
            // btn_Delete
            // 
            btn_Delete.Dock = DockStyle.Top;
            btn_Delete.Location = new Point(3, 154);
            btn_Delete.Margin = new Padding(4);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(407, 62);
            btn_Delete.TabIndex = 79;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Add
            // 
            btn_Add.Dock = DockStyle.Top;
            btn_Add.Location = new Point(3, 92);
            btn_Add.Margin = new Padding(4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(407, 62);
            btn_Add.TabIndex = 77;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Update
            // 
            btn_Update.Dock = DockStyle.Top;
            btn_Update.Location = new Point(3, 30);
            btn_Update.Margin = new Padding(4);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(407, 62);
            btn_Update.TabIndex = 78;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_Search
            // 
            txt_Search.BackColor = SystemColors.Info;
            txt_Search.Dock = DockStyle.Bottom;
            txt_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.Location = new Point(3, 341);
            txt_Search.Margin = new Padding(4);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Search";
            txt_Search.Size = new Size(407, 34);
            txt_Search.TabIndex = 76;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1787, 678);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Sale";
            Text = "Sale";
            Load += Sale_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_Sale).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dtpk_EndDate;
        private DateTimePicker dtpk_StartDate;
        private PictureBox pictureBox1;
        private TextBox txt_MinBill;
        private Label label4;
        private Label label3;
        private TextBox txt_TenSale;
        private Label label2;
        private Label label1;
        private TextBox txt_Search;
        private DataGridView dtg_Sale;
        private Button btn_Add;
        private Button btn_Update;
        private TextBox txt_MoTa;
        private Label label5;
        private Button btn_Delete;
    }
}