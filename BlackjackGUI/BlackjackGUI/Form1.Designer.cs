namespace BlackjackGUI
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
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxDeck = new System.Windows.Forms.PictureBox();
            this.pictureBoxNewCard = new System.Windows.Forms.PictureBox();
            this.labelDrawnCardPlayer = new System.Windows.Forms.Label();
            this.labelPlayerScoreText = new System.Windows.Forms.Label();
            this.labelDealerScoreText = new System.Windows.Forms.Label();
            this.labelResultPlayer = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDrawnCardDealer = new System.Windows.Forms.Label();
            this.labelResultDealer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewCard)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHit
            // 
            this.buttonHit.Location = new System.Drawing.Point(506, 213);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(148, 98);
            this.buttonHit.TabIndex = 0;
            this.buttonHit.Text = "Hit";
            this.buttonHit.UseVisualStyleBackColor = true;
            // 
            // buttonStand
            // 
            this.buttonStand.Location = new System.Drawing.Point(506, 326);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(148, 98);
            this.buttonStand.TabIndex = 1;
            this.buttonStand.Text = "Stand";
            this.buttonStand.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(195, 516);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(263, 50);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDeck
            // 
            this.pictureBoxDeck.Location = new System.Drawing.Point(12, 3);
            this.pictureBoxDeck.Name = "pictureBoxDeck";
            this.pictureBoxDeck.Size = new System.Drawing.Size(173, 87);
            this.pictureBoxDeck.TabIndex = 3;
            this.pictureBoxDeck.TabStop = false;
            // 
            // pictureBoxNewCard
            // 
            this.pictureBoxNewCard.Location = new System.Drawing.Point(12, 213);
            this.pictureBoxNewCard.Name = "pictureBoxNewCard";
            this.pictureBoxNewCard.Size = new System.Drawing.Size(173, 288);
            this.pictureBoxNewCard.TabIndex = 4;
            this.pictureBoxNewCard.TabStop = false;
            // 
            // labelDrawnCardPlayer
            // 
            this.labelDrawnCardPlayer.AutoSize = true;
            this.labelDrawnCardPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawnCardPlayer.Location = new System.Drawing.Point(191, 213);
            this.labelDrawnCardPlayer.Name = "labelDrawnCardPlayer";
            this.labelDrawnCardPlayer.Size = new System.Drawing.Size(135, 16);
            this.labelDrawnCardPlayer.TabIndex = 5;
            this.labelDrawnCardPlayer.Text = "You drew six of clubs.";
            // 
            // labelPlayerScoreText
            // 
            this.labelPlayerScoreText.AutoSize = true;
            this.labelPlayerScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerScoreText.Location = new System.Drawing.Point(192, 270);
            this.labelPlayerScoreText.Name = "labelPlayerScoreText";
            this.labelPlayerScoreText.Size = new System.Drawing.Size(107, 24);
            this.labelPlayerScoreText.TabIndex = 6;
            this.labelPlayerScoreText.Text = "Your score:";
            // 
            // labelDealerScoreText
            // 
            this.labelDealerScoreText.AutoSize = true;
            this.labelDealerScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealerScoreText.Location = new System.Drawing.Point(192, 339);
            this.labelDealerScoreText.Name = "labelDealerScoreText";
            this.labelDealerScoreText.Size = new System.Drawing.Size(135, 24);
            this.labelDealerScoreText.TabIndex = 7;
            this.labelDealerScoreText.Text = "Dealer\'s score:";
            // 
            // labelResultPlayer
            // 
            this.labelResultPlayer.AutoSize = true;
            this.labelResultPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultPlayer.ForeColor = System.Drawing.Color.Red;
            this.labelResultPlayer.Location = new System.Drawing.Point(191, 238);
            this.labelResultPlayer.Name = "labelResultPlayer";
            this.labelResultPlayer.Size = new System.Drawing.Size(154, 16);
            this.labelResultPlayer.TabIndex = 8;
            this.labelResultPlayer.Text = "You lost by overdrawing!";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(195, 448);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(263, 52);
            this.buttonContinue.TabIndex = 9;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerScore.Location = new System.Drawing.Point(335, 270);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(30, 24);
            this.labelPlayerScore.TabIndex = 10;
            this.labelPlayerScore.Text = "22";
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealerScore.Location = new System.Drawing.Point(334, 339);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(30, 24);
            this.labelDealerScore.TabIndex = 11;
            this.labelDealerScore.Text = "17";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(191, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(177, 42);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Blackjack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "by: Justin Carpenter";
            // 
            // labelDrawnCardDealer
            // 
            this.labelDrawnCardDealer.AutoSize = true;
            this.labelDrawnCardDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawnCardDealer.Location = new System.Drawing.Point(191, 378);
            this.labelDrawnCardDealer.Name = "labelDrawnCardDealer";
            this.labelDrawnCardDealer.Size = new System.Drawing.Size(212, 16);
            this.labelDrawnCardDealer.TabIndex = 14;
            this.labelDrawnCardDealer.Text = "The dealer drew seven of spades.";
            // 
            // labelResultDealer
            // 
            this.labelResultDealer.AutoSize = true;
            this.labelResultDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultDealer.Location = new System.Drawing.Point(191, 408);
            this.labelResultDealer.Name = "labelResultDealer";
            this.labelResultDealer.Size = new System.Drawing.Size(145, 16);
            this.labelResultDealer.TabIndex = 15;
            this.labelResultDealer.Text = "The dealer stood at 17.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 578);
            this.Controls.Add(this.labelResultDealer);
            this.Controls.Add(this.labelDrawnCardDealer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelResultPlayer);
            this.Controls.Add(this.labelDealerScoreText);
            this.Controls.Add(this.labelPlayerScoreText);
            this.Controls.Add(this.labelDrawnCardPlayer);
            this.Controls.Add(this.pictureBoxNewCard);
            this.Controls.Add(this.pictureBoxDeck);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxDeck;
        private System.Windows.Forms.PictureBox pictureBoxNewCard;
        private System.Windows.Forms.Label labelDrawnCardPlayer;
        private System.Windows.Forms.Label labelPlayerScoreText;
        private System.Windows.Forms.Label labelDealerScoreText;
        private System.Windows.Forms.Label labelResultPlayer;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDrawnCardDealer;
        private System.Windows.Forms.Label labelResultDealer;
    }
}

