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
        ucTimeInterval[] entryPanel = new ucTimeInterval[4];    //array of UC... 4 MAX

        private int getCurrentIndex()                       //mmmm possibly will use.
        {
            foreach (ucTimeInterval element in entryPanel)
            {
                if (element.Name == "current")
                    return getCurrentIndex();
            }
            return 0;               //might change if problems arrise.~~~
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            ucTimeInterval.OnButtonClick += new EventHandler(UserControl_ButtonClick);   //tie UC event to handler in form
            ucTimeInterval initial = new ucTimeInterval();          //create an initial uc
            initial.Location = new Point(104, 50);              
            initial.Name = "current";                           //name possibly used to organize array
            entryPanel[0] = initial;                    //first array index 
            this.Controls.Add(initial);                 
        }

        

        private void UserControl_ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).Name == "addUC")
                {
                    label1.Text = "Add";

                }
                if ((sender as Button).Name == "removeUC")
                {
                    label1.Text = "Remove";
                }
            }
            
        }



        

    }
}
