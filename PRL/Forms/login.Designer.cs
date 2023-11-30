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
            cb_showpass = new CheckBox();
            btn_Exit = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btn_Login.Location = new Point(53, 562);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(324, 49);
            btn_Login.TabIndex = 8;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(53, 413);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 324);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 14.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 251);
            label2.Name = "label2";
            label2.Size = new Size(208, 33);
            label2.TabIndex = 2;
            label2.Text = "Welcome back !";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 120);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cb_showpass);
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
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(496, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 674);
            panel1.TabIndex = 1;
            // 
            // cb_showpass
            // 
            cb_showpass.AutoSize = true;
            cb_showpass.Location = new Point(53, 496);
            cb_showpass.Name = "cb_showpass";
            cb_showpass.Size = new Size(134, 24);
            cb_showpass.TabIndex = 17;
            cb_showpass.Text = "Show password";
            cb_showpass.UseVisualStyleBackColor = true;
            cb_showpass.CheckedChanged += cb_showpass_CheckedChanged;
            // 
            // btn_Exit
            // 
            btn_Exit.Dock = DockStyle.Bottom;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.ForeColor = Color.Black;
            btn_Exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Exit.Location = new Point(0, 625);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(421, 45);
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
            pictureBox3.Location = new Point(350, 437);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(350, 348);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // txt_Password
            // 
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Location = new Point(53, 437);
            txt_Password.Name = "txt_Password";
            txt_Password.PlaceholderText = " Password here...";
            txt_Password.Size = new Size(291, 27);
            txt_Password.TabIndex = 12;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            txt_Username.BorderStyle = BorderStyle.FixedSingle;
            txt_Username.Location = new Point(53, 348);
            txt_Username.Name = "txt_Username";
            txt_Username.PlaceholderText = " Username here...";
            txt_Username.Size = new Size(291, 27);
            txt_Username.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(125, 204);
            label5.Name = "label5";
            label5.Size = new Size(193, 35);
            label5.TabIndex = 10;
            label5.Text = "Shirt Haven";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.Background;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(496, 674);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 674);
            Controls.Add(pictureBox4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private CheckBox cb_showpass;
        private PictureBox pictureBox4;
    }
}