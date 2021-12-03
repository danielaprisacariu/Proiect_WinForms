namespace Proiect_BDM_PrisacariuDaniela_1109
{
    partial class FormReagasireSemantica
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumeImagine = new System.Windows.Forms.TextBox();
            this.tbCoefCuloare = new System.Windows.Forms.TextBox();
            this.tbCoefTextura = new System.Windows.Forms.TextBox();
            this.tbCoefForma = new System.Windows.Forms.TextBox();
            this.tbCoefLocatie = new System.Windows.Forms.TextBox();
            this.btnRegasire = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regasirea semantica a unei imgini de pe server in bd in functie de cei 4 coeficie" +
    "nti de importanta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume imagine server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Coeficient Culoare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Coeficient Textura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Coeficient Forma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Coeficient Locatie";
            // 
            // tbNumeImagine
            // 
            this.tbNumeImagine.Location = new System.Drawing.Point(158, 77);
            this.tbNumeImagine.Name = "tbNumeImagine";
            this.tbNumeImagine.Size = new System.Drawing.Size(100, 20);
            this.tbNumeImagine.TabIndex = 2;
            // 
            // tbCoefCuloare
            // 
            this.tbCoefCuloare.Location = new System.Drawing.Point(158, 108);
            this.tbCoefCuloare.Name = "tbCoefCuloare";
            this.tbCoefCuloare.Size = new System.Drawing.Size(100, 20);
            this.tbCoefCuloare.TabIndex = 2;
            // 
            // tbCoefTextura
            // 
            this.tbCoefTextura.Location = new System.Drawing.Point(158, 138);
            this.tbCoefTextura.Name = "tbCoefTextura";
            this.tbCoefTextura.Size = new System.Drawing.Size(100, 20);
            this.tbCoefTextura.TabIndex = 2;
            // 
            // tbCoefForma
            // 
            this.tbCoefForma.Location = new System.Drawing.Point(158, 171);
            this.tbCoefForma.Name = "tbCoefForma";
            this.tbCoefForma.Size = new System.Drawing.Size(100, 20);
            this.tbCoefForma.TabIndex = 2;
            // 
            // tbCoefLocatie
            // 
            this.tbCoefLocatie.Location = new System.Drawing.Point(158, 202);
            this.tbCoefLocatie.Name = "tbCoefLocatie";
            this.tbCoefLocatie.Size = new System.Drawing.Size(100, 20);
            this.tbCoefLocatie.TabIndex = 2;
            // 
            // btnRegasire
            // 
            this.btnRegasire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(125)))), ((int)(((byte)(199)))));
            this.btnRegasire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegasire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegasire.Location = new System.Drawing.Point(115, 261);
            this.btnRegasire.Name = "btnRegasire";
            this.btnRegasire.Size = new System.Drawing.Size(75, 23);
            this.btnRegasire.TabIndex = 3;
            this.btnRegasire.Text = "Cauta";
            this.btnRegasire.UseVisualStyleBackColor = false;
            this.btnRegasire.Click += new System.EventHandler(this.btnRegasire_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(351, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormReagasireSemantica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(206)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(622, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegasire);
            this.Controls.Add(this.tbCoefLocatie);
            this.Controls.Add(this.tbCoefForma);
            this.Controls.Add(this.tbCoefTextura);
            this.Controls.Add(this.tbCoefCuloare);
            this.Controls.Add(this.tbNumeImagine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReagasireSemantica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReagasireSemantica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumeImagine;
        private System.Windows.Forms.TextBox tbCoefCuloare;
        private System.Windows.Forms.TextBox tbCoefTextura;
        private System.Windows.Forms.TextBox tbCoefForma;
        private System.Windows.Forms.TextBox tbCoefLocatie;
        private System.Windows.Forms.Button btnRegasire;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}