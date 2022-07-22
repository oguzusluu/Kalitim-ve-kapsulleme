using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsul_ve_kalıtım
{
    class program
    {

        static void Main(string[]args)
        {

            Class1 ogrenci = new Class1();
            ogrenci.setNo("862");
            string deger = ogrenci.getNo();
            if (deger=="862")
            {
                Console.WriteLine("Ögrenci Numarası Doğru");

            }
            else
            {
                Console.WriteLine("Hatalı Ögrenci Numarası");
            }
            Console.ReadKey();


        }



    }
}
