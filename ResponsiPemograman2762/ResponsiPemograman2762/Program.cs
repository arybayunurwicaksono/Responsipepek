using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemograman2762
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(19112762, 6000000, "Ary");
            Karyawan karyawan2 = new Karyawan(10101010, 4000000, "Bayu");

            Console.WriteLine("No. \t NIK/Nama \t\t Gaji Bulanan");
            Console.WriteLine("1. \t {0}t\t Gaji Bulanan");
            Console.WriteLine("2. \t {1}Gaji Bulanan");
            
        }
    }
    public class Karyawan
    {
        public int nik { get; set; }
        public int GajiBulanan { get; set; }
        public string nama { get; set; }
        public int GajiNaik { get; set; }
        


        public Karyawan(int NIK = 0, int gajibulanan = 0, string Nama = "kosong")
        {
            this.nik = NIK;
            this.nama = Nama;
            if (gajibulanan < 0)
            {
                this.GajiBulanan = 0;
                GajiNaik = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gajibulanan;
                GajiNaik = Convert.ToInt32((GajiBulanan * 1.1));
            }
        }
    }
}
