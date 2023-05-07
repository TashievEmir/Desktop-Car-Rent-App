namespace Car_Rent_App.Views
{
    partial class FormAuthentificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthentificate));
            this.panelAuth = new System.Windows.Forms.Panel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pb_car = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.panelAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_car)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAuth
            // 
            this.panelAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelAuth.Controls.Add(this.btnSignup);
            this.panelAuth.Controls.Add(this.btnSignIn);
            this.panelAuth.Controls.Add(this.pb_car);
            this.panelAuth.Controls.Add(this.label2);
            this.panelAuth.Controls.Add(this.lbEmail);
            this.panelAuth.Controls.Add(this.lbWelcome);
            this.panelAuth.Controls.Add(this.tbpassword);
            this.panelAuth.Controls.Add(this.tbemail);
            this.panelAuth.Location = new System.Drawing.Point(50, 40);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(500, 500);
            this.panelAuth.TabIndex = 0;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(252, 417);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(91, 35);
            this.btnSignup.TabIndex = 7;
            this.btnSignup.Text = "SignUp";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(106, 417);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(90, 35);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.Text = "SignIn";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pb_car
            // 
            this.pb_car.Image = ((System.Drawing.Image)(resources.GetObject("pb_car.Image")));
            this.pb_car.Location = new System.Drawing.Point(39, 151);
            this.pb_car.Name = "pb_car";
            this.pb_car.Size = new System.Drawing.Size(183, 168);
            this.pb_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_car.TabIndex = 5;
            this.pb_car.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(252, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbEmail.Location = new System.Drawing.Point(252, 151);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(79, 32);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Comic Sans MS", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbWelcome.Location = new System.Drawing.Point(185, 45);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(131, 38);
            this.lbWelcome.TabIndex = 2;
            this.lbWelcome.Text = "Welcome";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(252, 295);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(131, 24);
            this.tbpassword.TabIndex = 1;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(252, 197);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(131, 24);
            this.tbemail.TabIndex = 0;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // FormAuthentificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panelAuth);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAuthentificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuthentificate";
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_car)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAuth;
        private Button btnSignup;
        private Button btnSignIn;
        private PictureBox pb_car;
        private Label label2;
        private Label lbEmail;
        private Label lbWelcome;
        private TextBox tbpassword;
        private TextBox tbemail;
    }
}