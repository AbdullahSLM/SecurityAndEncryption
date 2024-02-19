using System.Windows.Forms;

namespace SecurityAndEncryption
{
    partial class Vigenere2 : Form
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.PlainTextTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.CipherTextTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.keyLabel = new System.Windows.Forms.Label();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.Vigenere2Algorithem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlainTextTextBox
            // 
            this.PlainTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlainTextTextBox.Font = new System.Drawing.Font("Cairo Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextTextBox.Location = new System.Drawing.Point(440, 178);
            this.PlainTextTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlainTextTextBox.Name = "PlainTextTextBox";
            this.PlainTextTextBox.Size = new System.Drawing.Size(212, 28);
            this.PlainTextTextBox.TabIndex = 1;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Font = new System.Drawing.Font("Cairo Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTextBox.Location = new System.Drawing.Point(325, 178);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(58, 28);
            this.keyTextBox.TabIndex = 0;
            // 
            // CipherTextTextBox
            // 
            this.CipherTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CipherTextTextBox.Font = new System.Drawing.Font("Cairo Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherTextTextBox.Location = new System.Drawing.Point(52, 178);
            this.CipherTextTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CipherTextTextBox.Name = "CipherTextTextBox";
            this.CipherTextTextBox.Size = new System.Drawing.Size(212, 28);
            this.CipherTextTextBox.TabIndex = 2;
            // 
            // EncryptButton
            // 
            this.EncryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptButton.BackColor = System.Drawing.Color.White;
            this.EncryptButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.EncryptButton.ForeColor = System.Drawing.Color.Black;
            this.EncryptButton.Location = new System.Drawing.Point(472, 232);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(145, 40);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "تشفير";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackColor = System.Drawing.Color.MistyRose;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(12, 486);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 40);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "الرجوع للخلف";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.BackColor = System.Drawing.Color.White;
            this.DecryptButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.DecryptButton.ForeColor = System.Drawing.Color.Black;
            this.DecryptButton.Location = new System.Drawing.Point(77, 232);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(145, 40);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "فك التشفير";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // keyLabel
            // 
            this.keyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.keyLabel.Location = new System.Drawing.Point(309, 133);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(91, 24);
            this.keyLabel.TabIndex = 5;
            this.keyLabel.Text = "مفتاح التشفير";
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainTextLabel.Location = new System.Drawing.Point(509, 133);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(80, 24);
            this.plainTextLabel.TabIndex = 6;
            this.plainTextLabel.Text = "النص الأصلي";
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.cipherTextLabel.Location = new System.Drawing.Point(109, 133);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(84, 24);
            this.cipherTextLabel.TabIndex = 7;
            this.cipherTextLabel.Text = "النص المشفر";
            // 
            // Vigenere2Algorithem
            // 
            this.Vigenere2Algorithem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vigenere2Algorithem.Font = new System.Drawing.Font("Cairo ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vigenere2Algorithem.ForeColor = System.Drawing.Color.Blue;
            this.Vigenere2Algorithem.Location = new System.Drawing.Point(192, 37);
            this.Vigenere2Algorithem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vigenere2Algorithem.Name = "Vigenere2Algorithem";
            this.Vigenere2Algorithem.Size = new System.Drawing.Size(328, 60);
            this.Vigenere2Algorithem.TabIndex = 9;
            this.Vigenere2Algorithem.Text = "Vigenere2 - خوارزمية";
            // 
            // Vigenere2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 539);
            this.Controls.Add(this.Vigenere2Algorithem);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.CipherTextTextBox);
            this.Controls.Add(this.PlainTextTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vigenere2";
            this.Text = "Vigenere2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.TextBox PlainTextTextBox;
        private System.Windows.Forms.TextBox CipherTextTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Vigenere2Algorithem;
    }
}