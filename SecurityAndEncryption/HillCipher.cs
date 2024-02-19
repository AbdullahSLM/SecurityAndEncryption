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
    public partial class HillCipher : Form
    {

        public HillCipher()
        {
            InitializeComponent();
        }

        public static int Mod(int x, int m)
        {
            int r = x % m;
            return r < 0 ? r + m : r;
        }

        public static Matrix<double> MatrixMod(Matrix<double> matrix, int m)
        {
            var mat = Matrix<double>.Build.SameAs(matrix);
            for (int i = 0; i < mat.RowCount; i++)
            {
                for (int j = 0; j < mat.ColumnCount; j++)
                {
                    mat[i, j] = Mod((int)(matrix[i, j].Round(1)), 26);
                }
            }
            return mat;
        }

        public static int Solve(double y, int z)
        {
            // We know that there are infinitely many solutions to the equation.
            // We can find one solution by trial and error.

            for (int i = 1; i <= 100000; i ++)
            {
                if (Mod((int)y * i, z) == 1.0)
                {
                    return i;
                }
                if (Mod((int)y * -i, z) == 1.0)
                {
                    return -i;
                }

            }

            // If we reach this point, then there are no solutions.

            return 0;
        }

        public static double[,] InverseMatrix(double[,] keyMatrix)
        {
            var key = Matrix<double>.Build.DenseOfArray(keyMatrix);
            var det = key.Determinant();
            var keyInverse = key.Inverse() * det;
            det = Solve(det, 26);

            Console.WriteLine("Key Inv 0");
            Console.WriteLine(keyInverse);

            keyInverse = MatrixMod(keyInverse, 26);
            Console.WriteLine("Key Inv 1");
            Console.WriteLine(keyInverse);

            keyInverse *= det;
            Console.WriteLine("Key Inv 2");
            Console.WriteLine(keyInverse);


            keyInverse = MatrixMod(keyInverse, 26);
            Console.WriteLine("Key Inv 3");
            Console.WriteLine(keyInverse);

            return keyInverse.ToArray();
        }
  
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string plainText = PlainTextTextBox.Text;
            string key = keyTextBox.Text;

            string encryptedText = Encrypt(plainText, key);
            CipherTextTextBox.Text = encryptedText;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string cipherText = CipherTextTextBox.Text;
            string key = keyTextBox.Text;

            string decryptedText = Decrypt(cipherText, key);
            PlainTextTextBox.Text = decryptedText;
        }

        private string Encrypt(string plainText, string key)
        {
            // تحقق من صحة المفتاح
            if (!IsValidKey(key))
            {
                MessageBox.Show("المفتاح غير صحيح. يرجى التأكد من أن المفتاح يحتوي على أحرف فقط وأن طوله مناسب.");
                return string.Empty;
            }

            // قم بتنفيذ الخوارزمية اللازمة لتشفير النص

            // تحويل المفتاح إلى مصفوفة
            int matrixSize = (int)Math.Sqrt(key.Length);
            int[,] keyMatrix = new int[matrixSize, matrixSize];
            int keyIndex = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    keyMatrix[j, i] = key[keyIndex++] - 'A';
                }
            }
            foreach (var item in keyMatrix)
            {
                MessageBox.Show(item.ToString());
            }

            // تحويل النص الأصلي إلى مصفوفة من الأعداد المقابلة للحروف
            int[,] plainTextNumbers = new int[plainText.Length / 2, 2];

            for (int i = 0; i < plainText.Length / 2; i++)
            {
                plainTextNumbers[i, 0] = plainText[2 * i] - 'A';
                plainTextNumbers[i, 1] = plainText[2 * i + 1] - 'A';
            }

            if (plainText.Length % 2 == 1)
            {
                plainTextNumbers[plainTextNumbers.GetLength(0) - 1, 0] = 'X' - 'A';
                plainTextNumbers[plainTextNumbers.GetLength(0) - 1, 1] = plainText[plainText.Length - 1] - 'A';
            }

            //foreach (var item in plainTextNumbers)
            //{
            //    MessageBox.Show(item.ToString());
            //}


            // قم بتطبيق عملية ضرب المصفوفة لتشفير النص
            int[,] encryptedNumbers = new int[plainTextNumbers.GetLength(0), plainTextNumbers.GetLength(1)];

            for (int i = 0; i < plainTextNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < plainTextNumbers.GetLength(1); j++)
                {
                    encryptedNumbers[i, j] = Mod((plainTextNumbers[i, 0] * keyMatrix[j, 0] + plainTextNumbers[i, 1] * keyMatrix[j, 1]) , 26);
                }
            }

            // تحويل الأعداد المشفرة إلى نص مشفر
            StringBuilder encryptedText = new StringBuilder();

            foreach (var num in encryptedNumbers)
            {
                encryptedText.Append((char)(num + 'A'));
            }

            // قم بإرجاع النص المشفر
            return encryptedText.ToString();
        }

        private string Decrypt(string cipherText, string key)
        {
            //MessageBox.Show(Solve(-11, 26).ToString());
            // تحقق من صحة المفتاح
            if (!IsValidKey(key))
            {
                MessageBox.Show("المفتاح غير صحيح. يرجى التأكد من أن المفتاح يحتوي على أحرف فقط وأن طوله مناسب.");
                return string.Empty;
            }

            // تحويل المفتاح إلى مصفوفة
            int matrixSize = (int)Math.Sqrt(key.Length);
            double[,] keyMatrix = new double[matrixSize, matrixSize];
            int keyIndex = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    keyMatrix[j, i] = key[keyIndex++] - 'A';
                }
            }
            Console.WriteLine("Key Matrix");
            Console.Write(keyMatrix[0, 0]);
            Console.Write("\t");
            Console.WriteLine(keyMatrix[0, 1]);
            Console.Write(keyMatrix[1, 0]);
            Console.Write("\t");
            Console.WriteLine(keyMatrix[1, 1]);


            // تحويل النص المشفر إلى مصفوفة من الأعداد المقابلة للحروف
            double[,] encryptedNumbers = new double[cipherText.Length / 2, 2];
            for (int i = 0; i < encryptedNumbers.GetLength(0); i++)
            {
                encryptedNumbers[i, 0] = cipherText[i * 2] - 'A';
                encryptedNumbers[i, 1] = cipherText[i * 2 + 1] - 'A';
            }

            double[,] keyMatrixInverse = InverseMatrix(keyMatrix);
            Console.WriteLine("Key Matrix Inverse");
            Console.Write(keyMatrixInverse[0, 0]);
            Console.Write("\t");
            Console.WriteLine(keyMatrixInverse[0, 1]);
            Console.Write(keyMatrixInverse[1, 0]);
            Console.Write("\t");
            Console.WriteLine(keyMatrixInverse[1, 1]);

            // قم بتطبيق عملية ضرب المصفوفة المعكوسة لفك تشفير النص
            double[,] decryptedNumbers = new double[cipherText.Length / 2, 2];

            for (int i = 0; i < decryptedNumbers.GetLength(0); i++) //decryptedNumbers.GetLength(0) عدد الصفوف
            {
                for (int j = 0; j < decryptedNumbers.GetLength(1); j++)  //decryptedNumbers.GetLength(1) عدد الأعمدة
                {
                    decryptedNumbers[i, j] = Mod((int)(encryptedNumbers[i, 0] * keyMatrixInverse[j, 0] + encryptedNumbers[i, 1] * keyMatrixInverse[j, 1]), 26);
                }
            }



            //foreach (var item in decryptedNumbers)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            // تحويل الأعداد المفكوكة إلى نص مفكوك
            StringBuilder decryptedText = new StringBuilder();

            foreach (var num in decryptedNumbers)
            {
                decryptedText.Append((char)(num + 'A'));
            }

            // قم بإرجاع النص المشفر
            return decryptedText.ToString();
        }

        private bool IsValidKey(string key)
        {
            // التحقق من صحة المفتاح
            // المفتاح يجب أن يحتوي على أحرف فقط وأن يكون طوله مناسب
            // قم بتنفيذ الشروط الخاصة بالتحقق من المفتاح

            // التحقق من طول المفتاح
            int matrixSize = (int)Math.Sqrt(key.Length);
            if (matrixSize * matrixSize != key.Length)
            {
                return false;
            }

            // التحقق من صحة الأحرف في المفتاح
            foreach (char c in key)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}