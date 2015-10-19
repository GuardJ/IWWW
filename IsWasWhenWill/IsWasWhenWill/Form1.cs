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
        ucTimeInterval[] entryPanel = new ucTimeInterval[4]; // new ucTimeInterval[4];    //array of UC... 4 MAX
        Point mainAnchor = new Point(104, 50);
        Point nextP;
        Point currentP;
        Point previousP;
        
        private int getCurrentIndex()                       //mmmm possibly will use...
        {            
            for(int i = 0; i < entryPanel.Length; i++)
            {
                if (entryPanel[i] != null)
                {
                    if (entryPanel[i].Name == "Current" || entryPanel[i].Name == "Initial")
                        return i;
                }
            }
            return 5;
        }
        private void ucLocations()
        {
            for(int i = 0; i < entryPanel.Length; i++)
            {
                if (entryPanel[i] != null)
                {
                    if (entryPanel[i].Name == "Initial")
                        entryPanel[i].Location = mainAnchor;
                    if (entryPanel[i].Name == "Current")
                        entryPanel[i].Location = currentP;
                    if (entryPanel[i].Name == "Previous")
                    {
                        previousP.Y = currentP.Y - 30;
                        entryPanel[i].Location = previousP;
                    }
                    if (entryPanel[i].Name == "Next")
                    {
                        nextP.Y = currentP.Y + 30;
                        entryPanel[i].Location = nextP;
                    }
                }
            }
        }
        private void setCurrent(ucTimeInterval ucThis)
        {
            //use entryPanel
            for (int i = 0; i < entryPanel.Length; i++)
            {
                if (entryPanel[i] != null)
                {
                    if (entryPanel[i].Name == ucThis.Name)
                    {
                        entryPanel[i].Name = "Current";
                        entryPanel[i + 1].Name = "Next";
                        if (entryPanel[i - 1] != null)
                            entryPanel[i - 1].Name = "Previous";
                        if (entryPanel[i - 2] != null)
                            entryPanel[i - 2].Name = "Previous2";

                    }                        
                }
            }
        }
        private int ucCount()
        {
            int nullCount = 0;
            for(int i = 0; i < entryPanel.Length; i++)
            {
                if(entryPanel[i] == null)
                {
                    nullCount += 1;
                }                
            }
            return entryPanel.Length - nullCount;
        }
        private bool isFull()
        {
            foreach (UserControl uc in entryPanel)
            {
                if (uc == null)
                    return false;
            }
            return true;
        }
        private void UserControl_ButtonClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).Name == "addUC")
                {
                    label1.Text = (sender as Button).Parent.Name + " Adding";
                    addingUC();                   
                }
                if ((sender as Button).Name == "removeUC")
                {
                    label1.Text = (sender as Button).Parent.Name + " Removing";
                    removingUC();
                }
            }
        }
        private void UserControl_Enter(object sender, EventArgs e)
        {
            label2.Text = (sender as ucTimeInterval).Name;
            setCurrent((sender as ucTimeInterval));
        }
        
        private void addingUC()
        {
            if (isFull())
                return;
            else
            {
                int p = getCurrentIndex();
                int c = p + 1;
                entryPanel[c] = new ucTimeInterval();
                this.Controls.Add(entryPanel[c]);   
            }
        }
        private void removingUC()
        {
            int c = getCurrentIndex();
                        
            foreach(Control control in entryPanel[c].Controls)
            {
                control.Dispose();
            }
            entryPanel[c].Controls.Clear();
            entryPanel[c].Dispose();
            entryPanel[c] = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucTimeInterval.OnEnter += new EventHandler(UserControl_Enter);              //enter
            ucTimeInterval.OnButtonClick += new EventHandler(UserControl_ButtonClick);   //tie UC event to handler in form
            ucTimeInterval initial = new ucTimeInterval();          //create an initial uc                          
            initial.Name = "Initial";//name possibly used to organize array
            entryPanel[0] = initial;
            ucLocations();           
            this.Controls.Add(initial);
        }
    }
}
