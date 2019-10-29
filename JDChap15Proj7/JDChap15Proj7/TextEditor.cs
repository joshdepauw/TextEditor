//Josh Depauw
//.Net 2
//Chapter 15 Project 7

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDChap15Proj7
{
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }
        //creates a new MessageBox when File>New is clicked
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new child
            var current = new ChildForm();
            current.MdiParent = TextEditor.ActiveForm;
            current.Show();
        }

        //closes out of the current selected child MessageBox when File>close is clicked
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (ChildForm.ActiveForm != null)
                {
                    //which page is selected
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Close();
                }
            }
            //error handling for if no MessageBoxs are open
            catch (NullReferenceException) {
                MessageBox.Show("You must have a child form open in order to close one out!");
            }
        }  
        //Exits the program when File>Exit is clicked
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //tile in cascade
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }               
        //tile horizontally
        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        //tile vertically
        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //reset checkmarks for Size ToolStripMenuItem
        private void ClearSize()
        {
            //clear all checkmarks
            eightToolStripMenuItem.Checked = false;
            twelveToolStripMenuItem.Checked = false;
            sixteenToolStripMenuItem.Checked = false;
            twentyToolStripMenuItem.Checked = false;
            twentyfourToolStripMenuItem.Checked = false;
        }

        //update and set size to 8
        private void eightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearSize();//clear out current size
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font(current.Font.Name, 8);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        //update and set size to 12
        private void twelveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearSize();//clear out current size
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font(current.Font.Name, 12);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        //update and set size to 16
        private void sixteenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearSize();//clear out current size
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font(current.Font.Name, 16);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        //update and set size to 20
        private void twentyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearSize();//clear out current size
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font(current.Font.Name, 20);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        //update and set size to 24
        private void twentyfourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearSize();//clear out current size
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font(current.Font.Name, 24);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        //reset checkmarks for Font ToolStripMenuItems
        private void ClearFont()//clear all checkmarks
        {
            timesToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            comicToolStripMenuItem.Checked = false;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearFont();//clear font
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font("Arial", current.Font.Size);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void comicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearFont();//clear font
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font("Comic Sans MS", current.Font.Size);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void timesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearFont();//clear font
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font("Times New Roman", current.Font.Size);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                   ClearFont();//clear font
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    current.Font = new Font("Courier New", current.Font.Size);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        //reset checkmarks for Color ToolStripMenuItem
        private void ClearColor()
        {
            //clear all checkmarks
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false; 
            yellowToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;         
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {                   
                    ClearColor(); //reset checkmarks for Color ToolStripMenuItems
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    ActiveMdiChild.Controls["displayRichTextBox"].ForeColor = Color.Black;
                    blackToolStripMenuItem.Checked = true;
                   
                   
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearColor(); //reset checkmarks for Color ToolStripMenuItems
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    ActiveMdiChild.Controls["displayRichTextBox"].ForeColor = Color.Blue;                    
                    blueToolStripMenuItem.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearColor(); //reset checkmarks for Color ToolStripMenuItems
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    ActiveMdiChild.Controls["displayRichTextBox"].ForeColor = Color.Red;
                    redToolStripMenuItem.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearColor(); //reset checkmarks for Color ToolStripMenuItems
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    ActiveMdiChild.Controls["displayRichTextBox"].ForeColor = Color.Green;
                    greenToolStripMenuItem.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearColor(); //reset checkmarks for Color ToolStripMenuItems
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    ActiveMdiChild.Controls["displayRichTextBox"].ForeColor = Color.Yellow;
                    yellowToolStripMenuItem.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildForm.ActiveForm != null)
                {
                    ClearColor(); //reset checkmarks for Color ToolStripMenuItems
                    ChildForm current = (ChildForm)this.ActiveMdiChild;
                    ActiveMdiChild.Controls["displayRichTextBox"].ForeColor = Color.Purple;
                    purpleToolStripMenuItem.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No window to format");
            }
        }
    }
}
