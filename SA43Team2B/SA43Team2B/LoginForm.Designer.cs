namespace SA43Team2B
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPromotions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.txtEmployeeID);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblEmployeeID);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(472, 82);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(248, 188);
            this.grpLogin.TabIndex = 8;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Employee Login";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(118, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(92, 38);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(118, 22);
            this.txtEmployeeID.TabIndex = 3;
            this.txtEmployeeID.TextChanged += new System.EventHandler(this.txtEmployeeID_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(5, 42);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(86, 16);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Location = new System.Drawing.Point(74, 136);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 29);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Central Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 51);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(102, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 180);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblPromotions
            // 
            this.lblPromotions.AutoSize = true;
            this.lblPromotions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotions.Location = new System.Drawing.Point(25, 132);
            this.lblPromotions.Name = "lblPromotions";
            this.lblPromotions.Size = new System.Drawing.Size(253, 16);
            this.lblPromotions.TabIndex = 10;
            this.lblPromotions.Text = "Deepawali Holiday on 28th October 2016.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome our new CEO Mr.Lim on 21st October 3:00 PM at Auditorium Hall.";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPromotions);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Welcome to Central Library Maintenace System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPromotions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
    }
}