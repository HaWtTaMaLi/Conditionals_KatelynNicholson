using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    enum WeaponType
    {
        fist,
        pistol,
        rocketlauncher,
        sniperRifle
    }
    internal class Program
    {
        static int weapon = 2;
        static int enemyHealth = 100;
        static WeaponType weapon = WeaponType ;        
        static int berries = 50;
        static int twigs = 40;
        static int rocks = 30;

        static void Main()
        {
            string 

            //switch statment
            switch(weapon)
            {
                case WeaponType.fist:
                    //Fist 
                    DealDamageToEnemy(20);
                    break;
                case WeaponType.pistol:
                    // Pistol 
                    DealDamageToEnemy(100);
                    break;
                case WeaponType.rocketlauncher:
                    //Rocket 
                    DealDamageToEnemy(100);
                    break;
                case WeaponType.sniperRifle:
                    //Sniper 
                    DealDamageToEnemy(50);
                    break;
                defult:
                    Console.Write("weapon was not valid");

            }
        }

        static void DealDamageToEnemy(int amount)
        {
            Console.WriteLine($"Enemy health was {enemyHealth}. They took {amount} damage."); // with $ you need {}
            enemyHealth -= amount;
            Console.WriteLine($"Enemy health is now {enemyHealth}.");
        }
    }
}
