namespace Car_Rent_App.Views
{
    partial class FormAllCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllCars));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lb_AddCar = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbChatGpt = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btn_searchCar = new System.Windows.Forms.Button();
            this.btnAddCars = new System.Windows.Forms.Button();
            this.dataGV_allCars = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_allCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panelHeader.Controls.Add(this.btnLogOut);
            this.panelHeader.Controls.Add(this.lb_AddCar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(854, 70);
            this.panelHeader.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(737, 18);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(85, 30);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lb_AddCar
            // 
            this.lb_AddCar.AutoSize = true;
            this.lb_AddCar.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_AddCar.ForeColor = System.Drawing.Color.White;
            this.lb_AddCar.Location = new System.Drawing.Point(339, 13);
            this.lb_AddCar.Name = "lb_AddCar";
            this.lb_AddCar.Size = new System.Drawing.Size(198, 34);
            this.lb_AddCar.TabIndex = 0;
            this.lb_AddCar.Text = "Page of all cars";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panelFooter.Controls.Add(this.lbChatGpt);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 504);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(854, 77);
            this.panelFooter.TabIndex = 3;
            // 
            // lbChatGpt
            // 
            this.lbChatGpt.AutoSize = true;
            this.lbChatGpt.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbChatGpt.ForeColor = System.Drawing.Color.White;
            this.lbChatGpt.Location = new System.Drawing.Point(270, 14);
            this.lbChatGpt.Name = "lbChatGpt";
            this.lbChatGpt.Size = new System.Drawing.Size(249, 34);
            this.lbChatGpt.TabIndex = 1;
            this.lbChatGpt.Text = "Powered by ChatGpt";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.Controls.Add(this.pictureBox1);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.btn_searchCar);
            this.panelSideMenu.Controls.Add(this.btnAddCars);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 70);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(190, 434);
            this.panelSideMenu.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(12, 274);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(165, 45);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btn_searchCar
            // 
            this.btn_searchCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btn_searchCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchCar.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_searchCar.ForeColor = System.Drawing.Color.White;
            this.btn_searchCar.Location = new System.Drawing.Point(12, 203);
            this.btn_searchCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_searchCar.Name = "btn_searchCar";
            this.btn_searchCar.Size = new System.Drawing.Size(165, 45);
            this.btn_searchCar.TabIndex = 1;
            this.btn_searchCar.Text = "Search Car";
            this.btn_searchCar.UseVisualStyleBackColor = false;
            // 
            // btnAddCars
            // 
            this.btnAddCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnAddCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCars.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddCars.ForeColor = System.Drawing.Color.White;
            this.btnAddCars.Location = new System.Drawing.Point(12, 132);
            this.btnAddCars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCars.Name = "btnAddCars";
            this.btnAddCars.Size = new System.Drawing.Size(165, 45);
            this.btnAddCars.TabIndex = 0;
            this.btnAddCars.Text = "Add Car";
            this.btnAddCars.UseVisualStyleBackColor = false;
            this.btnAddCars.Click += new System.EventHandler(this.btnAddCars_Click);
            // 
            // dataGV_allCars
            // 
            this.dataGV_allCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_allCars.Location = new System.Drawing.Point(196, 73);
            this.dataGV_allCars.Name = "dataGV_allCars";
            this.dataGV_allCars.RowTemplate.Height = 25;
            this.dataGV_allCars.Size = new System.Drawing.Size(646, 265);
            this.dataGV_allCars.TabIndex = 5;
            // 
            // FormAllCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(854, 581);
            this.Controls.Add(this.dataGV_allCars);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAllCars";
            this.Text = "FormAllCars";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_allCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelHeader;
        private Button btnLogOut;
        private Label lb_AddCar;
        private Panel panelFooter;
        private Label lbChatGpt;
        private Panel panelSideMenu;
        private PictureBox pictureBox1;
        private Button btnUsers;
        private Button btn_searchCar;
        private Button btnAddCars;
        private DataGridView dataGV_allCars;
    }
}