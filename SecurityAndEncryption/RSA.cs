using System;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using NumSharp;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using System.Numerics; // Use BigInteger for larger numbers
using MathNet.Numerics.LinearAlgebra.Double;
using System.Collections.Generic;
using System.Linq;


namespace SecurityAndEncryption
{
    public partial class RSAForm : Form
    {
        private static BigInteger p = BigInteger.Parse("104729");
        private static BigInteger q = BigInteger.Parse("104723");
        private static BigInteger n = p * q;
        private static BigInteger phi = (p - 1) * (q - 1);
        private static BigInteger e = 65537; // عدد عشوائي يجب أن يكون أقل من phi ولا يشترك معه في أي عامل

        private static BigInteger d = ModInverse(e, phi);

        public RSAForm()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string plaintext = PlainTextTextBox.Text;
            string encryptedMsg = Encrypt(plaintext);
            CipherTextTextBox.Text = encryptedMsg;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string encryptedMsg = CipherTextTextBox.Text;
            string decryptedMsg = Decrypt(encryptedMsg);
            PlainTextTextBox.Text = decryptedMsg;
        }

        private static string Encrypt(string plaintext)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(plaintext);
            BigInteger message = new BigInteger(bytes);
            BigInteger encryptedMessage = BigInteger.ModPow(message, e, n);
            return encryptedMessage.ToString();
        }

        private static string Decrypt(string encryptedMsg)
        {
            BigInteger encryptedMessage = BigInteger.Parse(encryptedMsg);
            BigInteger decryptedMessage = BigInteger.ModPow(encryptedMessage, d, n);
            byte[] bytes = decryptedMessage.ToByteArray();
            return Encoding.ASCII.GetString(bytes);
        }

        private static BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0;
            BigInteger x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

