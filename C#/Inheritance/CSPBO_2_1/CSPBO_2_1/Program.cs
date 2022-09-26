class BangunDatar
{
    public float luas()
    {
        Console.WriteLine("\nMenghitung laus bangun datar");
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

public class Inheritance
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Inheritance");
        Console.WriteLine("\nPilih operasi bangun datar!");
        Console.WriteLine("1. Persegi \n2. Lingkaran \n3. Persegi Panjang \n4. Segitiga");
        int pilih = int.Parse(Console.ReadLine());

        BangunDatar bangunDatar = new BangunDatar();

        bangunDatar.luas();
        bangunDatar.keliling();

        if (pilih == 1)
        {
            Persegi persegi = new Persegi();
            Console.WriteLine("\nMasukkan Sisi : ");
            persegi.sisi = float.Parse(Console.ReadLine());

            persegi.luas();
            persegi.keliling();
        }

        else if (pilih == 2)
        {
            Lingkaran lingkaran = new Lingkaran();
            Console.WriteLine("\nMasukkan Jari-Jari : ");
            lingkaran.r = float.Parse(Console.ReadLine());

            lingkaran.luas();
            lingkaran.keliling();
        }

        else if (pilih == 3)
        {
            PersegiPanjang persegiPanjang = new PersegiPanjang();
            Console.WriteLine("\nMasukkan Panjang : ");
            persegiPanjang.panjang = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Lebar : ");
            persegiPanjang.lebar = float.Parse(Console.ReadLine());

            persegiPanjang.luas();
            persegiPanjang.keliling();
        }

        else if (pilih == 4)
        {
            Segitiga mSegitiga = new Segitiga();
            Console.WriteLine("\nMasukkan Alas : ");
            mSegitiga.alas = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan Tinggi : ");
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