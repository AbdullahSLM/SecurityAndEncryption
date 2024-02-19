using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using NumSharp;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Linq;


namespace SecurityAndEncryption
{
    public partial class Vigenere2 : Form
    {

        public Vigenere2()
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
            int j = 0;
            for (int i = 0; i < textLength; ++i)
            {
                
                char currentChar = text[i];
                char keyChar = key[i];
                int keyValue = (encrypt ? 1 : -1) * (keyChar - 'A');

                char shiftedChar = (char)(((currentChar - 'A' + keyValue + 26) % 26) + 'A');
                result += shiftedChar;

                // تعبئة المفتاح الناقص من النص بدلاً من تكراره في حالة فك التشفير
                if (i + 1 > keyLength && i + 1 <= textLength && !encrypt)
                {
                    key += result[j++];
                }
                // تعبئة المفتاح الناقص من النص بدلاً من تكراره في حالة التشفير
                if (i + 1 >= keyLength && i + 1 <= textLength && encrypt)
                {
                    key += text[j++];
                }
            }

            return result;
        }
        void BackButton_Click(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}