using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsWasWhenWill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //checks pressed key can be convert to int
            char[] allowed = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' , '\b'};
            int tryAllowed = 0;
            foreach (char element in allowed)
            {
                tryAllowed++;
                if (e.KeyChar == element)
                {
                    e.Handled = false;
                    return;
                }
                else if (tryAllowed == (allowed.Length) && !(e.KeyChar == element))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
