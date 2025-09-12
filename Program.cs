namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("기본 공격: " + CalculateDamage(50, 25));
            Console.WriteLine("치명타 공격: " + CalculateDamage(50, 25, true));
            Console.WriteLine("보너스 공격: " + CalculateDamage(50, 25, 5));

        }

        static int  CalculateDamage(int atk, int def)
        {
            return atk - def;
        }
        static int CalculateDamage(int atk, int def, bool isCritical)
        {
            return (int)((atk-def)*1.5);
        }
        static int CalculateDamage(int atk, int def, int bonusDamage)
        {
            return atk - def + bonusDamage;
        }
    }
}
