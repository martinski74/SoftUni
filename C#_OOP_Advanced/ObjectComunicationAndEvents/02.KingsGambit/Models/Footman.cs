using System;

namespace _02.KingsGambit
{
    public class Footman:Soldier
    {
        public Footman(string name) : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
