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
    public partial class AuthorizationForm : Form
    {

       Crypt crypt = new Crypt();

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            if ((!string.IsNullOrEmpty(txtPassword.Text)) && (File.Exists(PathFolder.Pas)))
            {
                
                string stored = crypt.Decrypt(txtPassword.Text,File.ReadAllText(PathFolder.Pas));

                if (Crypt.HashKey(txtPassword.Text) == stored)
                {
                    
                  

                    Program.SetMainForm(new MainForm(Crypt.HashKey(txtPassword.Text)));
                    this.Close();
                    Program.ShowMainForm();
                }
                else
                {
                    MessageBox.Show("The password you provided is incorrect!", "ERROR: Logging in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }


}
