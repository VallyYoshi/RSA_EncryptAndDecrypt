using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WindowsFormsApp1
{
    class EncriptAndDecript
    {
        public static BigInteger Step(BigInteger chislo, BigInteger step)
        {
            BigInteger x = 1;

            for (BigInteger i = 0; i < step; i++)
            {
                x *= chislo;
            }
            return x;
        }

        // Процедура расшифрования
        public static string Encript(string text)
        {
            string EncriptText = "";
            BigInteger H;
            char ch;

            for (int i = 0; i < text.Length; i++) // шифрование по формуле C(i) = M(i)^e mod n
            {// C(i)                    M(i)^e                 mod     n
                H = Step((BigInteger)text[i], KeyCollection.ee) % KeyCollection.n;
                ch = (char)H;
                EncriptText += Convert.ToString(ch);
            }
            return EncriptText;
        }


        // Процедура шифрования
        public static string Decript(string text)
        {
            string DecriptText = "";
            BigInteger h;
            char ch;

            for (int i = 0; i < text.Length; i++) // шифрование по формуле M(i)=C(i)^e mod n
            {// M(i)                      C(i)^d               mod     n
                h = Step((BigInteger)text[i], KeyCollection.d) % KeyCollection.n;
                ch = (char)h;
                DecriptText += Convert.ToString(ch);
            }
            return DecriptText;
        }
    
    }
}
