using System;
namespace LaporanPraktikum_3

{
    internal class MobilApp
    {
        static void Main(string[] args)
        {
            mobil mobill = new mobil();
            mobil mobil2 = new mobil();
            mobil mobil3 = new mobil();

            mobill.warna = "silver";
            mobill.jumlah_pintu = 4;
            mobill.merek = "Avanza";
            mobill.model = "MPV";
            mobill.tahun_keluaran = 2019;

            mobill.Gas(180);
            mobill.klakson("Klakson udara");
            mobill.TampilkanInfo();
        } 
    }
}