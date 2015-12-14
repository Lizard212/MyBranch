using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace LearnNewWords
{
    public partial class Form1 : Form
    {

        Bus bus = new Bus();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bus.TestConnection();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

        }
    }
}
