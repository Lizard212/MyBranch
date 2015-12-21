using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Threading;
using SpeechLib;
namespace LearnNewWords
{
    public partial class tword : Form
    {

        Bus bus = new Bus();
        public tword()
        {

            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                ShowListWord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        
        public void ShowListWord()
        {
            List<int> list_group_checked = new List<int>();


            list_group_checked = formWord.list_group_checked;
            
           
            
            //list_group_checked.Add(2);
            List<WORD> list_word = new List<WORD>();

            foreach (int x in list_group_checked)
            {
                list_word.AddRange(bus.GetListWord(x));
            }
            //list_word = bus.GetListWord(2);
            int loop = 1;
            WORD word = new WORD();

             do
            {
                listBox1.Items.Clear();
                word = RandListWord(list_word);
                string item1 = string.Format("{0} ({1})", word.Word, word.Category);
                string item2 = word.Phonetic.ToString();
                string item3 = word.Mean.ToString();
                string item4 = word.Sentence.ToString();

                //listBox1.Items.Add("tung is a kids");
                //listBox1.Items.Add("xxxasdfadfasdfasdfasdf");
                listBox1.Items.Add(item1);
                listBox1.Items.Add(item2);
                listBox1.Items.Add(item3);
                listBox1.Items.Add(item4);

            }
            while (loop == 0);
            
        }

        // Random list word
        public WORD RandListWord(List<WORD > list_word)
        {
            Random ran = new Random();
            return list_word[ran.Next(list_word.Count)];
        }

        #region Context menu
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formWord formword = new formWord();
            formword.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Drag from
        // Drag from 
        private bool dragging = false;
        private Point drag_cursor_point;
        private Point drag_from_point;

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            drag_cursor_point = Cursor.Position;
            drag_from_point = this.Location;
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(drag_cursor_point));
                this.Location = Point.Add(drag_from_point, new Size(dif));
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        #endregion

        #region Speaker
        /// <summary>
        /// Button speaker 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            SpVoice voice = new SpVoice();
            if(listBox1.Items[0].ToString() != null && listBox1.Items[0].ToString() != "0")
            {
                voice.Speak(listBox1.Items[0].ToString(), SpeechVoiceSpeakFlags.SVSFDefault);
            }
           

        }

        private void btnSpeaker_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            drag_cursor_point = Cursor.Position;
            drag_from_point = this.Location;
        }

        private void btnSpeaker_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(drag_cursor_point));
                this.Location = Point.Add(drag_from_point, new Size(dif));
            }
        }

        private void btnSpeaker_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnSpeaker_MouseHover(object sender, EventArgs e)
        {
            btnSpeaker.BackColor = System.Drawing.Color.DarkCyan;
        }

        private void btnSpeaker_MouseLeave(object sender, EventArgs e)
        {
            btnSpeaker.BackColor = System.Drawing.Color.Silver;
        }
        #endregion
    }
}
