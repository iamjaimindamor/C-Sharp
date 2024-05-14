using System;
using System.Runtime.CompilerServices;

namespace Duel
{
    class Program
    {
        public static string Player1 { get; set; }
        public static string Player2 { get; set; }
        public static int P1_Attk { get; set; }
        public static int P2_Attk { get; set; }
        public static int P1_Blk { get; set; }
        public static int P2_Blk { get; set; }
        public static int P1_Health { get; set; }
        public static int P2_Health { get; set; }
        public static int P1_mgic { get; set; }
        public static int P2_mgic { get; set; }
        public static bool P1_bool { get; set; }
        public static bool P2_bool { get; set; }

        static void Main(string[] args)
        {
            string consult = "no";
            do
            {
                Console.WriteLine("                 WELCOME TO ARENA                     ");
                Console.WriteLine("************************************************************");

                Console.WriteLine("Want a Battle With Magic Or Non-Magic ?");
                string pref = Console.ReadLine();

                if (pref == "yes")
                {
                    Console.WriteLine("Enter Player 1 Details");
                    Console.Write("Enter Player 1 Name : ");
                    string name = Console.ReadLine();
                    Player1 = name;

                    Console.Write($"{name}'s Maximum Health (HP) (99-200 HP) : ");
                    int hp = int.Parse(Console.ReadLine());
                    P1_Health = hp;

                    Console.Write($"{name}'s Max Attack Damage Capability (Min 49)(Max 99)) : ");
                    int maxDMG = int.Parse(Console.ReadLine());
                    P1_Attk = maxDMG;

                    Console.Write($"{name}'s Max BLock Damage Capability (Min 35) (Max 86) : ");
                    int maxB = int.Parse(Console.ReadLine());
                    P1_Blk = maxB;

                    Console.Write("Does Your Player have Teleportation Powers ? ");
                    string power = Console.ReadLine();
                    P1_bool = true;
                    Console.Write("Enter Teleportation Capability (40-80 Preferred Range) : ");
                    int mgk = int.Parse(Console.ReadLine());
                    P1_mgic = mgk;

                    Console.WriteLine();
                    Console.WriteLine("******************************************************************");
                    Console.WriteLine("Enter Player 2 Details");
                    Console.Write("Enter Player 2 Name : ");
                    string name2 = Console.ReadLine();
                    Player2 = name2;

                    Console.Write($"{name2}'s Maximum Health (HP) (99-200 HP) : ");
                    int hp2 = int.Parse(Console.ReadLine());
                    P2_Health = hp2;

                    Console.Write($"{name2}'s Max Attack Damage Capability(Min 49)(Max 99) : ");
                    int maxDMG1 = int.Parse(Console.ReadLine());
                    P2_Attk = maxDMG1;

                    Console.Write($"{name2}'s Max BLock Damage Capability (Min 35 )(Max 86): ");
                    int maxB1 = int.Parse(Console.ReadLine());
                    P2_Blk = maxB1;

                    Console.Write("Does Your Player have Teleportation Powers ? ");
                    string pow1 = Console.ReadLine();
                    P2_bool = true;

                    Console.Write("Enter Teleportation Capability (40-80 Preferred Range) : ");
                    int mgk2 = int.Parse(Console.ReadLine());
                    P2_mgic = mgk2;

                    specialWarrior war1 = new specialWarrior(Player1, P1_Health, P1_Attk, P1_Blk, P1_bool, P1_mgic);
                    specialWarrior war2 = new specialWarrior(Player2, P2_Health, P2_Attk, P2_Blk, P2_bool, P2_mgic);
                    Battle.StartBattle(war1, war2);
                }
                else
                {
                    Console.WriteLine("Enter Player 1 Details");
                    Console.Write("Enter Player 1 Name : ");
                    string name = Console.ReadLine();
                    Player1 = name;

                    Console.Write($"{name}'s Maximum Health (HP) (99-200 HP) : ");
                    int hp = int.Parse(Console.ReadLine());
                    P1_Health = hp;

                    Console.Write($"{name}'s Max Attack Damage Capability (Min 49)(Max 99)) : ");
                    int maxDMG = int.Parse(Console.ReadLine());
                    P1_Attk = maxDMG;

                    Console.Write($"{name}'s Max BLock Damage Capability (Min 35) (Max 86) : ");
                    int maxB = int.Parse(Console.ReadLine());
                    P1_Blk = maxB;

                    Console.WriteLine();
                    Console.WriteLine("******************************************************************");
                    Console.WriteLine("Enter Player 2 Details");
                    Console.Write("Enter Player 2 Name : ");
                    string name2 = Console.ReadLine();
                    Player2 = name2;

                    Console.Write($"{name2}'s Maximum Health (HP) (99-200 HP) : ");
                    int hp2 = int.Parse(Console.ReadLine());
                    P2_Health = hp2;

                    Console.Write($"{name2}'s Max Attack Damage Capability(Min 49)(Max 99) : ");
                    int maxDMG1 = int.Parse(Console.ReadLine());
                    P2_Attk = maxDMG1;

                    Console.Write($"{name2}'s Max BLock Damage Capability (Min 35 )(Max 86): ");
                    int maxB1 = int.Parse(Console.ReadLine());
                    P2_Blk = maxB1;

                    warrior war1 = new warrior(Player1, P1_Health, P1_Attk, P1_Blk);
                    warrior war2 = new warrior(Player2, P2_Health, P2_Attk, P2_Blk);
                    Battle.StartBattle(war1, war2);
                }
            Battle1:
                if (pref == "no")
                {
                    warrior warA = new warrior(Player1, P1_Health, P1_Attk, P1_Blk);
                    warrior warB = new warrior(Player2, P2_Health, P2_Attk, P2_Blk);
                    Battle.StartBattle(warA, warB);
                }
                else
                {
                    specialWarrior warX = new specialWarrior(Player1, P1_Health, P1_Attk, P1_Blk, P1_bool, P1_mgic);
                    specialWarrior warY = new specialWarrior(Player2, P2_Health, P2_Attk, P2_Blk, P2_bool, P2_mgic);
                    Battle.StartBattle(warX, warY);
                }
                Console.WriteLine("Want To Fight Again ?");
                consult = Console.ReadLine();
                if (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase))
                {
                    Battle.isGameOver = false;
                    goto Battle1;
                }
            }
            while (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase));

        } 

    } 
}
    















