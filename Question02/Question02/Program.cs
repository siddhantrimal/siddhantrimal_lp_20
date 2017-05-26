/* 
 * Solved in .NET Framework Console
 * with Visual Studio 2017 Community Edition
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {

        public const int upperrange = 20;

        static void Main(string[] args)
        {
            bool flag = true;
            var i = 0;
            var testposnum = 1;

            while (1==1)
            {
                for (i = 1; i <= upperrange; i++)
                {
                    if (i==testposnum) {
                        continue;
                    }
                    if (testposnum % i != 0) {
                        flag = false;
                        break;
                    }
                    /*Uncomment the line below to see process*/
                    //Console.WriteLine("Check " + testposnum + " against (i=" + i + ") ->  flagState=" + flag);
                }
                if (!flag)
                {
                    testposnum++;
                    flag = true;
                }
                else {
                    break;
                } 
            }
            Console.WriteLine("The required answer is "+testposnum);
            Console.ReadLine();
        }
    }
}
