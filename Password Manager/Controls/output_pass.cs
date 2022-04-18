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
    public partial class output_pass : UserControl
    {
        public string? name { get; set; }
        public string? Username { get; set; }
       
        public string? Password { get; set; }
        public output_pass()
        {
            InitializeComponent();

            label1.Text = name;
            textBox1.Text = Username;
            textBox2.Text = Password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
