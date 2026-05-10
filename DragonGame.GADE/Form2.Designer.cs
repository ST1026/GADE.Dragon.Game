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
            hptxtbox1 = new RichTextBox();
            blkButton = new Button();
            satkButton = new Button();
            atkButton = new Button();
            opposingPlayer = new GroupBox();
            hptxtbox2 = new RichTextBox();
            oppPlayertxt = new Label();
            battleLog = new GroupBox();
            richTextBox1 = new RichTextBox();
            turnplayerBox.SuspendLayout();
            opposingPlayer.SuspendLayout();
            battleLog.SuspendLayout();
            SuspendLayout();
            // 
            // turnplayerBox
            // 
            turnplayerBox.Controls.Add(hptxtbox1);
            turnplayerBox.Controls.Add(blkButton);
            turnplayerBox.Controls.Add(satkButton);
            turnplayerBox.Controls.Add(atkButton);
            turnplayerBox.Location = new Point(12, 5);
            turnplayerBox.Name = "turnplayerBox";
            turnplayerBox.Size = new Size(206, 214);
            turnplayerBox.TabIndex = 0;
            turnplayerBox.TabStop = false;
            turnplayerBox.Text = "Player's Dragon's Turn";
            turnplayerBox.Enter += turnplayerBox_Enter;
            // 
            // hptxtbox1
            // 
            hptxtbox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hptxtbox1.Location = new Point(59, 26);
            hptxtbox1.Name = "hptxtbox1";
            hptxtbox1.Size = new Size(90, 41);
            hptxtbox1.TabIndex = 4;
            hptxtbox1.Text = "HP:";
            hptxtbox1.TextChanged += hptxtbox1_TextChanged;
            // 
            // blkButton
            // 
            blkButton.Location = new Point(9, 167);
            blkButton.Name = "blkButton";
            blkButton.Size = new Size(191, 41);
            blkButton.TabIndex = 3;
            blkButton.Text = "Block";
            blkButton.UseVisualStyleBackColor = true;
            blkButton.Click += blkButton_Click;
            // 
            // satkButton
            // 
            satkButton.Location = new Point(9, 120);
            satkButton.Name = "satkButton";
            satkButton.Size = new Size(191, 41);
            satkButton.TabIndex = 2;
            satkButton.Text = "Special Attack";
            satkButton.UseVisualStyleBackColor = true;
            satkButton.Click += satkButton_Click;
            // 
            // atkButton
            // 
            atkButton.Location = new Point(9, 73);
            atkButton.Name = "atkButton";
            atkButton.Size = new Size(191, 41);
            atkButton.TabIndex = 1;
            atkButton.Text = "Attack";
            atkButton.UseVisualStyleBackColor = true;
            atkButton.Click += atkButton_Click;
            // 
            // opposingPlayer
            // 
            opposingPlayer.Controls.Add(hptxtbox2);
            opposingPlayer.Controls.Add(oppPlayertxt);
            opposingPlayer.Location = new Point(265, 55);
            opposingPlayer.Name = "opposingPlayer";
            opposingPlayer.Size = new Size(262, 119);
            opposingPlayer.TabIndex = 1;
            opposingPlayer.TabStop = false;
            opposingPlayer.Text = "Opponent: Opposing Player";
            opposingPlayer.Enter += opposingPlayer_Enter;
            // 
            // hptxtbox2
            // 
            hptxtbox2.Anchor = AnchorStyles.None;
            hptxtbox2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hptxtbox2.Location = new Point(89, 66);
            hptxtbox2.Name = "hptxtbox2";
            hptxtbox2.Size = new Size(89, 42);
            hptxtbox2.TabIndex = 3;
            hptxtbox2.Text = "HP:";
            hptxtbox2.TextChanged += hptxtbox2_TextChanged;
            // 
            // oppPlayertxt
            // 
            oppPlayertxt.AutoSize = true;
            oppPlayertxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oppPlayertxt.Location = new Point(32, 24);
            oppPlayertxt.Name = "oppPlayertxt";
            oppPlayertxt.Size = new Size(201, 25);
            oppPlayertxt.TabIndex = 0;
            oppPlayertxt.Text = "Opp Player's Dragon:";
            oppPlayertxt.Click += oppPlayertxt_Click;
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
            richTextBox1.TextChanged += richTextBox1_TextChanged;
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
            Load += Form2_Load;
            turnplayerBox.ResumeLayout(false);
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
        private Label oppPlayertxt;
        private RichTextBox hptxtbox1;
        private RichTextBox hptxtbox2;
    }
}