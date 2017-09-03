using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public  class MindBogglng
    {
        // write a function which will return the largest even number on swapping only once last number with any of the digit present in number
        //public Int32 getMaxEvennumber(Int32 num) {
        //    int digit ,lastdigit= num%10;
        //    int cacheNum = num , lowest; 
        //    while (cacheNum / 10 > 0) {
        //        cacheNum = cacheNum / 10;
        //        digit = cacheNum % 10;
        //        if(digit %2 == 0 && digit < lastdigit)
        //        {
        //          lowest =   DSCommon.getLowestEvenDigitInNumber(cacheNum);

        //        }
        //    }

        //}

        public void getMaxEvenNumber(string str) {
            int len = str.Length;
            char[] arr = str.ToCharArray();
            Int32 dig, last;
            for (int i = 0; i < len; i++) {
                 dig = Convert.ToInt32(str[i]);
                 last = Convert.ToInt32(str[len - 1]);
                if (dig % 2 == 0 && dig < last) {
                    arr[i] = (char)last;
                    arr[len - 1] = (char)dig;
                    Console.WriteLine("MAX even number is " + new string(arr));
                   
                    break;
                }
            }
            Console.WriteLine("out side loop is " + str);
            Console.ReadKey();
        }

    }
}
