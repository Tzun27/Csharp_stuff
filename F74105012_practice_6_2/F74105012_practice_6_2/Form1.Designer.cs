namespace F74105012_practice_6_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.display = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.telPage = new System.Windows.Forms.TabPage();
            this.play941Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.play1477Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.play1336Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.play1209Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.play697Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.play852Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.play770Hz = new AxWMPLib.AxWindowsMediaPlayer();
            this.BHash = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.BDel = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.BStar = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logs = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.saveLabel = new System.Windows.Forms.Label();
            this.BCall = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.telPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.play941Hz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play1477Hz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play1336Hz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play1209Hz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play697Hz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play852Hz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play770Hz)).BeginInit();
            this.logPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(6, 3);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(364, 55);
            this.display.TabIndex = 0;
            this.display.Text = "Telephone";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(252, 91);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(50, 50);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B1_MouseDown);
            this.B1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B1_MouseUp);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.telPage);
            this.tab.Controls.Add(this.logPage);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(776, 426);
            this.tab.TabIndex = 2;
            this.tab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // telPage
            // 
            this.telPage.Controls.Add(this.play941Hz);
            this.telPage.Controls.Add(this.play1477Hz);
            this.telPage.Controls.Add(this.play1336Hz);
            this.telPage.Controls.Add(this.play1209Hz);
            this.telPage.Controls.Add(this.play697Hz);
            this.telPage.Controls.Add(this.play852Hz);
            this.telPage.Controls.Add(this.play770Hz);
            this.telPage.Controls.Add(this.BHash);
            this.telPage.Controls.Add(this.BCancel);
            this.telPage.Controls.Add(this.BCall);
            this.telPage.Controls.Add(this.BDel);
            this.telPage.Controls.Add(this.B2);
            this.telPage.Controls.Add(this.B3);
            this.telPage.Controls.Add(this.B0);
            this.telPage.Controls.Add(this.B8);
            this.telPage.Controls.Add(this.B7);
            this.telPage.Controls.Add(this.B9);
            this.telPage.Controls.Add(this.BStar);
            this.telPage.Controls.Add(this.B4);
            this.telPage.Controls.Add(this.B6);
            this.telPage.Controls.Add(this.B5);
            this.telPage.Controls.Add(this.display);
            this.telPage.Controls.Add(this.B1);
            this.telPage.Location = new System.Drawing.Point(4, 22);
            this.telPage.Name = "telPage";
            this.telPage.Padding = new System.Windows.Forms.Padding(3);
            this.telPage.Size = new System.Drawing.Size(768, 400);
            this.telPage.TabIndex = 0;
            this.telPage.Text = "Telephone";
            this.telPage.UseVisualStyleBackColor = true;
            this.telPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // play941Hz
            // 
            this.play941Hz.Enabled = true;
            this.play941Hz.Location = new System.Drawing.Point(25, 230);
            this.play941Hz.Name = "play941Hz";
            this.play941Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play941Hz.OcxState")));
            this.play941Hz.Size = new System.Drawing.Size(75, 23);
            this.play941Hz.TabIndex = 22;
            this.play941Hz.Visible = false;
            // 
            // play1477Hz
            // 
            this.play1477Hz.Enabled = true;
            this.play1477Hz.Location = new System.Drawing.Point(669, 91);
            this.play1477Hz.Name = "play1477Hz";
            this.play1477Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play1477Hz.OcxState")));
            this.play1477Hz.Size = new System.Drawing.Size(75, 23);
            this.play1477Hz.TabIndex = 21;
            this.play1477Hz.Visible = false;
            // 
            // play1336Hz
            // 
            this.play1336Hz.Enabled = true;
            this.play1336Hz.Location = new System.Drawing.Point(574, 91);
            this.play1336Hz.Name = "play1336Hz";
            this.play1336Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play1336Hz.OcxState")));
            this.play1336Hz.Size = new System.Drawing.Size(75, 23);
            this.play1336Hz.TabIndex = 20;
            this.play1336Hz.Visible = false;
            // 
            // play1209Hz
            // 
            this.play1209Hz.Enabled = true;
            this.play1209Hz.Location = new System.Drawing.Point(471, 91);
            this.play1209Hz.Name = "play1209Hz";
            this.play1209Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play1209Hz.OcxState")));
            this.play1209Hz.Size = new System.Drawing.Size(75, 23);
            this.play1209Hz.TabIndex = 19;
            this.play1209Hz.Visible = false;
            // 
            // play697Hz
            // 
            this.play697Hz.Enabled = true;
            this.play697Hz.Location = new System.Drawing.Point(25, 91);
            this.play697Hz.Name = "play697Hz";
            this.play697Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play697Hz.OcxState")));
            this.play697Hz.Size = new System.Drawing.Size(75, 23);
            this.play697Hz.TabIndex = 18;
            this.play697Hz.Visible = false;
            // 
            // play852Hz
            // 
            this.play852Hz.Enabled = true;
            this.play852Hz.Location = new System.Drawing.Point(25, 187);
            this.play852Hz.Name = "play852Hz";
            this.play852Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play852Hz.OcxState")));
            this.play852Hz.Size = new System.Drawing.Size(75, 23);
            this.play852Hz.TabIndex = 17;
            this.play852Hz.Visible = false;
            // 
            // play770Hz
            // 
            this.play770Hz.Enabled = true;
            this.play770Hz.Location = new System.Drawing.Point(25, 138);
            this.play770Hz.Name = "play770Hz";
            this.play770Hz.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("play770Hz.OcxState")));
            this.play770Hz.Size = new System.Drawing.Size(75, 23);
            this.play770Hz.TabIndex = 16;
            this.play770Hz.Visible = false;
            // 
            // BHash
            // 
            this.BHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BHash.Location = new System.Drawing.Point(399, 259);
            this.BHash.Name = "BHash";
            this.BHash.Size = new System.Drawing.Size(50, 50);
            this.BHash.TabIndex = 15;
            this.BHash.Text = "#";
            this.BHash.UseVisualStyleBackColor = true;
            this.BHash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BHash_MouseDown);
            this.BHash.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BHash_MouseUp);
            // 
            // BCancel
            // 
            this.BCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancel.Location = new System.Drawing.Point(252, 315);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(50, 50);
            this.BCancel.TabIndex = 14;
            this.BCancel.Text = "X";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BDel
            // 
            this.BDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDel.Location = new System.Drawing.Point(399, 315);
            this.BDel.Name = "BDel";
            this.BDel.Size = new System.Drawing.Size(50, 50);
            this.BDel.TabIndex = 12;
            this.BDel.Text = "<=";
            this.BDel.UseVisualStyleBackColor = true;
            this.BDel.Click += new System.EventHandler(this.BDel_Click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(330, 91);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(50, 50);
            this.B2.TabIndex = 11;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B2_MouseDown);
            this.B2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B2_MouseUp);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(399, 91);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(50, 50);
            this.B3.TabIndex = 10;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B3_MouseDown);
            this.B3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B3_MouseUp);
            // 
            // B0
            // 
            this.B0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B0.Location = new System.Drawing.Point(330, 259);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(50, 50);
            this.B0.TabIndex = 9;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B0_MouseDown);
            this.B0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B0_MouseUp);
            // 
            // B8
            // 
            this.B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B8.Location = new System.Drawing.Point(330, 203);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(50, 50);
            this.B8.TabIndex = 8;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B8_MouseDown);
            this.B8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B8_MouseUp);
            // 
            // B7
            // 
            this.B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B7.Location = new System.Drawing.Point(252, 203);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(50, 50);
            this.B7.TabIndex = 7;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B7_MouseDown);
            this.B7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B7_MouseUp);
            // 
            // B9
            // 
            this.B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B9.Location = new System.Drawing.Point(399, 203);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(50, 50);
            this.B9.TabIndex = 6;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B9_MouseDown);
            this.B9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B9_MouseUp);
            // 
            // BStar
            // 
            this.BStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BStar.Location = new System.Drawing.Point(252, 259);
            this.BStar.Name = "BStar";
            this.BStar.Size = new System.Drawing.Size(50, 50);
            this.BStar.TabIndex = 5;
            this.BStar.Text = "*";
            this.BStar.UseVisualStyleBackColor = true;
            this.BStar.Click += new System.EventHandler(this.button4_Click);
            this.BStar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BStar_MouseDown);
            this.BStar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BStar_MouseUp);
            // 
            // B4
            // 
            this.B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B4.Location = new System.Drawing.Point(252, 147);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(50, 50);
            this.B4.TabIndex = 4;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B4_MouseDown);
            this.B4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B4_MouseUp);
            // 
            // B6
            // 
            this.B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B6.Location = new System.Drawing.Point(399, 147);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(50, 50);
            this.B6.TabIndex = 3;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.B6_Click);
            this.B6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B6_MouseDown);
            this.B6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B6_MouseUp);
            // 
            // B5
            // 
            this.B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B5.Location = new System.Drawing.Point(330, 147);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(50, 50);
            this.B5.TabIndex = 2;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.B5_MouseDown);
            this.B5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.B5_MouseUp);
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logs);
            this.logPage.Controls.Add(this.saveButton);
            this.logPage.Controls.Add(this.input);
            this.logPage.Controls.Add(this.saveLabel);
            this.logPage.Location = new System.Drawing.Point(4, 22);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(768, 400);
            this.logPage.TabIndex = 1;
            this.logPage.Text = "Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logs.Location = new System.Drawing.Point(38, 73);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(690, 294);
            this.logs.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(661, 27);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(67, 21);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(76, 28);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(566, 20);
            this.input.TabIndex = 1;
            // 
            // saveLabel
            // 
            this.saveLabel.AutoSize = true;
            this.saveLabel.Location = new System.Drawing.Point(38, 31);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(32, 13);
            this.saveLabel.TabIndex = 0;
            this.saveLabel.Text = "Save";
            // 
            // BCall
            // 
            this.BCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCall.Image = global::F74105012_practice_6_2.Properties.Resources.Call1;
            this.BCall.Location = new System.Drawing.Point(330, 315);
            this.BCall.Name = "BCall";
            this.BCall.Size = new System.Drawing.Size(50, 50);
            this.BCall.TabIndex = 13;
            this.BCall.UseVisualStyleBackColor = true;
            this.BCall.Click += new System.EventHandler(this.BCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.tab.ResumeLayout(false);
            this.telPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.play941Hz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play1477Hz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play1336Hz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play1209Hz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play697Hz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play852Hz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play770Hz)).EndInit();
            this.logPage.ResumeLayout(false);
            this.logPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage telPage;
        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.Button BHash;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BCall;
        private System.Windows.Forms.Button BDel;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button BStar;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Label logs;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label saveLabel;
        private AxWMPLib.AxWindowsMediaPlayer play770Hz;
        private AxWMPLib.AxWindowsMediaPlayer play941Hz;
        private AxWMPLib.AxWindowsMediaPlayer play1477Hz;
        private AxWMPLib.AxWindowsMediaPlayer play1336Hz;
        private AxWMPLib.AxWindowsMediaPlayer play1209Hz;
        private AxWMPLib.AxWindowsMediaPlayer play697Hz;
        private AxWMPLib.AxWindowsMediaPlayer play852Hz;
    }
}

