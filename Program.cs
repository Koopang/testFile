namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("만들고 싶은 마름모의 크기를 정해주세요.(단, 홀수만 가능)");
            int inputnum =  int.Parse(Console.ReadLine());
            while(inputnum%2==0)
            { 
                Console.WriteLine("짝수를 입력하셨습니다. 다시 입력해주세요.");
                inputnum= int.Parse(Console.ReadLine());
            }

            int mid = inputnum / 2; // 중앙 인덱스

            // 위쪽 절반
            for (int i = 0; i <= mid; i++)
            {
                for (int j = 0; j < mid - i; j++) // 공백 출력
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++) // 별 출력
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 아래쪽 절반
            for (int i = mid - 1; i >= 0; i--)
            {
                for (int j = 0; j < mid - i; j++) // 공백 출력
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++) // 별 출력
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
