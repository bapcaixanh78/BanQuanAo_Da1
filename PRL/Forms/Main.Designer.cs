namespace PRL.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            grb_DN = new GroupBox();
            ptr_DN = new PictureBox();
            txt_TenDN = new TextBox();
            button1 = new Button();
            txt_MK = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_DN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptr_DN).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-8, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(903, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // grb_DN
            // 
            grb_DN.BackColor = Color.White;
            grb_DN.Controls.Add(ptr_DN);
            grb_DN.Controls.Add(txt_TenDN);
            grb_DN.Controls.Add(button1);
            grb_DN.Controls.Add(txt_MK);
            grb_DN.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            grb_DN.Location = new Point(12, 12);
            grb_DN.Name = "grb_DN";
            grb_DN.Size = new Size(346, 344);
            grb_DN.TabIndex = 8;
            grb_DN.TabStop = false;
            grb_DN.Text = "Đăng nhập";
            // 
            // ptr_DN
            // 
            ptr_DN.Image = (Image)resources.GetObject("ptr_DN.Image");
            ptr_DN.Location = new Point(130, 35);
            ptr_DN.Name = "ptr_DN";
            ptr_DN.Size = new Size(119, 104);
            ptr_DN.SizeMode = PictureBoxSizeMode.StretchImage;
            ptr_DN.TabIndex = 4;
            ptr_DN.TabStop = false;
            // 
            // txt_TenDN
            // 
            txt_TenDN.Location = new Point(53, 163);
            txt_TenDN.Name = "txt_TenDN";
            txt_TenDN.PlaceholderText = "Tên đăng nhập";
            txt_TenDN.Size = new Size(272, 25);
            txt_TenDN.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(142, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_MK
            // 
            txt_MK.Location = new Point(53, 214);
            txt_MK.Name = "txt_MK";
            txt_MK.PlaceholderText = "Mật khẩu";
            txt_MK.Size = new Size(272, 25);
            txt_MK.TabIndex = 1;
            txt_MK.UseSystemPasswordChar = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(893, 386);
            Controls.Add(grb_DN);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Main";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grb_DN.ResumeLayout(false);
            grb_DN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptr_DN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox grb_DN;
        private PictureBox ptr_DN;
        private TextBox txt_TenDN;
        private Button button1;
        private TextBox txt_MK;
    }
}