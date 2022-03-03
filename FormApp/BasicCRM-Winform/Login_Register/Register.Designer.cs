namespace Login_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Register_NameBox = new System.Windows.Forms.TextBox();
            this.Register_SurnameBox = new System.Windows.Forms.TextBox();
            this.Register_EmailBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register_NameBox
            // 
            this.Register_NameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_NameBox.Location = new System.Drawing.Point(144, 53);
            this.Register_NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.Register_NameBox.Name = "Register_NameBox";
            this.Register_NameBox.Size = new System.Drawing.Size(129, 16);
            this.Register_NameBox.TabIndex = 0;
            this.Register_NameBox.Text = "Name";
            // 
            // Register_SurnameBox
            // 
            this.Register_SurnameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_SurnameBox.Location = new System.Drawing.Point(144, 90);
            this.Register_SurnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.Register_SurnameBox.Name = "Register_SurnameBox";
            this.Register_SurnameBox.Size = new System.Drawing.Size(129, 16);
            this.Register_SurnameBox.TabIndex = 1;
            this.Register_SurnameBox.Text = "Surname";
            // 
            // Register_EmailBox
            // 
            this.Register_EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Register_EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_EmailBox.Location = new System.Drawing.Point(144, 125);
            this.Register_EmailBox.Margin = new System.Windows.Forms.Padding(2);
            this.Register_EmailBox.Name = "Register_EmailBox";
            this.Register_EmailBox.Size = new System.Drawing.Size(129, 16);
            this.Register_EmailBox.TabIndex = 2;
            this.Register_EmailBox.Text = "E-mail";
            this.Register_EmailBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Register_EmailBox.Leave += new System.EventHandler(this.Register_EmailBox_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 158);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Register_EmailBox);
            this.Controls.Add(this.Register_SurnameBox);
            this.Controls.Add(this.Register_NameBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Register_NameBox;
        private System.Windows.Forms.TextBox Register_SurnameBox;
        private System.Windows.Forms.TextBox Register_EmailBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}