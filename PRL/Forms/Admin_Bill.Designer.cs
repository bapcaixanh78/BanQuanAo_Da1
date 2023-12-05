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
            dtg_SanPham = new DataGridView();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            btn_Search = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpk_Loc = new DateTimePicker();
            pictureBox1 = new PictureBox();
            txt_TimKiemSP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtg_SanPham
            // 
            dtg_SanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_SanPham.BackgroundColor = SystemColors.ActiveCaption;
            dtg_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_SanPham.Dock = DockStyle.Fill;
            dtg_SanPham.Location = new Point(3, 23);
            dtg_SanPham.Name = "dtg_SanPham";
            dtg_SanPham.RowHeadersWidth = 51;
            dtg_SanPham.RowTemplate.Height = 29;
            dtg_SanPham.Size = new Size(1781, 374);
            dtg_SanPham.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(dtg_SanPham);
            groupBox1.Location = new Point(0, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1787, 400);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bill's information";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Search);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtpk_Loc);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txt_TimKiemSP);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1787, 272);
            panel2.TabIndex = 0;
            // 
            // btn_Search
            // 
            btn_Search.FlatAppearance.BorderSize = 0;
            btn_Search.Location = new Point(1322, 89);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(154, 74);
            btn_Search.TabIndex = 41;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(428, 60);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 40;
            label2.Text = "Search:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(428, 147);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 39;
            label1.Text = "Fillter by time:";
            // 
            // dtpk_Loc
            // 
            dtpk_Loc.Location = new Point(692, 147);
            dtpk_Loc.Name = "dtpk_Loc";
            dtpk_Loc.Size = new Size(250, 27);
            dtpk_Loc.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // txt_TimKiemSP
            // 
            txt_TimKiemSP.BackColor = SystemColors.Info;
            txt_TimKiemSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_TimKiemSP.Location = new Point(692, 50);
            txt_TimKiemSP.Multiline = true;
            txt_TimKiemSP.Name = "txt_TimKiemSP";
            txt_TimKiemSP.PlaceholderText = "Search";
            txt_TimKiemSP.Size = new Size(549, 38);
            txt_TimKiemSP.TabIndex = 36;
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
            ((System.ComponentModel.ISupportInitialize)dtg_SanPham).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtg_SanPham;
        private GroupBox groupBox1;
        private Panel panel2;
        private TextBox txt_TimKiemSP;
        private PictureBox pictureBox1;
        private DateTimePicker dtpk_Loc;
        private Label label2;
        private Label label1;
        private Button btn_Search;
    }
}