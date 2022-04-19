using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Password_Manager
{
    public partial class output_pass : UserControl
    {
        public string? Title {
            
            set { NameText.Text = value; }
         }
        public string? Username { set { UserText.Text = value; } }
       
        public string? Password { set { PassText.Text = value; } }
        
        public bool VisiblePass
        {
            set
            {
                if (!value)
                {
                    checkBox1.Checked = true;
                    PassText.UseSystemPasswordChar = true;
                }
            }
        }

        public output_pass()
        {
            InitializeComponent();

           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassText.UseSystemPasswordChar = true;

            }
            else
            {
                PassText.UseSystemPasswordChar = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = new DataObject();
            data.SetData(DataFormats.UnicodeText, true, PassText.Text);
            var thread = new Thread(() => Clipboard.SetDataObject(data, true));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
           
        }
    }
}
