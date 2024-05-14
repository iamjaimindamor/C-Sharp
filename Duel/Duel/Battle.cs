using System;

namespace Duel
{     class Battle
    {   public static bool isGameOver { get; set; }    
        public static void StartBattle(warrior war1 , warrior war2)
        {    
            while (isGameOver != true)
            {
                if(GetBattleResult(war1 , war2)=="GAME OVER")
                {
                    break;
                }
                if(GetBattleResult(war2 , war1)=="GAME OVER")
                {
                    break;
                }
            }
        }
        public static string GetBattleResult(warrior warA , warrior warB)
        {
            int attackDamage = warA.Attack();
            int blockDamage = warB.Block();
           
            int SustainedDMG = attackDamage - blockDamage;
;
            if (SustainedDMG > 0)
            {
                Console.WriteLine("{0} is Attacking And {1} Defending",warA.Name,warB.Name);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("{0} has Successful Attack ",warA.Name);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();

                warB.Health -= SustainedDMG;
                Console.WriteLine($"{SustainedDMG} Damage recieved "+"by {0} "+"from {1} ",warB.Name,warA.Name);
                Console.WriteLine();
                Console.WriteLine("{0} has {1} Health ",warB.Name,warB.Health);
                Console.WriteLine();
                Console.WriteLine("--------------NEXT DUEL-------------------------------------------------");
            }else if (SustainedDMG < 0) 
            {
                Console.WriteLine("{0} Defending....", warB.Name);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Attack Deflected");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();

                if (specialWarrior.isTeleport)
                {
                    Console.Write("CAUSE : {Attack Completely Blocked Due To Teleportation} ");
                    Console.WriteLine("Health Retained. Currently {0} has {1} Health", warB.Name, warB.Health);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("CAUSE: {Able to persuade the attack sucessfully} ");
                    Console.WriteLine("Health Retained. Currently {0} has {1} Health", warB.Name, warB.Health);
                    Console.WriteLine("--------------------NEXT DUEL--------------------------------------------------------");
                    Console.WriteLine();
                }
            }
            if (warB.Health <= 0)
            {
                Console.Write("{0} Is Defeated ",warB.Name);
                Console.WriteLine("and {0}  is Victorious",warA.Name);
                Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");
                Console.WriteLine();
                isGameOver = true;
                return "GAME OVER";
            }
            else return "FIGHT AGAIN";  
        }
    }
}


























/*
         public static string GetBattleResult(specialWarrior warA, specialWarrior warB)
        {
            int attackDamage = warA.Attack();
            int blockDamage = warB.Block();

            int SustainedDMG = attackDamage - blockDamage;


            if (SustainedDMG > 0)
            {
                warB.Health -= SustainedDMG;
                Console.WriteLine($"{SustainedDMG} Damage recieved " + "by {0} " + "from {1} ", warB.Name, warA.Name);
                Console.WriteLine("{0} has {1} Health ", warB.Name, warB.Health);
            }
            else
            {
                Console.Write("{Attack Completely Blocked} ");
                Console.WriteLine("Health Retained. Currently {0} has {1} Health", warB.Name, warB.Health);


                Console.WriteLine();
            }

            if (warB.Health <= 0)
            {
                Console.Write("{0} Is Defeated ", warB.Name);
                Console.WriteLine(" and {0}  is Victorious", warA.Name);
                Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");
                Console.WriteLine();
                isGameOver = true;
                return "GAME OVER";
            }
            else return "FIGHT AGAIN";





        }*/


/*
 *         public static string GetBattleResult(warrior warA, specialWarrior warB)
        {
            int attackDamage = warA.Attack();
            int blockDamage = warB.Block();

            int SustainedDMG = attackDamage - blockDamage;


            if (SustainedDMG > 0)
            {
                warB.Health -= SustainedDMG;
                Console.WriteLine($"{SustainedDMG} Damage recieved " + "by {0} " + "from {1} ", warB.Name, warA.Name);
                Console.WriteLine("{0} has {1} Health ", warB.Name, warB.Health);
            }
            else
            {
                Console.Write("{Attack Completely Blocked} ");
                Console.WriteLine("Health Retained. Currently {0} has {1} Health", warB.Name, warB.Health);


                Console.WriteLine();
            }


            if (warB.Health <= 0)
            {
                Console.Write("{0} Is Defeated ", warB.Name);
                Console.WriteLine(" and {0}  is Victorious", warA.Name);
                Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");
                Console.WriteLine();
                isGameOver = true;
                return "GAME OVER";
            }
            else return "FIGHT AGAIN";




        }
 */