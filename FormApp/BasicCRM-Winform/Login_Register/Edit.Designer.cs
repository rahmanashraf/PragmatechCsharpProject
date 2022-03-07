namespace Login_Register
{
    partial class Edit
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
            this.Edit_Mail = new System.Windows.Forms.TextBox();
            this.Edit_Pass = new System.Windows.Forms.TextBox();
            this.Edit_Save = new System.Windows.Forms.Button();
            this.Edit_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Edit_Mail
            // 
            this.Edit_Mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Edit_Mail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Edit_Mail.Location = new System.Drawing.Point(147, 82);
            this.Edit_Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_Mail.Name = "Edit_Mail";
            this.Edit_Mail.Size = new System.Drawing.Size(148, 26);
            this.Edit_Mail.TabIndex = 0;
            // 
            // Edit_Pass
            // 
            this.Edit_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Edit_Pass.Location = new System.Drawing.Point(147, 142);
            this.Edit_Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_Pass.Name = "Edit_Pass";
            this.Edit_Pass.Size = new System.Drawing.Size(148, 26);
            this.Edit_Pass.TabIndex = 1;
            // 
            // Edit_Save
            // 
            this.Edit_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Edit_Save.Location = new System.Drawing.Point(147, 205);
            this.Edit_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_Save.Name = "Edit_Save";
            this.Edit_Save.Size = new System.Drawing.Size(80, 35);
            this.Edit_Save.TabIndex = 2;
            this.Edit_Save.Text = "Save";
            this.Edit_Save.UseVisualStyleBackColor = false;
            this.Edit_Save.Click += new System.EventHandler(this.Edit_Save_Click);
            // 
            // Edit_Exit
            // 
            this.Edit_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.Edit_Exit.Location = new System.Drawing.Point(236, 205);
            this.Edit_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_Exit.Name = "Edit_Exit";
            this.Edit_Exit.Size = new System.Drawing.Size(62, 35);
            this.Edit_Exit.TabIndex = 3;
            this.Edit_Exit.Text = "Exit";
            this.Edit_Exit.UseVisualStyleBackColor = false;
            this.Edit_Exit.Click += new System.EventHandler(this.Edit_Exit_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Register.Properties.Resources.aa8d58b4_9389_4288_845a_7423129915b3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 325);
            this.Controls.Add(this.Edit_Exit);
            this.Controls.Add(this.Edit_Save);
            this.Controls.Add(this.Edit_Pass);
            this.Controls.Add(this.Edit_Mail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Edit_Mail;
        private System.Windows.Forms.TextBox Edit_Pass;
        private System.Windows.Forms.Button Edit_Save;
        private System.Windows.Forms.Button Edit_Exit;
    }
}