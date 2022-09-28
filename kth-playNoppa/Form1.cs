namespace kth_playNoppa
{
    public partial class Form1 : Form
    {
        //Random num
        private Random rng = new Random();
        List<Dice> Dices = new List<Dice>();
        int buttonPress = 0;
        public Form1()
        {
            InitializeComponent();
            //tyhjät nopat
            Dices.Add(new Dice());
            Dices.Add(new Dice());
        }
        //Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            //remove ptcBox -later
            picBoxWinner.Image = null;
            picBoxP1.Image = null;
            picBoxP2.Image = null;
            //btn unlock
            btnP1.Enabled = true;
            btnP2.Enabled = true;
            //Check btns reset
            buttonPress = 0;
        }

        //Player 1
        private void btnP1_Click(object sender, EventArgs e)
        {
            //btn lock
            btnP1.Enabled = false;
            //Rnd num
            Dices[0].Roll(rng);
            //picBox
            string key1 = $"N{Dices[0].Value}";
            picBoxP1.Image = DicePictures.ResourceManager.GetObject(key1) as Image;
            //Check if both btns pushed
            buttonPress++;
            if (buttonPress == 2)
            {
                winner();
            }
        }
        //Player 2
        private void btnP2_Click(object sender, EventArgs e)
        {
            //btn lock
            btnP2.Enabled = false;
            //Rnd num
            Dices[1].Roll(rng);
            //picBox
            string key2 = $"N{Dices[1].Value}";
            picBoxP2.Image = DicePictures.ResourceManager.GetObject(key2) as Image;
            //Check if both btns pushed
            buttonPress++;
            if(buttonPress == 2)
            {
                winner();
            }
        }
        //Winner
        private void winner()
        {
            //Player num
            int P1 = Dices[0].Value;
            int P2 = Dices[1].Value;
            //Dicide
            if (buttonPress == 2)
            {
                if (P1 > P2)
                {
                    picBoxWinner.Image = DicePictures.P1win;
                }
                if (P1 < P2)
                {
                    picBoxWinner.Image = DicePictures.P2win;
                }
                if (P2 == P1)
                {
                    picBoxWinner.Image = DicePictures.draw;
                }
            }
        }

    }
}