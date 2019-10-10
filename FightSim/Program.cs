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
                    if (mustGoON == true)
                    {
                        if (fighters[i].isAlive() == false)
                        {
                            mustGoON = false;
                        }
                    }
                    
                }

                if (mustGoON == true)
                {
                    damageDone = fighters[0].Attack();
                    Console.WriteLine(fighters[0].name + " did " + damageDone + " amount of damage!");

                    fighters[1].Hurt(damageDone);
                    currentDmg = fighters[1].GetHP();
                    Console.WriteLine(fighters[1].name + " now has " + currentDmg + " hp!");

                    Console.ReadLine();

                    if (fighters[1].isAlive() == true)
                    {
                        damageDone = fighters[1].Attack();
                        Console.WriteLine(fighters[1].name + " did " + damageDone + " amount of damage!");
                        fighters[0].Hurt(damageDone);


                        currentDmg = fighters[0].GetHP();
                        Console.WriteLine(fighters[0].name + " now has " + currentDmg + " hp!");

                        Console.ReadLine();
                    }

                }
            }

            for (int i = 0; i< fighters.Length; i++)
            {
                if (fighters[i].isAlive() == true)
                {
                    Console.WriteLine("Congratulations " + fighters[i].name + "! You Won!");
                }


            }

            
            





            Console.ReadLine();
        }
    }
}
