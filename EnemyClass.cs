using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamStory
{
    public class EnemyClass
    {

        public List<enemyStats> enemyType = new List<enemyStats>();
        public void addEnemy()
        {
            
            enemyType.Add(new enemyStats { Name = "SKELETON", Health = 10, Dmg = 29, Armor = 5,Ability = "HEAL", Id = 0 });
            enemyType.Add(new enemyStats { Name = "BANDIT", Health = 25, Dmg = 36, Armor = 2, Ability = "HIDE", Id = 1 });
            enemyType.Add(new enemyStats { Name = "SPIDER", Health = 20, Dmg = 31, Armor = 2, Ability = "POISON", Id = 2 });
         
            enemyType.Add(new enemyStats { Name = "SIMI-GOD", Health = 1000, Dmg = 8, Armor = 1, Ability = "HEAL", Id = 3 });
            enemyType.Add(new enemyStats { Name = "MASTER-THIEF", Health = 220, Dmg = 14, Armor = 1, Ability = "HIDE", Id = 4 });
           enemyType.Add(new enemyStats { Name = "MINI-TOXIC-LIZARD", Health = 1000, Dmg = 0, Armor = 1, Ability = "POISON", Id = 5 });
            
            foreach (enemyStats stats in enemyType)
            {
                Random rdm = new Random();
                int idnum = rdm.Next(1, enemyType.Count);
                if (stats.Id == idnum)
                {
                    Fight.enemyName = stats.Name;
                    Fight.enemyHealth = stats.Health;
                    Fight.enemyDmg = stats.Dmg;
                    Fight.enemyArmor = stats.Armor;
                    Fight.enemyAbility = stats.Ability;
                    Fight.enemyMaxHealth = stats.Health;

                }
            }
            }
        }
    }