//=======================TEST++++++++++++++++++++++++===================================================
//warrior war1 = new warrior("Jett", 150, 60, 40);
//warrior war2 = new warrior("Sova", 150, 60, 40);
//specialWarrior war1 = new specialWarrior("Jett", 150, 55, 35, true, 60);
//specialWarrior war2 = new specialWarrior("Sova", 150, 55, 35, true, 60);
//=======================================================================================================











































































































//ROUGH WORK_-----------------------------------------------------------------------------------------------------------------------


            //bool checkPower1 = false, checkPower2 = false;
            //int mgk = 0, mgk2 = 0;





/*
 * 
                if ((checkPower1 && checkPower2) == false)
                {

                    warrior war1 = new warrior(Player1, P1_Health, P1_Attk, P1_Blk);
                    warrior war2 = new warrior(Player2, P2_Health, P2_Attk, P2_Blk);
                    Battle.StartBattle(war1, war2);
                }
                

               if (checkPower1 == true)
                {
                    specialWarrior war1 = new specialWarrior(Player1, P1_Health, P1_Attk, P1_Blk, P1_bool, P1_mgic);
                    warrior war2 = new warrior(Player2, P2_Health, P2_Attk, P2_Blk);
                    Battle.StartBattle(war1, war2);
                }

               if(checkPower2 == true)
                {
                    warrior war1 = new warrior(Player1, P1_Health, P1_Attk, P1_Blk);
                    specialWarrior war2 = new specialWarrior(Player2, P2_Health, P2_Attk, P2_Blk, P2_bool, P2_mgic);
                    Battle.StartBattle(war1, war2);
                }
                
                if(checkPower1 && checkPower2 == true)
                {
                    specialWarrior war1 = new specialWarrior(Player1, P1_Health, P1_Attk, P1_Blk, P1_bool, P1_mgic);
                    specialWarrior war2 = new specialWarrior(Player2, P2_Health, P2_Attk, P2_Blk, P2_bool, P2_mgic);
                    Battle.StartBattle(war1, war2);

                }

 */























