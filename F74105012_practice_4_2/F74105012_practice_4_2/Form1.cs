using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74105012_practice_4_2
{
    public partial class Form1 : Form
    {
        Button[] buttonArray = new Button[16];
        int[] randomArray = new int[16];
        int firstOpened = -1, secondOpened = -1, pairsCorrect = 0;
        int score = 100;
        string playerName;

        public void randArrayGen(ref int[] a)
        {
            int[] array = new int[16];
            Random r = new Random();
            for (int i = 0, j = 0; i < 16; i += 2, j++)
            {
                array[i] = j;
                array[i + 1] = j;
            }

            a = array.OrderBy(x => r.Next()).ToArray();
        }

        public void winCheck()
        {
            if (pairsCorrect == 8)
            {
                DialogResult r = MessageBox.Show("分數：" + score.ToString(), "游戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                scoreboard.Text += playerName + "得分為：" + score + "\n";
                score = 100;
                pairsCorrect = 0;
                if (r == DialogResult.Retry)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        playTab.Controls.Remove(buttonArray[i]);
                    }
                    nameInput.Clear();
                    startButton.Enabled = true;
                    scoreLabel.Text = "分數：100";
                }
            }
        }

        public void pairCheck(int index)
        {
            if (firstOpened == -1)
            {
                firstOpened = index;
            }
            else if (secondOpened == -1)
            {
                if (index == firstOpened)
                {
                    return;

                }
                else secondOpened = index;
            }

            if (firstOpened != -1 && secondOpened != -1)
            {
                if (randomArray[firstOpened] == randomArray[secondOpened])
                {
                    buttonArray[firstOpened].Enabled = false;
                    buttonArray[secondOpened].Enabled = false;
                    firstOpened = -1;
                    secondOpened = -1;
                    pairsCorrect++;
                    score += 10;
                    scoreLabel.Text = "分數：" + score.ToString();
                }
                else
                {
                    continueButton.Enabled = true;
                    score -= 5;
                    scoreLabel.Text = "分數：" + score.ToString();
                    for (int i = 0; i < 16; i++)
                    {
                        if (buttonArray[i].Enabled == false)
                            continue;
                        if (i == firstOpened || i == secondOpened)
                            continue;

                        buttonArray[i].Enabled = false;
                    }

                }
                winCheck();

            }

        }

        public void buttonClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int index = Array.IndexOf(buttonArray, b);
            b.ImageIndex = randomArray[index];
            pairCheck(index);
        }

        public void createBoard()
        {
            for (int i = 1, j = 1; i < 17; i++)
            {
                buttonArray[i - 1] = new Button();
                buttonArray[i - 1].SetBounds(75 * ((i - 1) % 4) + 20 * ((i - 1) % 4) + 20, 100 * j - 40, 75, 100);
                buttonArray[i - 1].ImageList = imageList1;
                buttonArray[i - 1].ImageIndex = 8;
                //buttonArray[i - 1].Text = i.ToString();
                buttonArray[i - 1].Click += buttonClick;
                //Controls.Add(buttonArray[i - 1]);
                playTab.Controls.Add(buttonArray[i - 1]);

                if (i % 4 == 0)
                    j++;
            }

            randArrayGen(ref randomArray);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            buttonArray[firstOpened].ImageIndex = 8;
            buttonArray[secondOpened].ImageIndex = 8;
            firstOpened = -1;
            secondOpened = -1;
            for (int i = 0; i < 16; i++)
            {
                if (buttonArray[i].ImageIndex == 8)
                    buttonArray[i].Enabled = true;
            }
            continueButton.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("確定要離開游戲嗎", "離開游戲", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void playTab_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                playTab.Controls.Remove(buttonArray[i]);
            }
            nameInput.Clear();
            startButton.Enabled = true;
            scoreLabel.Text = "分數：100";
            score = 100;
            pairsCorrect = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /* for(int i = 0; i < 16; i++)
             {
                 buttonArray[i].ImageIndex = randomArray[i];
             } */
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string temp = nameInput.Text;

            if (temp == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (temp.Length < 3 || temp.Length > 10)
            {
                MessageBox.Show("名稱不合格式（>=3 && <=10）", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                playerName = temp;
                createBoard();
                startButton.Enabled = false;
            }
        }
    }
}
