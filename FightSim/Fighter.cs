using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {

        int hp = 100;
        public string name;
        int dmg;



        public int Attack()
        {
            dmg = 50;
            return dmg;
        }


        public void Hurt (int amount)
        {
            hp -= amount;
            
        }

        public bool isAlive()
        {
            if(hp < 0)
            {
                return false;
            }

            return true;
        }


        public int GetHP()
        {

            return hp;

        }



    }
}
