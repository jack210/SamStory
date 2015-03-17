using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamStory
{
    class Program
    {

        public static string name;
        public static string Name { get { return name; } set { name = value; } }
        public static void Main(string[] args)
        {
            
            Console.ResetColor();
            string choise;
            bool chose = false;
            chose = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("------------");
                Console.WriteLine("| SamStory |");
                Console.WriteLine("|          |"); 
                Console.WriteLine("|   Start  |");
                Console.WriteLine("|   Load   |");
                Console.WriteLine("|   Help   |");
                Console.WriteLine("|   Quit   |");
                Console.WriteLine("------------");
                Console.ResetColor();
                choise = Console.ReadLine().ToUpper();
                if (choise == "START")
                {
                   
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Type 'Attack' to attack 'Heal' to heal and your special ability is 'Silence' type it and your enemy cant use heal attack or any ability for this round(4 rounds cd)");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("So your name is?");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Name = Console.ReadLine().ToUpper();
                    Console.ResetColor();
                    bool abilityChoosen = true;
                    do
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Choose ability:");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("SILENCE : Enemy wont be able to use hes ability and you lose 2 dmg while he loses 6 health");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("MASSHEAL : Doubles your max health capacity and u get 100% hp and 20% damage for the round you cast it");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("SOULEATER : Damage enemy for 50% of his max health and heals for that ammount of damage and enemys damage is doubled {CAN BE USED ONLY ONCE}");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.ResetColor();
                        string ChooseAbility = Console.ReadLine().ToUpper();
                        
                        if (ChooseAbility == "SILENCE") { playerStats.Ability = ChooseAbility; abilityChoosen = false; }
                        if (ChooseAbility == "MASSHEAL") { playerStats.Ability = ChooseAbility; abilityChoosen = false; }
                        if (ChooseAbility == "SOULEATER") { playerStats.Ability = ChooseAbility; abilityChoosen = false; }
                        
                    } while (abilityChoosen);
                    Fight.fightFunction();

                }
                else if (choise == "LOAD")
                {
                    Console.Clear();
                    Console.WriteLine("Loading");
                    Console.ReadLine();

                }
                else if(choise == "HELP")
                {
                    Console.Clear();
                    Console.WriteLine("While in Game type (with out the quotes)'attack' to attack 'heal' to heal  'ability' to use ability.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choise == "QUIT")
                {
                    chose = true;
                }
                else
                {
                    Console.Clear();
                    chose = false;
                }

            } while (!chose);
        }public static void Exit() { Console.ReadKey(); }
        }
    }
