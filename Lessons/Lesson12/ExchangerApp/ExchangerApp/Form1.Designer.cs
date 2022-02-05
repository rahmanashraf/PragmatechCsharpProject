namespace ExchangerApp
{
    partial class Form1
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
            this.Pulundeyeri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboFrom = new System.Windows.Forms.ComboBox();
            this.ComboTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Netice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pulundeyeri
            // 
            this.Pulundeyeri.Location = new System.Drawing.Point(240, 55);
            this.Pulundeyeri.Name = "Pulundeyeri";
            this.Pulundeyeri.Size = new System.Drawing.Size(183, 26);
            this.Pulundeyeri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DaxilEt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // ComboFrom
            // 
            this.ComboFrom.FormattingEnabled = true;
            this.ComboFrom.Items.AddRange(new object[] {
            "",
            "Manat",
            "Dollar",
            "Euro",
            "Lira"});
            this.ComboFrom.Location = new System.Drawing.Point(240, 98);
            this.ComboFrom.Name = "ComboFrom";
            this.ComboFrom.Size = new System.Drawing.Size(183, 28);
            this.ComboFrom.TabIndex = 3;
            // 
            // ComboTo
            // 
            this.ComboTo.FormattingEnabled = true;
            this.ComboTo.Items.AddRange(new object[] {
            "",
            "Manat",
            "Dollar",
            "Euro",
            "Lira"});
            this.ComboTo.Location = new System.Drawing.Point(240, 148);
            this.ComboTo.Name = "ComboTo";
            this.ComboTo.Size = new System.Drawing.Size(183, 28);
            this.ComboTo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // Netice
            // 
            this.Netice.AutoSize = true;
            this.Netice.Location = new System.Drawing.Point(236, 218);
            this.Netice.Name = "Netice";
            this.Netice.Size = new System.Drawing.Size(54, 20);
            this.Netice.TabIndex = 6;
            this.Netice.Text = "Netice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Çevir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifirla
            // 
            this.sifirla.Location = new System.Drawing.Point(606, 51);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(75, 30);
            this.sifirla.TabIndex = 8;
            this.sifirla.Text = "Sıfırla";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 286);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Netice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboTo);
            this.Controls.Add(this.ComboFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pulundeyeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pulundeyeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboFrom;
        private System.Windows.Forms.ComboBox ComboTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Netice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sifirla;
    }
}

