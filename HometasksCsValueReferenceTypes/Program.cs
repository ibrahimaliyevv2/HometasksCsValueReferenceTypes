using System;

namespace HometasksCsValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Daxil edilmis string deyerinin icinde reqem olub olmadigini tapan alqoritm



            //Console.WriteLine("Input:");
            //string text = Console.ReadLine();

            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{

            //    if (text[i] >= '0' && text[i] <= '9')
            //    {
            //        count++;
            //    }

            //}
            //if (count >= 1)
            //{
            //    Console.WriteLine("Contains a digit");
            //}
            //else
            //{
            //    Console.WriteLine("Doesn't contain a digit");
            //}



            // Daxil edilmis string deyerinde ardicil a ve l char-larinin olub-olmadigini tapan proqram
            // Meselen, alma, salam ve s. kimi sozlerde "vardir" yazilmalidir

            //Console.WriteLine("Input:");
            //string text = Console.ReadLine();

            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{

            //    if (text[i] == 'a' && text[i+1] == 'l')
            //    {
            //        count++;
            //    }

            //}
            //if (count >= 1)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}






            //Verilmis ededin reqemlerinin ededi ortasini tapan proqram

            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int count = 0;
            //while (num != 0)
            //{
            //    count++;
            //    sum += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(sum/count);







            // Daxil edilmis yazi siyahisinda(string array) nece sozde reqem oldugunu tapan proqram

            Console.WriteLine("Adlarin sayini daxil et:");
            int namesCount = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[namesCount];

            for (int i = 0; i < namesCount; i++)
            {
                Console.WriteLine((i + 1) + "-ci adi daxil et:");
                names[i] = Console.ReadLine();
            }
            int count = 0;
            for (int i = 0; i < namesCount; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    if (names[i][j] >= '0' && names[i][j] <= '9')
                    {
                        count++;
                        break;
                    }
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}