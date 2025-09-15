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
        asultRifle,
        sniperRifle,
        rocketLauncher,
    }
    internal class Program
    {
        static int playerHealth 100;
        static int enemyHealth = 100;
        static WeaponType weapon = WeaponType.fist;     

        static void Main()
        {
            
            //switch statment
            switch(weapon)
            {
                case WeaponType.fist: 
                    DealDamageToEnemy(20);       //Hurt
                    break;
                case WeaponType.pistol: 
                    DealDamageToEnemy(50);       //Badly Hurt
                    break;
                case WeaponType.asultRifle:
                    DealDamageToEnemy(60);       //Severly Hurt
                    break;
                case WeaponType.sniperRifle:
                    DealDamageToEnemy(80);       //Imminent Danger
                    break;
                case WeaponType.rocketLauncher:
                    DealDamageToEnemy(100);      //Dead
                    break;
            }


            //Lines of Combat

        }

        static void DealDamageToEnemy(int amount)
        {
            Console.WriteLine($"Enemy health was {enemyHealth}. They took {amount} damage."); // with $ you need {}
            enemyHealth -= amount;
            Console.WriteLine($"Enemy health is now {enemyHealth}.");

        }

        static void DealDamageToPlayer(int amount)
        {
            playerHealth -= amount;

            if (playerHealth < 81)
            {
                Console.WriteLine("You are Hurt");
            }
            else if (playerHealth < 51)
            {
                Console.WriteLine("You are Badly Hurt");
            }
            else if (playerHealth < 41)
            {
                Console.WriteLine("You are Severly Hurt");
            }
            else if (playerHealth < 21)
            {
                Console.WriteLine("You are in Imminent Danger");
            }
            else if (playerHealth = 0)
            {
                Console.WriteLine("You are Dead");
            }
            else if (playerHealth = 100)
            {
                Console.WriteLine("You are Alive");
            }
        }

        static void HUD()
        {
            //HUD//
            Console.WriteLine("|Player  |");
            Console.WriteLine($"Health:{playerHealth}");
            
            //display player name           //display enemy name
            //display player health         //display enemy health
        }
    }
}
