using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager.Controls
{
    public partial class OnScreenKeyboard : UserControl
    {
        string text;
        Boolean Caps=false;
        string Text { 
        get { return text; }
        }
        public OnScreenKeyboard()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.text += '0';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.text += '-';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.text += '=';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.text += '+';
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'Q';
            }
            else
            {
                this.text += 'q';

            }
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'W';
            }
            else
            {
                this.text += 'w';

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'E';
            }
            else
            {
                this.text += 'e';

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'R';
            }
            else
            {
                this.text += 'r';

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'T';
            }
            else
            {
                this.text += 't';

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'Y';
            }
            else
            {
                this.text += 'y';

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'U';
            }
            else
            {
                this.text += 'u';

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'I';
            }
            else
            {
                this.text += 'i';

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'O';
            }
            else
            {
                this.text += 'o';

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'P';
            }
            else
            {
                this.text += 'p';

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            
             this.text += '[';
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.text += ']';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.text += '\\';
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.text=this.text.Remove(this.text.Length-1,1);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'A';
            }
            else
            {
                this.text += 'a';

            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'S';
            }
            else
            {
                this.text += 's';

            }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'D';
            }
            else
            {
                this.text += 'd';

            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'F';
            }
            else
            {
                this.text += 'f';

            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'G';
            }
            else
            {
                this.text += 'g';

            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'H';
            }
            else
            {
                this.text += 'h';

            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'J';
            }
            else
            {
                this.text += 'j';

            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'K';
            }
            else
            {
                this.text += 'k';

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'L';
            }
            else
            {
                this.text += 'l';

            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.text += ';';
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.text += ':';
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.text += '*';
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.text += '@';
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'Z';
            }
            else
            {
                this.text += 'z';

            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'X';
            }
            else
            {
                this.text += 'x';

            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'C';
            }
            else
            {
                this.text += 'c';

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'V';
            }
            else
            {
                this.text += 'v';

            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'B';
            }
            else
            {
                this.text += 'b';

            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'N';
            }
            else
            {
                this.text += 'n';

            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (Caps)
            {
                this.text += 'M';
            }
            else
            {
                this.text += 'm';

            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
           
            
                this.text += ',';
            
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.text += '.';
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.text += '?';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.text += '\'';
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.text += '\"';
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (this.Caps)
            {
                this.Caps = false;
            }
            else
            {
                this.Caps = true;
            } 
        }

        private void button54_Click(object sender, EventArgs e)
        {
            this.text += ' ';
        }
    }
}
