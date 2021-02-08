namespace Crypto
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCipher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy1 = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbEncryptedMessage = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCopy2 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAlphabet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(384, -3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(13, 65);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(407, 136);
            this.tbMessage.TabIndex = 2;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(330, 39);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(90, 20);
            this.tbKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ключ:";
            // 
            // cbCipher
            // 
            this.cbCipher.BackColor = System.Drawing.Color.White;
            this.cbCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCipher.FormattingEnabled = true;
            this.cbCipher.Location = new System.Drawing.Point(57, 38);
            this.cbCipher.Name = "cbCipher";
            this.cbCipher.Size = new System.Drawing.Size(78, 21);
            this.cbCipher.TabIndex = 7;
            this.cbCipher.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Шифр:";
            // 
            // btnCopy1
            // 
            this.btnCopy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy1.Location = new System.Drawing.Point(325, 207);
            this.btnCopy1.Name = "btnCopy1";
            this.btnCopy1.Size = new System.Drawing.Size(95, 23);
            this.btnCopy1.TabIndex = 9;
            this.btnCopy1.Text = "Скопировать";
            this.btnCopy1.UseVisualStyleBackColor = true;
            this.btnCopy1.Click += new System.EventHandler(this.btnCopy1_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Location = new System.Drawing.Point(12, 207);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(95, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbEncryptedMessage
            // 
            this.tbEncryptedMessage.Location = new System.Drawing.Point(12, 236);
            this.tbEncryptedMessage.Multiline = true;
            this.tbEncryptedMessage.Name = "tbEncryptedMessage";
            this.tbEncryptedMessage.Size = new System.Drawing.Size(408, 136);
            this.tbEncryptedMessage.TabIndex = 12;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(247, 207);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(38, 23);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "^^^^^^^";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCopy2
            // 
            this.btnCopy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy2.Location = new System.Drawing.Point(325, 378);
            this.btnCopy2.Name = "btnCopy2";
            this.btnCopy2.Size = new System.Drawing.Size(95, 23);
            this.btnCopy2.TabIndex = 14;
            this.btnCopy2.Text = "Скопировать";
            this.btnCopy2.UseVisualStyleBackColor = true;
            this.btnCopy2.Click += new System.EventHandler(this.btnCopy2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Location = new System.Drawing.Point(113, 207);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(95, 23);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Алфавит:";
            // 
            // cbAlphabet
            // 
            this.cbAlphabet.BackColor = System.Drawing.Color.White;
            this.cbAlphabet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlphabet.FormattingEnabled = true;
            this.cbAlphabet.Location = new System.Drawing.Point(201, 38);
            this.cbAlphabet.Name = "cbAlphabet";
            this.cbAlphabet.Size = new System.Drawing.Size(78, 21);
            this.cbAlphabet.TabIndex = 16;
            this.cbAlphabet.Tag = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAlphabet);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnCopy2);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbEncryptedMessage);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnCopy1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbEncryptedMessage;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCopy2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAlphabet;
    }
}

