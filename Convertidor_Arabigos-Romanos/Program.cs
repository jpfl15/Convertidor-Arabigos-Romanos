using System;

namespace Convertidor_Arabigos_Romanos
{
    class Program
    {
        public static String Convert(int num)
        {
            String newNum = "";
            int[] Enumbers = {900,500,400,100,90,50,40,10,9,5,4,1};
            String[] Rchar = {"CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"};
            if (num == 1000)
            {
                newNum += "M";
            }
            else
            {
                int count = 0;
                while(count<Enumbers.Length)
                { 
                    if (num >= Enumbers[count])
                    {
                        newNum += Rchar[count];
                        num -= Enumbers[count];
                    }
                    else
                    {
                        count++;
                    }
                }
            }

            return newNum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ARABIC NUMBERS TO ROMAN NUMERALS CONVERTER");

            bool validNum = false;
            while (!validNum)
            {
                Console.WriteLine("INSERT A NUMBER BETWHEEN 1 TO 1000");

                int num = int.Parse(Console.ReadLine());

                if (num > 0 && num <= 1000)
                {
                    Console.WriteLine("ROMAN NUMERAL: " + Convert(num));
                    validNum = true;
                }
            }
            
            
        }
    }
}
