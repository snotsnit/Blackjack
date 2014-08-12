namespace BlackJackLateNightAttempt
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
            this.radioButtonHigh = new System.Windows.Forms.RadioButton();
            this.radioButtonLow = new System.Windows.Forms.RadioButton();
            this.labelStanding = new System.Windows.Forms.Label();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.labelWins = new System.Windows.Forms.Label();
            this.labelLosses = new System.Windows.Forms.Label();
            this.labelTies = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelHand = new System.Windows.Forms.Label();
            this.labelHeld = new System.Windows.Forms.Label();
            this.picPlay1 = new System.Windows.Forms.PictureBox();
            this.picPlay2 = new System.Windows.Forms.PictureBox();
            this.picPlay3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay3)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonHigh
            // 
            this.radioButtonHigh.AutoSize = true;
            this.radioButtonHigh.Location = new System.Drawing.Point(790, 35);
            this.radioButtonHigh.Name = "radioButtonHigh";
            this.radioButtonHigh.Size = new System.Drawing.Size(79, 17);
            this.radioButtonHigh.TabIndex = 0;
            this.radioButtonHigh.TabStop = true;
            this.radioButtonHigh.Text = "Ace is High";
            this.radioButtonHigh.UseVisualStyleBackColor = true;
            // 
            // radioButtonLow
            // 
            this.radioButtonLow.AutoSize = true;
            this.radioButtonLow.Location = new System.Drawing.Point(790, 58);
            this.radioButtonLow.Name = "radioButtonLow";
            this.radioButtonLow.Size = new System.Drawing.Size(77, 17);
            this.radioButtonLow.TabIndex = 1;
            this.radioButtonLow.TabStop = true;
            this.radioButtonLow.Text = "Ace is Low";
            this.radioButtonLow.UseVisualStyleBackColor = true;
            // 
            // labelStanding
            // 
            this.labelStanding.AutoSize = true;
            this.labelStanding.Location = new System.Drawing.Point(38, 58);
            this.labelStanding.Name = "labelStanding";
            this.labelStanding.Size = new System.Drawing.Size(49, 13);
            this.labelStanding.TabIndex = 2;
            this.labelStanding.Text = "Standing";
            // 
            // buttonHit
            // 
            this.buttonHit.BackColor = System.Drawing.Color.Ivory;
            this.buttonHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHit.Location = new System.Drawing.Point(684, 206);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(128, 53);
            this.buttonHit.TabIndex = 4;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = false;
            this.buttonHit.Click += new System.EventHandler(this.buttonHit_Click);
            // 
            // buttonStand
            // 
            this.buttonStand.BackColor = System.Drawing.Color.Ivory;
            this.buttonStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStand.Location = new System.Drawing.Point(684, 280);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(128, 57);
            this.buttonStand.TabIndex = 5;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = false;
            this.buttonStand.Click += new System.EventHandler(this.buttonStand_Click);
            // 
            // buttonOkay
            // 
            this.buttonOkay.BackColor = System.Drawing.Color.Ivory;
            this.buttonOkay.Location = new System.Drawing.Point(794, 99);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(75, 23);
            this.buttonOkay.TabIndex = 8;
            this.buttonOkay.Text = "Okay";
            this.buttonOkay.UseVisualStyleBackColor = false;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click_1);
            // 
            // labelWins
            // 
            this.labelWins.AutoSize = true;
            this.labelWins.Location = new System.Drawing.Point(741, 393);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(31, 13);
            this.labelWins.TabIndex = 9;
            this.labelWins.Text = "Wins";
            // 
            // labelLosses
            // 
            this.labelLosses.AutoSize = true;
            this.labelLosses.Location = new System.Drawing.Point(741, 422);
            this.labelLosses.Name = "labelLosses";
            this.labelLosses.Size = new System.Drawing.Size(40, 13);
            this.labelLosses.TabIndex = 10;
            this.labelLosses.Text = "Losses";
            // 
            // labelTies
            // 
            this.labelTies.AutoSize = true;
            this.labelTies.Location = new System.Drawing.Point(741, 451);
            this.labelTies.Name = "labelTies";
            this.labelTies.Size = new System.Drawing.Size(27, 13);
            this.labelTies.TabIndex = 11;
            this.labelTies.Text = "Ties";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.Ivory;
            this.buttonNew.Font = new System.Drawing.Font("Mathematica7", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Location = new System.Drawing.Point(360, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(179, 77);
            this.buttonNew.TabIndex = 12;
            this.buttonNew.Text = "Start Game";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click_1);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(759, 509);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 33);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "YOUR HAND TOTAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Wins:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Losses:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(668, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ties";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "# of Cards in Hand:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dealer Action:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(802, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ace Rule";
            // 
            // labelHand
            // 
            this.labelHand.AutoSize = true;
            this.labelHand.BackColor = System.Drawing.Color.LightGreen;
            this.labelHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHand.ForeColor = System.Drawing.Color.Maroon;
            this.labelHand.Location = new System.Drawing.Point(310, 380);
            this.labelHand.Name = "labelHand";
            this.labelHand.Size = new System.Drawing.Size(338, 55);
            this.labelHand.TabIndex = 21;
            this.labelHand.Text = "HAND TOTAL";
            // 
            // labelHeld
            // 
            this.labelHeld.AutoSize = true;
            this.labelHeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeld.ForeColor = System.Drawing.Color.Maroon;
            this.labelHeld.Location = new System.Drawing.Point(315, 455);
            this.labelHeld.Name = "labelHeld";
            this.labelHeld.Size = new System.Drawing.Size(309, 29);
            this.labelHeld.TabIndex = 22;
            this.labelHeld.Text = "# of Cards Held by Player";
            // 
            // picPlay1
            // 
            this.picPlay1.Location = new System.Drawing.Point(158, 142);
            this.picPlay1.Name = "picPlay1";
            this.picPlay1.Size = new System.Drawing.Size(156, 218);
            this.picPlay1.TabIndex = 23;
            this.picPlay1.TabStop = false;
            // 
            // picPlay2
            // 
            this.picPlay2.Location = new System.Drawing.Point(320, 142);
            this.picPlay2.Name = "picPlay2";
            this.picPlay2.Size = new System.Drawing.Size(156, 218);
            this.picPlay2.TabIndex = 24;
            this.picPlay2.TabStop = false;
            // 
            // picPlay3
            // 
            this.picPlay3.Location = new System.Drawing.Point(482, 142);
            this.picPlay3.Name = "picPlay3";
            this.picPlay3.Size = new System.Drawing.Size(156, 218);
            this.picPlay3.TabIndex = 25;
            this.picPlay3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(911, 568);
            this.Controls.Add(this.picPlay3);
            this.Controls.Add(this.picPlay2);
            this.Controls.Add(this.picPlay1);
            this.Controls.Add(this.labelHeld);
            this.Controls.Add(this.labelHand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.labelTies);
            this.Controls.Add(this.labelLosses);
            this.Controls.Add(this.labelWins);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.labelStanding);
            this.Controls.Add(this.radioButtonLow);
            this.Controls.Add(this.radioButtonHigh);
            this.Name = "Form1";
            this.Text = "BlackJack - Team 3";
            ((System.ComponentModel.ISupportInitialize)(this.picPlay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonHigh;
        private System.Windows.Forms.RadioButton radioButtonLow;
        private System.Windows.Forms.Label labelStanding;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Label labelWins;
        private System.Windows.Forms.Label labelLosses;
        private System.Windows.Forms.Label labelTies;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelHand;
        private System.Windows.Forms.Label labelHeld;
        private System.Windows.Forms.PictureBox picPlay1;
        private System.Windows.Forms.PictureBox picPlay2;
        private System.Windows.Forms.PictureBox picPlay3;
    }
}

