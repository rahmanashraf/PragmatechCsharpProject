﻿namespace Login_Register
{
    partial class Register
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
            this.Registr_Exit = new System.Windows.Forms.Button();
            this.Registr_Clear = new System.Windows.Forms.Button();
            this.Registr_Signup = new System.Windows.Forms.Button();
            this.Registr_Name = new System.Windows.Forms.TextBox();
            this.Registr_Email = new System.Windows.Forms.TextBox();
            this.Registr_Surname = new System.Windows.Forms.TextBox();
            this.Passwordunyazisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Registr_Exit
            // 
            this.Registr_Exit.BackgroundImage = global::Login_Register.Properties.Resources.png_clipart_symbolize_x_thumbnail;
            this.Registr_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registr_Exit.Location = new System.Drawing.Point(1135, 12);
            this.Registr_Exit.Name = "Registr_Exit";
            this.Registr_Exit.Size = new System.Drawing.Size(41, 29);
            this.Registr_Exit.TabIndex = 0;
            this.Registr_Exit.UseVisualStyleBackColor = true;
            this.Registr_Exit.Click += new System.EventHandler(this.Registr_Exit_Click);
            // 
            // Registr_Clear
            // 
            this.Registr_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Registr_Clear.Location = new System.Drawing.Point(520, 340);
            this.Registr_Clear.Name = "Registr_Clear";
            this.Registr_Clear.Size = new System.Drawing.Size(87, 39);
            this.Registr_Clear.TabIndex = 1;
            this.Registr_Clear.Text = "Back";
            this.Registr_Clear.UseVisualStyleBackColor = false;
            this.Registr_Clear.Click += new System.EventHandler(this.Registr_Clear_Click);
            // 
            // Registr_Signup
            // 
            this.Registr_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Registr_Signup.Location = new System.Drawing.Point(613, 340);
            this.Registr_Signup.Name = "Registr_Signup";
            this.Registr_Signup.Size = new System.Drawing.Size(86, 39);
            this.Registr_Signup.TabIndex = 2;
            this.Registr_Signup.Text = "Sign Up";
            this.Registr_Signup.UseVisualStyleBackColor = false;
            this.Registr_Signup.Click += new System.EventHandler(this.Registr_Signup_Click);
            // 
            // Registr_Name
            // 
            this.Registr_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Registr_Name.Location = new System.Drawing.Point(520, 183);
            this.Registr_Name.Name = "Registr_Name";
            this.Registr_Name.Size = new System.Drawing.Size(179, 26);
            this.Registr_Name.TabIndex = 3;
            this.Registr_Name.Text = "Name";
            this.Registr_Name.Enter += new System.EventHandler(this.Registr_Name_Enter);
            this.Registr_Name.Leave += new System.EventHandler(this.Registr_Name_Leave);
            // 
            // Registr_Email
            // 
            this.Registr_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Registr_Email.Location = new System.Drawing.Point(520, 282);
            this.Registr_Email.Name = "Registr_Email";
            this.Registr_Email.Size = new System.Drawing.Size(179, 26);
            this.Registr_Email.TabIndex = 4;
            this.Registr_Email.Text = "E-mail";
            this.Registr_Email.Enter += new System.EventHandler(this.Registr_Email_Enter);
            this.Registr_Email.Leave += new System.EventHandler(this.Registr_Email_Leave);
            // 
            // Registr_Surname
            // 
            this.Registr_Surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Registr_Surname.Location = new System.Drawing.Point(520, 236);
            this.Registr_Surname.Name = "Registr_Surname";
            this.Registr_Surname.Size = new System.Drawing.Size(179, 26);
            this.Registr_Surname.TabIndex = 5;
            this.Registr_Surname.Text = "Surname";
            this.Registr_Surname.Enter += new System.EventHandler(this.Registr_Surname_Enter);
            this.Registr_Surname.Leave += new System.EventHandler(this.Registr_Surname_Leave);
            // 
            // Passwordunyazisi
            // 
            this.Passwordunyazisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Passwordunyazisi.Location = new System.Drawing.Point(929, 252);
            this.Passwordunyazisi.Name = "Passwordunyazisi";
            this.Passwordunyazisi.Size = new System.Drawing.Size(176, 26);
            this.Passwordunyazisi.TabIndex = 6;
   
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Register.Properties.Resources.aa8d58b4_9389_4288_845a_7423129915b3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 584);
            this.Controls.Add(this.Passwordunyazisi);
            this.Controls.Add(this.Registr_Surname);
            this.Controls.Add(this.Registr_Email);
            this.Controls.Add(this.Registr_Name);
            this.Controls.Add(this.Registr_Signup);
            this.Controls.Add(this.Registr_Clear);
            this.Controls.Add(this.Registr_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registr_Exit;
        private System.Windows.Forms.Button Registr_Clear;
        private System.Windows.Forms.Button Registr_Signup;
        private System.Windows.Forms.TextBox Registr_Name;
        private System.Windows.Forms.TextBox Registr_Email;
        private System.Windows.Forms.TextBox Registr_Surname;
        private System.Windows.Forms.TextBox Passwordunyazisi;
    }
}