class BangunDatar
{
    public virtual float luas()
    {
        Console.WriteLine("\nMenghitung luas bangun datar");
        return 0;
    }
    public virtual float keliling()
    {
        Console.WriteLine("Menghitung keliling bangun datar");
        return 0;
    }

}

class Persegi : BangunDatar
{
    public float sisi;
    public override float luas()
    {
        float luas = sisi * sisi;
        Console.WriteLine("\nLuas Persegi: " + luas);
        return luas;
    }
    public override float keliling()
    {
        float keliling = 4 * sisi;
        Console.WriteLine("Keliling Persegi: " + keliling);
        return keliling;
    }
}

class Lingkaran : BangunDatar
{
    public float r;
    public override float luas()
    {
        float luas = (float)(Math.PI * r * r);
        Console.WriteLine("\nLuas lingkaran: " + luas);
        return luas;
    }
    public override float keliling()
    {
        float keliling = (float)(2 * Math.PI * r);
        Console.WriteLine("Keliling Lingkaran: " + keliling);
        return keliling;
    }
}

class PersegiPanjang : BangunDatar
{
    public float panjang;
    public float lebar;
    public override float luas()
    {
        float luas = panjang * lebar;
        Console.WriteLine("\nLuas Persegi Panjang:" + luas);
        return luas;
    }
    public override float keliling()
    {
        float kll = 2 * panjang + 2 * lebar;
        Console.WriteLine("Keliling Persegi Panjang: " + kll);
        return kll;
    }
}

class Segitiga : BangunDatar
{
    public float alas;
    public float tinggi;
    public override float luas()
    {
        float luas = alas * tinggi / 2;
        Console.WriteLine("\nLuas Segitiga: " + luas);
        return luas;
    }
}

public class OverrideMethod
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Method Overriding");
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