using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Password_Manager
{
    public partial class MainForm : Form
    {
        bool IsDialogOpen = false;
        internal static List<Account> Accounts = new List<Account>();
        int selectIndex = 0;

        Crypt crypt = new Crypt();
        internal static string key;
    

        public MainForm(string key)
        {
           MainForm.key = key;
            InitializeComponent();
            DeserializeAccounts();
            if (Accounts.Count > 0)
            {
                LoadAccounts();
            }
            
            
            

        }
       

      
        private void DeserializeAccounts()
        {
            
            try
            {
                using (var stream = File.Open(PathFolder.PasData, FileMode.OpenOrCreate))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        while (reader.PeekChar() > -1)
                        {
                            string name = reader.ReadString();
                            string usname = reader.ReadString();
                            string pas = reader.ReadString();
                            
                            Accounts.Add(new Account(name, usname, pas));
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR: passdata account");
            }
            
        }
        internal void LoadAccounts()
        {
            AccountView.Items.Clear();
            AccountView.Refresh();
            AccountView.LargeImageList = imageList1;
            int i=0;
            foreach (Account account in Accounts)
            {

                ListViewItem item = new ListViewItem();
                item.Text = crypt.Decrypt(key, account.Name);
                item.ImageIndex = i;
                AccountView.Items.Add(item);
               i++;
            }
            output.Title = crypt.Decrypt(key, Accounts[selectIndex].Name);
            output.Username = crypt.Decrypt(key, Accounts[selectIndex].Username);

            output.Password = crypt.Decrypt(key, Accounts[selectIndex].Password);



        }

        

        private void Add()
        {
            AccountForm f = new AccountForm();
            IsDialogOpen = true;
            DialogResult r = f.ShowDialog(this);
            IsDialogOpen = false;
            if(r == DialogResult.OK)
            {
                LoadAccounts();
            }

            Program.SaveSettings();



        }

        private void Edit()
        {
            
            AccountForm f = new AccountForm(selectIndex);
            IsDialogOpen = true;
            DialogResult r = f.ShowDialog(this);
            IsDialogOpen = false;

            if (r == DialogResult.OK)
            {
                LoadAccounts();
            }
            Program.SaveSettings();
        }
        private void AccountView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection accs =
        this.AccountView.SelectedItems;
            foreach (ListViewItem item in accs)
            {
                output.Title = crypt.Decrypt(key, Accounts[item.Index].Name);
                output.Username = crypt.Decrypt(key, Accounts[item.Index].Username);

                output.Password = crypt.Decrypt(key, Accounts[item.Index].Password);
                selectIndex = item.Index;
            }

            output.VisiblePass = false;
        }
        private void AddNewButton_Click(object sender, EventArgs e)
        {

            Add();
        }
        private void EditButton_Click_1(object sender, EventArgs e)
        {
            Edit();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Accounts.RemoveAt(selectIndex);
            selectIndex = 0;
            Program.SaveSettings();
            if (Accounts.Count > 0)
            {
                LoadAccounts();
            }


        }

        private void AccountView_ItemActivate(object sender, EventArgs e)
        {
            Edit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}