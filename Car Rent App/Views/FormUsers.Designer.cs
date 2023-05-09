namespace Car_Rent_App.Views
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lb_users = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbChatGpt = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.btn_AllCar = new System.Windows.Forms.Button();
            this.btnAddCars = new System.Windows.Forms.Button();
            this.dataGV_users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_users)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panelHeader.Controls.Add(this.btnLogOut);
            this.panelHeader.Controls.Add(this.lb_users);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(934, 84);
            this.panelHeader.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(737, 22);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 36);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lb_users
            // 
            this.lb_users.AutoSize = true;
            this.lb_users.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_users.ForeColor = System.Drawing.Color.White;
            this.lb_users.Location = new System.Drawing.Point(339, 16);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(173, 34);
            this.lb_users.TabIndex = 0;
            this.lb_users.Text = "Page of users";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panelFooter.Controls.Add(this.lbChatGpt);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 653);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(934, 80);
            this.panelFooter.TabIndex = 5;
            // 
            // lbChatGpt
            // 
            this.lbChatGpt.AutoSize = true;
            this.lbChatGpt.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbChatGpt.ForeColor = System.Drawing.Color.White;
            this.lbChatGpt.Location = new System.Drawing.Point(270, 17);
            this.lbChatGpt.Name = "lbChatGpt";
            this.lbChatGpt.Size = new System.Drawing.Size(249, 34);
            this.lbChatGpt.TabIndex = 1;
            this.lbChatGpt.Text = "Powered by ChatGpt";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Controls.Add(this.btnSearchCar);
            this.panelSideMenu.Controls.Add(this.btn_AllCar);
            this.panelSideMenu.Controls.Add(this.btnAddCars);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 84);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(190, 569);
            this.panelSideMenu.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnSearchCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCar.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSearchCar.ForeColor = System.Drawing.Color.White;
            this.btnSearchCar.Location = new System.Drawing.Point(12, 329);
            this.btnSearchCar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(165, 54);
            this.btnSearchCar.TabIndex = 3;
            this.btnSearchCar.Text = "Search Car";
            this.btnSearchCar.UseVisualStyleBackColor = false;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // btn_AllCar
            // 
            this.btn_AllCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btn_AllCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AllCar.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_AllCar.ForeColor = System.Drawing.Color.White;
            this.btn_AllCar.Location = new System.Drawing.Point(12, 244);
            this.btn_AllCar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_AllCar.Name = "btn_AllCar";
            this.btn_AllCar.Size = new System.Drawing.Size(165, 54);
            this.btn_AllCar.TabIndex = 1;
            this.btn_AllCar.Text = "All Car";
            this.btn_AllCar.UseVisualStyleBackColor = false;
            this.btn_AllCar.Click += new System.EventHandler(this.btn_AllCar_Click);
            // 
            // btnAddCars
            // 
            this.btnAddCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnAddCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCars.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddCars.ForeColor = System.Drawing.Color.White;
            this.btnAddCars.Location = new System.Drawing.Point(12, 158);
            this.btnAddCars.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddCars.Name = "btnAddCars";
            this.btnAddCars.Size = new System.Drawing.Size(165, 54);
            this.btnAddCars.TabIndex = 0;
            this.btnAddCars.Text = "Add Car";
            this.btnAddCars.UseVisualStyleBackColor = false;
            this.btnAddCars.Click += new System.EventHandler(this.btnAddCars_Click);
            // 
            // dataGV_users
            // 
            this.dataGV_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_users.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV_users.Location = new System.Drawing.Point(190, 171);
            this.dataGV_users.Name = "dataGV_users";
            this.dataGV_users.RowTemplate.Height = 25;
            this.dataGV_users.Size = new System.Drawing.Size(744, 482);
            this.dataGV_users.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(226, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t forget choose a row for updating";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(686, 110);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 733);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGV_users);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelHeader;
        private Button btnLogOut;
        private Label lb_users;
        private Panel panelFooter;
        private Label lbChatGpt;
        private Panel panelSideMenu;
        private PictureBox pictureBox1;
        private Button btnSearchCar;
        private Button btn_AllCar;
        private Button btnAddCars;
        private DataGridView dataGV_users;
        private Label label1;
        private Button btnUpdate;
    }
}