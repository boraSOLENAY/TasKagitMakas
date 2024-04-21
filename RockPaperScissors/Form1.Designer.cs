namespace RockPaperScissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picCPUs = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.lnkLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.Lime;
            this.btnRock.Location = new System.Drawing.Point(19, 456);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(144, 75);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "TAŞ";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPaper.Location = new System.Drawing.Point(169, 456);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(150, 75);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "KAĞIT";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnScissors.Location = new System.Drawing.Point(325, 456);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(158, 75);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "MAKAS";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Red;
            this.lblPlayer.Location = new System.Drawing.Point(72, 174);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(77, 28);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            // 
            // lblCPU
            // 
            this.lblCPU.Location = new System.Drawing.Point(0, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(100, 23);
            this.lblCPU.TabIndex = 12;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRestart.Location = new System.Drawing.Point(498, 456);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(140, 75);
            this.btnRestart.TabIndex = 7;
            this.btnRestart.Text = "SIFIRLA";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(205, 205);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(202, 25);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Player: 0 - CPU: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountDown.Location = new System.Drawing.Point(292, 262);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(25, 25);
            this.txtCountDown.TabIndex = 9;
            this.txtCountDown.Text = "5";
            this.txtCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRounds.Location = new System.Drawing.Point(243, 318);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(119, 25);
            this.txtRounds.TabIndex = 10;
            this.txtRounds.Text = "Rounds: 3";
            this.txtRounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(475, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RockPaperScissors.Properties.Resources.gh;
            this.pictureBox2.Location = new System.Drawing.Point(441, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // picCPUs
            // 
            this.picCPUs.Image = global::RockPaperScissors.Properties.Resources.qm;
            this.picCPUs.Location = new System.Drawing.Point(423, 205);
            this.picCPUs.Name = "picCPUs";
            this.picCPUs.Size = new System.Drawing.Size(165, 171);
            this.picCPUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPUs.TabIndex = 17;
            this.picCPUs.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.qm;
            this.picPlayer.Location = new System.Drawing.Point(29, 205);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(164, 171);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 14;
            this.picPlayer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissors.Properties.Resources.rps;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.Location = new System.Drawing.Point(0, 0);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(100, 50);
            this.picCPU.TabIndex = 13;
            this.picCPU.TabStop = false;
            // 
            // lnkLbl
            // 
            this.lnkLbl.AutoSize = true;
            this.lnkLbl.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLbl.Location = new System.Drawing.Point(501, 408);
            this.lnkLbl.Name = "lnkLbl";
            this.lnkLbl.Size = new System.Drawing.Size(164, 28);
            this.lnkLbl.TabIndex = 24;
            this.lnkLbl.TabStop = true;
            this.lnkLbl.Text = "boraSOLENAY";
            this.lnkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(665, 563);
            this.Controls.Add(this.lnkLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCPUs);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Taş Kağıt Makas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnkLbl;
    }
}

