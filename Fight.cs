using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamStory
{
    class Fight
    {
        //enemyStats
        public static string enemyName = "";
        public static int enemyHealth = 2;
        public static int enemyDmg = 1;
        public static int enemyArmor = 1;
        public static string enemyAbility = "HEALING";
        public static int enemyMaxHealth = 2;
        static playerStats playerhealth = new playerStats();

        public static void fightFunction()
        {
            Console.Clear();

            Random rdm = new Random();
            EnemyClass enemy = new EnemyClass();
            
            int health = playerhealth.health;
            int dmg = playerStats.dmg;
            int armor = playerStats.armor;
            int enemyChoise;
           // other
            bool fight = true;
            // playerStats
            string playerChoise;
            bool notSilenced = true;
            int enemyLowState;
            int enemyAbilityCD = 0;//3
            int abilityCD = 0;//4
            bool enemyToPlay ;
            bool playerPoisoned = false;
            int playerPosionRound = 0;
            bool enemyHiden = false ;
            int enemyHidenRound = 0;
            bool souleaten = false;
            int enemyHealthDev = 0;
            bool HealthStack = false;
            bool enemyHealthStack = false;
            dmg = health / 4;
            enemyLowState = enemyHealth / 2;
           // Player health
            if (playerStats.dmg < enemyArmor) { fightFunction(); }
            enemy.addEnemy();
            do
            {
                if (enemyHealth > 100) 
                {
                    enemyHealthDev = enemyHealth / 100;
                    enemyHealthStack = true;
                }
                dmg = 10 +  health / 4;
                if (enemyAbilityCD > 0 && souleaten) { enemyAbilityCD = 0; souleaten = false; }
                if (abilityCD != 0) { abilityCD--; }
                if(enemyAbilityCD != 0){enemyAbilityCD--;}
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------{0}----------", Program.Name);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Health : "); for (int i = 0; i < health; i++) { Console.Write("|"); } Console.ForegroundColor = ConsoleColor.Gray; for (int i = 0; i < playerStats.maxHealth - health; i++) { Console.Write("|"); } if (playerPoisoned) { Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write("POISONED: {0} rounds", playerPosionRound); }
                Console.ResetColor();
                //     1 line between health and dmg
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Damage : " + dmg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Armor : " + armor);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ability : {0}", playerStats.Ability);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Buff : {0}", null);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("DeBuff : {0}", null);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------{0}----------", enemyName);
                Console.ResetColor();
                if (!enemyHiden)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("Enemy Health : "); for (int i = 0; i < enemyHealth; i++) { Console.Write("|"); } Console.ForegroundColor = ConsoleColor.Gray; for (int z = 0; z < enemyMaxHealth - enemyHealth; z++) { Console.Write("|"); } if (enemyHealthDev > 1) { Console.Write("x{0}", enemyHealthDev); }
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enemy Damage : " + enemyDmg);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enemy Armor : " + enemyArmor);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ability : {0}", enemyAbility);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Buff : {0}", null);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("DeBuff : {0}", null);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
                
                    Console.WriteLine("---------------------------------------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    playerChoise = Console.ReadLine().ToUpper();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("---------------------------------------------------");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                
                // player

                    
                        if (enemyHidenRound == 0) { enemyHiden = false; }
                        if (enemyHiden) { Console.WriteLine("Enemy is HIDEN"); }
                        if (!enemyHiden)
                        {
                            if (playerChoise == "ATTACK") { enemyHealth -= rdm.Next(dmg / 2, dmg) / enemyArmor; }
                            else if (playerChoise == "HEAL") { health += rdm.Next(health / 2, health / 2 + 5); }
                            else if (playerChoise == "ABILITY" && abilityCD == 0)
                            {
                               
                                if (playerStats.Ability == "SILENCE")
                                {

                                    dmg -= 2;
                                    enemyHealth -= enemyHealth/2;
                                    enemyMaxHealth -= enemyHealth/2;
                                    enemyAbilityCD = 9999;
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Enemy cant use ability you lose 2 dmg[AMOUNT] and he loses 50% health and max health [CAPACITY]");
                                    Console.ResetColor();

                                } if (playerStats.Ability == "MASSHEAL")
                                {
                                    dmg += dmg / 5;
                                    playerStats.maxHealth *= 2;
                                    health = playerStats.maxHealth;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Your health gose full, your max health capacity is doubled and  you get 20% dmg ");
                                    Console.ResetColor();
                                   
                                }
                                if (playerStats.Ability == "SOULEATER")
                                {
                                    souleaten = true;
                                    enemyDmg *= 2;
                                    health += enemyMaxHealth / 4;
                                    enemyHealth -= enemyMaxHealth / 2;
                                    abilityCD = 9999;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Enemy's armor is reduced by 50% and he takes a damage equal to enemys + players damage ");
                                    Console.ResetColor();
                                    
                                }
                            }
                            else { notSilenced = false; }
                            if (health > playerStats.maxHealth) { health = playerStats.maxHealth; }
                        }
                    
                //enemy

                if (notSilenced)
                {
                    if (enemyHiden) { enemyHidenRound--; }
                    enemyToPlay = true;

                    if (playerPosionRound == 0) { playerPoisoned = false; }
                    if (playerPoisoned && playerPosionRound != 0)
                    {
                        health -= rdm.Next(1, 2);
                        playerPosionRound--;
                    } 


                    do
                    {
                        enemyChoise = rdm.Next(0, 4);
                        if (enemyDmg <= 0) { enemyChoise = 4; }
                        if ( enemyChoise == 1 || enemyChoise == 2) { enemyToPlay = false; health -= rdm.Next(enemyDmg / 2, enemyDmg) / armor; if (!enemyHiden) { Console.WriteLine("Enemy Attacked you"); } }
                       else if (enemyChoise == 3) { enemyToPlay = false; enemyHealth += rdm.Next(1, 3); if (!enemyHiden) { Console.WriteLine("Enemy Self-Healed"); } }
                        else  if (enemyDmg == 0 || enemyChoise == 4 && enemyAbilityCD == 0)
                        {
                            
                            Console.WriteLine("Enemy USED ABILITY");
                            enemyToPlay = false;

                            if (enemyAbility == "HEAL")
                            {
                                enemyAbilityCD = 3;
                                enemyHealth += rdm.Next(2, 4);
                                Console.WriteLine("Enemy used ability: HEALING , On him self."); 
                            }
                            else if (enemyAbility == "POISON")
                            {
                                enemyAbilityCD = 3;
                                playerPoisoned = true;
                                playerPosionRound = rdm.Next(1, 2);
                                Console.WriteLine("Enemy used ability: POSION , On you.You are POISONED for {0} rounds", playerPosionRound); 
                            }
                            else if (enemyAbility == "HIDE")
                            {
                                enemyAbilityCD = 3;
                                enemyHiden = true;
                                playerPosionRound = rdm.Next(1, 2);
                                Console.WriteLine("Enemy Hide Himself", playerPosionRound);
                            }
                            else 
                            {
                                enemyToPlay = true;
                            }
                           if(enemyDmg == 0){enemyAbilityCD = 0;}

                            
                        }
                       
                    } while (enemyToPlay);

                }
                //  Other stats about the game
                Console.ResetColor();
                if (enemyHealth > enemyMaxHealth) { enemyHealth = enemyMaxHealth; }
                Console.ReadKey();
                Console.Clear();
                if (health <= 0 && enemyHealth <= 0) { Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("You both Died"); fight = false; Console.ReadKey(); }
                else if (health <= 0) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You Died"); fight = false; }
                else if (enemyHealth <= 0) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You Won"); fight = false; }


                notSilenced = true;

            } while (fight);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press any key");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}