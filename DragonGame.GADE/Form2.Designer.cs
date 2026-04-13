namespace DragonGame.GADE
{
    partial class Form2
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
            turnplayerBox = new GroupBox();
            opposingPlayer = new GroupBox();
            battleLog = new GroupBox();
            richTextBox1 = new RichTextBox();
            hpTxt1 = new Label();
            atkButton = new Button();
            satkButton = new Button();
            blkButton = new Button();
            oppPlayertxt = new Label();
            turnplayerBox.SuspendLayout();
            opposingPlayer.SuspendLayout();
            battleLog.SuspendLayout();
            SuspendLayout();
            // 
            // turnplayerBox
            // 
            turnplayerBox.Controls.Add(blkButton);
            turnplayerBox.Controls.Add(satkButton);
            turnplayerBox.Controls.Add(atkButton);
            turnplayerBox.Controls.Add(hpTxt1);
            turnplayerBox.Location = new Point(12, 12);
            turnplayerBox.Name = "turnplayerBox";
            turnplayerBox.Size = new Size(206, 207);
            turnplayerBox.TabIndex = 0;
            turnplayerBox.TabStop = false;
            turnplayerBox.Text = "Player's Dragon's Turn";
            // 
            // opposingPlayer
            // 
            opposingPlayer.Controls.Add(oppPlayertxt);
            opposingPlayer.Location = new Point(265, 74);
            opposingPlayer.Name = "opposingPlayer";
            opposingPlayer.Size = new Size(262, 100);
            opposingPlayer.TabIndex = 1;
            opposingPlayer.TabStop = false;
            opposingPlayer.Text = "Opponent: Opposing Player";
            opposingPlayer.Enter += opposingPlayer_Enter;
            // 
            // battleLog
            // 
            battleLog.Controls.Add(richTextBox1);
            battleLog.Location = new Point(12, 225);
            battleLog.Name = "battleLog";
            battleLog.Size = new Size(515, 163);
            battleLog.TabIndex = 2;
            battleLog.TabStop = false;
            battleLog.Text = "Battle Log";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(503, 135);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // hpTxt1
            // 
            hpTxt1.AutoSize = true;
            hpTxt1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hpTxt1.Location = new Point(52, 19);
            hpTxt1.Name = "hpTxt1";
            hpTxt1.Size = new Size(107, 40);
            hpTxt1.TabIndex = 0;
            hpTxt1.Text = "HP: 15";
            // 
            // atkButton
            // 
            atkButton.Location = new Point(9, 62);
            atkButton.Name = "atkButton";
            atkButton.Size = new Size(191, 41);
            atkButton.TabIndex = 1;
            atkButton.Text = "Attack";
            atkButton.UseVisualStyleBackColor = true;
            // 
            // satkButton
            // 
            satkButton.Location = new Point(9, 109);
            satkButton.Name = "satkButton";
            satkButton.Size = new Size(191, 41);
            satkButton.TabIndex = 2;
            satkButton.Text = "Special Attack";
            satkButton.UseVisualStyleBackColor = true;
            // 
            // blkButton
            // 
            blkButton.Location = new Point(9, 156);
            blkButton.Name = "blkButton";
            blkButton.Size = new Size(191, 41);
            blkButton.TabIndex = 3;
            blkButton.Text = "Block";
            blkButton.UseVisualStyleBackColor = true;
            // 
            // oppPlayertxt
            // 
            oppPlayertxt.AutoSize = true;
            oppPlayertxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oppPlayertxt.Location = new Point(35, 36);
            oppPlayertxt.Name = "oppPlayertxt";
            oppPlayertxt.Size = new Size(201, 25);
            oppPlayertxt.TabIndex = 0;
            oppPlayertxt.Text = "Opp Player's Dragon:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 400);
            Controls.Add(battleLog);
            Controls.Add(opposingPlayer);
            Controls.Add(turnplayerBox);
            Name = "Form2";
            Text = "Form2";
            turnplayerBox.ResumeLayout(false);
            turnplayerBox.PerformLayout();
            opposingPlayer.ResumeLayout(false);
            opposingPlayer.PerformLayout();
            battleLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox turnplayerBox;
        private GroupBox opposingPlayer;
        private GroupBox battleLog;
        private RichTextBox richTextBox1;
        private Button blkButton;
        private Button satkButton;
        private Button atkButton;
        private Label hpTxt1;
        private Label oppPlayertxt;
    }
}