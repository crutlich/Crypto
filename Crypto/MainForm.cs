using System;
using System.Windows.Forms;

namespace Crypto
{
    public partial class MainForm : BorderlessWinForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbCipher.Items.Add("Цезаря");
            cbCipher.Items.Add("Виженера");
            cbCipher.SelectedIndex = 0;
            
            cbAlphabet.Items.Add("Кириллица");
            cbAlphabet.Items.Add("Латиница");
            cbAlphabet.SelectedIndex = 0;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCipher.SelectedIndex == 0)
                    tbEncryptedMessage.Text = CaesarCipher.Encrypt(tbMessage.Text, tbKey.Text, cbAlphabet.Text);
                else
                    tbEncryptedMessage.Text = VigenereCipher.Encrypt(tbMessage.Text, tbKey.Text, cbAlphabet.Text);
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try { 

                if (cbCipher.SelectedIndex == 0)
                    tbEncryptedMessage.Text = CaesarCipher.Decrypt(tbMessage.Text, tbKey.Text, cbAlphabet.Text);
                else
                    tbEncryptedMessage.Text = VigenereCipher.Decrypt(tbMessage.Text, tbKey.Text, cbAlphabet.Text);     
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            tbMessage.Text = tbEncryptedMessage.Text;
            tbEncryptedMessage.Text = "";
        }

        private void btnCopy1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbMessage.Text);
        }

        private void btnCopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbEncryptedMessage.Text);
           
        }

        
    }
}
