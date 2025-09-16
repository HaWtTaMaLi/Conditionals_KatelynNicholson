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
        static int playerHealth = 100;
        static int enemyHealth = 100;
        static WeaponType weapon = WeaponType.fist;     

        static void Main()
        {
            
            //Lines of Combat
            Console.WriteLine("An enemy appears!");
            Console.ReadKey();
            Console.WriteLine("You ready your weapon");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"You strike the enemy with your {weapon}!");
            Console.ReadKey();
            Console.WriteLine("You miss and hit your own foot!");
            DealDamageToPlayer(20);
            Console.ReadKey();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You ready your weapon and strike the enemy again");
            DealDamageToEnemy(20);
            Console.ReadKey();
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("enemy attack u ");

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
        }

        static void DealDamageToEnemy(int amount)
        {
            Console.Clear();
            Console.WriteLine($"Enemy health was {enemyHealth}. They took {amount} damage.");
            enemyHealth -= amount;
            HUD();
            Console.ReadKey();
            Console.Clear();
        }

        static void DealDamageToPlayer(int amount)
        {
            Console.Clear();
            Console.WriteLine($"Your health was {playerHealth}. You took {amount} damage.");
            playerHealth -= amount;
            HUD();
            Console.ReadKey(); 
            Console.Clear();

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
            else if (playerHealth <= 0)
            {
                Console.WriteLine("You are Dead");
            }
            else if (playerHealth <= 100)
            {
                Console.WriteLine("You are Alive");
            }
        }

        static void HUD()
        {
            //HUD//
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~HUD~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Player Health:{playerHealth,3}   |   Enemy Health:{enemyHealth,3}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}
