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
    public partial class AccountForm : Form
    {
        Crypt crypt=new Crypt();
        bool edit=false;
        int index;
        public AccountForm()
        {
            InitializeComponent();
            
        }

        public AccountForm(int index)
        {
            InitializeComponent();
            name_text.Text = crypt.Decrypt(MainForm.key, MainForm.Accounts[index].Name);
            username_text.Text = crypt.Decrypt(MainForm.key, MainForm.Accounts[index].Username);
            pas_text.Text = crypt.Decrypt(MainForm.key, MainForm.Accounts[index].Password);
            edit = true;
            this.index= index;

           
        }
        private void Save()
        {
            if (!string.IsNullOrEmpty(name_text.Text) && !string.IsNullOrEmpty(username_text.Text) && !string.IsNullOrEmpty(pas_text.Text))
            {
                
                Account account = new Account(
                    crypt.Encrypt(MainForm.key, name_text.Text),
                    crypt.Encrypt(MainForm.key, username_text.Text),
                    crypt.Encrypt(MainForm.key, pas_text.Text)
                );
                if (edit)
                {
                    MainForm.Accounts[index] = account;
                }
                else{
                    MainForm.Accounts.Add(account);
                }
               

                name_text.Text = string.Empty;
                username_text.Text = string.Empty;
                pas_text.Text = string.Empty;
             
                account = null;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pas_text.UseSystemPasswordChar = true;
            }
            else { pas_text.UseSystemPasswordChar = false; }
        }
    }

}
