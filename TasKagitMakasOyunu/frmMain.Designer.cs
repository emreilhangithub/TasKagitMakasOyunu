
namespace TasKagitMakasOyunu
{
    partial class frmMain
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
            this.rdMakas = new System.Windows.Forms.RadioButton();
            this.rdKagit = new System.Windows.Forms.RadioButton();
            this.rdTas = new System.Windows.Forms.RadioButton();
            this.btnOyna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBitir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rdMakas
            // 
            this.rdMakas.AutoSize = true;
            this.rdMakas.Location = new System.Drawing.Point(448, 140);
            this.rdMakas.Name = "rdMakas";
            this.rdMakas.Size = new System.Drawing.Size(57, 17);
            this.rdMakas.TabIndex = 10;
            this.rdMakas.TabStop = true;
            this.rdMakas.Text = "Makas";
            this.rdMakas.UseVisualStyleBackColor = true;
            // 
            // rdKagit
            // 
            this.rdKagit.AutoSize = true;
            this.rdKagit.Location = new System.Drawing.Point(312, 140);
            this.rdKagit.Name = "rdKagit";
            this.rdKagit.Size = new System.Drawing.Size(49, 17);
            this.rdKagit.TabIndex = 9;
            this.rdKagit.TabStop = true;
            this.rdKagit.Text = "Kağıt";
            this.rdKagit.UseVisualStyleBackColor = true;
            // 
            // rdTas
            // 
            this.rdTas.AutoSize = true;
            this.rdTas.Location = new System.Drawing.Point(176, 140);
            this.rdTas.Name = "rdTas";
            this.rdTas.Size = new System.Drawing.Size(43, 17);
            this.rdTas.TabIndex = 8;
            this.rdTas.TabStop = true;
            this.rdTas.Text = "Taş";
            this.rdTas.UseVisualStyleBackColor = true;
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.Yellow;
            this.btnOyna.Location = new System.Drawing.Point(210, 188);
            this.btnOyna.Margin = new System.Windows.Forms.Padding(2);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(151, 79);
            this.btnOyna.TabIndex = 7;
            this.btnOyna.Text = "Oyna";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seçim Yapınız =";
            // 
            // btnBitir
            // 
            this.btnBitir.BackColor = System.Drawing.Color.Yellow;
            this.btnBitir.Location = new System.Drawing.Point(402, 188);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(2);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(151, 79);
            this.btnBitir.TabIndex = 12;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = false;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(467, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puanım =";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(535, 9);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(13, 13);
            this.lblPuan.TabIndex = 14;
            this.lblPuan.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TasKagitMakasOyunu.Properties.Resources.tas;
            this.pictureBox1.Location = new System.Drawing.Point(176, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TasKagitMakasOyunu.Properties.Resources.kagit;
            this.pictureBox2.Location = new System.Drawing.Point(312, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TasKagitMakasOyunu.Properties.Resources.makas;
            this.pictureBox3.Location = new System.Drawing.Point(448, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(560, 272);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdMakas);
            this.Controls.Add(this.rdKagit);
            this.Controls.Add(this.rdTas);
            this.Controls.Add(this.btnOyna);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taş Kağıt Makas Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdMakas;
        private System.Windows.Forms.RadioButton rdKagit;
        private System.Windows.Forms.RadioButton rdTas;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

