using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            string[] frase = {"1","2","3","4","5","6","7","8","9"};
            string[] array = new string[9];
            foreach (string s in frase)
            {
                array[x] = s;
                x+=1;
            }
            for(int i=0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
