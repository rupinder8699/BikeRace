namespace BikeRace
{
    partial class RacingTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingTrack));
            this.gpSetPlayer = new System.Windows.Forms.GroupBox();
            this.nmSetBudget = new System.Windows.Forms.NumericUpDown();
            this.txtSetPlayer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetPlayer = new System.Windows.Forms.Button();
            this.allPlyr = new System.Windows.Forms.GroupBox();
            this.PlayerLbl3 = new System.Windows.Forms.Label();
            this.PlayerLbl2 = new System.Windows.Forms.Label();
            this.PlayerLbl1 = new System.Windows.Forms.Label();
            this.betArea = new System.Windows.Forms.GroupBox();
            this.BikeCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Button();
            this.Bet = new System.Windows.Forms.Button();
            this.nmBet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayerCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RaceTrack = new System.Windows.Forms.GroupBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.RaceBike3 = new System.Windows.Forms.PictureBox();
            this.RaceBike2 = new System.Windows.Forms.PictureBox();
            this.RaceBike1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BikeTmr = new System.Windows.Forms.Timer(this.components);
            this.gpSetPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSetBudget)).BeginInit();
            this.allPlyr.SuspendLayout();
            this.betArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBet)).BeginInit();
            this.RaceTrack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceBike3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceBike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceBike1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpSetPlayer
            // 
            this.gpSetPlayer.Controls.Add(this.nmSetBudget);
            this.gpSetPlayer.Controls.Add(this.txtSetPlayer);
            this.gpSetPlayer.Controls.Add(this.label2);
            this.gpSetPlayer.Controls.Add(this.label1);
            this.gpSetPlayer.Controls.Add(this.btnSetPlayer);
            this.gpSetPlayer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSetPlayer.Location = new System.Drawing.Point(12, 12);
            this.gpSetPlayer.Name = "gpSetPlayer";
            this.gpSetPlayer.Size = new System.Drawing.Size(344, 202);
            this.gpSetPlayer.TabIndex = 0;
            this.gpSetPlayer.TabStop = false;
            this.gpSetPlayer.Text = "Set Player";
            // 
            // nmSetBudget
            // 
            this.nmSetBudget.Location = new System.Drawing.Point(163, 86);
            this.nmSetBudget.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmSetBudget.Name = "nmSetBudget";
            this.nmSetBudget.Size = new System.Drawing.Size(161, 25);
            this.nmSetBudget.TabIndex = 4;
            // 
            // txtSetPlayer
            // 
            this.txtSetPlayer.Location = new System.Drawing.Point(164, 44);
            this.txtSetPlayer.Name = "txtSetPlayer";
            this.txtSetPlayer.Size = new System.Drawing.Size(160, 25);
            this.txtSetPlayer.TabIndex = 3;
            this.txtSetPlayer.TextChanged += new System.EventHandler(this.txtSetPlayer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Player Name";
            // 
            // btnSetPlayer
            // 
            this.btnSetPlayer.Location = new System.Drawing.Point(46, 133);
            this.btnSetPlayer.Name = "btnSetPlayer";
            this.btnSetPlayer.Size = new System.Drawing.Size(200, 41);
            this.btnSetPlayer.TabIndex = 0;
            this.btnSetPlayer.Text = "Add";
            this.btnSetPlayer.UseVisualStyleBackColor = true;
            this.btnSetPlayer.Click += new System.EventHandler(this.btnSetPlayer_Click);
            // 
            // allPlyr
            // 
            this.allPlyr.Controls.Add(this.PlayerLbl3);
            this.allPlyr.Controls.Add(this.PlayerLbl2);
            this.allPlyr.Controls.Add(this.PlayerLbl1);
            this.allPlyr.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPlyr.Location = new System.Drawing.Point(362, 23);
            this.allPlyr.Name = "allPlyr";
            this.allPlyr.Size = new System.Drawing.Size(323, 191);
            this.allPlyr.TabIndex = 1;
            this.allPlyr.TabStop = false;
            this.allPlyr.Text = "All Player";
            this.allPlyr.Visible = false;
            // 
            // PlayerLbl3
            // 
            this.PlayerLbl3.AutoSize = true;
            this.PlayerLbl3.Location = new System.Drawing.Point(6, 122);
            this.PlayerLbl3.Name = "PlayerLbl3";
            this.PlayerLbl3.Size = new System.Drawing.Size(132, 18);
            this.PlayerLbl3.TabIndex = 7;
            this.PlayerLbl3.Text = "Enter Player Name";
            // 
            // PlayerLbl2
            // 
            this.PlayerLbl2.AutoSize = true;
            this.PlayerLbl2.Location = new System.Drawing.Point(6, 75);
            this.PlayerLbl2.Name = "PlayerLbl2";
            this.PlayerLbl2.Size = new System.Drawing.Size(132, 18);
            this.PlayerLbl2.TabIndex = 6;
            this.PlayerLbl2.Text = "Enter Player Name";
            // 
            // PlayerLbl1
            // 
            this.PlayerLbl1.AutoSize = true;
            this.PlayerLbl1.Location = new System.Drawing.Point(6, 33);
            this.PlayerLbl1.Name = "PlayerLbl1";
            this.PlayerLbl1.Size = new System.Drawing.Size(32, 18);
            this.PlayerLbl1.TabIndex = 5;
            this.PlayerLbl1.Text = "Lbl";
            // 
            // betArea
            // 
            this.betArea.Controls.Add(this.BikeCB);
            this.betArea.Controls.Add(this.label5);
            this.betArea.Controls.Add(this.Race);
            this.betArea.Controls.Add(this.Bet);
            this.betArea.Controls.Add(this.nmBet);
            this.betArea.Controls.Add(this.label4);
            this.betArea.Controls.Add(this.PlayerCB);
            this.betArea.Controls.Add(this.label3);
            this.betArea.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betArea.Location = new System.Drawing.Point(691, 23);
            this.betArea.Name = "betArea";
            this.betArea.Size = new System.Drawing.Size(285, 182);
            this.betArea.TabIndex = 2;
            this.betArea.TabStop = false;
            this.betArea.Text = "Bet Area";
            this.betArea.Visible = false;
            // 
            // BikeCB
            // 
            this.BikeCB.FormattingEnabled = true;
            this.BikeCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.BikeCB.Location = new System.Drawing.Point(27, 94);
            this.BikeCB.Name = "BikeCB";
            this.BikeCB.Size = new System.Drawing.Size(121, 26);
            this.BikeCB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose Bike";
            // 
            // Race
            // 
            this.Race.Location = new System.Drawing.Point(157, 115);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(116, 54);
            this.Race.TabIndex = 9;
            this.Race.Text = "Race";
            this.Race.UseVisualStyleBackColor = true;
            this.Race.Visible = false;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // Bet
            // 
            this.Bet.Location = new System.Drawing.Point(172, 48);
            this.Bet.Name = "Bet";
            this.Bet.Size = new System.Drawing.Size(82, 35);
            this.Bet.TabIndex = 8;
            this.Bet.Text = "Bet";
            this.Bet.UseVisualStyleBackColor = true;
            this.Bet.Click += new System.EventHandler(this.Bet_Click);
            // 
            // nmBet
            // 
            this.nmBet.Location = new System.Drawing.Point(27, 144);
            this.nmBet.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmBet.Name = "nmBet";
            this.nmBet.Size = new System.Drawing.Size(121, 25);
            this.nmBet.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // PlayerCB
            // 
            this.PlayerCB.FormattingEnabled = true;
            this.PlayerCB.Location = new System.Drawing.Point(27, 39);
            this.PlayerCB.Name = "PlayerCB";
            this.PlayerCB.Size = new System.Drawing.Size(121, 26);
            this.PlayerCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Player";
            // 
            // RaceTrack
            // 
            this.RaceTrack.Controls.Add(this.pictureBox12);
            this.RaceTrack.Controls.Add(this.RaceBike3);
            this.RaceTrack.Controls.Add(this.RaceBike2);
            this.RaceTrack.Controls.Add(this.RaceBike1);
            this.RaceTrack.Controls.Add(this.pictureBox7);
            this.RaceTrack.Controls.Add(this.pictureBox8);
            this.RaceTrack.Controls.Add(this.pictureBox9);
            this.RaceTrack.Controls.Add(this.pictureBox10);
            this.RaceTrack.Controls.Add(this.pictureBox11);
            this.RaceTrack.Controls.Add(this.pictureBox6);
            this.RaceTrack.Controls.Add(this.pictureBox4);
            this.RaceTrack.Controls.Add(this.pictureBox5);
            this.RaceTrack.Controls.Add(this.pictureBox3);
            this.RaceTrack.Controls.Add(this.pictureBox2);
            this.RaceTrack.Controls.Add(this.pictureBox1);
            this.RaceTrack.Location = new System.Drawing.Point(12, 220);
            this.RaceTrack.Name = "RaceTrack";
            this.RaceTrack.Size = new System.Drawing.Size(964, 218);
            this.RaceTrack.TabIndex = 3;
            this.RaceTrack.TabStop = false;
            this.RaceTrack.Text = "RaceTrack";
            this.RaceTrack.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Location = new System.Drawing.Point(906, 14);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(60, 204);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            // 
            // RaceBike3
            // 
            this.RaceBike3.Image = ((System.Drawing.Image)(resources.GetObject("RaceBike3.Image")));
            this.RaceBike3.Location = new System.Drawing.Point(7, 156);
            this.RaceBike3.Name = "RaceBike3";
            this.RaceBike3.Size = new System.Drawing.Size(92, 50);
            this.RaceBike3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RaceBike3.TabIndex = 16;
            this.RaceBike3.TabStop = false;
            // 
            // RaceBike2
            // 
            this.RaceBike2.Image = ((System.Drawing.Image)(resources.GetObject("RaceBike2.Image")));
            this.RaceBike2.Location = new System.Drawing.Point(7, 88);
            this.RaceBike2.Name = "RaceBike2";
            this.RaceBike2.Size = new System.Drawing.Size(92, 50);
            this.RaceBike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RaceBike2.TabIndex = 15;
            this.RaceBike2.TabStop = false;
            // 
            // RaceBike1
            // 
            this.RaceBike1.Image = ((System.Drawing.Image)(resources.GetObject("RaceBike1.Image")));
            this.RaceBike1.Location = new System.Drawing.Point(7, 20);
            this.RaceBike1.Name = "RaceBike1";
            this.RaceBike1.Size = new System.Drawing.Size(92, 50);
            this.RaceBike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RaceBike1.TabIndex = 14;
            this.RaceBike1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(803, 140);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(122, 10);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(619, 140);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(122, 10);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(403, 140);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(122, 10);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(222, 140);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(122, 10);
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(6, 140);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(122, 10);
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(803, 72);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(122, 10);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(619, 72);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(122, 10);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(403, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(122, 10);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(222, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 10);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 10);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BikeTmr
            // 
            this.BikeTmr.Interval = 200;
            this.BikeTmr.Tick += new System.EventHandler(this.BikeTmr_Tick);
            // 
            // RacingTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.RaceTrack);
            this.Controls.Add(this.betArea);
            this.Controls.Add(this.allPlyr);
            this.Controls.Add(this.gpSetPlayer);
            this.Name = "RacingTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RacingTrack";
            this.gpSetPlayer.ResumeLayout(false);
            this.gpSetPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSetBudget)).EndInit();
            this.allPlyr.ResumeLayout(false);
            this.allPlyr.PerformLayout();
            this.betArea.ResumeLayout(false);
            this.betArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBet)).EndInit();
            this.RaceTrack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceBike3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceBike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaceBike1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpSetPlayer;
        private System.Windows.Forms.Button btnSetPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSetPlayer;
        private System.Windows.Forms.NumericUpDown nmSetBudget;
        private System.Windows.Forms.GroupBox allPlyr;
        private System.Windows.Forms.Label PlayerLbl1;
        private System.Windows.Forms.Label PlayerLbl3;
        private System.Windows.Forms.Label PlayerLbl2;
        private System.Windows.Forms.GroupBox betArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PlayerCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmBet;
        private System.Windows.Forms.Button Bet;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BikeCB;
        private System.Windows.Forms.GroupBox RaceTrack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox RaceBike1;
        private System.Windows.Forms.PictureBox RaceBike2;
        private System.Windows.Forms.PictureBox RaceBike3;
        private System.Windows.Forms.Timer BikeTmr;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}