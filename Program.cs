using System;

namespace Modul_4_Kel4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string k = "PRAKTIKUM DKP KELOMPOK 4 SHIFT 1"; Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
            Console.WriteLine(k);
            Console.WriteLine(" ");
            Console.WriteLine("NAMA PRAKTIKAN 1\t : NADIA");
            Console.WriteLine("NIM\t                 : 21120119120023");
            Console.WriteLine("NAMA PRAKTIKAN 2\t : AGRIAN RIZKY HIBATULLAH");
            Console.WriteLine("NIM\t                 : 21120119130106");
            Console.WriteLine(" ");

            Class2 objek = new Class2();


            {
                string S = "SELAMAT DATANG DI TOKO ELEKRONIK SINAR JAYA. KAMI SIAP MELAYANI ANDA DENGAN SEPENUH HATI"; Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
                Console.WriteLine(S);
                string L = "****************************************************************************************"; Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
                Console.WriteLine(L);
                Console.WriteLine();

            }
            int hp, byr, kmb, p, jml, i, j;

            String[,] smp = new String[10, 4];
            //MENU :
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("|NO |              NAMA ELEKTRONIK \t\t          |  HARGA(Rp)|");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("|1  |            TELEVISI PANASONIC\t\t          |  1,300,000|");
            Console.WriteLine("|2  |                 KULKAS \t\t\t          |  1,600,000|");
            Console.WriteLine("|3  |                 RADIO\t\t\t          |  2,750,000|");
            Console.WriteLine("|4  |              LAPTOP ASUS\t\t\t          |  1,250,000|");
            Console.WriteLine("|5  |               KOMPUTER\t\t\t\t  |  350,000  |");
            Console.WriteLine("|6  |              KIPAS ANGIN  \t\t\t  |  700,000  |");
            Console.WriteLine("|7  |                   AC \t                          |  2,717,000|");
            Console.WriteLine("|8  |              JAM DINDING                            |  115,000  |");
            Console.WriteLine("-----------------------------------------------------------------------");




            for (i = 0; i < 9; i++)
                Console.WriteLine("\n-----------------------------------------------------------------------------");
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(smp[i, j] + "\t|");
                }
                Console.WriteLine("\n-----------------------------------------------------------------------------");         //pindah baris
            }


            Console.WriteLine("MASUKKAN NO PILIHAN ELEKTRONIK YANG ANDA INGINKAN : ");
            int.TryParse(Console.ReadLine(), out hp);
            Console.WriteLine("MASUKKAN JUMLAH ELEKTRONIK YANG AKAN ANDA BELI : ");
            int.TryParse(Console.ReadLine(), out jml);
            Console.WriteLine("MASUKKAN NOMINAL PEMBAYARAN : ");
            int.TryParse(Console.ReadLine(), out byr);

            System.Console.WriteLine();
            switch (hp)
            {
                case 1:
                    p = 1300000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[1, 1] + " SEJUMLAH "  +  jml  +  " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA "  +  kmb  +  " RUPIAH");
                    }
                    else { objek.k(smp[1, 1], jml); }
                    break;
                case 2:
                    p = 1600000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[2, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[2, 1], jml); }
                    break;
                case 3:
                    p = 2750000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[3, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[3, 1], jml); }
                    break;
                case 4:
                    p = 1250000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[4, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[4, 1], jml); }
                    break;

                case 5:
                    p = 350000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[5, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[5, 1], jml); }
                    break;
                case 6:
                    p = 700000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[6, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[6, 1], jml); }
                    break;
                case 7:
                    p = 2717000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[7, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[7, 1], jml); }
                    break;
                case 8:
                    p = 115000;
                    kmb = byr - (p * jml);
                    if (kmb >= 0)
                    {
                        objek.tx();
                        Console.WriteLine(smp[8, 1] + " SEJUMLAH " + jml + " BUAH");
                        Console.WriteLine("UANG KEMBALIAN ANDA " + kmb + " RUPIAH");
                    }
                    else { objek.k(smp[8, 1], jml); }
                    break;
                default:
                    Console.WriteLine("MASUKAN SALAH");
                    break;
            }
            Console.ReadKey();
        }

    }
}


 