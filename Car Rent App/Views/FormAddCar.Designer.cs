namespace Car_Rent_App.Views
{
    partial class FormAddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCar));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lb_AddCar = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbChatGpt = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btn_searchCar = new System.Windows.Forms.Button();
            this.btnAllCars = new System.Windows.Forms.Button();
            this.tb_brand = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.cbIsAvailable = new System.Windows.Forms.ComboBox();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbAvailability = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelHeader.Size = new System.Drawing.Size(834, 70);
            this.panelHeader.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(676, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(96, 40);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lb_AddCar
            // 
            this.lb_AddCar.AutoSize = true;
            this.lb_AddCar.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_AddCar.ForeColor = System.Drawing.Color.White;
            this.lb_AddCar.Location = new System.Drawing.Point(270, 14);
            this.lb_AddCar.Name = "lb_AddCar";
            this.lb_AddCar.Size = new System.Drawing.Size(285, 34);
            this.lb_AddCar.TabIndex = 0;
            this.lb_AddCar.Text = "Page of adding new car";
            this.lb_AddCar.Click += new System.EventHandler(this.lb_AddCar_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(112)))));
            this.panelFooter.Controls.Add(this.lbChatGpt);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 504);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(834, 77);
            this.panelFooter.TabIndex = 2;
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
            this.panelSideMenu.Controls.Add(this.btnAllCars);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 70);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(190, 434);
            this.panelSideMenu.TabIndex = 3;
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
            // btnAllCars
            // 
            this.btnAllCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnAllCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCars.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAllCars.ForeColor = System.Drawing.Color.White;
            this.btnAllCars.Location = new System.Drawing.Point(12, 132);
            this.btnAllCars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllCars.Name = "btnAllCars";
            this.btnAllCars.Size = new System.Drawing.Size(165, 45);
            this.btnAllCars.TabIndex = 0;
            this.btnAllCars.Text = "All Cars";
            this.btnAllCars.UseVisualStyleBackColor = false;
            this.btnAllCars.Click += new System.EventHandler(this.btnAllCars_Click);
            // 
            // tb_brand
            // 
            this.tb_brand.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_brand.Location = new System.Drawing.Point(286, 117);
            this.tb_brand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_brand.Name = "tb_brand";
            this.tb_brand.Size = new System.Drawing.Size(150, 30);
            this.tb_brand.TabIndex = 5;
            // 
            // tbColor
            // 
            this.tbColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tbColor.Location = new System.Drawing.Point(563, 191);
            this.tbColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(146, 30);
            this.tbColor.TabIndex = 7;
            // 
            // tb_Model
            // 
            this.tb_Model.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_Model.Location = new System.Drawing.Point(286, 191);
            this.tb_Model.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.Size = new System.Drawing.Size(150, 30);
            this.tb_Model.TabIndex = 9;
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbIsAvailable.FormattingEnabled = true;
            this.cbIsAvailable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbIsAvailable.Location = new System.Drawing.Point(610, 273);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(135, 31);
            this.cbIsAvailable.TabIndex = 11;
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbBrand.Location = new System.Drawing.Point(219, 117);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(61, 23);
            this.lbBrand.TabIndex = 12;
            this.lbBrand.Text = "Brand:";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbModel.Location = new System.Drawing.Point(219, 194);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(61, 23);
            this.lbModel.TabIndex = 13;
            this.lbModel.Text = "Model:";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbYear.Location = new System.Drawing.Point(502, 117);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(53, 23);
            this.lbYear.TabIndex = 14;
            this.lbYear.Text = "Year:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbColor.Location = new System.Drawing.Point(502, 194);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(55, 23);
            this.lbColor.TabIndex = 15;
            this.lbColor.Text = "Color:";
            // 
            // lbAvailability
            // 
            this.lbAvailability.AutoSize = true;
            this.lbAvailability.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbAvailability.Location = new System.Drawing.Point(502, 276);
            this.lbAvailability.Name = "lbAvailability";
            this.lbAvailability.Size = new System.Drawing.Size(102, 23);
            this.lbAvailability.TabIndex = 16;
            this.lbAvailability.Text = "Availability:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(422, 363);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(561, 114);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker.TabIndex = 17;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.lbPrice.Location = new System.Drawing.Point(219, 276);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(55, 23);
            this.lbPrice.TabIndex = 18;
            this.lbPrice.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tbPrice.Location = new System.Drawing.Point(286, 273);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(150, 30);
            this.tbPrice.TabIndex = 19;
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAvailability);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.cbIsAvailable);
            this.Controls.Add(this.tb_Model);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.tb_brand);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCar";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button btnAllCars;
        private TextBox tb_brand;
        private TextBox tbColor;
        private TextBox tb_Model;
        private ComboBox cbIsAvailable;
        private Label lbBrand;
        private Label lbModel;
        private Label lbYear;
        private Label lbColor;
        private Label lbAvailability;
        private Button btnSave;
        private DateTimePicker dateTimePicker;
        private Label lbPrice;
        private TextBox tbPrice;
    }
}