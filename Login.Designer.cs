namespace Transport_mgmt
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb2_username = new System.Windows.Forms.Label();
            this.lb3_username = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn1_login = new System.Windows.Forms.Button();
            this.btn2_reset = new System.Windows.Forms.Button();
            this.btn3_registration = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login_Form";
            // 
            // lb2_username
            // 
            this.lb2_username.AutoSize = true;
            this.lb2_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb2_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2_username.Location = new System.Drawing.Point(569, 62);
            this.lb2_username.Name = "lb2_username";
            this.lb2_username.Size = new System.Drawing.Size(98, 22);
            this.lb2_username.TabIndex = 1;
            this.lb2_username.Text = "Username:";
            // 
            // lb3_username
            // 
            this.lb3_username.AutoSize = true;
            this.lb3_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb3_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3_username.Location = new System.Drawing.Point(569, 111);
            this.lb3_username.Name = "lb3_username";
            this.lb3_username.Size = new System.Drawing.Size(93, 22);
            this.lb3_username.TabIndex = 2;
            this.lb3_username.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_password.Location = new System.Drawing.Point(733, 113);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(138, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_username.Location = new System.Drawing.Point(733, 64);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(138, 20);
            this.txt_username.TabIndex = 4;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // btn1_login
            // 
            this.btn1_login.BackColor = System.Drawing.Color.BurlyWood;
            this.btn1_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1_login.Location = new System.Drawing.Point(594, 242);
            this.btn1_login.Name = "btn1_login";
            this.btn1_login.Size = new System.Drawing.Size(82, 33);
            this.btn1_login.TabIndex = 5;
            this.btn1_login.Text = "Login";
            this.btn1_login.UseVisualStyleBackColor = false;
            this.btn1_login.Click += new System.EventHandler(this.btn1_login_Click);
            // 
            // btn2_reset
            // 
            this.btn2_reset.BackColor = System.Drawing.Color.BurlyWood;
            this.btn2_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_reset.Location = new System.Drawing.Point(706, 321);
            this.btn2_reset.Name = "btn2_reset";
            this.btn2_reset.Size = new System.Drawing.Size(82, 33);
            this.btn2_reset.TabIndex = 6;
            this.btn2_reset.Text = "Reset";
            this.btn2_reset.UseVisualStyleBackColor = false;
            this.btn2_reset.Click += new System.EventHandler(this.btn2_reset_Click);
            // 
            // btn3_registration
            // 
            this.btn3_registration.BackColor = System.Drawing.Color.BurlyWood;
            this.btn3_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3_registration.Location = new System.Drawing.Point(818, 242);
            this.btn3_registration.Name = "btn3_registration";
            this.btn3_registration.Size = new System.Drawing.Size(122, 33);
            this.btn3_registration.TabIndex = 7;
            this.btn3_registration.Text = "Registration";
            this.btn3_registration.UseVisualStyleBackColor = false;
            this.btn3_registration.Click += new System.EventHandler(this.btn3_registration_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(52, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 437);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Transport_mgmt.Properties.Resources.login_img;
            this.pictureBox1.Location = new System.Drawing.Point(57, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn3_registration);
            this.Controls.Add(this.btn2_reset);
            this.Controls.Add(this.btn1_login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lb3_username);
            this.Controls.Add(this.lb2_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb2_username;
        private System.Windows.Forms.Label lb3_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn1_login;
        private System.Windows.Forms.Button btn2_reset;
        private System.Windows.Forms.Button btn3_registration;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}