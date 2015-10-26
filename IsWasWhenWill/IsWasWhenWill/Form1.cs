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
        ucTimeInterval[] entryPanel = new ucTimeInterval[4]; 
        Point mainAnchor = new Point(104, 50);
        Point nextP;
        Point currentP;
        Point previousP;

        private void setCurrent(ucTimeInterval ucThis)
        {
            //use entryPanel
            ucThis.Name = "this";
            for (int l = 0; l < entryPanel.Length; l++)
            {
                if (entryPanel[l] != null)
                {
                    if (entryPanel[l].Name != "this")
                        entryPanel[l].Name = "";
                }
            }
            ucThis.Name = "Current";
            previousP = currentP;
            ucLocations();
        }
        private int  getCurrentIndex()
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
            if (isOnly())
            {
                int u = firstUsedIndex();
                entryPanel[u].Location = mainAnchor;
            }
            int x = getCurrentIndex();
            if (x != 5)
            {
                currentP = entryPanel[x].Location;
                nextP = new Point(currentP.X, currentP.Y + 30);
                for(int t = 0; t < entryPanel.Length; t++)
                {
                    if (entryPanel[t] != null && entryPanel[t].Location == nextP)
                    {
                        entryPanel[t].Location = new Point(nextP.X, nextP.Y + 30);
                    }
                }
            }
        }
 
        private int  ucCount()
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
        private bool isEmpty()
        {
            foreach (ucTimeInterval uc in entryPanel)
            {
                if (uc != null)
                    return false;
            }
            return true;
        }
        private bool isFull()
        {
            foreach (ucTimeInterval uc in entryPanel)
            {
                if (uc == null)
                    return false;
            }
            return true;
        }
        private bool isOnly()
        {
            int only = 0;
            foreach (ucTimeInterval uc in entryPanel)
            {
                if (uc != null)
                    only++;
                if (only > 1)
                    return false;
            }
            return true;
        }
        private int firstEmptyIndex()
        {
            int e;

            for (e = 0; e < entryPanel.Length; e++)
            {
                if (entryPanel[e] == null)
                    return e;
            }
            return e;
        }
        private int firstUsedIndex()
        {
            int u;

            for (u = 0; u < entryPanel.Length; u++)
            {
                if (entryPanel[u] != null)
                    return u;
            }
            return u;
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
            setCurrent((sender as ucTimeInterval));
        }
        
        private void addingUC()
        {
            if (isFull())
                return;
            else
            {
                int c = firstEmptyIndex();
                if (c != 5)
                {
                    entryPanel[c] = new ucTimeInterval();
                    entryPanel[c].Location = nextP;
                    entryPanel[c].Name = "";
                    this.Controls.Add(entryPanel[c]);
                }
            }
        }
        private void removingUC()
        {
            if (!isOnly())
            {
                int c = getCurrentIndex();

                foreach (Control control in entryPanel[c].Controls)
                {
                    control.Dispose();
                }
                entryPanel[c].Controls.Clear();
                entryPanel[c].Dispose();
                entryPanel[c] = null;
            }
            ucLocations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucTimeInterval.OnEnter += new EventHandler(UserControl_Enter);              //enter handler
            ucTimeInterval.OnButtonClick += new EventHandler(UserControl_ButtonClick);   //tie UC event to handler in form
            ucTimeInterval initial = new ucTimeInterval();                                
            initial.Name = "Initial";
            initial.Location = mainAnchor;
            entryPanel[0] = initial;
            this.Controls.Add(initial);            
        }
    }
}
