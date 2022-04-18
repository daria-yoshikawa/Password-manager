using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Forms
{
    public partial class TestForm : Form
    {
        private BindingList<TestClass> personsList = new BindingList<TestClass>();

        public TestForm()
        {
            InitializeComponent();

            bindingPersons.ListChanged += BindingPersons_ListChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personsList.Add(new TestClass("Иванов", "Иван", "Иванович"));
            personsList.Add(new TestClass("Петров", "Петр", "Петрович"));
            personsList.Add(new TestClass("Сидоров", "Сидор", "Сидорович"));
            /*
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("patronymic", "Отчество");

            foreach (TestClass person in personsList)
            {
                dataGridView1.Rows.Add(new string[] { person.Surname, person.Name, person.Patronymic });
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = personsList;
            dataGridView1.DataSource = bindingSource1;


            dataGridView1.Columns[0].HeaderText = "Фамилия";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Отчество";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personsList[0].Surname);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personsList[0].Surname = "Котов";
        }


        BindingList<TestClass> bindingPersons = new BindingList<TestClass>();

        private void button5_Click(object sender, EventArgs e)
        {
            bindingPersons.Add(new TestClass("Иванов", "Иван", "Иванович"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingPersons[0].Surname = "Борщ";
        }

        private void BindingPersons_ListChanged(object? sender, ListChangedEventArgs e)
        {
            textBox1.Text = bindingPersons[0].Surname;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
