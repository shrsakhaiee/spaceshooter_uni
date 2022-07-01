using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Guards
{
    public partial class frm_main : Form
    {
        string playerName = "sahari";
        int shoutCount = 0;
        int missShout = 0;

        PictureBox[,] enemies;
        int enemiesRow = 0;
        int enemiesCol = 0;

        int verticalSpace = 0;
        int horizontalSpace = 0;
        int sizeOfEnemies = 0;
        int totalSize = 0;

        int speed = 0;
        int slider = 0;
        bool isItEndOfPage = true;

        public frm_main()
        {
            InitializeComponent();

            cmb_Theme.SelectedIndex = 0;
            rdb_Keyboard.Checked = false;

            this.Size = new Size(1280, 800);

            ListViewItem item = new ListViewItem(new[] { "sahar", "500", "1990/12/09" });
            lsv_playerScoreDsec.Items.Add(item);
            ListViewItem item2 = new ListViewItem(new[] { "mohammadreza", "1000", "2000/15/09" });
            lsv_playerScoreAsc.Items.Add(item2);
        }

        private void lbl_Theme_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            
            gpb_userInfo.Enabled = false;
            gpb_gameInfo.Enabled = false;
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            ptb_backGround.Enabled = true;
            ptb_spaceShip.Visible = true;
            ptb_spaceShip.Focus();
            lbl_shoutCount.Visible = true;
            lbl_shoutCountText1.Visible = true;
            label1.Visible = true;
            lbl_missShoutText.Visible = true;

            tmr_main.Start();


            speed = 5;
            totalSize = (enemiesCol * sizeOfEnemies) + ((enemiesCol - 1) * horizontalSpace);

            if (totalSize >= 900 || totalSize <= 0)
            {
                enemiesCol = 5;
                enemiesRow = 4;
                sizeOfEnemies = 50;
                horizontalSpace = verticalSpace = 20;
                totalSize = (enemiesCol * sizeOfEnemies) + ((enemiesCol - 1) * horizontalSpace);
            }
            slider = totalSize;
            speed = 5;

            Random rnd = new Random();
            enemies = new PictureBox[enemiesCol, enemiesRow];

            for (int i = 0; i < enemiesCol; i++)
            {

                for (int j = 0; j < enemiesRow; j++)
                {
                    enemies[i, j] = new PictureBox();
                    enemies[i, j].Size =
                         new Size(sizeOfEnemies, sizeOfEnemies);
                    ptb_backGround.Controls.Add(enemies[i, j]);
                    int x = i * (sizeOfEnemies + horizontalSpace);
                    int y = j * (sizeOfEnemies + verticalSpace);
                    enemies[i, j].Location = new Point(x, y);
                }
            }


        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            
            ptb_backGround.Controls.Add(ptb_spaceShip);
            ptb_backGround.Controls.Add(lbl_shoutCount);
            ptb_backGround.Controls.Add(lbl_shoutCountText1);
            ptb_backGround.Controls.Add(label1);
            ptb_backGround.Controls.Add(lbl_missShoutText);
        }

        public static void exitFromTheGame()
        {
            Application.Exit();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            exitFromTheGame();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            frm_pauseMessage f = new frm_pauseMessage();
            f.ShowDialog();
        }
        void Fire()
        {
            Button rocket = new Button();
            rocket.Size = new Size(30, 30);
            rocket.Location = ptb_spaceShip.Location;
            rocket.FlatStyle = FlatStyle.Flat;
            rocket.FlatAppearance.BorderSize = 0;
            
            int SSLX = ptb_spaceShip.Location.X;
            int SSLY = ptb_spaceShip.Location.Y;
            int SSW = ptb_spaceShip.Width;
            int RW = rocket.Width;

            rocket.Location = new Point(SSLX + ((SSW / 2) - RW / 2), SSLY);

            ptb_backGround.Controls.Add(rocket);
            shoutCount++;
            lbl_shoutCount.Text = shoutCount.ToString();
        }

        private void frm_main_KeyDown(object sender, KeyEventArgs e)
        {
            if (rdb_Keyboard.Checked == true)

                if (e.KeyData == Keys.Space)

                    Fire();
        }

        private void ptb_backGround_Click(object sender, EventArgs e)
        {
            if (rdb_Mouse.Checked == true)

                Fire();
        }

        private void ptb_backGround_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= ptb_spaceShip.Size.Width / 2)
            {
                ptb_spaceShip.Location = new Point(0, ptb_spaceShip.Location.Y);
            }
            else if (e.X + ptb_spaceShip.Size.Width / 2 >= ptb_backGround.Size.Width)
            {
                ptb_spaceShip.Location = new Point(ptb_backGround.Size.Width - ptb_spaceShip.Size.Width, ptb_spaceShip.Location.Y);

            }
            else
                ptb_spaceShip.Location = new Point(e.X - (ptb_spaceShip.Size.Width / 2), ptb_spaceShip.Location.Y);
        }

        private void rdb_Keyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Keyboard.Checked == true)
                MessageBox.Show("شلیک با کیبورد انتخاب شد");
            else
                MessageBox.Show("شلیک با ماوس انتخاب شد");
        }

        private void rdb_Mouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Mouse.Checked == true)
                MessageBox.Show("شلیک با ماوس انتخاب شد");
            else
                MessageBox.Show("شلیک با کیبورد انتخاب شد");
        }

        private void tmr_main_Tick(object sender, EventArgs e)
        {
            foreach (Control element in ptb_backGround.Controls)
            {
                if (element is Button)
                {
                    element.Location = new Point(element.Location.X, element.Location.Y - 10);

                    if (element.Location.Y <= (enemiesRow * sizeOfEnemies) + (enemiesRow * verticalSpace) - verticalSpace)
                    {
                        for (int i = 0; i < enemiesCol; i++)
                        {
                            for (int j = 0; j < enemiesRow; j++)
                            {

                                if (!enemies[i, j].IsDisposed)
                                {
                                    int elementLY = element.Location.Y;  
                                    int elementMiddlePoint = element.Location.X + (element.Size.Width / 2);
                                    int startEnemieY = enemies[i, j].Location.Y;
                                    int startEnemyX = enemies[i, j].Location.X;
                                    int endEnemyY = startEnemieY + enemies[i, j].Size.Height;
                                    int endEnemyX = startEnemyX + enemies[i, j].Size.Width;

                                    if (elementLY >= startEnemieY && elementLY <= endEnemyY)
                                    {
                                        if (elementMiddlePoint >= startEnemyX && elementMiddlePoint <= endEnemyX)
                                        {
                                            ptb_backGround.Controls.Remove(element);
                                            ptb_backGround.Controls.Remove(enemies[i, j]);

                                            element.Dispose();
                                            enemies[i, j].Dispose();
                                        }
                                    }
                                }
                            }
                        }

                    }


                    if (element.Location.Y <= 0)
                    {
                        ptb_backGround.Controls.Remove(element);
                        element.Dispose();
                        missShout++;
                        label1.Text = missShout.ToString();

                    }
                }

                if (element is PictureBox && element.Name != "ptb_spaceShip")
                {
                    if (isItEndOfPage == true)
                        element.Location = new Point(element.Location.X + speed, element.Location.Y);

                    else if (isItEndOfPage == false)
                        element.Location = new Point(element.Location.X - speed, element.Location.Y);
                }

            }
            if (slider >= spc_main.Panel2.Size.Width)
                isItEndOfPage = false;

            else if (slider < totalSize)
                isItEndOfPage = true;

            if (isItEndOfPage == true)
                slider += speed;

            else if (isItEndOfPage == false)
                slider -= speed;

        }
    }

}

