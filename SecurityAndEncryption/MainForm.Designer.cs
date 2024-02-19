using System;
using System.Windows.Forms;

namespace SecurityAndEncryption
{
    public partial class MainForm : Form
    {
        private void InitializeComponent()
        {
            this.caesarButton = new System.Windows.Forms.Button();
            this.platFairAlgorithmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.HillCipherButton = new System.Windows.Forms.Button();
            this.RSA_button = new System.Windows.Forms.Button();
            this.Vigenere_button = new System.Windows.Forms.Button();
            this.Vigenere2_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caesarButton
            // 
            this.caesarButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caesarButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.caesarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caesarButton.ForeColor = System.Drawing.Color.Black;
            this.caesarButton.Location = new System.Drawing.Point(72, 17);
            this.caesarButton.Margin = new System.Windows.Forms.Padding(8);
            this.caesarButton.MaximumSize = new System.Drawing.Size(300, 60);
            this.caesarButton.MinimumSize = new System.Drawing.Size(267, 55);
            this.caesarButton.Name = "caesarButton";
            this.caesarButton.Size = new System.Drawing.Size(300, 55);
            this.caesarButton.TabIndex = 1;
            this.caesarButton.Text = "Caesar تطبيق خوارزمية";
            this.caesarButton.UseVisualStyleBackColor = false;
            this.caesarButton.Click += new System.EventHandler(this.CaesarButton_Click);
            // 
            // platFairAlgorithmButton
            // 
            this.platFairAlgorithmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.platFairAlgorithmButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.platFairAlgorithmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.platFairAlgorithmButton.ForeColor = System.Drawing.Color.Black;
            this.platFairAlgorithmButton.Location = new System.Drawing.Point(72, 88);
            this.platFairAlgorithmButton.Margin = new System.Windows.Forms.Padding(8);
            this.platFairAlgorithmButton.MaximumSize = new System.Drawing.Size(300, 60);
            this.platFairAlgorithmButton.MinimumSize = new System.Drawing.Size(267, 55);
            this.platFairAlgorithmButton.Name = "platFairAlgorithmButton";
            this.platFairAlgorithmButton.Size = new System.Drawing.Size(300, 55);
            this.platFairAlgorithmButton.TabIndex = 2;
            this.platFairAlgorithmButton.Text = "PlayFair تطبيق خوارزمية";
            this.platFairAlgorithmButton.Click += new System.EventHandler(this.PlayFairButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitButton.BackColor = System.Drawing.Color.MistyRose;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(13, 474);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 42);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "إنهاء";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HillCipherButton
            // 
            this.HillCipherButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HillCipherButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.HillCipherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HillCipherButton.ForeColor = System.Drawing.Color.Black;
            this.HillCipherButton.Location = new System.Drawing.Point(72, 159);
            this.HillCipherButton.Margin = new System.Windows.Forms.Padding(8);
            this.HillCipherButton.MaximumSize = new System.Drawing.Size(300, 60);
            this.HillCipherButton.MinimumSize = new System.Drawing.Size(267, 55);
            this.HillCipherButton.Name = "HillCipherButton";
            this.HillCipherButton.Size = new System.Drawing.Size(300, 55);
            this.HillCipherButton.TabIndex = 4;
            this.HillCipherButton.Text = " HillCipher تطبيق خوارزمية";
            this.HillCipherButton.Click += new System.EventHandler(this.HillCipherButton_Click);
            // 
            // RSA_button
            // 
            this.RSA_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RSA_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.RSA_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RSA_button.ForeColor = System.Drawing.Color.Black;
            this.RSA_button.Location = new System.Drawing.Point(72, 230);
            this.RSA_button.Margin = new System.Windows.Forms.Padding(8);
            this.RSA_button.MaximumSize = new System.Drawing.Size(300, 60);
            this.RSA_button.MinimumSize = new System.Drawing.Size(267, 55);
            this.RSA_button.Name = "RSA_button";
            this.RSA_button.Size = new System.Drawing.Size(300, 55);
            this.RSA_button.TabIndex = 5;
            this.RSA_button.Text = " RSA تطبيق خوارزمية";
            this.RSA_button.Click += new System.EventHandler(this.RSAButton_Click);
            // 
            // Vigenere_button
            // 
            this.Vigenere_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vigenere_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Vigenere_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vigenere_button.ForeColor = System.Drawing.Color.Black;
            this.Vigenere_button.Location = new System.Drawing.Point(72, 301);
            this.Vigenere_button.Margin = new System.Windows.Forms.Padding(8);
            this.Vigenere_button.MaximumSize = new System.Drawing.Size(300, 60);
            this.Vigenere_button.MinimumSize = new System.Drawing.Size(267, 55);
            this.Vigenere_button.Name = "Vigenere_button";
            this.Vigenere_button.Size = new System.Drawing.Size(300, 55);
            this.Vigenere_button.TabIndex = 6;
            this.Vigenere_button.Text = " Vigenere تطبيق خوارزمية";
            this.Vigenere_button.Click += new System.EventHandler(this.VigenereButton_Click);

            // 
            // Vigenere2_button
            // 
            this.Vigenere2_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vigenere2_button.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Vigenere2_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vigenere2_button.ForeColor = System.Drawing.Color.Black;
            this.Vigenere2_button.Location = new System.Drawing.Point(72, 372);
            this.Vigenere2_button.Margin = new System.Windows.Forms.Padding(8);
            this.Vigenere2_button.MaximumSize = new System.Drawing.Size(300, 60);
            this.Vigenere2_button.MinimumSize = new System.Drawing.Size(267, 55);
            this.Vigenere2_button.Name = "Vigenere2_button";
            this.Vigenere2_button.Size = new System.Drawing.Size(300, 55);
            this.Vigenere2_button.TabIndex = 7;
            this.Vigenere2_button.Text = " Vigenere_2 تطبيق خوارزمية";
            this.Vigenere2_button.Click += new System.EventHandler(this.Vigenere2Button_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 529);
            this.Controls.Add(this.Vigenere2_button);
            this.Controls.Add(this.Vigenere_button);
            this.Controls.Add(this.RSA_button);
            this.Controls.Add(this.HillCipherButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.caesarButton);
            this.Controls.Add(this.platFairAlgorithmButton);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(416, 300);
            this.Name = "MainForm";
            this.Text = "الواجهة الرئيسية";
            this.ResumeLayout(false);

        }

        private Button exitButton;
        private Button caesarButton;
        private Button platFairAlgorithmButton;
        private Button HillCipherButton;
        private Button RSA_button;
        private Button Vigenere_button;
        private Button Vigenere2_button;
    }
}