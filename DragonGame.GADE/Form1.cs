using static DragonGame.GADE.Form2;
namespace DragonGame.GADE
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;

        string[] dataP1 = new string[3]; //Player1 name, Dragon1 Name, Dragon1 Type
        int[] valuesP1 = new int[4]; //Health, Attack, Special Attack, and Block Stats
        string[] dataP2 = new string[3]; //Player2 name, Dragon2 Name, Dragon2 Type
        int[] valuesP2 = new int[4]; //Health, Attack, Special Attack, and Block Stats

        //declaring dragons and their stats:

        //Ice Dragon:
        const string iceDName = "Ice Dragon";
        const int iceDHp = 30;
        const int iceDAttack = 4;
        const int iceDSAttack = 9;
        const int iceDBLK = 5;

        //Fire Dragon:
        const string fireDName = "Fire Dragon";
        const int fireDHp = 20;
        const int fireDAttack = 5;
        const int fireDSAttack = 12;
        const int fireDBLK = 4;

        //Earth Dragon:
        const string earthDName = "Earth Dragon";
        const int earthDHp = 50;
        const int earthDAttack = 2;
        const int earthDSAttack = 5;
        const int earthDBLK = 6;

        //Wind Dragon:
        const string windDName = "Wind Dragon";
        const int windDHp = 40;
        const int windDAttack = 3;
        const int windDSAttack = 7;
        const int windDBLK = 5;




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void savePlayer1_Click(object sender, EventArgs e)
        {
            //collected data from Player 1
            string playerName = player1Name.Text;
            string dragonName = dragon1Name.Text;
            string dragonType = dragonBox.Text;

            //save Player1's values
            CollectedData(playerName, dragonName, dragonType, out player1);
            savePlayer1.Enabled = false;

            //check if both players have saved before game starts
            if(!savePlayer1.Enabled && !savePlayer2.Enabled)
            {
                startGame.Enabled = true;
            }
        }

        private void savePlayer2_Click(object sender, EventArgs e)
        {
            //collected data from P2
            string playerName = player2Name.Text;
            string dragonName = dragon2Name.Text;
            string dragonType = dragonBox2.Text;

            //Save P2 Values
            CollectedData(playerName, dragonName, dragonType, out player2);
            savePlayer2.Enabled = false;

            //check if both players have saved before game starts 
            if (!savePlayer1.Enabled && !savePlayer2.Enabled)
            {
                startGame.Enabled = true;
            }
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            Form2 gameForm = new Form2(player1, player2);
            gameForm.Show();
            string dragonType1 = dragonBox.Text;
            string dragonType2 = dragonBox2.Text;
            this.Hide();
        }

        private void player1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void player2Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dragon2Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void CollectedData(string playerName, string dragonName, string dragonType, out Player player)
        {
            int HP = 20, ATK = 1, SpATK = 3, BLK = 1;

            switch (dragonType)
            {
                case iceDName:
                    HP = iceDHp;
                    ATK = iceDAttack;
                    SpATK = iceDSAttack;
                    BLK = iceDBLK;
                    break;

                case fireDName:
                    HP = fireDHp;
                    ATK = fireDAttack;
                    SpATK = fireDSAttack;
                    BLK = fireDBLK;
                    break;

                case earthDName:
                    HP = earthDHp;
                    ATK = earthDAttack;
                    SpATK = earthDSAttack;
                    BLK = earthDBLK;
                    break;

                case windDName:
                    HP = windDHp;
                    ATK = windDAttack;
                    SpATK = windDSAttack;
                    BLK = windDBLK;
                    break;
            }
            player = new Player(playerName, dragonName, dragonType, HP, ATK, SpATK, BLK);

        }




    }
}
