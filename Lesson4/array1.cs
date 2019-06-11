using System;
using System.IO;

namespace Lesson4
{
    class MyArray1
    {
        int[] x;

        public MyArray1(int n, int e1)
        {
            x = new int[n];
            for (int i = 0; i < n; i++)
                x[i] = e1;
        }

        public MyArray1(int n, int min, int max)
        {
            x = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                x[i] = rnd.Next(min, max);
        }

        #region Ex2. //а) Дописать класс для работы с одномерным массивом. 
        //Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
        //Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi,
        //умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
        //В Main продемонстрировать работу класса.

        public MyArray1(int n, int min, int max, int step)
        {
            x = new int[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = min;
                min += step;
            }
        }

        public int Sum
        {
            get
            {
                int sum = x[0];
                for (int i = 1; i < x.Length; i++)
                    sum += x[i];
                return sum;
            }
        }
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    if (x[i] == Max)
                    {
                        maxCount++;
                    }
                }
                return maxCount;
            }
        }
        public void Inverse()
        {
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * (-1);

        }
        public void Multi(int umnog)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * umnog;
        }

        public void Read(string filename)
        {
            if (File.Exists(filename))
            {
                //Считываем все строки из файла
                string[] ss = File.ReadAllLines(filename);
                for (int i = 0; i < ss.Length; i++)
                {
                    Console.Write(ss[i] + " ");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Error load file");
        }
        public void Rec(string filename)
        {
            //переводим данные из чисел в строки
            string[] x_string = new string[x.Length];
            for (int i = 0; i < x_string.Length; i++)
                x_string[i] = Convert.ToString(x[i]);

            //пишем массив со строками в файл
            System.IO.File.WriteAllLines(filename, x_string);
        }

        #endregion
        public int Max
        {
            get
            {
                int max = x[0];
                for (int i = 1; i < x.Length; i++)
                    if (x[i] > max) max = x[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = x[0];
                for (int i = 1; i < x.Length; i++)
                    if (x[i] < min) min = x[i];
                return min;
            }
        }
        public int CountPositive
        {
            get
            {
                int count = 0;
                for (int i = 0; i < x.Length; i++)
                    if (x[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in x)
                s = s + v + " ";
            return s;
        }

    }
}
