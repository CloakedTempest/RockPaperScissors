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
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.PaperIcon = new System.Windows.Forms.Label();
            this.ScissorsIcon = new System.Windows.Forms.Label();
            this.RockIcon = new System.Windows.Forms.Label();
            this.SingleplayerButton = new System.Windows.Forms.Button();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.Cover = new System.Windows.Forms.GroupBox();
            this.ResultBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Cover.SuspendLayout();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(74, 330);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(131, 54);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(303, 330);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(131, 54);
            this.PaperButton.TabIndex = 1;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Location = new System.Drawing.Point(529, 330);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(131, 54);
            this.ScissorsButton.TabIndex = 2;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // PaperIcon
            // 
            this.PaperIcon.AutoSize = true;
            this.PaperIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.PaperIcon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PaperIcon.Location = new System.Drawing.Point(299, 110);
            this.PaperIcon.Name = "PaperIcon";
            this.PaperIcon.Size = new System.Drawing.Size(145, 153);
            this.PaperIcon.TabIndex = 3;
            this.PaperIcon.Text = "🗎";
            this.PaperIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PaperIcon.Click += new System.EventHandler(this.PaperClick);
            this.PaperIcon.MouseEnter += new System.EventHandler(this.PaperEnter);
            this.PaperIcon.MouseLeave += new System.EventHandler(this.PaperLeave);
            // 
            // ScissorsIcon
            // 
            this.ScissorsIcon.AutoSize = true;
            this.ScissorsIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.ScissorsIcon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ScissorsIcon.Location = new System.Drawing.Point(524, 134);
            this.ScissorsIcon.Name = "ScissorsIcon";
            this.ScissorsIcon.Size = new System.Drawing.Size(151, 107);
            this.ScissorsIcon.TabIndex = 4;
            this.ScissorsIcon.Text = "✂";
            this.ScissorsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScissorsIcon.Click += new System.EventHandler(this.ScissorsClick);
            this.ScissorsIcon.MouseEnter += new System.EventHandler(this.ScissorsEnter);
            this.ScissorsIcon.MouseLeave += new System.EventHandler(this.ScissorsLeave);
            // 
            // RockIcon
            // 
            this.RockIcon.AutoSize = true;
            this.RockIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.RockIcon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.RockIcon.Location = new System.Drawing.Point(66, 134);
            this.RockIcon.Name = "RockIcon";
            this.RockIcon.Size = new System.Drawing.Size(153, 107);
            this.RockIcon.TabIndex = 5;
            this.RockIcon.Text = "💎";
            this.RockIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RockIcon.Click += new System.EventHandler(this.RockClick);
            this.RockIcon.MouseEnter += new System.EventHandler(this.RockEnter);
            this.RockIcon.MouseLeave += new System.EventHandler(this.RockLeave);
            // 
            // SingleplayerButton
            // 
            this.SingleplayerButton.BackColor = System.Drawing.Color.OliveDrab;
            this.SingleplayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SingleplayerButton.Location = new System.Drawing.Point(110, 179);
            this.SingleplayerButton.Name = "SingleplayerButton";
            this.SingleplayerButton.Size = new System.Drawing.Size(222, 120);
            this.SingleplayerButton.TabIndex = 7;
            this.SingleplayerButton.Text = "Singleplayer";
            this.SingleplayerButton.UseVisualStyleBackColor = false;
            this.SingleplayerButton.Click += new System.EventHandler(this.SingleplayerButton_Click);
            this.SingleplayerButton.MouseEnter += new System.EventHandler(this.Singleplayer_Enter);
            this.SingleplayerButton.MouseLeave += new System.EventHandler(this.Singleplayer_Leave);
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.BackColor = System.Drawing.Color.OliveDrab;
            this.MultiplayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MultiplayerButton.Location = new System.Drawing.Point(487, 179);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MultiplayerButton.Size = new System.Drawing.Size(222, 120);
            this.MultiplayerButton.TabIndex = 8;
            this.MultiplayerButton.Text = "Multiplayer";
            this.MultiplayerButton.UseVisualStyleBackColor = false;
            this.MultiplayerButton.Click += new System.EventHandler(this.MultiplayerButton_Click);
            this.MultiplayerButton.MouseEnter += new System.EventHandler(this.Multiplayer_Enter);
            this.MultiplayerButton.MouseLeave += new System.EventHandler(this.Multiplayer_Leave);
            // 
            // Cover
            // 
            this.Cover.BackColor = System.Drawing.Color.DimGray;
            this.Cover.Controls.Add(this.MultiplayerButton);
            this.Cover.Controls.Add(this.SingleplayerButton);
            this.Cover.Location = new System.Drawing.Point(-7, -8);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(5007, 5008);
            this.Cover.TabIndex = 9;
            this.Cover.TabStop = false;
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.LightGray;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ResultBox.Location = new System.Drawing.Point(181, 12);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(391, 37);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.UseVisualStyleBackColor = false;
            this.ResultBox.Click += new System.EventHandler(this.ResultBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Player 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player 2: ";
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(69, 9);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(100, 20);
            this.Player1Name.TabIndex = 12;
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(648, 9);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(100, 20);
            this.Player2Name.TabIndex = 13;
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Score1.ForeColor = System.Drawing.Color.DarkGreen;
            this.Score1.Location = new System.Drawing.Point(106, 32);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(29, 31);
            this.Score1.TabIndex = 14;
            this.Score1.Text = "0";
            this.Score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Score2.ForeColor = System.Drawing.Color.DarkGreen;
            this.Score2.Location = new System.Drawing.Point(686, 32);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(29, 31);
            this.Score2.TabIndex = 15;
            this.Score2.Text = "0";
            this.Score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cover);
            this.Controls.Add(this.RockIcon);
            this.Controls.Add(this.ScissorsIcon);
            this.Controls.Add(this.PaperIcon);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.Score2);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Name = "Form1";
            this.Text = "RockPaperScissors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Cover.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Label PaperIcon;
        private System.Windows.Forms.Label ScissorsIcon;
        private System.Windows.Forms.Label RockIcon;
        private System.Windows.Forms.Button SingleplayerButton;
        private System.Windows.Forms.Button MultiplayerButton;
        private System.Windows.Forms.GroupBox Cover;
        private System.Windows.Forms.Button ResultBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
    }
}

