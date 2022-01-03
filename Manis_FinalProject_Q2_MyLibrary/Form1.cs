using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manis_FinalProject_Q2_MyLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void selectionButton_Click(object sender, EventArgs e)
        {
            const double PRICE = 3.99;
            int COUNT = bookListBox.SelectedItems.Count;
            double Price = COUNT * PRICE;
            outPutLabel.Text = COUNT + " Selections, price is: " + Price.ToString("c");
        }
    }
}
