using System;
using System.Collections.Generic;


namespace TesteNavita.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaiorNumero(10000009));
        }

        static int MaiorNumero(int num)
        {
            if(num > 100000000)
            {
                return -1;
            }
           
            int[] count = new int[10];

            String str = num.ToString();

            
            for (int i = 0; i < str.Length; i++)
                count[str[i] - '0']++;

            int result = 0, multiplier = 1;

           
            for (int i = 0; i <= 9; i++)
            {
                while (count[i] > 0)
                {
                    result = result + (i * multiplier);
                    count[i]--;
                    multiplier = multiplier * 10;
                }
            }
            
            return result;
        }
    }
}
