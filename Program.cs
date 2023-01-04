using System;

namespace App_for_Converting_F_to_C
{
    class Program
    {
        static void Main(string[] args)
        {
            read:
            Console.WriteLine("Это программа для перевода температуры\n в градусах Фарингейта в градусы по Цельсию и наоборот");
            read1:
           Console.WriteLine("Выберите вариант перевода! \n Если Вы хотите перевести Фарингейты в Цельсии введите 1,\n если Цельсии в Фарингейты, нажмите 2!");
            byte selectInput=Convert.ToByte(Console.ReadLine());
            
            if (selectInput== 1)
            {
                Console.WriteLine("Перевод F в C. ВВЕДИТЕ ЗНАЧЕНИЕ ТЕМПЕРАТУРЫ");
                int inputTemp =Convert.ToUInt16( Console.ReadLine());
                Console.WriteLine($"Текущее значение температуры в градусах Цельсия:{(inputTemp-32)*5/9}");
                goto read1;
            }
            else if (selectInput == 2)
            {
                Console.WriteLine("Перевод C в F. ВВЕДИТЕ ЗНАЧЕНИЕ ТЕМПЕРАТУРЫ");
                int inputTemp = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine($"Текущее значение температуры в градусах Фаренгейта:{inputTemp*9/5+32}");
                goto read1;
            }
            else
            {
                Console.WriteLine("Вы выбрали не то,что нужно.Попробуйте ещё раз! ");
                goto read;

            }
        }
    }
}
