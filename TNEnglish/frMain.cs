using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Windows.Forms;
using TN.Core.Control;
using TN.Core.File;
using TN.Core.Model;
using TN.Data.Model;
using TN.Data.TNBusiness;
using WMPLib;

namespace TNEnglish
{
    public partial class frMain : Form
    {

        private static Account _account;
        private WindowsMediaPlayer _wplayer;
        private static readonly string LinkApp = Application.StartupPath;
        private static IList<Learn> _listWord;
        private static int _playnum, _noword = 1, _point,_total =9*10*30, _fail = 0,_numfail;
        private static Learn _learn;
        public frMain()
        {
            InitializeComponent();
            panelDangNhap.Location = new Point(0, 40);
            panelDangNhap.Visible = true;
            panelWord.Visible = false;
            panelTotal.Visible = false;
            txtUsername.Select();
            lbName.Text = "";
            lbThoat.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login(); //Dday laf hamf  Login
        }

        private void Login()
        {
            var username = txtUsername.Text;
            var passwrod = txtPassword.Text;
            IAccount account = new AccountManager();
            _account = account.LoginAccount(username, passwrod);

            if (_account != null)
            {
                lbName.Text = _account.FullName;
                lbThoat.Text = "(Đăng xuất)";
               

                txtUsername.Text = "";
                txtPassword.Text = "";


                panelWord.Location = new Point(0, 40);
                panelDangNhap.Visible = false;
               
                panelWord.Visible = true;

                panelWordOne.Location = new Point(50, 70);
                panelWordOne.Visible = true;
                panelWordTwo.Visible = false;
                panelTienTrinh.Visible = false;

                _listWord = LearnControl.ListWord(_account.Id, _account.Username, _account.Password);
                button2.Text = "Bắt đầu";
                _check = true;
                GetWord();
                //-----------------------------


                lbWord.Text = _learn.Word;
                lbMean.Text = _learn.Mean;
                lbWordRem.Text = _learn.WordRemember;
                LoadImage(_learn.Image);

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lbName.Text = "";
            lbThoat.Text = "";
            if (_account != null)
                FileLearn.SaveProcess(_listWord, _account.Username, _account.Password);
            _account = null;
            panelDangNhap.Visible = true;
            panelWord.Visible = false;
           
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
           

        }

        private bool _check = true;
        private void button2_Click(object sender, EventArgs e)
        {

            if (_check)
            {
                //button begin
                _check = false;

                LoadWord();
            }
            else
            {
                button2.Text = "Kiểm tra";
                CheckWord();

            }
            txtInputWord.Select();
            this.Focus();
            txtInputWord.Focus();

        }

        private void LoadWord()
        {



            panelWordOne.Location = new Point(50, 70);
            panelWordTwo.Location = new Point(50, 70);
            panelWordOne.Visible = true;
            panelWordTwo.Visible = false;
            panelTienTrinh.Visible = true;

            try
            {
                _wplayer = new WindowsMediaPlayer { URL = LinkApp + "\\Appdata\\Sound\\" + _learn.Audio };
                _temp = 0;
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer2.Interval = 100;
                button2.Visible = false;
            }
            catch (Exception e)
            {
                // ignored
            }

            lbWord.Text = _learn.Word;
            lbMean.Text = _learn.Mean;
            lbWordRem.Text = _learn.WordRemember;
            LoadImage(_learn.Image);

        }

        public void GetWord()
        {
            if (_learn != null)
            {

                _listWord.First(x => x.Id == _learn.Id).NumFail = _fail;
                if (_fail < 1)
                {
                    _listWord.First(x => x.Id == _learn.Id).No = 0;
                    
                    
                }
                else if (_fail <=2)
                {
                    _listWord.First(x => x.Id == _learn.Id).No--;
                    
                }
                else if (_fail > 2 && _fail < 5)
                {
                    _listWord.First(x => x.Id == _learn.Id).No++;
                    _point -= 90;
                }
                else
                {
                    _listWord.First(x => x.Id == _learn.Id).No += 2;
                    _point -= 9*10*2;
                    
                    
                }

            }


            _learn = _listWord.Where(x => x.No > 0).OrderBy(x => Guid.NewGuid()).ToList().ElementAt(0);

            if (_learn == null)
            {
                panelDangNhap.Visible = false;
                panelTotal.Location = new Point(0, 40);
               
                panelWord.Visible = false;
                panelTotal.Visible = true;

                int dathuoc = 0;
                foreach (var temp in _listWord)
                {
                  
                    
                   
                     
                        if (temp.NumFail >= 9)
                        {
                           
                        }
                        else if (temp.NumFail >= 5)
                        {
                           
                        }
                        else if (temp.NumFail >= 3)
                        {
                            

                        }
                        else if (temp.NumFail < 2)
                        {
                            dathuoc++;

                        }
                        if (temp.Hight)
                        {
                           
                        }
                    if (temp.Done)
                    {
                        dathuoc++;
                    }
                }
                label10.Text = dathuoc + "/30";
                label11.Text = _numfail + "";
                LearnControl.SaveLearn(_listWord);
            }
            else
            {
                _learn.Point = 0;
                _learn.NumFail = 0;
            }

        }

        private void LearnWord()
        {
            if (_noword > 9)
            {
                _playnum = 0;
                GetWord();
                _noword = 1;
                
                LoadWord();

            }
            else
            {
                panelWordOne.Location = new Point(50, 70);
                panelWordTwo.Location = new Point(50, 70);
                panelWordOne.Visible = false;
                panelWordTwo.Visible = true;
                panelTienTrinh.Visible = true;

                switch (_noword)
                {
                    case 1:
                        labelText.Text = _learn.Word;
                        pictureBoxWord2.Visible = false;
                        labelText.Visible = true;
                        break;
                    case 2:
                        if (_learn.WordRemember == null || _learn.WordRemember.Trim() == "")
                            labelText.Text = _learn.Word;
                        else
                            labelText.Text = _learn.WordRemember;
                        pictureBoxWord2.Visible = false;
                        labelText.Visible = true;
                        break;
                    case 3:
                        labelText.Visible = true;
                        labelText.Text = StringControl.ToHyphen(_learn.Word, 2);
                        pictureBoxWord2.Visible = false;
                        break;
                    case 4:
                        if (!LoadImage(_learn.Image))
                        {
                            labelText.Text = _learn.Word;
                            pictureBoxWord2.Visible = false;
                        }
                        else
                        {
                            labelText.Visible = false;
                            pictureBoxWord2.Visible = true;
                        }
                        break;
                    case 5:
                        labelText.Visible = true;
                        labelText.Text = _learn.Mean;
                        pictureBoxWord2.Visible = false;
                        break;
                    case 6:
                        if (_learn.WordRemember == null || _learn.WordRemember.Trim() == "")
                            labelText.Text = _learn.Word;
                        else
                            labelText.Text = _learn.WordRemember;
                        pictureBoxWord2.Visible = false;
                        labelText.Visible = true;
                        break;
                    case 7:
                        labelText.Visible = true;
                        labelText.Text = StringControl.ToHyphen(_learn.Word, 3);
                        pictureBoxWord2.Visible = false;
                        break;
                    case 8:
                        labelText.Visible = true;
                        labelText.Text = StringControl.ToHyphen(_learn.Word, true);
                        pictureBoxWord2.Visible = false;
                        break;
                    case 9:
                        labelText.Visible = true;
                        labelText.Text = StringControl.ToHyphen(_learn.Word, false);
                        pictureBoxWord2.Visible = false;
                        break;
                }


            }



        }



        private bool LoadImage(string image)
        {
            try
            {
                pictureBoxWord.Image = Image.FromFile(LinkApp + "\\Appdata\\Images\\" + image.Trim() + ".jpg");
                pictureBoxWord2.Image = Image.FromFile(LinkApp + "\\Appdata\\Images\\" + image.Trim() + ".jpg");
                return true;

            }
            catch (Exception)
            {
                try
                {
                    pictureBoxWord.Image = Image.FromFile(LinkApp + "\\Appdata\\Images\\" + image.Trim() + ".png");
                    pictureBoxWord2.Image = Image.FromFile(LinkApp + "\\Appdata\\Images\\" + image.Trim() + ".png");

                    return true;
                }
                catch (Exception)
                {
                    pictureBoxWord.Image = Image.FromFile(LinkApp + "\\img\\noimg.jpg");
                    pictureBoxWord2.Image = Image.FromFile(LinkApp + "\\img\\noimg.jpg");
                    return true;

                }

            }
        }
        Label _label = new Label();
        private void LoadStatus(int width)
        {
            _label.Height = panelTienTrinh.Height;
            _label.BackColor = Color.LawnGreen;
            _label.Font = new Font(new FontFamily("Consolas"), 13);
            _label.ForeColor = Color.White;
            _label.TextAlign = ContentAlignment.TopCenter;
            panelTienTrinh.Controls.Add(_label);
            panelTienTrinh.Refresh();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _wplayer.controls.play();
            _playnum++;
            if (_playnum >= 5)
                timer1.Enabled = false;
        }

        private int _temp;
        private void timer2_Tick(object sender, EventArgs e)
        {

            LoadStatus(_temp);
            _label.Text = (_temp / 20) + "/5";
            _label.Width = (int)(((double)panelTienTrinh.Width / 100) * _temp);
            _temp += 2;
            if (_temp <= 100) return;
            timer2.Enabled = false;
            timer1.Enabled = false;
            txtInputWord.Text="";
            txtInputWord.SelectAll();
            button2.Visible = true;
            button2.Text = "Kiểm Tra";
            _label.Width = (int)((panelTienTrinh.Width / 100) * (((double)_point / 1800) * 100));
            _label.Text = String.Format("{0:0.##}", (((double)_point / 1800) * 100)) + "%";
            LearnWord();


        }

        private void CheckWord()
        {
            var text = txtInputWord.Text.Trim().ToLower();
            if (text.Equals(_learn.Word.ToLower()))
            {
                txtInputWord.ForeColor = Color.Blue;
                pictureBox1.Visible = false;

                _noword++;
                _learn.Point += 10;
                _point += 10;
                LearnWord();
            }
            else
            {
                pictureBox1.Visible = true;
                _learn.Point -= 15;
                _fail++;
                _numfail++;
                txtInputWord.ForeColor = Color.Red;

            }
            txtInputWord.Text = "";
            timer1.Enabled = true;
            _label.Width = (int)((panelTienTrinh.Width / 100) * (((double)_point / 1800) * 100));
            _label.Text = String.Format("{0:0.##}", (((double)_point / 1800) * 100)) + "%";

        }

        private void txtInputWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInputWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckWord();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();

        }

