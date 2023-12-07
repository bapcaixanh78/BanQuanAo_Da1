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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(436, 149);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 47;
            label2.Text = "End date:";
            // 
            // dtpk_end
            // 
            dtpk_end.Location = new Point(700, 151);
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
            btn_Search.Location = new Point(1038, 95);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(105, 83);
            btn_Search.TabIndex = 45;
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(436, 95);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 39;
            label1.Text = "Start date:";
            // 
            // dtpk_start
            // 
            dtpk_start.Location = new Point(700, 95);
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
        private Label label3;
        private Button btn_Search;
        private Label label2;
        private DateTimePicker dtpk_end;
    }
}