namespace SecurityAndEncryption
{
    partial class Caesar
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
            this.PlaintextTextBox = new System.Windows.Forms.TextBox();
            this.ShiftTextBox = new System.Windows.Forms.TextBox();
            this.CiphertextTextBox = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.plainTextLabel = new System.Windows.Forms.Label();
            this.cipherTextLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CaeserAlgorithem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlaintextTextBox
            // 
            this.PlaintextTextBox.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.PlaintextTextBox.Location = new System.Drawing.Point(407, 175);
            this.PlaintextTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PlaintextTextBox.Name = "PlaintextTextBox";
            this.PlaintextTextBox.Size = new System.Drawing.Size(212, 32);
            this.PlaintextTextBox.TabIndex = 1;
            // 
            // ShiftTextBox
            // 
            this.ShiftTextBox.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.ShiftTextBox.Location = new System.Drawing.Point(311, 175);
            this.ShiftTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ShiftTextBox.Name = "ShiftTextBox";
            this.ShiftTextBox.Size = new System.Drawing.Size(58, 32);
            this.ShiftTextBox.TabIndex = 0;
            // 
            // CiphertextTextBox
            // 
            this.CiphertextTextBox.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.CiphertextTextBox.Location = new System.Drawing.Point(67, 175);
            this.CiphertextTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CiphertextTextBox.Name = "CiphertextTextBox";
            this.CiphertextTextBox.Size = new System.Drawing.Size(212, 32);
            this.CiphertextTextBox.TabIndex = 2;
            // 
            // EncryptButton
            // 
            this.EncryptButton.BackColor = System.Drawing.Color.White;
            this.EncryptButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.EncryptButton.ForeColor = System.Drawing.Color.Black;
            this.EncryptButton.Location = new System.Drawing.Point(438, 233);
            this.EncryptButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(145, 40);
            this.EncryptButton.TabIndex = 3;
            this.EncryptButton.Text = "تشفير";
            this.EncryptButton.UseVisualStyleBackColor = false;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.White;
            this.DecryptButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.DecryptButton.ForeColor = System.Drawing.Color.Black;
            this.DecryptButton.Location = new System.Drawing.Point(90, 233);
            this.DecryptButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(145, 40);
            this.DecryptButton.TabIndex = 4;
            this.DecryptButton.Text = "فك التشفير";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.shiftLabel.Location = new System.Drawing.Point(297, 126);
            this.shiftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(87, 24);
            this.shiftLabel.TabIndex = 5;
            this.shiftLabel.Text = "قيمة التحويل";
            // 
            // plainTextLabel
            // 
            this.plainTextLabel.AutoSize = true;
            this.plainTextLabel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.plainTextLabel.Location = new System.Drawing.Point(469, 126);
            this.plainTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plainTextLabel.Name = "plainTextLabel";
            this.plainTextLabel.Size = new System.Drawing.Size(80, 24);
            this.plainTextLabel.TabIndex = 6;
            this.plainTextLabel.Text = "النص الأصلي";
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.AutoSize = true;
            this.cipherTextLabel.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.cipherTextLabel.Location = new System.Drawing.Point(116, 128);
            this.cipherTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.Size = new System.Drawing.Size(84, 24);
            this.cipherTextLabel.TabIndex = 7;
            this.cipherTextLabel.Text = "النص المشفر";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.MistyRose;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(11, 482);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(145, 40);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "الرجوع للخلف";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CaeserAlgorithem
            // 
            this.CaeserAlgorithem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CaeserAlgorithem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaeserAlgorithem.Font = new System.Drawing.Font("Cairo ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaeserAlgorithem.ForeColor = System.Drawing.Color.Blue;
            this.CaeserAlgorithem.Location = new System.Drawing.Point(188, 35);
            this.CaeserAlgorithem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CaeserAlgorithem.Name = "CaeserAlgorithem";
            this.CaeserAlgorithem.Size = new System.Drawing.Size(293, 60);
            this.CaeserAlgorithem.TabIndex = 10;
            this.CaeserAlgorithem.Text = "Caesar - خوارزمية";
            // 
            // Caesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 539);
            this.Controls.Add(this.CaeserAlgorithem);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.plainTextLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.CiphertextTextBox);
            this.Controls.Add(this.PlaintextTextBox);
            this.Controls.Add(this.ShiftTextBox);
            this.Font = new System.Drawing.Font("Cairo", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Caesar";
            this.Text = "Caesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox ShiftTextBox;
        private System.Windows.Forms.TextBox PlaintextTextBox;
        private System.Windows.Forms.TextBox CiphertextTextBox;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label plainTextLabel;
        private System.Windows.Forms.Label cipherTextLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CaeserAlgorithem;
    }
}