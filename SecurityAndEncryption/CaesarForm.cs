using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SecurityAndEncryption
{
    public partial class Caesar : Form
    {
        public Caesar()
        {
            InitializeComponent();
        }


        private void EncryptButton_Click(object sender, EventArgs e)
        {
            int shift = Convert.ToInt32(ShiftTextBox.Text); // الحصول على قيمة التحويل المطلوبة من المربع النص
            string plaintext = PlaintextTextBox.Text; // الحصول على النص الأصلي من المربع النص
            string ciphertext = Encrypt(plaintext, shift); // تشفير النص الأصلي
            CiphertextTextBox.Text = ciphertext; // عرض النص المشفر في المربع النص المشفر

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            int shift = Convert.ToInt32(ShiftTextBox.Text); // الحصول على قيمة التحويل المطلوبة من المربع النص
            string ciphertext = CiphertextTextBox.Text; // الحصول على النص المشفر من المربع النص المشفر
            string plaintext = Decrypt(ciphertext, shift); // فك تشفير النص المشفر
            PlaintextTextBox.Text = plaintext; // عرض النص الأصلي في المربع النص الأصلي
        }

        private string Encrypt(string plaintext, int shift)
        {
            string ciphertext = "";
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a'; // تحديد الحرف الأساسي (A أو a) بناءً على حالة الحرف
                    char encryptedChar = (char)(((c - baseChar) + shift) % 26 + baseChar);
                    ciphertext += encryptedChar;
                }
                else
                {
                    ciphertext += c;
                }
            }
            return ciphertext;
        }

        private string Decrypt(string ciphertext, int shift)
        {
            string plaintext = "";
            shift %= 26;
            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char decryptedChar = (char)(((c - baseChar) - shift + 26) % 26 + baseChar);
                    plaintext += decryptedChar;
                }
                else
                {
                    plaintext += c; // إضافة الحرف كما هو إذا ليس حرفًا
                }
            }
            return plaintext;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
