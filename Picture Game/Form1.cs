using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _counterRoll = 0;
        int _aliScore = 0, _ebrahimScore = 0;
        private Button _firstSelect, _secendSelect;
        private Button SearchButton(string buttonName)
        {
            foreach (var item in PanelBoarde.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    var obj = item as Button;
                    if (obj.Name == buttonName)
                    {
                        return obj;
                    }
                }
            }
            return null;
        }
        private void SetButtonPicture()
        {
            int picCount = 1, setPicCounter = 0;
            while (picCount < 11)
            {
                Random rand = new Random();
                var generateRandomNumber = rand.Next(1, 21);
                var btnSearch = SearchButton("btn" + generateRandomNumber);
                if (btnSearch.Tag == null)
                {
                    btnSearch.Tag = picCount;

                    setPicCounter++;
                    if (setPicCounter == 2)
                    {
                        setPicCounter = 0;
                        picCount++;
                    }
                }

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetButtonPicture();
            lblAliScore.Text = _aliScore.ToString();
            lblEbrahimScore.Text = _ebrahimScore.ToString();
        }
        private void ResetGame()
        {
            foreach (var item in PanelBoarde.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    var obj = item as Button;
                    obj.BackgroundImage = null;
                    obj.Tag = null;
                    obj.Enabled = true;
                }
            }
            SetButtonPicture();
            _ebrahimScore = _aliScore = 0;
            lblAliScore.Text = "0";
            lblEbrahimScore.Text = "0";
            lblPlayer.Text = "1";
            _counterRoll = 0;
            _firstSelect = null; 
            _secendSelect = null;
        }
        private void Checkplay(Button btn)
        {
            _counterRoll++;
            if (_counterRoll == 1)
            {
                _firstSelect = btn;
                _firstSelect.BackgroundImage = imageList1.Images[int.Parse(_firstSelect.Tag.ToString()) - 1];
                _firstSelect.Enabled = false;
            }
            else
            {
                _secendSelect = btn;
                _secendSelect.BackgroundImage = imageList1.Images[int.Parse(_secendSelect.Tag.ToString()) - 1];
                _secendSelect.Enabled = false;
            }
            if (_counterRoll == 2)
            {
                Application.DoEvents();
                Thread.Sleep(1000);

                if (int.Parse(_firstSelect.Tag.ToString()) == int.Parse(_secendSelect.Tag.ToString()))
                {
                    _firstSelect.BackgroundImage = imageList1.Images[int.Parse(_firstSelect.Tag.ToString()) - 1];
                    _secendSelect.BackgroundImage = imageList1.Images[int.Parse(_firstSelect.Tag.ToString()) - 1];

                    if (lblPlayer.Text == "1")
                    {
                        _aliScore++;
                        lblAliScore.Text = _aliScore.ToString();
                    }
                    else
                    {
                        _ebrahimScore++;
                        lblEbrahimScore.Text = _ebrahimScore.ToString();
                    }

                }
                else
                {
                    _firstSelect.BackgroundImage = null;
                    _secendSelect.BackgroundImage = null;

                    _firstSelect.Enabled = true;
                    _secendSelect.Enabled = true;
                }

                _counterRoll = 0;

                lblPlayer.Text = lblPlayer.Text == "1" ? "2" : "1";

                if ((_aliScore + _ebrahimScore) == 10)
                {
                    if (_aliScore == _ebrahimScore)
                    {
                        MessageBox.Show("بازی مساوی شد.");
                    }
                    else if (_aliScore > _ebrahimScore)
                    {
                        MessageBox.Show("علی بازی را برد.");
                    }
                    else
                    {
                        MessageBox.Show("ابراهیم بازی را برد.");
                    }

                    ResetGame();
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Checkplay(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Checkplay(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Checkplay(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Checkplay(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Checkplay(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Checkplay(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Checkplay(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Checkplay(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Checkplay(btn9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Checkplay(btn10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Checkplay(btn11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Checkplay(btn12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Checkplay(btn13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            Checkplay(btn14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Checkplay(btn15);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Checkplay(btn16);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            Checkplay(btn17);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            Checkplay(btn18);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            Checkplay(btn19);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Checkplay(btn20);
        }
    }
}
