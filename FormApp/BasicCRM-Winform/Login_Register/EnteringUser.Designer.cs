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
            this.button2 = new System.Windows.Forms.Button();
            this.Tablom = new System.Windows.Forms.TableLayoutPanel();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Login_Register.Properties.Resources.png_clipart_symbolize_x_thumbnail;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(764, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Melumatlari Goster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tablom
            // 
            this.Tablom.ColumnCount = 6;
            this.Tablom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.20513F));
            this.Tablom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.79487F));
            this.Tablom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.Tablom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Tablom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.Tablom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.Tablom.Location = new System.Drawing.Point(0, 71);
            this.Tablom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tablom.Name = "Tablom";
            this.Tablom.RowCount = 1;
            this.Tablom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.Tablom.Size = new System.Drawing.Size(798, 43);
            this.Tablom.TabIndex = 3;
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackgroundImage = global::Login_Register.Properties.Resources.edit;
            this.Edit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit_Button.Location = new System.Drawing.Point(684, 123);
            this.Edit_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(45, 45);
            this.Edit_Button.TabIndex = 4;
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Login_Register.Properties.Resources._362_3620680_delete_icon_png_download_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(736, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 45);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EnteringUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login_Register.Properties.Resources.aa8d58b4_9389_4288_845a_7423129915b3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.Tablom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnteringUser";
            this.Text = "EnteringUser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel Tablom;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button button3;
    }
}