using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsWasWhenWill
{
    public partial class ucTimeInterval : UserControl
    {
        public ucTimeInterval()
        {
            InitializeComponent();

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //checks pressed key can be convert to int
        {
            char[] allowed = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '\b' };
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
        public int addInterval { get; private set; }
        public int whichInterval { get; private set; }
        public string whichButton()
        {
            return this.Name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //selection in dropbox changed
        {            
            addInterval = Convert.ToInt32(textBox1.Text);
            whichInterval = Convert.ToInt32(comboBox1.SelectedIndex);
        }

        private void textBox1_Leave(object sender, EventArgs e) //current textbox unfocused
        {            
            addInterval = Convert.ToInt32(textBox1.Text);
            whichInterval = Convert.ToInt32(comboBox1.SelectedIndex);
        }

        public static EventHandler OnButtonClick { get; set; }

        private void addUC_Click(object sender, EventArgs e)
        {
            if (OnButtonClick != null)
            {                
                OnButtonClick(this.addUC, e);
            }
        }

        private void removeUC_Click(object sender, EventArgs e)
        {
            if (OnButtonClick != null)
                OnButtonClick(this.removeUC, e);
        }


    }
}
