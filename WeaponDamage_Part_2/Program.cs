using System;

namespace WeaponDamage_Part_2
{
    class Program
    {
        static Random random = new Random();


        private static int RollDice(int numberOfRolls)
        {
            int result = 0;
            for (int i = numberOfRolls; i > 0; i--)
            {
                result += random.Next(1, 7);
            }
            return result;
        }
        
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));

            while (true)
            {

                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");

                char keyChar = Console.ReadKey(false).KeyChar;

                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3') return;

                Console.Write("\nS for sword, A for arrow, anything else to quit: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);


                switch (weaponKey)
                {
                    case 'S':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (keyChar == '1' || keyChar == '3');
                        swordDamage.Flaming = (keyChar == '2' || keyChar == '3');
                        Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP");
                        break;
                    case 'A':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = (keyChar == '1' || keyChar == '3');
                        arrowDamage.Flaming = (keyChar == '2' || keyChar == '3');
                        Console.WriteLine($"\nRolled {arrowDamage.Roll} for {arrowDamage.Damage} HP");
                        break;
                    default:
                        return;
                }


            }
        }
    }
}
