using System;
namespace LaporanPraktikum_3

{
    public class MobilApp
    {
        static public void Main(String[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.warna = "Purple";
            mobil1.JumlahPintu = 2;
            mobil1.merek = "Angkot";
            mobil1.model = "Angkutan Umum";
            mobil1.TahunKeluar = 1945;

            mobil1.Gas(300);
            mobil1.Klakson("DJ Angkot");
            mobil1.TampilkanInfo();

            Console.WriteLine("\n");
            Console.WriteLine("===================");

            Mobil mobil2 = new Mobil();
            mobil2.warna = "Pink";
            mobil2.JumlahPintu = 4;
            mobil2.merek = "Taxi";
            mobil2.model = "Angkutan Umum";
            mobil2.TahunKeluar = 2030;

            mobil2.Gas(200);
            mobil2.Klakson("Tetttt tettttt");
            mobil2.TampilkanInfo();


            Console.ReadKey();


        }
    }
}