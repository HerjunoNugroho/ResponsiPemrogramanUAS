using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();
        
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("MENU YANG ANDA SALAH");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection
            Produk produk = new Produk();
            Console.WriteLine("Tambah Data Produk\n");
            Console.Write("Kode Produk          : ");
            produk.Kode = Console.ReadLine();
            Console.Write("Nama Produk          : ");
            produk.Nama = Console.ReadLine();
            Console.Write("Harga Beli           : ");
            produk.HargaBeli = Convert.ToInt32(Console.ReadLine());
            Console.Write("Harga Jual           : ");
            produk.HargaJual = Convert.ToInt32(Console.ReadLine());
            daftarProduk.Add(produk);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection
            int hapus = -1, nomor = 1;
            Console.Write("Kode Produk : ");
            string kodeproduk = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                hapus++;
                if (produk.Kode == kodeproduk)
                {
                    nomor = hapus;
                }
            }
            if (nomor != -1)
            {
                daftarProduk.RemoveAt(nomor);
                Console.WriteLine("\nData Produk Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("\nKode Produk Tidak Ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection
            int urutan = 0;
            Console.WriteLine("Data Produk\n");
            foreach (Produk produk in daftarProduk)
            {
                urutan++;
                Console.WriteLine("{0}. Kode Produk : {1}, Nama Produk : {2}, Harga Beli : {3}, Harga Jual : {4}", urutan, produk.Kode, produk.Nama, produk.HargaBeli, produk.HargaJual);
            }
            if (urutan < 1)
            {
                Console.WriteLine("Data Produk Kosong");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}