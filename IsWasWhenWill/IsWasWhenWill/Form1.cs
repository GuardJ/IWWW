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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int add1;
            int what1;
            add1 = Convert.ToInt32(textBox1.Text);
            what1 = Convert.ToInt32(comboBox1.SelectedIndex);

            switch(what1)
            {
                case 0: //days
                    dtpResult1.Value = dtpInitial1.Value.AddDays(add1);

                    return;
                case 1: //weeks
                    dtpResult1.Value = dtpInitial1.Value.AddDays(add1 * 7);
                    return;
                case 2: //months
                    dtpResult1.Value = dtpInitial1.Value.AddMonths(add1);
                    return;
                case 3: //years
                    dtpResult1.Value = dtpInitial1.Value.AddYears(add1);
                    return;
                default:
                    return;
            } 
                      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int add1;
            int what1;
            add1 = Convert.ToInt32(textBox1.Text);
            what1 = Convert.ToInt32(comboBox1.SelectedIndex);

            switch (what1)
            {
                case 0: //days
                    dtpResult1.Value = dtpInitial1.Value.AddDays(add1);

                    return;
                case 1: //weeks
                    dtpResult1.Value = dtpInitial1.Value.AddDays(add1 * 7);
                    return;
                case 2: //months
                    dtpResult1.Value = dtpInitial1.Value.AddMonths(add1);
                    return;
                case 3: //years
                    dtpResult1.Value = dtpInitial1.Value.AddYears(add1);
                    return;
                default:
                    return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //ucTimeInterval ucNext = new ucTimeInterval();     WIP
            //ucNext.Location.X 
        }
    }
}
