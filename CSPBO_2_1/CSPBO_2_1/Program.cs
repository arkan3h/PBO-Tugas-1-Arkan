﻿class BangunDatar
{
    public float luas()
    {
        Console.WriteLine("Menghitung laus bangun datar");
        return 0;
    }
    public float keliling()
    {
        Console.WriteLine("Menghitung keliling bangun datar");
        return 0;
    }

}

class Persegi : BangunDatar
{
    public float sisi;
}

class Lingkaran : BangunDatar
{
    // jari-jari lingkaran
    public float r;
}

class PersegiPanjang : BangunDatar
{
    public float panjang;
    public float lebar;
}

class Segitiga : BangunDatar
{
    public float alas;
    public float tinggi;
}

public class InheritanceNoOverride
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Inheritance tanpa override");
        Console.WriteLine("\nPilih operasi bnagun datar!");
        Console.WriteLine("1. Persegi \n2. Lingkaran \n3. Persegi Panjang \n4. Segitiga");
        int pilih = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        // membuat objek bangun datar
        BangunDatar bangunDatar = new BangunDatar();

        // memanggil method luas dan keliling
        bangunDatar.luas();
        bangunDatar.keliling();

        if (pilih == 1)
        {
            // membuat objek persegi dan mengisi nilai properti
            Persegi persegi = new Persegi();
            Console.WriteLine("\nMasukkan sisi persegi!");
            persegi.sisi = float.Parse(Console.ReadLine());

            persegi.luas();
            persegi.keliling();
        }

        else if (pilih == 2)
        {
            // membuat objek Lingkaran dan mengisi nilai properti
            Lingkaran lingkaran = new Lingkaran();
            Console.WriteLine("\nMasukkan jari-jari lingkaran!");
            lingkaran.r = float.Parse(Console.ReadLine());

            lingkaran.luas();
            lingkaran.keliling();
        }

        else if (pilih == 3)
        {
            // membuat objek Persegi Panjang dan mengisi nilai properti
            PersegiPanjang persegiPanjang = new PersegiPanjang();
            Console.WriteLine("\nMasukkan panjang persegi!");
            persegiPanjang.panjang = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan lebar persegi!");
            persegiPanjang.lebar = float.Parse(Console.ReadLine());

            persegiPanjang.luas();
            persegiPanjang.keliling();
        }

        else if (pilih == 4)
        {
            // membuat objek Segitiga dan mengisi nilai properti
            Segitiga mSegitiga = new Segitiga();
            Console.WriteLine("\nMasukkan alas segitiga!");
            mSegitiga.alas = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi segitiga!");
            mSegitiga.tinggi = float.Parse(Console.ReadLine());

            mSegitiga.luas();
            mSegitiga.keliling();
        }

        else
        {
            Console.WriteLine("\nError!!!");
        }
    }
}