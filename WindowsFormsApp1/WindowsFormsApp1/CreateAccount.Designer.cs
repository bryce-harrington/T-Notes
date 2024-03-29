﻿namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.confirm_icon = new System.Windows.Forms.PictureBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.email_icon = new System.Windows.Forms.PictureBox();
            this.btnCreateAnAccount = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.password_icon = new System.Windows.Forms.PictureBox();
            this.usrname_icon = new System.Windows.Forms.PictureBox();
            this.CreateAccount_lable = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Tnotes_lable = new System.Windows.Forms.Label();
            this.shsu_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shsu_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.confirm_icon);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.email_icon);
            this.panel1.Controls.Add(this.btnCreateAnAccount);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtCreatePassword);
            this.panel1.Controls.Add(this.password_icon);
            this.panel1.Controls.Add(this.usrname_icon);
            this.panel1.Location = new System.Drawing.Point(137, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 233);
            this.panel1.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.textEmail.Location = new System.Drawing.Point(50, 62);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(243, 20);
            this.textEmail.TabIndex = 14;
            this.textEmail.Text = "Email";
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(50, 137);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(243, 20);
            this.txtConfirmPassword.TabIndex = 13;
            this.txtConfirmPassword.Text = "Confirm Your Password";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // confirm_icon
            // 
            this.confirm_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.confirm_icon.BackColor = System.Drawing.Color.Transparent;
            this.confirm_icon.Image = ((System.Drawing.Image)(resources.GetObject("confirm_icon.Image")));
            this.confirm_icon.Location = new System.Drawing.Point(20, 138);
            this.confirm_icon.Name = "confirm_icon";
            this.confirm_icon.Size = new System.Drawing.Size(20, 20);
            this.confirm_icon.TabIndex = 12;
            this.confirm_icon.TabStop = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtLastName.Location = new System.Drawing.Point(167, 25);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 23);
            this.txtLastName.TabIndex = 11;
            this.txtLastName.Text = "Last Name";
            // 
            // email_icon
            // 
            this.email_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.email_icon.BackColor = System.Drawing.Color.Transparent;
            this.email_icon.Image = ((System.Drawing.Image)(resources.GetObject("email_icon.Image")));
            this.email_icon.Location = new System.Drawing.Point(20, 66);
            this.email_icon.Name = "email_icon";
            this.email_icon.Size = new System.Drawing.Size(20, 15);
            this.email_icon.TabIndex = 9;
            this.email_icon.TabStop = false;
            // 
            // btnCreateAnAccount
            // 
            this.btnCreateAnAccount.AutoSize = true;
            this.btnCreateAnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(142)))), ((int)(((byte)(30)))));
            this.btnCreateAnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.btnCreateAnAccount.Location = new System.Drawing.Point(19, 179);
            this.btnCreateAnAccount.Name = "btnCreateAnAccount";
            this.btnCreateAnAccount.Size = new System.Drawing.Size(274, 29);
            this.btnCreateAnAccount.TabIndex = 8;
            this.btnCreateAnAccount.Text = "Create Account";
            this.btnCreateAnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAnAccount.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtFirstName.Location = new System.Drawing.Point(50, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(111, 23);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.Text = "First Name";
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(173)))), ((int)(((byte)(223)))));
            this.txtCreatePassword.Location = new System.Drawing.Point(50, 99);
            this.txtCreatePassword.Multiline = true;
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.PasswordChar = '*';
            this.txtCreatePassword.Size = new System.Drawing.Size(243, 20);
            this.txtCreatePassword.TabIndex = 3;
            this.txtCreatePassword.Text = "Password";
            this.txtCreatePassword.UseSystemPasswordChar = true;
            // 
            // password_icon
            // 
            this.password_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password_icon.BackColor = System.Drawing.Color.Transparent;
            this.password_icon.Image = ((System.Drawing.Image)(resources.GetObject("password_icon.Image")));
            this.password_icon.Location = new System.Drawing.Point(21, 100);
            this.password_icon.Name = "password_icon";
            this.password_icon.Size = new System.Drawing.Size(17, 20);
            this.password_icon.TabIndex = 1;
            this.password_icon.TabStop = false;
            // 
            // usrname_icon
            // 
            this.usrname_icon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.usrname_icon.BackColor = System.Drawing.Color.Transparent;
            this.usrname_icon.Image = ((System.Drawing.Image)(resources.GetObject("usrname_icon.Image")));
            this.usrname_icon.Location = new System.Drawing.Point(21, 26);
            this.usrname_icon.Name = "usrname_icon";
            this.usrname_icon.Size = new System.Drawing.Size(17, 20);
            this.usrname_icon.TabIndex = 2;
            this.usrname_icon.TabStop = false;
            // 
            // CreateAccount_lable
            // 
            this.CreateAccount_lable.AutoSize = true;
            this.CreateAccount_lable.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccount_lable.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.CreateAccount_lable.Location = new System.Drawing.Point(178, 61);
            this.CreateAccount_lable.Name = "CreateAccount_lable";
            this.CreateAccount_lable.Size = new System.Drawing.Size(217, 37);
            this.CreateAccount_lable.TabIndex = 7;
            this.CreateAccount_lable.Text = "Create Account";
            this.CreateAccount_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(85, 84);
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            // 
            // Tnotes_lable
            // 
            this.Tnotes_lable.AutoSize = true;
            this.Tnotes_lable.BackColor = System.Drawing.Color.Transparent;
            this.Tnotes_lable.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnotes_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(240)))));
            this.Tnotes_lable.Location = new System.Drawing.Point(230, 30);
            this.Tnotes_lable.Name = "Tnotes_lable";
            this.Tnotes_lable.Size = new System.Drawing.Size(120, 37);
            this.Tnotes_lable.TabIndex = 8;
            this.Tnotes_lable.Text = "T-Notes";
            // 
            // shsu_icon
            // 
            this.shsu_icon.BackColor = System.Drawing.Color.Transparent;
            this.shsu_icon.Image = ((System.Drawing.Image)(resources.GetObject("shsu_icon.Image")));
            this.shsu_icon.Location = new System.Drawing.Point(515, 341);
            this.shsu_icon.Name = "shsu_icon";
            this.shsu_icon.Size = new System.Drawing.Size(35, 30);
            this.shsu_icon.TabIndex = 9;
            this.shsu_icon.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 383);
            this.Controls.Add(this.shsu_icon);
            this.Controls.Add(this.Tnotes_lable);
            this.Controls.Add(this.CreateAccount_lable);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "T-Notes  |  Create An Account ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirm_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.email_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrname_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shsu_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox confirm_icon;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.PictureBox email_icon;
        private System.Windows.Forms.Button btnCreateAnAccount;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.PictureBox password_icon;
        private System.Windows.Forms.PictureBox usrname_icon;
        private System.Windows.Forms.Label CreateAccount_lable;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Tnotes_lable;
        private System.Windows.Forms.PictureBox shsu_icon;
        private System.Windows.Forms.TextBox textEmail;
    }
}