using System;


namespace _1._1._01_7._86
{
    class Program
    {
       public static void Main()
        {
            var n = 0;
            var rand = new Random();
            while (true)
            {
              

                //Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.Default;
                Console.WriteLine("Введіть кількість чисел");

                var number = rand.Next(10, 30);/*int.Parse(Console.ReadLine());*/
                Console.WriteLine("Введіть найбільшу суму");
                var MaxSumm = rand.Next(number * 15, number * 20);/*int.Parse(Console.ReadLine());*/
                int[] array = new int[number];
               
                var summ = 0;
                for (int i = 0; i != number; i++)
                {
                    array[i] = rand.Next(1, 20);
                    summ = summ + array[i];
                }
                Console.WriteLine("Сума елементів массиву:" + summ);
                if (summ == 190)
                {
                    n++;
                }
                if (summ > MaxSumm)
                {
                    Console.WriteLine("Сумма елементів массиву більша за " + MaxSumm);
                //}
                //else Console.WriteLine("Сумма елементів массиву менша за " + MaxSumm);
                //Console.WriteLine("Почати знову? y/n");
                //if (Console.ReadLine() == "n")
                
                    break;
                }
                

            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
