namespace Login_Register
{
    partial class EnteringUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edit_butt = new System.Windows.Forms.Button();
            this.edit_pass = new System.Windows.Forms.TextBox();
            this.edit_email = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Login_Register.Properties.Resources.png_clipart_symbolize_x_thumbnail;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1142, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.button3.BackgroundImage = global::Login_Register.Properties.Resources._362_3620680_delete_icon_png_download_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1102, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 45);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.groupBox1.Controls.Add(this.edit_butt);
            this.groupBox1.Controls.Add(this.edit_pass);
            this.groupBox1.Controls.Add(this.edit_email);
            this.groupBox1.Location = new System.Drawing.Point(910, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 258);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // edit_butt
            // 
            this.edit_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(125)))), ((int)(((byte)(1)))));
            this.edit_butt.Location = new System.Drawing.Point(120, 179);
            this.edit_butt.Name = "edit_butt";
            this.edit_butt.Size = new System.Drawing.Size(75, 34);
            this.edit_butt.TabIndex = 2;
            this.edit_butt.Text = "Save";
            this.edit_butt.UseVisualStyleBackColor = false;
            // 
            // edit_pass
            // 
            this.edit_pass.Location = new System.Drawing.Point(44, 108);
            this.edit_pass.Name = "edit_pass";
            this.edit_pass.Size = new System.Drawing.Size(159, 26);
            this.edit_pass.TabIndex = 1;
            // 
            // edit_email
            // 
            this.edit_email.Location = new System.Drawing.Point(44, 56);
            this.edit_email.Name = "edit_email";
            this.edit_email.Size = new System.Drawing.Size(159, 26);
            this.edit_email.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 106);
            this.dataGridView1.TabIndex = 7;
            // 
            // EnteringUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Register.Properties.Resources.aa8d58b4_9389_4288_845a_7423129915b3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1188, 584);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnteringUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnteringUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button edit_butt;
        private System.Windows.Forms.TextBox edit_pass;
        private System.Windows.Forms.TextBox edit_email;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}