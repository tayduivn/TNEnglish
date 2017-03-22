using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN.Data.Model;
using TN.Data.TNBusiness;

namespace Update_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadWord();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private static Word word;
        private void LoadWord()
        {
            var a = new LearnManager();
          word = a.GetWordNull();

          label1.Text = word.Word1;
          label2.Text = word.Mean;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
               
        }
    }
}
