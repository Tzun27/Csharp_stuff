namespace F74105012_practice_4_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameName = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.restartButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.playTab = new System.Windows.Forms.TabPage();
            this.scoreTab = new System.Windows.Forms.TabPage();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scoreboard = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.playTab.SuspendLayout();
            this.scoreTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(12, 9);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(117, 25);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "翻牌小游戲";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(610, 175);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(86, 31);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "開始游戲";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(610, 233);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(86, 31);
            this.continueButton.TabIndex = 2;
            this.continueButton.Text = "繼續";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.Location = new System.Drawing.Point(610, 409);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 31);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開游戲";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.jpg");
            this.imageList1.Images.SetKeyName(1, "02.jpg");
            this.imageList1.Images.SetKeyName(2, "03.jpg");
            this.imageList1.Images.SetKeyName(3, "04.jpg");
            this.imageList1.Images.SetKeyName(4, "05.jpg");
            this.imageList1.Images.SetKeyName(5, "06.jpg");
            this.imageList1.Images.SetKeyName(6, "07.jpg");
            this.imageList1.Images.SetKeyName(7, "08.jpg");
            this.imageList1.Images.SetKeyName(8, "card.jpg");
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(610, 287);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(86, 31);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "重新開始";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.playTab);
            this.tabControl.Controls.Add(this.scoreTab);
            this.tabControl.Location = new System.Drawing.Point(12, 46);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(503, 498);
            this.tabControl.TabIndex = 5;
            // 
            // playTab
            // 
            this.playTab.Controls.Add(this.nameInput);
            this.playTab.Controls.Add(this.name);
            this.playTab.Controls.Add(this.scoreLabel);
            this.playTab.Location = new System.Drawing.Point(4, 22);
            this.playTab.Name = "playTab";
            this.playTab.Padding = new System.Windows.Forms.Padding(3);
            this.playTab.Size = new System.Drawing.Size(495, 472);
            this.playTab.TabIndex = 0;
            this.playTab.Text = "游玩區";
            this.playTab.UseVisualStyleBackColor = true;
            this.playTab.Click += new System.EventHandler(this.playTab_Click);
            // 
            // scoreTab
            // 
            this.scoreTab.Controls.Add(this.scoreboard);
            this.scoreTab.Location = new System.Drawing.Point(4, 22);
            this.scoreTab.Name = "scoreTab";
            this.scoreTab.Padding = new System.Windows.Forms.Padding(3);
            this.scoreTab.Size = new System.Drawing.Size(495, 472);
            this.scoreTab.TabIndex = 1;
            this.scoreTab.Text = "歷史記錄區";
            this.scoreTab.UseVisualStyleBackColor = true;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(3, 3);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(84, 20);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "分數：100";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(108, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(57, 20);
            this.name.TabIndex = 1;
            this.name.Text = "名稱：";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(161, 3);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(191, 20);
            this.nameInput.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboard.Location = new System.Drawing.Point(12, 13);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(0, 20);
            this.scoreboard.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 566);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.playTab.ResumeLayout(false);
            this.playTab.PerformLayout();
            this.scoreTab.ResumeLayout(false);
            this.scoreTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage playTab;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TabPage scoreTab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label scoreboard;
    }
}

