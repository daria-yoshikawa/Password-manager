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
            if ((!string.IsNullOrEmpty(txtPassword.Text)) && (File.Exists(PathFolder.PasSerial)))
            {
                string hashed = Crypt.HashKey(txtPassword.Text);
                string stored = File.ReadAllText(PathFolder.PasSerial);

                if (hashed == stored)
                {
                    
                    txtPassword.Text = string.Empty;
                    hashed = string.Empty;
                    stored = string.Empty;

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
    }


}
