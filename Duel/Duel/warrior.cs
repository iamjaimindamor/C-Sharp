using System;
using System.Runtime.InteropServices;

namespace Duel { 
     class warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int attack {  get; set; }
        public int block { get; set; }
        public warrior(string name,
            int health ,
            int MAXattckDMG,
            int MAXblckDMG)
        { 
            Name = name;
            Health = health;
            attack = MAXattckDMG;
            block = MAXblckDMG;
        }
        Random rd1 = new Random();   
        public int Attack()
        {
            int atkDMG = rd1.Next(1,attack);

            return atkDMG;
        }
        public virtual int Block()
        {
           int blkDMG = rd1.Next(1,block);

            return blkDMG;
         }
     }
}
