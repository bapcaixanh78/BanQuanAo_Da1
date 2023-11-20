namespace PRL.Forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label6 = new Label();
            btn_Login = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btn_Exit = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(53, 614);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 9;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.RoyalBlue;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.ForeColor = SystemColors.ButtonHighlight;
            btn_Login.Location = new Point(43, 515);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(324, 35);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 414);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 325);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(97, 236);
            label2.Name = "label2";
            label2.Size = new Size(217, 31);
            label2.TabIndex = 2;
            label2.Text = "Welcome back !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(147, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_Exit);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(txt_Username);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 674);
            panel1.TabIndex = 1;
            // 
            // btn_Exit
            // 
            btn_Exit.Dock = DockStyle.Bottom;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.ForeColor = Color.Black;
            btn_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Exit.Location = new Point(0, 629);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(431, 45);
            btn_Exit.TabIndex = 16;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            btn_Exit.MouseLeave += btn_Exit_MouseLeave;
            btn_Exit.MouseMove += btn_Exit_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(320, 438);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(320, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(53, 438);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = "pass";
            txt_Password.Size = new Size(261, 27);
            txt_Password.TabIndex = 12;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(53, 349);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = "usernamehere";
            txt_Username.Size = new Size(261, 27);
            txt_Username.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(147, 157);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 10;
            label5.Text = "Shirt Haven";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 674);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Button btn_Login;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox2;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private PictureBox pictureBox3;
        private Button btn_Exit;
    }
}