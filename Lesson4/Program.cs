using System;
using System.IO;

//Гаврилов Владимир 
namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex1    //Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.


            int[] array = new int[20];//создание массива из 20 целочисленных элементов

            Random r = new Random();

            int a = array[0];
            int b = array[1];

            int coach = 0;

            int schetchik = 0;

            for (coach = 0; coach < array.Length; coach++)
            {
                array[coach] = r.Next(-10000, 10000);//генерация случайного из возможных значений для элемента массива 
                Console.WriteLine($"{array[coach]}");
            }

            coach = 0;

            while (coach <= array.Length)//запуск цикла, для подсчета пар элементов, соответствующих условию.
            {
                if (a % 3 == 0 || b % 3 == 0)
                {
                    schetchik++;

                }
                if (b == array[19])
                {
                    break;
                }
                a = b;
                b = array[coach++];
            }
            Console.WriteLine("Количество пар элементов массива, в которых хотя бы одно число делится на три - " + schetchik);

            #endregion

            MyArray1 x = new MyArray1(10, 0, 100);
            Console.WriteLine(x.ToString());
            Console.WriteLine(x.Max);
            Console.WriteLine(x.Min);
            Console.WriteLine(x.CountPositive);

            #region Ex2        //В Main продемонстрировать работу класса.
            MyArray1 y = new MyArray1(20, 15, 150, 5);
            Console.WriteLine(y.ToString());
            Console.WriteLine(y.Sum);//Демострация работы свойств(Ex2)
            y.Inverse();//и методов
            Console.WriteLine(y.ToString());
            y.Multi(-3);
            Console.WriteLine(y.ToString());
            Console.WriteLine(y.MaxCount);

            y.Read("data.txt");
            Console.WriteLine(y.ToString());

            y.Rec("data2.txt");
            
            #endregion






            Console.ReadKey();
        }
    }

}
