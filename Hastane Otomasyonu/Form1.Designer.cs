namespace Hastane_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btniletisim = new System.Windows.Forms.Button();
            this.btnkullanıcıgiris = new System.Windows.Forms.Button();
            this.btnyöneticigiris = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btniletisim);
            this.panel1.Controls.Add(this.btnkullanıcıgiris);
            this.panel1.Controls.Add(this.btnyöneticigiris);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 524);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btniletisim
            // 
            this.btniletisim.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniletisim.Image = ((System.Drawing.Image)(resources.GetObject("btniletisim.Image")));
            this.btniletisim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btniletisim.Location = new System.Drawing.Point(3, 330);
            this.btniletisim.Name = "btniletisim";
            this.btniletisim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btniletisim.Size = new System.Drawing.Size(231, 53);
            this.btniletisim.TabIndex = 2;
            this.btniletisim.Text = "İletişim";
            this.btniletisim.UseVisualStyleBackColor = true;
            this.btniletisim.Click += new System.EventHandler(this.btniletisim_Click);
            // 
            // btnkullanıcıgiris
            // 
            this.btnkullanıcıgiris.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkullanıcıgiris.Image = ((System.Drawing.Image)(resources.GetObject("btnkullanıcıgiris.Image")));
            this.btnkullanıcıgiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkullanıcıgiris.Location = new System.Drawing.Point(2, 271);
            this.btnkullanıcıgiris.Name = "btnkullanıcıgiris";
            this.btnkullanıcıgiris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnkullanıcıgiris.Size = new System.Drawing.Size(232, 53);
            this.btnkullanıcıgiris.TabIndex = 1;
            this.btnkullanıcıgiris.Text = "Normal Kullanıcı \r\nGiriş";
            this.btnkullanıcıgiris.UseVisualStyleBackColor = true;
            this.btnkullanıcıgiris.Click += new System.EventHandler(this.btnkullanıcıgiris_Click);
            // 
            // btnyöneticigiris
            // 
            this.btnyöneticigiris.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyöneticigiris.Image = ((System.Drawing.Image)(resources.GetObject("btnyöneticigiris.Image")));
            this.btnyöneticigiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyöneticigiris.Location = new System.Drawing.Point(2, 212);
            this.btnyöneticigiris.Name = "btnyöneticigiris";
            this.btnyöneticigiris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnyöneticigiris.Size = new System.Drawing.Size(232, 53);
            this.btnyöneticigiris.TabIndex = 0;
            this.btnyöneticigiris.Text = "Yönetici Giriş";
            this.btnyöneticigiris.UseVisualStyleBackColor = true;
            this.btnyöneticigiris.Click += new System.EventHandler(this.btnyöneticigiris_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(914, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 32);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 497);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnyöneticigiris;
        private System.Windows.Forms.Button btniletisim;
        private System.Windows.Forms.Button btnkullanıcıgiris;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

