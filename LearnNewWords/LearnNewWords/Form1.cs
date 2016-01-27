using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearnNewWords
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            textboxWord.Text = "Enter a new word...";


        }



        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEx1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void textboxWord_MouseClick(object sender, MouseEventArgs e)
        {
            if (textboxWord.Text == "Enter a new word...")
            {
                textboxWord.Text = "";
            }
            

        }

        private void textboxWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX4_MouseClick(object sender, MouseEventArgs e)
        {
            if(textboxGroup.Text == "Enter a new group...")
            {
                textboxGroup.Text = "";
            }
        }

        private void textboxSearch_Click(object sender, EventArgs e)
        {
            if(textboxSearch.Text == "Search words or gourps...")
            {
                textboxSearch.Text = "";
            }
        }
    }
}
