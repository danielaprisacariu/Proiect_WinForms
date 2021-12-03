namespace Proiect_BDM_PrisacariuDaniela_1109
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbURLVideo = new System.Windows.Forms.TextBox();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.btnAdaugaVideo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL video";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nume video";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(119, 37);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(405, 20);
            this.tbDenumire.TabIndex = 2;
            // 
            // tbURLVideo
            // 
            this.tbURLVideo.Location = new System.Drawing.Point(119, 70);
            this.tbURLVideo.Name = "tbURLVideo";
            this.tbURLVideo.Size = new System.Drawing.Size(405, 20);
            this.tbURLVideo.TabIndex = 2;
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(119, 102);
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(405, 20);
            this.tbVideo.TabIndex = 2;
            // 
            // btnAdaugaVideo
            // 
            this.btnAdaugaVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(125)))), ((int)(((byte)(199)))));
            this.btnAdaugaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaVideo.Location = new System.Drawing.Point(223, 166);
            this.btnAdaugaVideo.Name = "btnAdaugaVideo";
            this.btnAdaugaVideo.Size = new System.Drawing.Size(130, 33);
            this.btnAdaugaVideo.TabIndex = 3;
            this.btnAdaugaVideo.Text = "Adauga";
            this.btnAdaugaVideo.UseVisualStyleBackColor = false;
            this.btnAdaugaVideo.Click += new System.EventHandler(this.btnAdaugaVideo_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(206)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(588, 231);
            this.Controls.Add(this.btnAdaugaVideo);
            this.Controls.Add(this.tbVideo);
            this.Controls.Add(this.tbURLVideo);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbURLVideo;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.Button btnAdaugaVideo;
    }
}