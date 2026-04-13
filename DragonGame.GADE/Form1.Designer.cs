namespace DragonGame.GADE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player1Info = new GroupBox();
            savePlayer1 = new Button();
            dragonBox = new GroupBox();
            earthDragon = new RadioButton();
            windDragon = new RadioButton();
            fireDragon = new RadioButton();
            iceDragon = new RadioButton();
            dragon1Name = new TextBox();
            player1Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            player2Info = new GroupBox();
            savePlayer2 = new Button();
            dragonBox2 = new GroupBox();
            earthDragon2 = new RadioButton();
            windDragon2 = new RadioButton();
            iceDragon2 = new RadioButton();
            fireDragon2 = new RadioButton();
            dragon2Name = new TextBox();
            player2Name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            startGame = new Button();
            dragonStats = new RichTextBox();
            player1Info.SuspendLayout();
            dragonBox.SuspendLayout();
            player2Info.SuspendLayout();
            dragonBox2.SuspendLayout();
            SuspendLayout();
            // 
            // player1Info
            // 
            player1Info.Controls.Add(savePlayer1);
            player1Info.Controls.Add(dragonBox);
            player1Info.Controls.Add(dragon1Name);
            player1Info.Controls.Add(player1Name);
            player1Info.Controls.Add(label2);
            player1Info.Controls.Add(label1);
            player1Info.Location = new Point(12, 45);
            player1Info.Name = "player1Info";
            player1Info.Size = new Size(302, 305);
            player1Info.TabIndex = 0;
            player1Info.TabStop = false;
            player1Info.Text = "Player1";
            // 
            // savePlayer1
            // 
            savePlayer1.Location = new Point(6, 269);
            savePlayer1.Name = "savePlayer1";
            savePlayer1.Size = new Size(290, 27);
            savePlayer1.TabIndex = 5;
            savePlayer1.Text = "Save";
            savePlayer1.UseVisualStyleBackColor = true;
            // 
            // dragonBox
            // 
            dragonBox.Controls.Add(earthDragon);
            dragonBox.Controls.Add(windDragon);
            dragonBox.Controls.Add(fireDragon);
            dragonBox.Controls.Add(iceDragon);
            dragonBox.Location = new Point(6, 113);
            dragonBox.Name = "dragonBox";
            dragonBox.Size = new Size(290, 150);
            dragonBox.TabIndex = 4;
            dragonBox.TabStop = false;
            dragonBox.Text = "Dragon Type";
            // 
            // earthDragon
            // 
            earthDragon.AutoSize = true;
            earthDragon.Location = new Point(13, 118);
            earthDragon.Name = "earthDragon";
            earthDragon.Size = new Size(94, 19);
            earthDragon.TabIndex = 3;
            earthDragon.TabStop = true;
            earthDragon.Text = "Earth Dragon";
            earthDragon.UseVisualStyleBackColor = true;
            // 
            // windDragon
            // 
            windDragon.AutoSize = true;
            windDragon.Location = new Point(13, 93);
            windDragon.Name = "windDragon";
            windDragon.Size = new Size(95, 19);
            windDragon.TabIndex = 2;
            windDragon.TabStop = true;
            windDragon.Text = "Wind Dragon";
            windDragon.UseVisualStyleBackColor = true;
            // 
            // fireDragon
            // 
            fireDragon.AutoSize = true;
            fireDragon.Location = new Point(13, 43);
            fireDragon.Name = "fireDragon";
            fireDragon.Size = new Size(86, 19);
            fireDragon.TabIndex = 1;
            fireDragon.TabStop = true;
            fireDragon.Text = "Fire Dragon";
            fireDragon.UseVisualStyleBackColor = true;
            // 
            // iceDragon
            // 
            iceDragon.AutoSize = true;
            iceDragon.Location = new Point(13, 68);
            iceDragon.Name = "iceDragon";
            iceDragon.Size = new Size(82, 19);
            iceDragon.TabIndex = 0;
            iceDragon.TabStop = true;
            iceDragon.Text = "Ice Dragon";
            iceDragon.UseVisualStyleBackColor = true;
            // 
            // dragon1Name
            // 
            dragon1Name.Location = new Point(99, 68);
            dragon1Name.Name = "dragon1Name";
            dragon1Name.Size = new Size(197, 23);
            dragon1Name.TabIndex = 3;
            dragon1Name.TextChanged += textBox2_TextChanged;
            // 
            // player1Name
            // 
            player1Name.Location = new Point(99, 24);
            player1Name.Name = "player1Name";
            player1Name.Size = new Size(197, 23);
            player1Name.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Dragon Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Player Name:";
            // 
            // player2Info
            // 
            player2Info.Controls.Add(savePlayer2);
            player2Info.Controls.Add(dragonBox2);
            player2Info.Controls.Add(dragon2Name);
            player2Info.Controls.Add(player2Name);
            player2Info.Controls.Add(label4);
            player2Info.Controls.Add(label3);
            player2Info.Location = new Point(337, 45);
            player2Info.Name = "player2Info";
            player2Info.Size = new Size(302, 305);
            player2Info.TabIndex = 1;
            player2Info.TabStop = false;
            player2Info.Text = "Player2";
            // 
            // savePlayer2
            // 
            savePlayer2.Location = new Point(6, 269);
            savePlayer2.Name = "savePlayer2";
            savePlayer2.Size = new Size(290, 27);
            savePlayer2.TabIndex = 5;
            savePlayer2.Text = "Save";
            savePlayer2.UseVisualStyleBackColor = true;
            // 
            // dragonBox2
            // 
            dragonBox2.Controls.Add(earthDragon2);
            dragonBox2.Controls.Add(windDragon2);
            dragonBox2.Controls.Add(iceDragon2);
            dragonBox2.Controls.Add(fireDragon2);
            dragonBox2.Location = new Point(6, 113);
            dragonBox2.Name = "dragonBox2";
            dragonBox2.Size = new Size(290, 150);
            dragonBox2.TabIndex = 4;
            dragonBox2.TabStop = false;
            dragonBox2.Text = "Dragon Type";
            // 
            // earthDragon2
            // 
            earthDragon2.AutoSize = true;
            earthDragon2.Location = new Point(16, 118);
            earthDragon2.Name = "earthDragon2";
            earthDragon2.Size = new Size(94, 19);
            earthDragon2.TabIndex = 3;
            earthDragon2.TabStop = true;
            earthDragon2.Text = "Earth Dragon";
            earthDragon2.UseVisualStyleBackColor = true;
            // 
            // windDragon2
            // 
            windDragon2.AutoSize = true;
            windDragon2.Location = new Point(16, 93);
            windDragon2.Name = "windDragon2";
            windDragon2.Size = new Size(95, 19);
            windDragon2.TabIndex = 2;
            windDragon2.TabStop = true;
            windDragon2.Text = "Wind Dragon";
            windDragon2.UseVisualStyleBackColor = true;
            // 
            // iceDragon2
            // 
            iceDragon2.AutoSize = true;
            iceDragon2.Location = new Point(16, 68);
            iceDragon2.Name = "iceDragon2";
            iceDragon2.Size = new Size(82, 19);
            iceDragon2.TabIndex = 1;
            iceDragon2.TabStop = true;
            iceDragon2.Text = "Ice Dragon";
            iceDragon2.UseVisualStyleBackColor = true;
            // 
            // fireDragon2
            // 
            fireDragon2.AutoSize = true;
            fireDragon2.Location = new Point(16, 43);
            fireDragon2.Name = "fireDragon2";
            fireDragon2.Size = new Size(86, 19);
            fireDragon2.TabIndex = 0;
            fireDragon2.TabStop = true;
            fireDragon2.Text = "Fire Dragon";
            fireDragon2.UseVisualStyleBackColor = true;
            // 
            // dragon2Name
            // 
            dragon2Name.Location = new Point(101, 68);
            dragon2Name.Name = "dragon2Name";
            dragon2Name.Size = new Size(195, 23);
            dragon2Name.TabIndex = 3;
            // 
            // player2Name
            // 
            player2Name.Location = new Point(101, 24);
            player2Name.Name = "player2Name";
            player2Name.Size = new Size(195, 23);
            player2Name.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 71);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Dragon Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 27);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 0;
            label3.Text = "Player Name:";
            // 
            // startGame
            // 
            startGame.Location = new Point(12, 384);
            startGame.Name = "startGame";
            startGame.Size = new Size(627, 40);
            startGame.TabIndex = 2;
            startGame.Text = "Start Game";
            startGame.UseVisualStyleBackColor = true;
            // 
            // dragonStats
            // 
            dragonStats.BackColor = SystemColors.ButtonFace;
            dragonStats.Location = new Point(674, 12);
            dragonStats.Name = "dragonStats";
            dragonStats.Size = new Size(127, 374);
            dragonStats.TabIndex = 4;
            dragonStats.Text = resources.GetString("dragonStats.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 436);
            Controls.Add(dragonStats);
            Controls.Add(startGame);
            Controls.Add(player2Info);
            Controls.Add(player1Info);
            Name = "Form1";
            Text = "Form1";
            player1Info.ResumeLayout(false);
            player1Info.PerformLayout();
            dragonBox.ResumeLayout(false);
            dragonBox.PerformLayout();
            player2Info.ResumeLayout(false);
            player2Info.PerformLayout();
            dragonBox2.ResumeLayout(false);
            dragonBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox player1Info;
        private Label label2;
        private Label label1;
        private GroupBox player2Info;
        private Label label4;
        private Label label3;
        private TextBox dragon1Name;
        private TextBox player1Name;
        private TextBox dragon2Name;
        private TextBox player2Name;
        private GroupBox dragonBox;
        private RadioButton earthDragon;
        private RadioButton windDragon;
        private RadioButton fireDragon;
        private RadioButton iceDragon;
        private GroupBox dragonBox2;
        private RadioButton earthDragon2;
        private RadioButton windDragon2;
        private RadioButton iceDragon2;
        private RadioButton fireDragon2;
        private Button savePlayer1;
        private Button savePlayer2;
        private Button startGame;
        private RichTextBox dragonStats;
    }
}
