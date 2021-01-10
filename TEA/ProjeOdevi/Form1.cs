using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeOdevi
{
    public partial class Form1 : Form
    {
        private string sifreliText, geciciText;
        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void icon_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icon_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (girilecek_textbox.TextLength == 0)
            {
                MessageBox.Show("Text Bos Olamaz");
            }
            else if (key_textbox.TextLength == 0)
            {
                MessageBox.Show("Key Bos Olamaz");
            }
            else
            {
                Tea tea = new Tea();
                sifreliText = tea.Encrypt(girilecek_textbox.Text, key_textbox.Text);
                sifreli_textbox.Text = sifreliText;
               
            };
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            if (girilecek_textbox.TextLength != 0 || sifreli_textbox.TextLength != 0)
            {
                girilecek_textbox.Text = "";
                sifreli_textbox.Text = "";
                cozulmus_textbox.Text = "";
                MessageBox.Show("Temizleme Islemi Tamamlandı.");
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (sifreli_textbox.TextLength == 0)
            {
                MessageBox.Show("Şifreli Text Silinmiş Ya Da Boş");
            }
            else if (key_textbox.TextLength == 0)
            {
                MessageBox.Show("Key Silinmiş Ya Da Boş");
            }
            else
            {
                Tea tea = new Tea();
                geciciText = tea.Decrypt(sifreli_textbox.Text, key_textbox.Text);
                cozulmus_textbox.Text = geciciText;
                MessageBox.Show("Şifreli Text Çözüldü(Türkçe karakterlerde problem çıkabilir.)");
            };
        }
    }
}
