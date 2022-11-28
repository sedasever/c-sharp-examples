using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace zombie
{
    public class Characters
    {
        public string Name { get; set; }
        public int CharNum { get; set; }
        public int Health { get; set; }
        public int HitPower { get; set; }
        public int Accuracy { get; set; }
        public Characters()
        {

        }
        public Characters(string name,int charNum,int health,int hitPower,int accuracy)
        {
            Name = name;
            CharNum=charNum;
            Health=health;
            HitPower=hitPower;
            Accuracy=accuracy;
        }
        public void Damage(int damage,int accuracy)
        {
            Random random = new Random();
            int iskaRandom = random.Next(100);
            if (iskaRandom > accuracy)
            {
                Health -= damage;
            }
        }

    }
}