/*    bool detailsCollected = false;

                while (!detailsCollected)
                {
                    if (String.Equals(power, "yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Enter Magic Capability (45-65 Preferred Range) ");
                        int mg = int.Parse(Console.ReadLine());
                        specialWarrior war1 = new specialWarrior(name, hp, maxDMG, maxB, true, mg);
                    }
                    else
                    {
                        warrior war1 = new warrior(name, hp, maxDMG, maxB);
                    }
                    if (String.Equals(pow1, "yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Enter Magic Capability (45-65 Preferred Range) ");
                        int mg = int.Parse(Console.ReadLine());
                        specialWarrior war2 = new specialWarrior(name2,hp2,maxDMG1,maxB1,true, mg);
                    }
                    else
                    {
                        warrior war2 = new warrior(name2, hp2, maxDMG1, maxB1);
                    }
                    detailsCollected = true;

                   
                }

*/

/*
 *     if (power == "no")
                {
                    if (pow1 == "no")
                    {
                        warrior war1 = new warrior(Player1, P1_Health, P1_Attk, P1_Blk);
                        warrior war2 = new warrior(Player2, P2_Health, P2_Attk, P2_Blk);

                    sameBattlen:

                        Battle.StartBattle(war1, war2);
                        Console.WriteLine("Want to fight again?");
                        consult = Console.ReadLine();
                        if (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase))
                        {
                            Battle.isGameOver = false;
                            goto sameBattlen;
                        }
                    }
                    else if (pow1 == "yes")
                    {
                        warrior war1 = new warrior(name, hp, maxDMG, maxB);
                        specialWarrior war2 = new specialWarrior(name2, hp2, maxDMG1, maxB1, true, mgk);

                    sameBattlen:
                        Battle.StartBattle(war1, war2);
                        Console.WriteLine("Want to fight again?");
                        consult = Console.ReadLine();
                        if (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase))
                        {
                            Battle.isGameOver = false;
                            goto sameBattlen;
                        }
                    }
                }
                else if (power == "yes")
                {
                    if (pow1 == "no")
                    {
                        specialWarrior war1 = new specialWarrior(name, hp, maxDMG, maxB, true, mgk);
                        warrior war2 = new warrior(name2, hp2, maxDMG1, maxB1);

                    sameBattlen:
                        Battle.StartBattle(war1, war2);
                        Console.WriteLine("Want to fight again?");
                        consult = Console.ReadLine();
                        if (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase))
                        {
                            Battle.isGameOver = false;
                            goto sameBattlen;
                        }
                        Battle.StartBattle(war1, war2);
                    }
                    else if (pow1 == "yes")
                    {

                        specialWarrior war1 = new specialWarrior(name, hp, maxDMG, maxB, true, mgk);
                        specialWarrior war2 = new specialWarrior(name2, hp2, maxDMG1, maxB1, true, mgk);

                    sameBattlen:
                        Battle.StartBattle(war1, war2);
                        Console.WriteLine("Want to fight again?");
                        consult = Console.ReadLine();
                        if (String.Equals(consult, "yes", StringComparison.OrdinalIgnoreCase))
                        {
                            Battle.isGameOver = false;
                            goto sameBattlen;
                        }
                    }
 * */