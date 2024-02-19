using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecurityAndEncryption
{
    public partial class PlayFair : Form
    {
        public PlayFair()
        {
            InitializeComponent();
        }

        private char[,] PlayfairMatrix;

        private string Encrypt(string plaintext, string key)
        {
            GeneratePlayfairMatrix(key);
            string preparedText = PrepareText(plaintext);
            string ciphertext = "";

            for (int i = 0; i < preparedText.Length; i += 2)
            {
                char char1 = preparedText[i];
                char char2 = preparedText[i + 1];
                int row1 = -1, col1 = -1, row2 = -1, col2 = -1;

                FindCharPosition(char1, ref row1, ref col1);
                FindCharPosition(char2, ref row2, ref col2);

                if (row1 == row2)
                {
                    col1 = (col1 + 1) % 5;
                    col2 = (col2 + 1) % 5;
                }
                else if (col1 == col2)
                {
                    row1 = (row1 + 1) % 5;
                    row2 = (row2 + 1) % 5;
                }
                else
                {
                    (col2, col1) = (col1, col2);
                }

                ciphertext += PlayfairMatrix[row1, col1];
                ciphertext += PlayfairMatrix[row2, col2];
            }

            return ciphertext;
        }

        private string Decrypt(string ciphertext, string key)
        {
            GeneratePlayfairMatrix(key);
            string plaintext = "";

            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                char char1 = ciphertext[i];
                char char2 = ciphertext[i + 1];
                int row1 = -1, col1 = -1, row2 = -1, col2 = -1;

                FindCharPosition(char1, ref row1, ref col1);
                FindCharPosition(char2, ref row2, ref col2);

                if (row1 == row2)
                {
                    col1 = (col1 - 1 + 5) % 5;
                    col2 = (col2 - 1 + 5) % 5;
                }
                else if (col1 == col2)
                {
                    row1 = (row1 - 1 + 5) % 5;
                    row2 = (row2 - 1 + 5) % 5;
                }
                else
                {
                    (col2, col1) = (col1, col2);
                }

                plaintext += PlayfairMatrix[row1, col1];
                plaintext += PlayfairMatrix[row2, col2];
            }

            return plaintext;
        }

        private void GeneratePlayfairMatrix(string key)
        {
            string cleanedKey = CleanKey(key);
            PlayfairMatrix = new char[5, 5];
            int keyIndex = 0;
            bool[] usedChars = new bool[25];

            for (int i = 0; i < cleanedKey.Length; i++)
            {
                int row = i / 5;
                int col = i % 5;
                PlayfairMatrix[row, col] = cleanedKey[i];
                usedChars[cleanedKey[i] - 'A'] = true;
                keyIndex++;
            }

            for (int i = 0; i < 25; i++)
            {
                if (!usedChars[i] && (char)(i + 'A') != 'J')
                {
                    int row = keyIndex / 5;
                    int col = keyIndex % 5;
                    PlayfairMatrix[row, col] = (char)(i + 'A');
                    keyIndex++;
                }
            }

            MessageBox.Show(PlayfairMatrix.ToString());
        }

        private string CleanKey(string key)
        {
            string cleanedKey = "";

            foreach (char c in key)
            {
                if (Char.IsLetter(c))
                {
                    char upperC = Char.ToUpper(c);
                    if (!cleanedKey.Contains(upperC) && upperC != 'J')
                    {
                        cleanedKey += upperC;
                    }
                }
            }
            return cleanedKey;
        }

        private void FindCharPosition(char c, ref int row, ref int col)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (PlayfairMatrix[i, j] == c)
                    {
                        row = i;
                        col = j;
                        return;
                    }
                }
            }
        }

        private string PrepareText(string text)
        {
            // Remove non-letter characters and convert to uppercase
            string cleanedText = "";
            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                {
                    cleanedText += Char.ToUpper(c);
                }
            }

            // Replace 'J' with 'I'
            cleanedText = cleanedText.Replace('J', 'I');

            // Insert 'X' between consecutive identical letters
            string preparedText = "";
            char prevChar = '\0';
            foreach (char c in cleanedText)
            {
                if (c != prevChar)
                {
                    preparedText += c;
                }
                else
                {
                    preparedText += 'X';
                    preparedText += c;
                }

                prevChar = c;
            }

            // If the text length is odd, append 'X' at the end
            if (preparedText.Length % 2 != 0)
            {
                preparedText += 'X';
            }

            return preparedText;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string plaintext = PlainTextTextBox.Text;
            string key = keyTextBox.Text;
            string ciphertext = Encrypt(plaintext, key);
            CipherTextTextBox.Text = ciphertext;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string ciphertext = CipherTextTextBox.Text;
            string key = keyTextBox.Text;
            string plaintext = Decrypt(ciphertext, key);
            PlainTextTextBox.Text = plaintext;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

