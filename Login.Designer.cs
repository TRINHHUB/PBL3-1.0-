﻿namespace PBL3_1._0_
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
            this.txtTK = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(579, 213);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(191, 28);
            this.txtTK.TabIndex = 12;
            // 
            // button_Register
            // 
            this.button_Register.BackColor = System.Drawing.SystemColors.Info;
            this.button_Register.Location = new System.Drawing.Point(633, 293);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(95, 31);
            this.button_Register.TabIndex = 20;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = false;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click_1);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(579, 247);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(191, 28);
            this.txtMK.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(395, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 57);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome to our store";
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Info;
            this.button_Exit.Location = new System.Drawing.Point(633, 330);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(95, 32);
            this.button_Exit.TabIndex = 15;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click_1);
            // 
            // btnForget
            // 
            this.btnForget.BackColor = System.Drawing.SystemColors.Info;
            this.btnForget.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.Location = new System.Drawing.Point(475, 330);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(117, 31);
            this.btnForget.TabIndex = 19;
            this.btnForget.Text = "Forget Password";
            this.btnForget.UseVisualStyleBackColor = false;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(447, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "PassWord";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(447, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "User";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogin.Location = new System.Drawing.Point(475, 293);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 31);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::PBL3_1._0_.Properties.Resources._671822c2f63dd5f65d8fd15c9710420b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 513);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogin;
    }
}

