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
            panel1.Size = new Size(1344, 336);
            panel1.TabIndex = 0;
            // 
            // dtpk_EndDate
            // 
            dtpk_EndDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_EndDate.Location = new Point(454, 192);
            dtpk_EndDate.Margin = new Padding(4);
            dtpk_EndDate.Name = "dtpk_EndDate";
            dtpk_EndDate.Size = new Size(336, 34);
            dtpk_EndDate.TabIndex = 75;
            // 
            // dtpk_StartDate
            // 
            dtpk_StartDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpk_StartDate.Location = new Point(454, 139);
            dtpk_StartDate.Margin = new Padding(4);
            dtpk_StartDate.Name = "dtpk_StartDate";
            dtpk_StartDate.Size = new Size(336, 34);
            dtpk_StartDate.TabIndex = 74;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 82);
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
            txt_MinBill.Location = new Point(454, 245);
            txt_MinBill.Margin = new Padding(4);
            txt_MinBill.Name = "txt_MinBill";
            txt_MinBill.Size = new Size(336, 34);
            txt_MinBill.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 259);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 65;
            label4.Text = "Min bill : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 206);
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
            txt_TenSale.Location = new Point(454, 90);
            txt_TenSale.Margin = new Padding(4);
            txt_TenSale.Name = "txt_TenSale";
            txt_TenSale.Size = new Size(336, 34);
            txt_TenSale.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 62;
            label2.Text = "Start date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 100);
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
            groupBox1.Location = new Point(0, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 330);
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
            dtg_Sale.Size = new Size(1781, 297);
            dtg_Sale.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Add);
            groupBox2.Controls.Add(btn_Update);
            groupBox2.Controls.Add(txt_Search);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(1374, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 348);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Services";
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
            // 
            // txt_Search
            // 
            txt_Search.BackColor = SystemColors.Info;
            txt_Search.Dock = DockStyle.Bottom;
            txt_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Search.Location = new Point(3, 311);
            txt_Search.Margin = new Padding(4);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Search";
            txt_Search.Size = new Size(407, 34);
            txt_Search.TabIndex = 76;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1787, 678);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Sale";
            Text = "Sale";
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
    }
}