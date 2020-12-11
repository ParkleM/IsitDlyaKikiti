using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРОГААДЫНИСИТ
{
   public class Solution
    {
        public static Boolean resh(int[] stroka)
        {
            int predZn = stroka[1] - stroka[0];
            for(int i = 2; i < stroka.Length; i++)
            {
                if (stroka[i] - stroka[i-1] == predZn)
                {
                    if (i == stroka.Length -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
