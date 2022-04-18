using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void Register_Click(object sender, EventArgs e)
        {
            if ((txtPassword.Text == txtVerify.Text) && (!string.IsNullOrEmpty(txtPassword.Text)) && (!string.IsNullOrEmpty(txtVerify.Text)))
            {
                try
                {
                    File.WriteAllText(PathFolder.PasSerial, Crypt.HashKey(txtVerify.Text));
                    Program.SetMainForm(new MainForm(Crypt.HashKey(txtPassword.Text)));
                    txtPassword.Text = string.Empty;
                    txtVerify.Text = string.Empty;
                    
                    this.Close();
                    Program.ShowMainForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR: Creating account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
