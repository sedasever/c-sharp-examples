using System.Threading.Tasks;
using System;

namespace zombie
{
    public partial class Form1 : Form
    {
        Characters myHero = new Characters();
        Characters pcHero = new Characters();
        Characters tier=new Characters("Tier", 1, 870, 130, 17);
        Characters robokill=new Characters("Robokill", 2, 950, 200, 15);
        Characters chimera=new Characters("Chimera", 3, 750, 180, 8);
        Characters hunter=new Characters("Hunter", 4, 900, 220, 19);
        public int MyHeroChoose()
        {
            int charNum;
            return 0;
            if (charNum==1)
            {
                radioButtonTier.Checked = true;
                tier.Damage(870, 17);
                return tier.Health - pcHero.HitPower;
            }
            if (charNum==2)
            {
                radioButtonRobkill.Checked = true;
                robokill.Damage(950, 15);
                return robokill.Health - pcHero.HitPower;
            }
            if (charNum==3)
            {
                radioButtonChimera.Checked = true;
                chimera.Damage(750, 8);
                return chimera.Health - pcHero.HitPower;
            }
            if (charNum==4)
            {
                radioButtonHunter.Checked = true;
                hunter.Damage(900, 19);
                return hunter.Health - pcHero.HitPower;
            }
        }
        public void EndGame()
        {
            gameTimer.Stop();
            MessageBox.Show("Game Over!");
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void StartButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int pcHero = random.Next(1, 4);
            if (pcHero == 1)
            {
                pcHunter.Visible = true;
                pcChimera.Visible = false;
                pcTier.Visible = false;
                pcRobokill.Visible = false;
                pcTextBox.Text = "Computer Choose HUNTER!";
                pcHealthTextBox.Text = "Health: 900";
            }
            else if (pcHero == 2)
            {
                pcHunter.Visible = false;
                pcChimera.Visible = true;
                pcTier.Visible = false;
                pcRobokill.Visible = false;
                pcTextBox.Text = "Computer Choose CHIMERA!";
                pcHealthTextBox.Text = "Health: 750";
            }
            else if (pcHero == 3)
            {
                pcHunter.Visible = false;
                pcChimera.Visible = false;
                pcTier.Visible = true;
                pcRobokill.Visible = false;
                pcTextBox.Text = "Computer Choose TIER!";
                pcHealthTextBox.Text = "Health: 870";
            }
            else
            {
                pcHunter.Visible = false;
                pcChimera.Visible = false;
                pcTier.Visible = false;
                pcRobokill.Visible = true;
                pcTextBox.Text = "Computer Choose ROBOKILL!";
                pcHealthTextBox.Text = "Health: 950";
            }
        }
        private void radioButtonRobkill_CheckedChanged(object sender, EventArgs e)
        {
            yourHealthTextBox.Text = "Health: 950";
            Robokill.Visible = true;
            Tier.Visible = false;
            Hunter.Visible = false;
            Chimera.Visible = false;
        }
        private void radioButtonChimera_CheckedChanged(object sender, EventArgs e)
        {
            yourHealthTextBox.Text = "Health: 750";
            Robokill.Visible = false;
            Tier.Visible = false;
            Hunter.Visible = false;
            Chimera.Visible = true;
        }
        private void radioButtonTier_CheckedChanged(object sender, EventArgs e)
        {
            yourHealthTextBox.Text = "Health: 870";
            Robokill.Visible = false;
            Tier.Visible = true;
            Hunter.Visible = false;
            Chimera.Visible = false;
        }
        private void radioButtonHunter_CheckedChanged(object sender, EventArgs e)
        {
            yourHealthTextBox.Text = "Health: 900";
            Robokill.Visible = false;
            Tier.Visible = false;
            Hunter.Visible = true;
            Chimera.Visible = false;
        }
        public void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {   
        }
    }
}