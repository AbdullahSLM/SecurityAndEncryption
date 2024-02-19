using System.Windows.Forms;

namespace SecurityAndEncryption
{
    partial class RSAForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.PlainTextTextBox = new System.Windows.Forms.TextBox();
            this.CipherTextTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.RSAAlgorithem = new System.Windows.Forms.Label();
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
            // RSAAlgorithem
            // 
            this.RSAAlgorithem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RSAAlgorithem.Font = new System.Drawing.Font("Cairo ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSAAlgorithem.ForeColor = System.Drawing.Color.Blue;
            this.RSAAlgorithem.Location = new System.Drawing.Point(192, 37);
            this.RSAAlgorithem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RSAAlgorithem.Name = "RSAAlgorithem";
            this.RSAAlgorithem.Size = new System.Drawing.Size(314, 60);
            this.RSAAlgorithem.TabIndex = 9;
            this.RSAAlgorithem.Text = "RSA - خوارزمية";
            this.RSAAlgorithem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RSAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 539);
            this.Controls.Add(this.RSAAlgorithem);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.CipherTextTextBox);
            this.Controls.Add(this.PlainTextTextBox);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RSAForm";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox PlainTextTextBox;
        private System.Windows.Forms.TextBox CipherTextTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label RSAAlgorithem;
    }
}