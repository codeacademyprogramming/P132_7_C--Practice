using System;

namespace _11082022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==================================================
            //1.Verilmis siyahidaki en boyuk ededi tapan proqram
            //==================================================


            //int[] numbers = { 1, 2, 3, };

            //int maxNumber = numbers[0];

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //==================================================
            //1.Verilmis siyahidaki 21-e bolunen ededlerin ededi ortasini tapan proqram
            //=================================================
            //int[] numbers = { 12, 21, 33, 42, 55 };
            //int sum = 0;
            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 21 == 0)
            //    {
            //        sum += numbers[i];
            //        count++;
            //    }
            //}
            //if (count != 0)
            //{
            //    int result = sum / count;
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Arrayde 21-e bolunen eded yoxdur");
            //}


            //==================================================
            //3.Verilmis yazida a herfinin olub olmadigini tapan proqram
            //=================================================
            //string word = "alma";
            //bool hasWantedLetter = false;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if(word[i] == 'a')
            //    {
            //        hasWantedLetter = true;
            //        break;
            //    }
            //}

            //if(hasWantedLetter == true)
            //{
            //    Console.WriteLine("a herfi var");
            //}
            //else
            //{
            //    Console.WriteLine("a herfi yoxdur!");
            //}




            //==================================================
            //4.Verilmis yazida a herfi yoxdursa yazinin yeniden daxil edilmesini teleb edn proqram
            //=================================================

            //string sentence;
            //bool hasWantedLetter = false;
            //do
            //{
            //    sentence = Console.ReadLine();
            //    for (int i = 0; i < sentence.Length; i++)
            //    {
            //        if (sentence[i] == 'a')
            //        {
            //            hasWantedLetter = true;
            //            break;
            //        }
            //    }
            //} while (hasWantedLetter == false);



            //Console.WriteLine("Proses bitdi!");



            //==================================================
            //5.Daxil edilmis yazinin icerisinde daxil edilmis charin olub olmadigini tapan proqram
            //==================================================

            //string word = Console.ReadLine();
            //string letterStr = Console.ReadLine();
            //char letter = Convert.ToChar(letterStr);
            //bool hasWantedLetter = false;

            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //    {
            //        hasWantedLetter = true;
            //        break;
            //    }
            //}

            //if (hasWantedLetter == true)
            //{
            //    Console.WriteLine("herfi var");
            //}
            //else
            //{
            //    Console.WriteLine("herfi yoxdur!");
            //}


            //==================================================
            //6.Daxil edilmis yazinin icerisinde daxil edilmis char-dan nece ededn oldugunu tapan proqram
            //========================================================

            Console.WriteLine("Yazini daxil edin");
            string sentence = Console.ReadLine();
            Console.WriteLine("Axtaracaginiz xarakter:");
            string letterStr = Console.ReadLine();
            char letter = Convert.ToChar(letterStr);
            int counter = 0;


            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == letter)
                    counter++;
            }

            Console.WriteLine(counter);

        }
    }
}
