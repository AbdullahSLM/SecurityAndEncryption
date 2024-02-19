using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SecurityAndEncryption
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void CaesarButton_Click(object sender, EventArgs e)
        {
            Caesar form = new Caesar();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(); // أو form.ShowDialog() إذا كنت ترغب في تشغيل النموذج كـــــحوار (Dialog)
        }

        private void PlayFairButton_Click(object sender, EventArgs e)
        {
            PlayFair form = new PlayFair();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }


        private void HillCipherButton_Click(object sender, EventArgs e)
        {
            HillCipher form = new HillCipher();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void RSAButton_Click(object sender, EventArgs e)
        {
            RSAForm form = new RSAForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void VigenereButton_Click(object sender, EventArgs e)
        {
            Vigenere form = new Vigenere();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void Vigenere2Button_Click(object sender, EventArgs e)
        {
            Vigenere2 form = new Vigenere2();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}