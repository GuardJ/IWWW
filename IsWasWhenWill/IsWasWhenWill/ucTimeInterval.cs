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

        public int addInterval { get; private set; }
        public int whichInterval { get; private set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            addInterval = Convert.ToInt32(textBox1.Text);
            whichInterval = Convert.ToInt32(comboBox1.SelectedIndex);
        }

        private void addUC_Click(object sender, EventArgs e)
        {

        }
    }
}
