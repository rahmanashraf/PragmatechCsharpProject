namespace PhotoGalleryApp
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
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.txtbxPhoto = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtbxcateg = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(713, 12);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(179, 33);
            this.btnAddPhoto.TabIndex = 0;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // txtbxPhoto
            // 
            this.txtbxPhoto.Location = new System.Drawing.Point(713, 62);
            this.txtbxPhoto.Name = "txtbxPhoto";
            this.txtbxPhoto.Size = new System.Drawing.Size(179, 26);
            this.txtbxPhoto.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(952, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(166, 33);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // txtbxcateg
            // 
            this.txtbxcateg.Location = new System.Drawing.Point(952, 62);
            this.txtbxcateg.Name = "txtbxcateg";
            this.txtbxcateg.Size = new System.Drawing.Size(166, 26);
            this.txtbxcateg.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 450);
            this.Controls.Add(this.txtbxcateg);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtbxPhoto);
            this.Controls.Add(this.btnAddPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "PhotoGallery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.TextBox txtbxPhoto;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtbxcateg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

