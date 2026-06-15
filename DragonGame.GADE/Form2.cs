using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragonGame.GADE
{
    public partial class Form2 : Form
    {
        Random round = new Random();
        private bool FirstRoundOver = false;

        public class Player
        {
            public string playerName { get; set; }
            public string dragonName { get; set; }
            public string dragonType { get; set; }

            public int Health { get; set; }
            public int Attack { get; set; }
            public int SpecialA { get; set; }
            public int Block { get; set; }

            public bool isBlocking;

            public Player(string name, string dragname, string dragtype, int health, int attack, int specialAtk, int block)
            {
                playerName = name;
                dragonName = dragname;
                dragonType = dragtype;
                Health = health;
                Attack = attack;
                SpecialA = specialAtk;
                Block = block;
                isBlocking = false;
            }

            public void LoseHp(int damage)
            {
                Health -= damage;
                if (Health < 0) Health = 0; // prevent negative health as game has ended
            }


        }
        public void startGame()
        {
            Form2 gameForm = new Form2(player1, player2);
            gameForm.Show();
            this.Hide();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            currentplayer = TakeInitiative();

            //Start BattleLog
            LogAction("---LET THE BATTLE BEGIN---");
            LogAction($"{player1.playerName} vs {player2.playerName}");
            LogAction($"{player1.dragonName} vs {player2.dragonName}");

            Player starter = (currentplayer == 1) ? player1 : player2;
            LogAction($"{starter.playerName} wins the roll and goes first");

            RerollInitiative();

            UpdategameForm(currentplayer);

        }

        private Player player1;
        private Player player2;
        private int currentplayer;

        public Form2(Player player1, Player player2)
        {
            InitializeComponent();

            this.player1 = player1;
            this.player2 = player2;
            this.currentplayer = 1; //assumption that player 1 starts

            RefreshUI();
        }


        private int RandomRoll()
        {
            return round.Next(1, 7);
        }

        private int TakeInitiative()
        {
            int rollPlayer1, rollPlayer2;
            do
            {
                rollPlayer1 = RandomRoll();
                rollPlayer2 = RandomRoll();
            }
            while (rollPlayer1 == rollPlayer2); //prevent rolls from having the same value
            return (rollPlayer1 > rollPlayer2) ? 1 : 2; //returns 1 for player 1 and 2 for player 2 when either wins the roll

        }
        private void LoadTurn(object sender, EventArgs e)
        {

        }


        private void UpdategameForm(int player)
        {
            if (player == 1)
            {
                //Update Ui for player 1
            }
            else
            {
                //Update Ui for player 2
            }


        }

        private void RefreshUI()
        {
            //identify players
            Player active = (currentplayer == 1) ? player1 : player2;
            Player oppo = (currentplayer == 1) ? player2 : player1;

            //Update UI at once
            turnplayerBox.Text = active.dragonName;
            opposingPlayer.Text = oppo.dragonName;
            oppPlayertxt.Text = oppo.playerName;

            //simple health display
            hptxtbox1.Text = $"HP: {active.Health}";
            hptxtbox2.Text = $"HP: {oppo.Health}";
        }


        public void Attack(Player playerATK, Player playerDEF)
        {
            if (!playerDEF.isBlocking)
            {
                playerDEF.LoseHp(playerATK.Attack);
            }
            playerATK.isBlocking = false;
        }

        public void SAttack(Player playerATK, Player playerDEF)
        {
            if (!playerDEF.isBlocking)
            {
                playerDEF.LoseHp(playerATK.SpecialA);
            }
            playerATK.isBlocking = false;
        }

        public void Block(Player player)
        {
            player.isBlocking = true;
        }

        //sorting out the button actions
        private void atkButton_Click(object sender, EventArgs e)
        {
            TurnAction("Attack");
        }

        private void satkButton_Click(object sender, EventArgs e)
        {
            TurnAction("Special Attack");
        }

        private void blkButton_Click(object sender, EventArgs e)
        {
            TurnAction("Block");
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            //identify player/dragon to rest
            Player attacker = (currentplayer == 1) ? player1 : player2;

            //Excecute Rest Logic
            Rest(attacker);
        }
        //handle turn switching between the players
        public void TurnAction(string action)
        {
            Player cPlayer = (currentplayer == 1) ? player1 : player2;
            Player oPlayer = (currentplayer == 1) ? player2 : player1;

            if (action == "Block")
            {
                Block(cPlayer);
                LogAction($"{cPlayer.dragonName} blocks the attack!");
            }
            else if (action == "Attack")
            {
                if (oPlayer.isBlocking)
                {
                    LogAction($"{cPlayer.dragonName} attacks, but {oPlayer.dragonName} blocks!");
                }
                else
                {
                    oPlayer.LoseHp(cPlayer.Attack);
                    LogAction($"{cPlayer.dragonName} deals {cPlayer.Attack} damage to {oPlayer.dragonName}!");
                }
                cPlayer.isBlocking = false; //resets blocking after attack
            }
            else if (action == "Special Attack")
            {
                if (oPlayer.isBlocking)
                {
                    LogAction($"{oPlayer.dragonName} manages to block against {cPlayer.dragonName}'s special attack!");
                }
                else
                {
                    oPlayer.LoseHp(cPlayer.SpecialA);
                    LogAction($"BOOM!! {cPlayer.dragonName} lands an amazing Special Attack on {oPlayer.dragonName}!");
                }
                oPlayer.isBlocking = false;

                //SATK CoolDown: Hide Action buttons
                atkButton.Visible = false;
                satkButton.Visible = false;
                blkButton.Visible = false;

                //reveal rest button on top
                restButton.Visible = true;


            }
            if (!CheckForWin())
            {
                SwitchTurns(); //switch between players or trigger reroll
            }
            RefreshUI();
        }

        private void Rest(Player restedDragon)
        {
            
            restedDragon.isBlocking = false;

            //log rest action taken by dragon
            LogAction($"{restedDragon.dragonName} takes a rest to recover after the special attack!");

            //swap button layout back to normal
            restButton.Visible = false;

            atkButton.Visible = true;
            satkButton.Visible = true;
            blkButton.Visible = true;

            //conclude rest and resume normal game
            if(!CheckForWin())
            {
                SwitchTurns();
            }

        }

        public void SwitchTurns()
        {
            if (!FirstRoundOver)
            {
                //current player's turn toggled
                currentplayer = (currentplayer == 1) ? 2 : 1;
                FirstRoundOver = true;

                LogAction("---------------------------------");
                Player nextPlayer = (currentplayer == 1) ? player1 : player2;
                LogAction($"It is now {nextPlayer.playerName}'s turn");

                //reset block status for next player's turn
                nextPlayer.isBlocking = false;
                RefreshUI();
            }
            else
            {
                LogAction("-----------------------------------------");
                LogAction("Round 1 Over. Re-Rolling Initiative for next round");

                //reset round tracker
                FirstRoundOver = false;

                //Trigger ReRoll for initiative
                RerollInitiative();
            }


            UpdategameForm(currentplayer);
        }

        private void RerollInitiative()
        {
            int firstP = TakeInitiative();
            currentplayer = firstP;

            Player starter = (currentplayer == 1) ? player1 : player2;

            LogAction($"Dice Rolled! {starter.playerName} and {starter.dragonName} get initiative!");
            LogAction("--------------------------------------------");

            starter.isBlocking = false;

            RefreshUI();
        }




        //setting up text in battle log
        private void LogAction(string battlelog)
        {
            //appends text and adds a new line
            richTextBox1.AppendText($"{battlelog}{Environment.NewLine}");

            //Auto scrolls so you always see last move made
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

        }
        private bool CheckForWin()
        {
            if (player1.Health <= 0)
            {
                LogAction("---------------------------------------");
                LogAction($"GAME OVER: {player1.dragonName} has been defeated!");
                LogAction($"{player2.dragonName} WINS THE BATTLE!");
                DisableButtons();
                return true;
            }
            if (player2.Health <= 0)
            {
                LogAction("----------------------------------------");
                LogAction($"GAME OVER: {player2.dragonName} has lost the batte!");
                LogAction($"{player1.dragonName} IS THE WINNER!");
                DisableButtons();
                return true;
            }
            return false;
        }

        public void DisableButtons()
        {
            atkButton.Enabled = false;
            satkButton.Enabled = false;
            blkButton.Enabled = false;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void turnplayerBox_Enter(object sender, EventArgs e)
        {

        }
        private void oppPlayertxt_Click(object sender, EventArgs e)
        {

        }
        private void opposingPlayer_Enter(object sender, EventArgs e)
        {

        }
        private void hptxtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hptxtbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
