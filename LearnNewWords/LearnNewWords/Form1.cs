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
    public partial class formWord : Form
    {

        Bus bus = new Bus();
        public formWord()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListWordGroup();
            dgvListWordGroup.Rows[1].Cells[2].Value = true;
           // list_group_checked.Add(2);
        }
        
        private void LoadListWordGroup()
        {
            try
            { 
                List<WORD_GROUP> list_group = new List<WORD_GROUP>();
                list_group = bus.GetListGroup();
                dgvListWordGroup.DataSource = null;
                dgvListWordGroup.Rows.Clear();
                comboBoxWordGroup.Items.Clear();

                foreach (WORD_GROUP w in list_group)
                {
                    dgvListWordGroup.Rows.Add(w.word_group_id, w.name_word_group);
                    comboBoxWordGroup.Items.Add(w.name_word_group);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadListWord(int word_group_id)
        {
            try
            {
                List<WORD> list_word = new List<WORD>();
                list_word = bus.GetListWord(word_group_id);

                dgvListWord.DataSource = null;
                dgvListWord.Rows.Clear();
             
                foreach(WORD w in list_word)
                {
                    dgvListWord.Rows.Add(w.Word);
                   
                }
              
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                WORD_GROUP word = new WORD_GROUP();
                if(txtAddGroup.Text == "")
                {

                    return;
                }

                if (bus.CheckExistsWordGroup(txtAddGroup.Text.ToString()))
                {
                    MessageBox.Show("Name of group has already in list","TWORD",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    word.name_word_group = txtAddGroup.Text.ToString();
                    bus.InsertWordGroup(word);
                    LoadListWordGroup();
                    txtAddGroup.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           

        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            try
            {
                WORD word = new WORD();
                if(txtWord.Text == "" || txtCategory.Text =="" || txtCategory.Text == ""
                    || txtMean.Text == ""|| txtSentence.Text == "" || comboBoxWordGroup.SelectedIndex == -1)
                {
                    MessageBox.Show("You unfinished items", "TWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                word.Word = txtWord.Text.ToString();
                word.Category = txtCategory.Text.ToString();
                word.Phonetic = txtPhonetic.Text.ToString();
                word.Mean = txtMean.Text.ToString();
                word.Sentence = txtSentence.Text.ToString();
                word.Word_group_id = Convert.ToInt32(comboBoxWordGroup.SelectedIndex) + 1;

                bus.InsertWord(word);
                MessageBox.Show("Add sucessfully", "TWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reset text
                txtWord.Text = "";
                txtCategory.Text = "";
                txtPhonetic.Text = "";
                txtMean.Text = "";
                txtMean.Text = "";
                txtSentence.Text = "";

            }
            catch (Exception  ex)
            {

                MessageBox.Show(ex.ToString(), "TWORD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            // Reset text
            txtWord.Text = "";
            txtCategory.Text = "";
            txtPhonetic.Text = "";
            txtMean.Text = "";
            txtMean.Text = "";
            txtSentence.Text = "";

        }

        private void dgvListWordGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                int temp = int.Parse(dgvListWordGroup.Rows[e.RowIndex].Cells["num_group"].Value.ToString());
                LoadListWord(temp);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


        public static List<int> list_group_checked; 
        private void dgvListWordGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
               
               // list_group_checked.Clear();
                
                if (e.ColumnIndex == 2)
                {
                    if (Convert.ToBoolean(dgvListWordGroup.Rows[e.RowIndex].Cells[2].EditedFormattedValue) == true)
                    {
                        // list_group_checked.Add(e.RowIndex + 1);
                        MessageBox.Show((e.RowIndex + 1).ToString());
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
           
        }


    }
}
