using System;

namespace Duel
{
     class specialWarrior : warrior
    {
        public bool Magic { get; set; }
        public int magicChance { get; set; }
        public int magicConcur { get; set; }
        public static bool isTeleport {  get; set; }

        Random rd = new Random();
        public specialWarrior(string Spname, int Sphealth, int SpMAXattckDMG, int SpMAXblckDMG ,bool Spmgk , int Spmgkchance) : base(Spname, Sphealth, SpMAXattckDMG, SpMAXblckDMG)
        {
            Name  = Spname;
            Health = Sphealth;
            attack = SpMAXattckDMG;
            block = SpMAXblckDMG;
            Magic = Spmgk;
            magicConcur = Spmgkchance;
        }
        public override int Block()
        {
            isTeleport = false;

            if (Magic == true)
            {
                int magicChance = rd.Next((magicConcur) % 40, (magicConcur) % 69);

                if (magicChance >= 40)
                {
                    isTeleport = true;
                    Console.WriteLine("Teleport SuccessFul");
                    Console.WriteLine("+++++++++++++++++++++++++");
                    magicConcur -= (magicConcur % 4);
                    return 100000;
                }
                else
                {
                    isTeleport = false;
                    Console.WriteLine("Teleportation Failed X");
                    Console.WriteLine("--------------------------");
                    return base.Block();
                }
            }
            else
            {
                Console.WriteLine("Magic Ability Not Available");

                return base.Block();

            }
        }

     }
}
