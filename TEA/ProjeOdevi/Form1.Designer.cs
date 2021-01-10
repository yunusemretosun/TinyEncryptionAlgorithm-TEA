namespace ProjeOdevi
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
            this.tea_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yet_icon = new System.Windows.Forms.Label();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_cikis = new System.Windows.Forms.PictureBox();
            this.encrypt = new FontAwesome.Sharp.IconButton();
            this.girilecek_textbox = new System.Windows.Forms.TextBox();
            this.sifreli_textbox = new System.Windows.Forms.TextBox();
            this.cozulmus_textbox = new System.Windows.Forms.TextBox();
            this.key_textbox = new System.Windows.Forms.TextBox();
            this.text_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.key_label = new System.Windows.Forms.Label();
            this.temizle = new FontAwesome.Sharp.IconButton();
            this.decrypt = new FontAwesome.Sharp.IconButton();
            this.key_lenght_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // tea_label
            // 
            this.tea_label.AutoSize = true;
            this.tea_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tea_label.ForeColor = System.Drawing.Color.DarkViolet;
            this.tea_label.Location = new System.Drawing.Point(57, 3);
            this.tea_label.Name = "tea_label";
            this.tea_label.Size = new System.Drawing.Size(105, 48);
            this.tea_label.TabIndex = 0;
            this.tea_label.Text = "TEA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.yet_icon);
            this.panel1.Controls.Add(this.icon_minimize);
            this.panel1.Controls.Add(this.icon_cikis);
            this.panel1.Controls.Add(this.tea_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 59);
            this.panel1.TabIndex = 4;
            // 
            // yet_icon
            // 
            this.yet_icon.AutoSize = true;
            this.yet_icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.yet_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yet_icon.ForeColor = System.Drawing.Color.SlateBlue;
            this.yet_icon.Image = ((System.Drawing.Image)(resources.GetObject("yet_icon.Image")));
            this.yet_icon.Location = new System.Drawing.Point(0, 0);
            this.yet_icon.Name = "yet_icon";
            this.yet_icon.Size = new System.Drawing.Size(51, 58);
            this.yet_icon.TabIndex = 17;
            this.yet_icon.Text = "  ";
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.BackColor = System.Drawing.Color.Gainsboro;
            this.icon_minimize.Image = ((System.Drawing.Image)(resources.GetObject("icon_minimize.Image")));
            this.icon_minimize.Location = new System.Drawing.Point(1293, 3);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(25, 25);
            this.icon_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_minimize.TabIndex = 2;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // icon_cikis
            // 
            this.icon_cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_cikis.BackColor = System.Drawing.Color.Gainsboro;
            this.icon_cikis.Image = ((System.Drawing.Image)(resources.GetObject("icon_cikis.Image")));
            this.icon_cikis.Location = new System.Drawing.Point(1329, 3);
            this.icon_cikis.Name = "icon_cikis";
            this.icon_cikis.Size = new System.Drawing.Size(25, 25);
            this.icon_cikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_cikis.TabIndex = 1;
            this.icon_cikis.TabStop = false;
            this.icon_cikis.Click += new System.EventHandler(this.icon_cikis_Click);
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.Color.Gainsboro;
            this.encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.encrypt.IconColor = System.Drawing.Color.Black;
            this.encrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.encrypt.Location = new System.Drawing.Point(610, 678);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(133, 46);
            this.encrypt.TabIndex = 5;
            this.encrypt.Text = "Şifrele";
            this.encrypt.UseVisualStyleBackColor = false;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // girilecek_textbox
            // 
            this.girilecek_textbox.Location = new System.Drawing.Point(81, 251);
            this.girilecek_textbox.Multiline = true;
            this.girilecek_textbox.Name = "girilecek_textbox";
            this.girilecek_textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.girilecek_textbox.Size = new System.Drawing.Size(349, 191);
            this.girilecek_textbox.TabIndex = 6;
            // 
            // sifreli_textbox
            // 
            this.sifreli_textbox.Location = new System.Drawing.Point(502, 251);
            this.sifreli_textbox.Multiline = true;
            this.sifreli_textbox.Name = "sifreli_textbox";
            this.sifreli_textbox.Size = new System.Drawing.Size(349, 191);
            this.sifreli_textbox.TabIndex = 7;
            // 
            // cozulmus_textbox
            // 
            this.cozulmus_textbox.Location = new System.Drawing.Point(918, 251);
            this.cozulmus_textbox.Multiline = true;
            this.cozulmus_textbox.Name = "cozulmus_textbox";
            this.cozulmus_textbox.Size = new System.Drawing.Size(349, 191);
            this.cozulmus_textbox.TabIndex = 8;
            // 
            // key_textbox
            // 
            this.key_textbox.Location = new System.Drawing.Point(502, 625);
            this.key_textbox.MaxLength = 16;
            this.key_textbox.Name = "key_textbox";
            this.key_textbox.Size = new System.Drawing.Size(349, 22);
            this.key_textbox.TabIndex = 9;
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_label.ForeColor = System.Drawing.Color.SlateBlue;
            this.text_label.Location = new System.Drawing.Point(206, 209);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(83, 39);
            this.text_label.TabIndex = 10;
            this.text_label.Text = "Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(581, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifreli Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(970, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Çözülmüş Text";
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_label.ForeColor = System.Drawing.Color.SlateBlue;
            this.key_label.Location = new System.Drawing.Point(425, 618);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(57, 29);
            this.key_label.TabIndex = 13;
            this.key_label.Text = "Key";
            // 
            // temizle
            // 
            this.temizle.BackColor = System.Drawing.Color.Gainsboro;
            this.temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temizle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.temizle.IconColor = System.Drawing.Color.Black;
            this.temizle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.temizle.Location = new System.Drawing.Point(502, 683);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(87, 37);
            this.temizle.TabIndex = 14;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = false;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // decrypt
            // 
            this.decrypt.BackColor = System.Drawing.Color.Gainsboro;
            this.decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrypt.IconChar = FontAwesome.Sharp.IconChar.None;
            this.decrypt.IconColor = System.Drawing.Color.Black;
            this.decrypt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.decrypt.Location = new System.Drawing.Point(764, 683);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(87, 37);
            this.decrypt.TabIndex = 15;
            this.decrypt.Text = "Çöz";
            this.decrypt.UseVisualStyleBackColor = false;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // key_lenght_label
            // 
            this.key_lenght_label.AutoSize = true;
            this.key_lenght_label.ForeColor = System.Drawing.Color.SlateBlue;
            this.key_lenght_label.Location = new System.Drawing.Point(857, 625);
            this.key_lenght_label.Name = "key_lenght_label";
            this.key_lenght_label.Size = new System.Drawing.Size(170, 17);
            this.key_lenght_label.TabIndex = 16;
            this.key_lenght_label.Text = "*(1-16) karakter uzunluğu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.key_lenght_label);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.key_textbox);
            this.Controls.Add(this.cozulmus_textbox);
            this.Controls.Add(this.sifreli_textbox);
            this.Controls.Add(this.girilecek_textbox);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_cikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tea_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_cikis;
        private FontAwesome.Sharp.IconButton encrypt;
        private System.Windows.Forms.TextBox girilecek_textbox;
        private System.Windows.Forms.TextBox sifreli_textbox;
        private System.Windows.Forms.TextBox cozulmus_textbox;
        private System.Windows.Forms.TextBox key_textbox;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label key_label;
        private FontAwesome.Sharp.IconButton temizle;
        private FontAwesome.Sharp.IconButton decrypt;
        private System.Windows.Forms.Label yet_icon;
        private System.Windows.Forms.Label key_lenght_label;
    }
}

