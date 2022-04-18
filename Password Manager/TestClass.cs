using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Password_Manager
{
    public class TestClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string surname = "";
        private string name = "";
        private string patronymic = "";
        private int age = 20;
        private bool working = false;
        private SexEnum sex = SexEnum.Men;

        public enum SexEnum
        {
            Men = 0,
            Women = 1
        }



        public string Surname
        { 
            get 
            { 
                return surname; 
            } 
            set 
            { 
                if (surname != value)
                {
                    surname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname"));
                }                 
            } 
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                if (patronymic != value)
                {
                    patronymic = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Patronymic"));
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            /*
            set
            {
                if (age != value)
                {
                    age = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
                }
            }
            */
        }

        [Description("Работает")]
        public bool Working
        {
            get
            {
                return working;
            }
            
            set
            {
                if (working != value)
                {
                    working = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Working"));
                }
            }           
        }

        public SexEnum Sex
        {
            get
            {
                return sex;
            }

            set
            {
                if (sex != value)
                {
                    sex = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sex"));
                }
            }
        }

        public TestClass()
        {

        }

        public TestClass(string surname, string name, string patronymic)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;

        }
    }
}
