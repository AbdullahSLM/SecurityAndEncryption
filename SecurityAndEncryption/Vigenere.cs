using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using NumSharp;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;


namespace SecurityAndEncryption
{
    public partial class Vigenere : Form
    {

        public Vigenere()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string plaintext = PlainTextTextBox.Text.ToUpper();
            string key = keyTextBox.Text.ToUpper();
            string ciphertext = ApplyVigenereCipher(plaintext, key, true);
            CipherTextTextBox.Text = ciphertext;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string ciphertext = CipherTextTextBox.Text.ToUpper();
            string key = keyTextBox.Text.ToUpper();
            string decryptedText = ApplyVigenereCipher(ciphertext, key, false);
            PlainTextTextBox.Text = decryptedText;
        }

        private string ApplyVigenereCipher(string text, string key, bool encrypt)
        {

            string result = string.Empty;
            int keyLength = key.Length;
            int textLength = text.Length;

            for (int i = 0; i < textLength; ++i)
            {
                char currentChar = text[i];
                char keyChar = key[i % keyLength];
                int keyValue = (encrypt ? 1 : -1) * (keyChar - 'A');
                char shiftedChar = (char)(((currentChar - 'A' + keyValue + 26) % 26) + 'A');
                result += shiftedChar;
            }

            return result;
        }
        
        void BackButton_Click(Object sender, EventArgs e)
        {
            Close();
        }
    }
}

