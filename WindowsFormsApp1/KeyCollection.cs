using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class KeyCollection
    {
        public static int p, q, m, n, d, ee;

        static int[] mass = new int[100];
        static Random rnd = new Random();

        //Выбор рандомного простого числа из массива
        public static int rand()
        {
            int[] array = { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61,
                            67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137,
                            139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211,
                            223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283,
                            293 };
            int x;
            x = array[rnd.Next(array.GetLength(0))];//рандом

            return x;
        }

        public static void KeyColl()
        {
            p = rand();
            q = rand();
            n = p * q;// ключ n
            m = (p - 1) * (q - 1);

            // нахождения ключей d
            int j = 0;
            for (d = 3; d < m; d++)
            {
                for (int i = 2; i <= m; i++)
                {
                    if ((d % i == 0) && (m % i == 0))
                        break;
                    else
                    {
                        if (i == m)
                        {
                            mass[j] = d;
                            j++;
                        }
                    }
                }
                if (j == 100)
                    break;
            }

            // выбор рандомного числа d из массива
            d = mass[rnd.Next(mass.GetLength(0))];

            // нахождение е вывод ключа e
            for (ee = 1; ee < m; ee++)
            {
                if ((ee * d) % m == 1)
                {
                    break;
                }
            }
        }
    }
}
