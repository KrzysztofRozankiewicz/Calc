using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add");


                if (menu == 0)
                {
                    break;
                }
                Console.WriteLine("2. Diff");
                Console.WriteLine("3. Mul");
            }      
                    
         }

    }
}
