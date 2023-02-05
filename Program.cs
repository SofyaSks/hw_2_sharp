using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_2_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1");
            Write("Введите строку: ");
            string str;
            str = ReadLine();
            char[] stroka = str.ToCharArray();
            Write("Другой регистр: ");
            foreach (char item in stroka)
            {
                if (char.IsLower(item))
                {
                    Write(char.ToUpper(item));
                }
                else
                {
                    Write(char.ToLower(item));
                }
            }
            WriteLine();
            WriteLine("2");
            string num;
            Write("Введите число: ");
            num = ReadLine();
            char[] rev = num.ToCharArray();
            Array.Reverse(rev);
            Write("Ревёрс: ");
            foreach(char item in rev)
            {
                Write(item);
            }
            WriteLine();
            WriteLine("3");

            string n, m;
            Write("Первое число: ");
            n = ReadLine();
            int n1 = Convert.ToInt32(n);
            Write("Второе число: ");
            m = ReadLine();
            int m1 = Convert.ToInt32(m);
            if (n1 > m1)
            {
                int tmp;
                tmp = n1;
                n1 = m1;
                m1 = tmp;
            }

            int[][] arr = new int[m1-n1][];
            for (int i = n1; i <= m1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(i + " ");
                }
                WriteLine();
            }
           
        }
    }
}
