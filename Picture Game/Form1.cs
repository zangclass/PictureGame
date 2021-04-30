using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    if(setPicCounter == 2)
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

            foreach (var item in PanelBoarde.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    var obj = item as Button;
                    if (obj.Tag != null)
                    {
                        listBox1.Items.Add(obj.Tag.ToString());
                    }
                    else
                    {
                        listBox1.Items.Add("Null");
                    }
                }
            }
        }

        private void Checkplay(Button btn)
        {
            MessageBox.Show(btn.Tag.ToString()); ;
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
