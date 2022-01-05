using System;

namespace HelloWorld
{
    public class Battle : IBattle
    {
        public Saiyan Attacker { get; set; }
        public Saiyan Defender { get; set; }
        
        public Battle(Saiyan attacker, Saiyan defender)
        {
            Attacker = attacker;
            Defender = defender;
        }
        public void BattleForTheAges()
        {
            bool hasBattleStarted = true;
            int attackerPower = Attacker.PowerLevel;

            //this won't work because this method is implicitly public and static
            //static methods cannot be used outside of their declared class
            //TestMethod();
            while(hasBattleStarted)
            {
                Console.WriteLine(Attacker.Attack());
                Console.WriteLine(Defender.Defend(attackerPower));

                int defenderPower = Defender.DefenseLevel;
                if(defenderPower <= 0){
                    Console.WriteLine(Attacker.Name + " wins! What a powerful attack!");
                }else{
                    Console.WriteLine(Defender.Name + " wins! Defense for the win!");
                }

                hasBattleStarted = false;
            }
        }
    }
}