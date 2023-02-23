using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_personelin_bilgilerini_tutan_ve_yazdiran_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrno = { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110" };
            string[] isim = { "Ayşe", "Fatma", "Hasan", "Hüseyin", "Elif", "Zeynep", "Ali", "Arda", "Ahmet", "Ece" };
            string[] telefon = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            string[] mail = { "ayşe@gmail.com", "fatma@gmail.com", "hasan@gmail.com", "hüseyin@gmail.com", "elif@gmail.com", "zeynep@gmail.com", "ali@gmail.com", "arda@gmail.com", "ahmet@gmail.com", "ece@gmail.com" };

            Console.Write("Kişi Numarasını Giriniz: ");
             string aranan = Console.ReadLine();
             int no = Array.IndexOf(ogrno, aranan.ToString());
            Console.WriteLine("=====================================================");
            Console.ReadLine();
            Console.WriteLine("Aranan Kişi : {0}\tTelefonu: {1}\tE-mail: {2}", isim[no], telefon[no], mail[no]);
            Console.ReadKey();
        }
    }
}
