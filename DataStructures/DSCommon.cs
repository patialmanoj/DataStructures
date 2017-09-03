using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public static class DSCommon
    {
        public static void swapTwoNumbers (){
        }
        public static Int32 getLowestEvenDigitInNumber(Int32 num) {
            Int32 digit ,lastdigit = num % 10;
            Int32 min = lastdigit;
            while (num / 10 > 0) {
                num = num / 10;
                digit = num % 10;
                if (digit < lastdigit && digit % 2 == 0) {
                    min = digit;
                }
                
            }
            return min;
        }
    }
}
