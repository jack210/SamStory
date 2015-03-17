using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamStory
{
    class playerStats
    {
        
        static playerStats statUp = new playerStats();
        public  int health = 20;
        public static int maxHealth = 20;
        public static int dmg = 12;
        public static int armor = statUp.health / 5;
        public static string Ability = "";

      
    }
}
