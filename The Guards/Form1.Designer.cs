
namespace The_Guards
{
    partial class frm_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.spc_main = new System.Windows.Forms.SplitContainer();
            this.spc_rightPanel = new System.Windows.Forms.SplitContainer();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.gpb_gameInfo = new System.Windows.Forms.GroupBox();
            this.cmb_Theme = new System.Windows.Forms.ComboBox();
            this.lbl_Theme = new System.Windows.Forms.Label();
            this.rdb_Mouse = new System.Windows.Forms.RadioButton();
            this.rdb_Keyboard = new System.Windows.Forms.RadioButton();
            this.gpb_userInfo = new System.Windows.Forms.GroupBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tbc_score = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsv_playerScoreAsc = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsv_playerScoreDsec = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_missShoutText = new System.Windows.Forms.Label();
            this.lbl_shoutCount = new System.Windows.Forms.Label();
            this.lbl_shoutCountText1 = new System.Windows.Forms.Label();
            this.lbl_shoutCountText = new System.Windows.Forms.Label();
            this.ptb_spaceShip = new System.Windows.Forms.PictureBox();
            this.ptb_backGround = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tmr_main = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spc_main)).BeginInit();
            this.spc_main.Panel1.SuspendLayout();
            this.spc_main.Panel2.SuspendLayout();
            this.spc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_rightPanel)).BeginInit();
            this.spc_rightPanel.Panel1.SuspendLayout();
            this.spc_rightPanel.Panel2.SuspendLayout();
            this.spc_rightPanel.SuspendLayout();
            this.gpb_gameInfo.SuspendLayout();
            this.gpb_userInfo.SuspendLayout();
            this.tbc_score.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_spaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_backGround)).BeginInit();
            this.SuspendLayout();
            // 
            // spc_main
            // 
            this.spc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_main.Location = new System.Drawing.Point(0, 0);
            this.spc_main.Name = "spc_main";
            // 
            // spc_main.Panel1
            // 
            this.spc_main.Panel1.Controls.Add(this.spc_rightPanel);
            this.spc_main.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spc_main.Panel2
            // 
            this.spc_main.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.spc_main.Panel2.Controls.Add(this.label2);
            this.spc_main.Panel2.Controls.Add(this.label1);
            this.spc_main.Panel2.Controls.Add(this.lbl_missShoutText);
            this.spc_main.Panel2.Controls.Add(this.lbl_shoutCount);
            this.spc_main.Panel2.Controls.Add(this.lbl_shoutCountText1);
            this.spc_main.Panel2.Controls.Add(this.lbl_shoutCountText);
            this.spc_main.Panel2.Controls.Add(this.ptb_spaceShip);
            this.spc_main.Panel2.Controls.Add(this.ptb_backGround);
            this.spc_main.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spc_main.Size = new System.Drawing.Size(1262, 753);
            this.spc_main.SplitterDistance = 420;
            this.spc_main.TabIndex = 0;
            // 
            // spc_rightPanel
            // 
            this.spc_rightPanel.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.spc_rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_rightPanel.Location = new System.Drawing.Point(0, 0);
            this.spc_rightPanel.Name = "spc_rightPanel";
            this.spc_rightPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_rightPanel.Panel1
            // 
            this.spc_rightPanel.Panel1.Controls.Add(this.btn_exit);
            this.spc_rightPanel.Panel1.Controls.Add(this.btn_stop);
            this.spc_rightPanel.Panel1.Controls.Add(this.btn_start);
            this.spc_rightPanel.Panel1.Controls.Add(this.gpb_gameInfo);
            this.spc_rightPanel.Panel1.Controls.Add(this.gpb_userInfo);
            this.spc_rightPanel.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // spc_rightPanel.Panel2
            // 
            this.spc_rightPanel.Panel2.Controls.Add(this.tbc_score);
            this.spc_rightPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spc_rightPanel.Size = new System.Drawing.Size(420, 753);
            this.spc_rightPanel.SplitterDistance = 384;
            this.spc_rightPanel.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(55, 337);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(94, 29);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "خروج";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(155, 337);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(94, 29);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "توقف";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(255, 337);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 29);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "شروع";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // gpb_gameInfo
            // 
            this.gpb_gameInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_gameInfo.Controls.Add(this.cmb_Theme);
            this.gpb_gameInfo.Controls.Add(this.lbl_Theme);
            this.gpb_gameInfo.Controls.Add(this.rdb_Mouse);
            this.gpb_gameInfo.Controls.Add(this.rdb_Keyboard);
            this.gpb_gameInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_gameInfo.Location = new System.Drawing.Point(3, 175);
            this.gpb_gameInfo.Name = "gpb_gameInfo";
            this.gpb_gameInfo.Size = new System.Drawing.Size(405, 142);
            this.gpb_gameInfo.TabIndex = 1;
            this.gpb_gameInfo.TabStop = false;
            this.gpb_gameInfo.Text = "تنظیمات بازی";
            // 
            // cmb_Theme
            // 
            this.cmb_Theme.FormattingEnabled = true;
            this.cmb_Theme.Items.AddRange(new object[] {
            "ستاره ای",
            "کهکشانی",
            "فضایی"});
            this.cmb_Theme.Location = new System.Drawing.Point(9, 41);
            this.cmb_Theme.Name = "cmb_Theme";
            this.cmb_Theme.Size = new System.Drawing.Size(151, 26);
            this.cmb_Theme.TabIndex = 5;
            // 
            // lbl_Theme
            // 
            this.lbl_Theme.AutoSize = true;
            this.lbl_Theme.Location = new System.Drawing.Point(181, 44);
            this.lbl_Theme.Name = "lbl_Theme";
            this.lbl_Theme.Size = new System.Drawing.Size(151, 18);
            this.lbl_Theme.TabIndex = 4;
            this.lbl_Theme.Text = "تم بازی را انتخاب کنید :";
            this.lbl_Theme.Click += new System.EventHandler(this.lbl_Theme_Click);
            // 
            // rdb_Mouse
            // 
            this.rdb_Mouse.AutoSize = true;
            this.rdb_Mouse.Location = new System.Drawing.Point(37, 89);
            this.rdb_Mouse.Name = "rdb_Mouse";
            this.rdb_Mouse.Size = new System.Drawing.Size(123, 22);
            this.rdb_Mouse.TabIndex = 1;
            this.rdb_Mouse.Text = "شلیک با ماوس";
            this.rdb_Mouse.UseVisualStyleBackColor = true;
            this.rdb_Mouse.CheckedChanged += new System.EventHandler(this.rdb_Mouse_CheckedChanged);
            // 
            // rdb_Keyboard
            // 
            this.rdb_Keyboard.AutoSize = true;
            this.rdb_Keyboard.Location = new System.Drawing.Point(209, 89);
            this.rdb_Keyboard.Name = "rdb_Keyboard";
            this.rdb_Keyboard.Size = new System.Drawing.Size(123, 22);
            this.rdb_Keyboard.TabIndex = 0;
            this.rdb_Keyboard.Text = "شلیک با کیبورد";
            this.rdb_Keyboard.UseVisualStyleBackColor = true;
            this.rdb_Keyboard.CheckedChanged += new System.EventHandler(this.rdb_Keyboard_CheckedChanged);
            // 
            // gpb_userInfo
            // 
            this.gpb_userInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_userInfo.Controls.Add(this.txt_username);
            this.gpb_userInfo.Controls.Add(this.lbl_username);
            this.gpb_userInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpb_userInfo.Location = new System.Drawing.Point(3, 12);
            this.gpb_userInfo.Name = "gpb_userInfo";
            this.gpb_userInfo.Size = new System.Drawing.Size(405, 157);
            this.gpb_userInfo.TabIndex = 0;
            this.gpb_userInfo.TabStop = false;
            this.gpb_userInfo.Text = "مشخصات بازیکن";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(153, 56);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(125, 26);
            this.txt_username.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(297, 59);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(35, 18);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "نام :";
            // 
            // tbc_score
            // 
            this.tbc_score.Controls.Add(this.tabPage1);
            this.tbc_score.Controls.Add(this.tabPage2);
            this.tbc_score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_score.Location = new System.Drawing.Point(0, 0);
            this.tbc_score.Name = "tbc_score";
            this.tbc_score.RightToLeftLayout = true;
            this.tbc_score.SelectedIndex = 0;
            this.tbc_score.Size = new System.Drawing.Size(420, 365);
            this.tbc_score.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsv_playerScoreAsc);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "براساس بیشترین امتیاز";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsv_playerScoreAsc
            // 
            this.lsv_playerScoreAsc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsv_playerScoreAsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_playerScoreAsc.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsv_playerScoreAsc.HideSelection = false;
            this.lsv_playerScoreAsc.Location = new System.Drawing.Point(3, 3);
            this.lsv_playerScoreAsc.Name = "lsv_playerScoreAsc";
            this.lsv_playerScoreAsc.RightToLeftLayout = true;
            this.lsv_playerScoreAsc.Size = new System.Drawing.Size(406, 326);
            this.lsv_playerScoreAsc.TabIndex = 0;
            this.lsv_playerScoreAsc.UseCompatibleStateImageBehavior = false;
            this.lsv_playerScoreAsc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "نام بازیکن";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "امتیاز";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "تاریخ بازی";
            this.columnHeader3.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsv_playerScoreDsec);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "براساس کمترین امتیاز";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsv_playerScoreDsec
            // 
            this.lsv_playerScoreDsec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsv_playerScoreDsec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_playerScoreDsec.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsv_playerScoreDsec.HideSelection = false;
            this.lsv_playerScoreDsec.Location = new System.Drawing.Point(3, 3);
            this.lsv_playerScoreDsec.Name = "lsv_playerScoreDsec";
            this.lsv_playerScoreDsec.RightToLeftLayout = true;
            this.lsv_playerScoreDsec.Size = new System.Drawing.Size(406, 326);
            this.lsv_playerScoreDsec.TabIndex = 0;
            this.lsv_playerScoreDsec.UseCompatibleStateImageBehavior = false;
            this.lsv_playerScoreDsec.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "نام بازیکن ";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "امتیاز";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "تاریخ بازی";
            this.columnHeader6.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(740, 3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            this.label1.Visible = false;
            // 
            // lbl_missShoutText
            // 
            this.lbl_missShoutText.AutoSize = true;
            this.lbl_missShoutText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_missShoutText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_missShoutText.ForeColor = System.Drawing.Color.White;
            this.lbl_missShoutText.Location = new System.Drawing.Point(33, 8);
            this.lbl_missShoutText.Name = "lbl_missShoutText";
            this.lbl_missShoutText.Size = new System.Drawing.Size(208, 18);
            this.lbl_missShoutText.TabIndex = 5;
            this.lbl_missShoutText.Text = "موشک های شلیک خارج شده :";
            this.lbl_missShoutText.Visible = false;
            // 
            // lbl_shoutCount
            // 
            this.lbl_shoutCount.AutoSize = true;
            this.lbl_shoutCount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_shoutCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_shoutCount.ForeColor = System.Drawing.Color.White;
            this.lbl_shoutCount.Location = new System.Drawing.Point(12, 41);
            this.lbl_shoutCount.Name = "lbl_shoutCount";
            this.lbl_shoutCount.Size = new System.Drawing.Size(17, 18);
            this.lbl_shoutCount.TabIndex = 4;
            this.lbl_shoutCount.Text = "0";
            this.lbl_shoutCount.Visible = false;
            // 
            // lbl_shoutCountText1
            // 
            this.lbl_shoutCountText1.AutoSize = true;
            this.lbl_shoutCountText1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_shoutCountText1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_shoutCountText1.ForeColor = System.Drawing.Color.White;
            this.lbl_shoutCountText1.Location = new System.Drawing.Point(33, 41);
            this.lbl_shoutCountText1.Name = "lbl_shoutCountText1";
            this.lbl_shoutCountText1.Size = new System.Drawing.Size(175, 18);
            this.lbl_shoutCountText1.TabIndex = 3;
            this.lbl_shoutCountText1.Text = "موشک های شلیک شده :";
            this.lbl_shoutCountText1.Visible = false;
            // 
            // lbl_shoutCountText
            // 
            this.lbl_shoutCountText.AutoSize = true;
            this.lbl_shoutCountText.Location = new System.Drawing.Point(850, 780);
            this.lbl_shoutCountText.Name = "lbl_shoutCountText";
            this.lbl_shoutCountText.Size = new System.Drawing.Size(163, 20);
            this.lbl_shoutCountText.TabIndex = 2;
            this.lbl_shoutCountText.Text = "موشک های شلیک شده :";
            // 
            // ptb_spaceShip
            // 
            this.ptb_spaceShip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_spaceShip.BackColor = System.Drawing.Color.Transparent;
            this.ptb_spaceShip.Image = global::The_Guards.Properties.Resources.spacerocketnasaspaceshipfreevectorgraphiconpixabay;
            this.ptb_spaceShip.Location = new System.Drawing.Point(383, 661);
            this.ptb_spaceShip.Name = "ptb_spaceShip";
            this.ptb_spaceShip.Size = new System.Drawing.Size(80, 80);
            this.ptb_spaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_spaceShip.TabIndex = 1;
            this.ptb_spaceShip.TabStop = false;
            this.ptb_spaceShip.Visible = false;
            // 
            // ptb_backGround
            // 
            this.ptb_backGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_backGround.Enabled = false;
            this.ptb_backGround.Image = ((System.Drawing.Image)(resources.GetObject("ptb_backGround.Image")));
            this.ptb_backGround.Location = new System.Drawing.Point(0, 0);
            this.ptb_backGround.Name = "ptb_backGround";
            this.ptb_backGround.Size = new System.Drawing.Size(838, 753);
            this.ptb_backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_backGround.TabIndex = 0;
            this.ptb_backGround.TabStop = false;
            this.ptb_backGround.Click += new System.EventHandler(this.ptb_backGround_Click);
            this.ptb_backGround.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptb_backGround_MouseMove);
            // 
            // tmr_main
            // 
            this.tmr_main.Interval = 20;
            this.tmr_main.Tick += new System.EventHandler(this.tmr_main_Tick);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.spc_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محافظین سفینه";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyDown);
            this.spc_main.Panel1.ResumeLayout(false);
            this.spc_main.Panel2.ResumeLayout(false);
            this.spc_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_main)).EndInit();
            this.spc_main.ResumeLayout(false);
            this.spc_rightPanel.Panel1.ResumeLayout(false);
            this.spc_rightPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_rightPanel)).EndInit();
            this.spc_rightPanel.ResumeLayout(false);
            this.gpb_gameInfo.ResumeLayout(false);
            this.gpb_gameInfo.PerformLayout();
            this.gpb_userInfo.ResumeLayout(false);
            this.gpb_userInfo.PerformLayout();
            this.tbc_score.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_spaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_backGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_main;
        private System.Windows.Forms.PictureBox ptb_backGround;
        private System.Windows.Forms.SplitContainer spc_rightPanel;
        private System.Windows.Forms.GroupBox gpb_gameInfo;
        private System.Windows.Forms.GroupBox gpb_userInfo;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdb_Mouse;
        private System.Windows.Forms.RadioButton rdb_Keyboard;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_Theme;
        private System.Windows.Forms.ComboBox cmb_Theme;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TabControl tbc_score;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lsv_playerScoreAsc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lsv_playerScoreDsec;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox ptb_spaceShip;
        private System.Windows.Forms.Label lbl_shoutCountText;
        private System.Windows.Forms.Label lbl_shoutCountText1;
        private System.Windows.Forms.Label lbl_shoutCount;
        private System.Windows.Forms.Timer tmr_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_missShoutText;
        private System.Windows.Forms.Label label2;
    }
}

