using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = new Fighter[2];


            string name = "";

            int damageDone;

            int currentDmg;

            bool mustGoON = true;

            //First guys name
            Console.WriteLine("Hey, welcome to this fight!");
            Console.WriteLine("What is the first fighters name?");
            name = Console.ReadLine();
            Console.WriteLine("Allright his name is " + name + "!");

            fighters[0] = new Fighter();

            fighters[0].name = name;

            //Second guys name
            Console.WriteLine("What is the second fighters name?");
            name = Console.ReadLine();
            Console.WriteLine("Allright his name is " + name + "!");

            fighters[1] = new Fighter();

            fighters[1].name = name;


            while (mustGoON == true)
            {
                for (int i = 0; i < fighters.Length; i++)
                {
                    if (fighters[i].isAlive() == false)
                    {
                        mustGoON = false;
                    }
                }

                
                for (int i = 0; i < fighters.Length; i++)
                {
                    damageDone = fighters[i].Attack();
                    Console.WriteLine(fighters[i].name + " did " + damageDone + " amount of damage!");
                    
                    fighters[i + 1].Hurt(damageDone);
                    currentDmg = fighters[i + 1].GetHP();
                    Console.WriteLine(fighters[i+1] + " now has " + currentDmg + " hp!");

                    Console.ReadLine();
                }

            }

            for (int i = 0; i< fighters.Length; i++)
            {



            }

            
            





            Console.ReadLine();
        }
    }
}
