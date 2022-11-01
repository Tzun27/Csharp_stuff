using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace F74105012_practice_6_2
{
    public partial class Form1 : Form
    {
        string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        bool calling = false;
        int press = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void B6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string path = @input.Text;
            if (path == "")
                MessageBox.Show("Empty String");

            else if (File.Exists(path) == false)
            {
                MessageBox.Show("Directory Not Found");
            }
            else
            {
                FileInfo f = new FileInfo(path);
                String s = f.FullName;
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(logs.Text);
                }
                MessageBox.Show("Done\n" + s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            play697Hz.URL = @"697.wav";
            play770Hz.URL = @"770.wav";
            play852Hz.URL = @"852.wav";
            play941Hz.URL = @"941.wav";
            play1209Hz.URL = @"1209.wav";
            play1336Hz.URL = @"1336.wav";
            play1477Hz.URL = @"1477.wav";

            play697Hz.Ctlcontrols.stop();
            play770Hz.Ctlcontrols.stop();
            play852Hz.Ctlcontrols.stop();
            play941Hz.Ctlcontrols.stop();
            play1209Hz.Ctlcontrols.stop();
            play1336Hz.Ctlcontrols.stop();
            play1477Hz.Ctlcontrols.stop();
        }

        private void B1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play697Hz.Ctlcontrols.play();
                play1209Hz.Ctlcontrols.play();
                display.Text += "1";
            }
        }

        private void B1_MouseUp(object sender, MouseEventArgs e)
        {
            play697Hz.Ctlcontrols.stop();
            play1209Hz.Ctlcontrols.stop();
        }

        private void B2_MouseDown(object sender, MouseEventArgs e)
        {
            if(tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play697Hz.Ctlcontrols.play();
                play1336Hz.Ctlcontrols.play();
                display.Text += "2";
            }
        }

        private void B2_MouseUp(object sender, MouseEventArgs e)
        {
            play697Hz.Ctlcontrols.stop();
            play1336Hz.Ctlcontrols.stop();
        }

        private void B3_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play697Hz.Ctlcontrols.play();
                play1477Hz.Ctlcontrols.play();
                display.Text += "3";
            }
        }

        private void B3_MouseUp(object sender, MouseEventArgs e)
        {
            play697Hz.Ctlcontrols.stop();
            play1477Hz.Ctlcontrols.stop();
        }

        private void B4_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play770Hz.Ctlcontrols.play();
                play1209Hz.Ctlcontrols.play();
                display.Text += "4";
            }
        }

        private void B4_MouseUp(object sender, MouseEventArgs e)
        {
            play770Hz.Ctlcontrols.stop();
            play1209Hz.Ctlcontrols.stop();
        }

        private void B5_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play770Hz.Ctlcontrols.play();
                play1336Hz.Ctlcontrols.play();
                display.Text += "5";
            }
        }

        private void B5_MouseUp(object sender, MouseEventArgs e)
        {
            play770Hz.Ctlcontrols.stop();
            play1336Hz.Ctlcontrols.stop();
        }

        private void B6_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play770Hz.Ctlcontrols.play();
                play1477Hz.Ctlcontrols.play();
                display.Text += "6";
            }
        }

        private void B6_MouseUp(object sender, MouseEventArgs e)
        {
            play770Hz.Ctlcontrols.stop();
            play1477Hz.Ctlcontrols.stop();
        }

        private void B7_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play852Hz.Ctlcontrols.play();
                play1209Hz.Ctlcontrols.play();
                display.Text += "7";
            }
        }

        private void B7_MouseUp(object sender, MouseEventArgs e)
        {
            play852Hz.Ctlcontrols.stop();
            play1209Hz.Ctlcontrols.stop();
        }

        private void B8_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play852Hz.Ctlcontrols.play();
                play1336Hz.Ctlcontrols.play();
                display.Text += "8";
            }
        }

        private void B8_MouseUp(object sender, MouseEventArgs e)
        {
            play852Hz.Ctlcontrols.stop();
            play1336Hz.Ctlcontrols.stop();
        }

        private void B9_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play852Hz.Ctlcontrols.play();
                play1477Hz.Ctlcontrols.play();
                display.Text += "9";
            }
        }

        private void B9_MouseUp(object sender, MouseEventArgs e)
        {
            play852Hz.Ctlcontrols.stop();
            play1477Hz.Ctlcontrols.stop();
        }

        private void BStar_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play941Hz.Ctlcontrols.play();
                play1209Hz.Ctlcontrols.play();
                display.Text += "*";
            }
        }

        private void BStar_MouseUp(object sender, MouseEventArgs e)
        {
            play941Hz.Ctlcontrols.stop();
            play1209Hz.Ctlcontrols.stop();
        }

        private void B0_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play941Hz.Ctlcontrols.play();
                play1336Hz.Ctlcontrols.play();
                display.Text += "0";
            }
        }

        private void B0_MouseUp(object sender, MouseEventArgs e)
        {
            play941Hz.Ctlcontrols.stop();
            play1336Hz.Ctlcontrols.stop();
        }

        private void BHash_MouseDown(object sender, MouseEventArgs e)
        {
            if (tab.SelectedIndex == 0)
            {
                if (display.Text == "Telephone")
                    display.Text = "";

                play941Hz.Ctlcontrols.play();
                play1477Hz.Ctlcontrols.play();
                display.Text += "#";
            }
        }

        private void BHash_MouseUp(object sender, MouseEventArgs e)
        {
            play941Hz.Ctlcontrols.stop();
            play1477Hz.Ctlcontrols.stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            press++;
            if(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play697Hz.Ctlcontrols.play();
                    play1209Hz.Ctlcontrols.play();
                    if(press == 1)
                        display.Text += "1";
                }
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play697Hz.Ctlcontrols.play();
                    play1336Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "2";
                }
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play697Hz.Ctlcontrols.play();
                    play1477Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "3";
                }
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play770Hz.Ctlcontrols.play();
                    play1209Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "4";
                }
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play770Hz.Ctlcontrols.play();
                    play1336Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "5";
                }
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play770Hz.Ctlcontrols.play();
                    play1477Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "6";
                }
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play852Hz.Ctlcontrols.play();
                    play1209Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "7";
                }
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play852Hz.Ctlcontrols.play();
                    play1336Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "8";
                }
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play852Hz.Ctlcontrols.play();
                    play1477Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "9";
                }
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play941Hz.Ctlcontrols.play();
                    play1336Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "0";
                }
            }
            else if (e.KeyCode == Keys.ShiftKey && (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8))
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play941Hz.Ctlcontrols.play();
                    play1209Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "*";
                }
            }
            else if (e.KeyCode == Keys.ShiftKey && (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3))
            {
                if (tab.SelectedIndex == 0)
                {
                    if (display.Text == "Telephone")
                        display.Text = "";

                    play941Hz.Ctlcontrols.play();
                    play1477Hz.Ctlcontrols.play();
                    if (press == 1)
                        display.Text += "#";
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (tab.SelectedIndex == 0)
                    display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (tab.SelectedIndex == 0)
                {
                    calling = !calling;
                    if (calling)
                    {
                        BCall.Image = global::F74105012_practice_6_2.Properties.Resources.NoCall1;
                        B0.Enabled = false;
                        B1.Enabled = false;
                        B2.Enabled = false;
                        B3.Enabled = false;
                        B4.Enabled = false;
                        B5.Enabled = false;
                        B6.Enabled = false;
                        B7.Enabled = false;
                        B8.Enabled = false;
                        B9.Enabled = false;
                        BStar.Enabled = false;
                        BHash.Enabled = false;
                    }
                    else
                    {
                        BCall.Image = global::F74105012_practice_6_2.Properties.Resources.Call1;
                        if (press == 1)
                        {
                            logs.Text += display.Text;
                            logs.Text += "\n";
                        }

                        B0.Enabled = true;
                        B1.Enabled = true;
                        B2.Enabled = true;
                        B3.Enabled = true;
                        B4.Enabled = true;
                        B5.Enabled = true;
                        B6.Enabled = true;
                        B7.Enabled = true;
                        B8.Enabled = true;
                        B9.Enabled = true;
                        BStar.Enabled = true;
                        BHash.Enabled = true;

                        display.Text = "Telephone";
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            press = 0;
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                play697Hz.Ctlcontrols.stop();
                play1209Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                play697Hz.Ctlcontrols.stop();
                play1336Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                play697Hz.Ctlcontrols.stop();
                play1477Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                play770Hz.Ctlcontrols.stop();
                play1209Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                play770Hz.Ctlcontrols.stop();
                play1336Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                play770Hz.Ctlcontrols.stop();
                play1477Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                play852Hz.Ctlcontrols.stop();
                play1209Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                play852Hz.Ctlcontrols.stop();
                play1336Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                play852Hz.Ctlcontrols.stop();
                play1477Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                play941Hz.Ctlcontrols.stop();
                play1336Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.ShiftKey && (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8))
            {
                play941Hz.Ctlcontrols.stop();
                play1209Hz.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.ShiftKey && (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3))
            {
                play941Hz.Ctlcontrols.stop();
                play1477Hz.Ctlcontrols.stop();
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void BCall_Click(object sender, EventArgs e)
        {
            calling = !calling;
            if(calling)
            {
                BCall.Image = global::F74105012_practice_6_2.Properties.Resources.NoCall1;
                B0.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                B4.Enabled = false;
                B5.Enabled = false;
                B6.Enabled = false;
                B7.Enabled = false;
                B8.Enabled = false;
                B9.Enabled = false;
                BStar.Enabled = false;
                BHash.Enabled = false;
            }
            else
            {
                BCall.Image = global::F74105012_practice_6_2.Properties.Resources.Call1;
                logs.Text += display.Text;
                logs.Text += "\n";

                B0.Enabled = true;
                B1.Enabled = true;
                B2.Enabled = true;
                B3.Enabled = true;
                B4.Enabled = true;
                B5.Enabled = true;
                B6.Enabled = true;
                B7.Enabled = true;
                B8.Enabled = true;
                B9.Enabled = true;
                BStar.Enabled = true;
                BHash.Enabled = true;

                display.Text = "Telephone";
            }
        }

        private void BDel_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Remove(display.Text.Length - 1, 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
