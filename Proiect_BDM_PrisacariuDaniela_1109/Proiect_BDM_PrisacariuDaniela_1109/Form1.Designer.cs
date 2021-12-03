namespace Proiect_BDM_PrisacariuDaniela_1109
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDenPictCutata = new System.Windows.Forms.TextBox();
            this.btnCautaImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInserare = new System.Windows.Forms.Button();
            this.btnVideoclipuri = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imagineInOglindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportImagineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegasireSemantica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire pictura";
            // 
            // tbDenPictCutata
            // 
            this.tbDenPictCutata.Location = new System.Drawing.Point(155, 38);
            this.tbDenPictCutata.Name = "tbDenPictCutata";
            this.tbDenPictCutata.Size = new System.Drawing.Size(154, 20);
            this.tbDenPictCutata.TabIndex = 1;
            // 
            // btnCautaImg
            // 
            this.btnCautaImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(125)))), ((int)(((byte)(199)))));
            this.btnCautaImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCautaImg.BackgroundImage")));
            this.btnCautaImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCautaImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCautaImg.Location = new System.Drawing.Point(315, 35);
            this.btnCautaImg.Name = "btnCautaImg";
            this.btnCautaImg.Size = new System.Drawing.Size(28, 25);
            this.btnCautaImg.TabIndex = 2;
            this.btnCautaImg.UseVisualStyleBackColor = false;
            this.btnCautaImg.Click += new System.EventHandler(this.btnCautaImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(497, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire,
            this.Artist,
            this.columnHeader1});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 94);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(428, 217);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 149;
            // 
            // Artist
            // 
            this.Artist.Text = "Artist";
            this.Artist.Width = 178;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "An aparitie";
            this.columnHeader1.Width = 96;
            // 
            // btnInserare
            // 
            this.btnInserare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(125)))), ((int)(((byte)(199)))));
            this.btnInserare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserare.Location = new System.Drawing.Point(27, 340);
            this.btnInserare.Name = "btnInserare";
            this.btnInserare.Size = new System.Drawing.Size(112, 34);
            this.btnInserare.TabIndex = 5;
            this.btnInserare.Text = "Adugare pictura";
            this.btnInserare.UseVisualStyleBackColor = false;
            this.btnInserare.Click += new System.EventHandler(this.btnInserare_Click);
            // 
            // btnVideoclipuri
            // 
            this.btnVideoclipuri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(125)))), ((int)(((byte)(199)))));
            this.btnVideoclipuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoclipuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoclipuri.Location = new System.Drawing.Point(27, 391);
            this.btnVideoclipuri.Name = "btnVideoclipuri";
            this.btnVideoclipuri.Size = new System.Drawing.Size(112, 28);
            this.btnVideoclipuri.TabIndex = 6;
            this.btnVideoclipuri.Text = "Videoclipuri";
            this.btnVideoclipuri.UseVisualStyleBackColor = false;
            this.btnVideoclipuri.Click += new System.EventHandler(this.btnVideoclipuri_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagineInOglindaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.exportImagineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 70);
            // 
            // imagineInOglindaToolStripMenuItem
            // 
            this.imagineInOglindaToolStripMenuItem.Name = "imagineInOglindaToolStripMenuItem";
            this.imagineInOglindaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.imagineInOglindaToolStripMenuItem.Text = "Imagine in oglinda";
            this.imagineInOglindaToolStripMenuItem.Click += new System.EventHandler(this.imagineInOglindaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // exportImagineToolStripMenuItem
            // 
            this.exportImagineToolStripMenuItem.Name = "exportImagineToolStripMenuItem";
            this.exportImagineToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exportImagineToolStripMenuItem.Text = "Export imagine";
            this.exportImagineToolStripMenuItem.Click += new System.EventHandler(this.exportImagineToolStripMenuItem_Click);
            // 
            // btnRegasireSemantica
            // 
            this.btnRegasireSemantica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(125)))), ((int)(((byte)(199)))));
            this.btnRegasireSemantica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegasireSemantica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegasireSemantica.Location = new System.Drawing.Point(618, 391);
            this.btnRegasireSemantica.Name = "btnRegasireSemantica";
            this.btnRegasireSemantica.Size = new System.Drawing.Size(149, 28);
            this.btnRegasireSemantica.TabIndex = 8;
            this.btnRegasireSemantica.Text = "Regasire semantica";
            this.btnRegasireSemantica.UseVisualStyleBackColor = false;
            this.btnRegasireSemantica.Click += new System.EventHandler(this.btnRegasireSemantica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(206)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegasireSemantica);
            this.Controls.Add(this.btnVideoclipuri);
            this.Controls.Add(this.btnInserare);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCautaImg);
            this.Controls.Add(this.tbDenPictCutata);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDenPictCutata;
        private System.Windows.Forms.Button btnCautaImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnInserare;
        private System.Windows.Forms.Button btnVideoclipuri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imagineInOglindaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportImagineToolStripMenuItem;
        private System.Windows.Forms.Button btnRegasireSemantica;
    }
}