        private void frMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_account != null) FileLearn.SaveProcess(_listWord, _account.Username, _account.Password);
        }

        private void frMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_account != null)
                FileLearn.SaveProcess(_listWord, _account.Username, _account.Password);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(!_learn.Done ? "Appdata/Icon/ok.png" : "Appdata\\Icon\\ok1.png");
            _learn.Done = !_learn.Done;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(!_learn.Hight ? "Appdata/Icon/star1.png" : "Appdata/Icon/star.png");
            _learn.Hight = !_learn.Hight;
        }

        private string wordtemp;
        private bool labelstatus;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            labelstatus = labelText.Visible;
            timer3.Enabled = true;
            if (labelText.Visible)
            {
                wordtemp = labelText.Text;
                if (_learn.WordRemember == null)
                    labelText.Text = _learn.Word;
                else
                    labelText.Text = _learn.WordRemember;
            }
            else
            {
                labelText.Visible = true;
                pictureBoxWord2.Visible = false;

                if (_learn.WordRemember == null)
                    labelText.Text = _learn.Word;
                else
                    labelText.Text = _learn.WordRemember;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (labelstatus)
            {
                labelText.Text = wordtemp;

            }
            else
            {
                labelText.Visible = false;
                pictureBoxWord2.Visible = true;
            }
            timer3.Enabled = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }



}
