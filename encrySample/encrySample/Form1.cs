using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encrySample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Encrypt(string m)
        {
            string str = m;
            char[] charValues = str.ToCharArray();
            string hexOutput = "";
            foreach (char _eachChar in charValues)
            {
                // Get the integral value of the character.
                int value = Convert.ToInt32(  _eachChar);
                // Convert the decimal value to a hexadecimal value in string form.
                hexOutput += String.Format("{0:X}", value);
                // to make output as your eg 
                //  hexOutput +=" "+ String.Format("{0:X}", value);

            }
            return hexOutput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
            textBox2.Text = Encrypt(textBox1.Text);
        }
    }
}
