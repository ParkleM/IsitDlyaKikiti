using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proga1ISIT;
using ПРОГААДЫНИСИТ;

namespace proga1ISIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[,] Matrix = new int[n, n];

            //Random random = new Random();
            //int rand;
            //        for (int i = 0; i < n; i++)
            //         {
            //             for (int j = 0; j < n; j++)
            //             {
            //                 rand = random.Next(0, 100);
            //                 Matrix[i, j] = rand;
            //             }
            //        }
            
              for (int str = 0; str < n; str++)
            {
                for(int stolb = 0; stolb < n; stolb++)
                {
                    int vvodInt = Convert.ToInt32(Console.ReadLine());
                    Matrix[str, stolb] = vvodInt;
                }
            }          

            int otvet = 0;
        
            for (int str = 0; str < n; str++)
            {
                int[] stroka = new int[n];
                for (int stolb = 0; stolb < n; stolb++)
                {
                    stroka[stolb] = Matrix[str, stolb];
                }
                
                if(Solution.resh(stroka) == true)
                {
                    otvet++;
                }
            }

            Console.Write(otvet);
        }
    }
}
