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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtbxcateg = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CatComboBox = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlphoto = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.x = new System.Windows.Forms.ToolStripMenuItem();
            this.lastfive = new System.Windows.Forms.ToolStripMenuItem();
            this.biggestfive = new System.Windows.Forms.ToolStripMenuItem();
            this.menujpgcaller = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlphoto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPhoto
            // 
            resources.ApplyResources(this.btnAddPhoto, "btnAddPhoto");
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // btnAddCategory
            // 
            resources.ApplyResources(this.btnAddCategory, "btnAddCategory");
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtbxcateg
            // 
            resources.ApplyResources(this.txtbxcateg, "txtbxcateg");
            this.txtbxcateg.BackColor = System.Drawing.Color.DarkOrange;
            this.txtbxcateg.Name = "txtbxcateg";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CatComboBox
            // 
            resources.ApplyResources(this.CatComboBox, "CatComboBox");
            this.CatComboBox.BackColor = System.Drawing.Color.DarkOrange;
            this.CatComboBox.ForeColor = System.Drawing.Color.Black;
            this.CatComboBox.FormattingEnabled = true;
            this.CatComboBox.Name = "CatComboBox";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.Orange;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteCat
            // 
            resources.ApplyResources(this.btnDeleteCat, "btnDeleteCat");
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnMinimize
            // 
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.BackColor = System.Drawing.Color.Orange;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlphoto
            // 
            resources.ApplyResources(this.pnlphoto, "pnlphoto");
            this.pnlphoto.BackColor = System.Drawing.Color.Transparent;
            this.pnlphoto.Controls.Add(this.vScrollBar1);
            this.pnlphoto.Name = "pnlphoto";
            // 
            // vScrollBar1
            // 
            resources.ApplyResources(this.vScrollBar1, "vScrollBar1");
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.txtbxcateg);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.CatComboBox);
            this.panel1.Controls.Add(this.btnDeleteCat);
            this.panel1.Controls.Add(this.btnAddPhoto);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // x
            // 
            this.x.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastfive,
            this.biggestfive,
            this.menujpgcaller});
            this.x.Name = "x";
            resources.ApplyResources(this.x, "x");
            // 
            // lastfive
            // 
            this.lastfive.BackColor = System.Drawing.Color.DarkOrange;
            this.lastfive.Name = "lastfive";
            resources.ApplyResources(this.lastfive, "lastfive");
            this.lastfive.Click += new System.EventHandler(this.lastfive_Click);
            // 
            // biggestfive
            // 
            this.biggestfive.BackColor = System.Drawing.Color.DarkOrange;
            this.biggestfive.Name = "biggestfive";
            resources.ApplyResources(this.biggestfive, "biggestfive");
            this.biggestfive.Click += new System.EventHandler(this.biggestfive_Click);
            // 
            // menujpgcaller
            // 
            this.menujpgcaller.BackColor = System.Drawing.Color.DarkOrange;
            this.menujpgcaller.Name = "menujpgcaller";
            resources.ApplyResources(this.menujpgcaller, "menujpgcaller");
            this.menujpgcaller.Click += new System.EventHandler(this.menujpgcaller_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::PhotoGalleryApp.Properties.Resources.Wekil;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlphoto);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.pnlphoto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtbxcateg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CatComboBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlphoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem x;
        private System.Windows.Forms.ToolStripMenuItem lastfive;
        private System.Windows.Forms.ToolStripMenuItem biggestfive;
        private System.Windows.Forms.ToolStripMenuItem menujpgcaller;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

