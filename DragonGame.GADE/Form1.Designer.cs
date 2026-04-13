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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dragonBox = new GroupBox();
            iceDragon = new RadioButton();
            fireDragon = new RadioButton();
            windDragon = new RadioButton();
            earthDragon = new RadioButton();
            dragonBox2 = new GroupBox();
            fireDragon2 = new RadioButton();
            iceDragon2 = new RadioButton();
            windDragon2 = new RadioButton();
            earthDragon2 = new RadioButton();
            savePlayer1 = new Button();
            savePlayer2 = new Button();
            startGame = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            dragonBox.SuspendLayout();
            dragonBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(savePlayer1);
            groupBox1.Controls.Add(dragonBox);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(savePlayer2);
            groupBox2.Controls.Add(dragonBox2);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(348, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Player2";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Dragon Name: ";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 71);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Dragon Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 24);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(101, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 23);
            textBox4.TabIndex = 3;
            // 
            // dragonBox
            // 
            dragonBox.Controls.Add(earthDragon);
            dragonBox.Controls.Add(windDragon);
            dragonBox.Controls.Add(fireDragon);
            dragonBox.Controls.Add(iceDragon);
            dragonBox.Location = new Point(6, 113);
            dragonBox.Name = "dragonBox";
            dragonBox.Size = new Size(315, 150);
            dragonBox.TabIndex = 4;
            dragonBox.TabStop = false;
            dragonBox.Text = "Dragon Type";
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
            // dragonBox2
            // 
            dragonBox2.Controls.Add(earthDragon2);
            dragonBox2.Controls.Add(windDragon2);
            dragonBox2.Controls.Add(iceDragon2);
            dragonBox2.Controls.Add(fireDragon2);
            dragonBox2.Location = new Point(6, 113);
            dragonBox2.Name = "dragonBox2";
            dragonBox2.Size = new Size(317, 150);
            dragonBox2.TabIndex = 4;
            dragonBox2.TabStop = false;
            dragonBox2.Text = "Dragon Type";
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
            // savePlayer1
            // 
            savePlayer1.Location = new Point(6, 269);
            savePlayer1.Name = "savePlayer1";
            savePlayer1.Size = new Size(315, 27);
            savePlayer1.TabIndex = 5;
            savePlayer1.Text = "Save";
            savePlayer1.UseVisualStyleBackColor = true;
            // 
            // savePlayer2
            // 
            savePlayer2.Location = new Point(6, 269);
            savePlayer2.Name = "savePlayer2";
            savePlayer2.Size = new Size(317, 27);
            savePlayer2.TabIndex = 5;
            savePlayer2.Text = "Save";
            savePlayer2.UseVisualStyleBackColor = true;
            // 
            // startGame
            // 
            startGame.Location = new Point(12, 372);
            startGame.Name = "startGame";
            startGame.Size = new Size(665, 40);
            startGame.TabIndex = 2;
            startGame.Text = "Start Game";
            startGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(startGame);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            dragonBox.ResumeLayout(false);
            dragonBox.PerformLayout();
            dragonBox2.ResumeLayout(false);
            dragonBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
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
    }
}
