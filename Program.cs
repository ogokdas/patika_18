using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace patika_18
{
    internal class Program
    {
        static void Main(string[] args)
        {



            ArrayList ArrayListesi = new ArrayList();

            ArrayListesi.Add(3); // integer
            ArrayListesi.Add("Merhaba"); // string
            ArrayListesi.Add(true); // bool

            ArrayList A2 = new ArrayList();

            int[] dizi = { 8, 2, 1, 0, 89, 61, -4 };
            A2.AddRange(dizi);
            A2.Sort();
            A2.Reverse();
            foreach (var item in A2)
            {
                Console.WriteLine(item);
            }


            //Console.WriteLine(A2.BinarySearch(-4));

            A2.Reverse();

            Console.ReadLine();

        }
    }
}
