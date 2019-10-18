using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin {
    class Program {
        static string decimalToBinary(int decimalNumber) {
            int lastNumberResult = decimalNumber;
            string binaryResultString = "";

            while (lastNumberResult != 1 && lastNumberResult != 0) {
                int addDecimal = lastNumberResult % 2;
                //Console.WriteLine("LOOP");
                //Console.WriteLine(lastNumberResult);
                //Console.WriteLine(binaryResultString);

                if (lastNumberResult == 2 || lastNumberResult == 1) {
                    addDecimal = 1;
                }

                lastNumberResult = lastNumberResult / 2;
                binaryResultString = addDecimal.ToString() + binaryResultString;
                
                for
            }

            return binaryResultString;
        }

        static void Main(string[] args) {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(decimalToBinary(input));
            Console.ReadKey();
        }
    }
}
