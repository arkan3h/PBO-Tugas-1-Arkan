class BangunDatar
{
    public virtual float luas()
    {
        Console.WriteLine("Menghitung laus bangun datar");
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
    public Persegi(float sisi)
    {
        this.sisi = sisi;
    }
    public override float luas()
    {
        return this.sisi * this.sisi;
    }
    public override float keliling()
    {
        return this.sisi * 4;
    }
}

class Segitiga : BangunDatar
{
    public float alas;
    public float tinggi;
    public Segitiga(float alas, float tinggi)
    {
        this.alas = alas;
        this.tinggi = tinggi;
    }
    public override float luas()
    {
        return this.alas * this.tinggi / 2;
    }
}
class Lingkaran : BangunDatar
{
    // jari-jari lingkaran
    public float r;
    public Lingkaran(float r)
    {
        this.r = r;
    }
    public override float luas()
    {
        return (float)(Math.PI * r * r);
    }
    public override float keliling()
    {
        return (float)(2 * Math.PI * r);
    }
}

public class Polymorphism
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Polimorfisme");
        Console.WriteLine("\nPilih operasi bnagun datar!");
        Console.WriteLine("1. Persegi \n2. Segitiga \n3. Lingkaran");
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
            Console.WriteLine("\nMasukkan sisi persegi!");
            Persegi persegi = new Persegi(float.Parse(Console.ReadLine()));

            Console.WriteLine("Luas persegi: " + persegi.luas());
            Console.WriteLine("keliling persegi: " + persegi.keliling());
        }
        
        else if (pilih == 2)
        {
            // membuat objek Segitiga dan mengisi nilai properti
            
            Console.WriteLine("\nMasukkan alas segitiga!");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan tinggi segitiga!");
            float t = float.Parse(Console.ReadLine());
            Segitiga segitiga = new Segitiga(a, t);

            Console.WriteLine("Luas segitiga: " + segitiga.luas());
        }

        else if (pilih == 3)
        {
            // membuat objek Lingkaran dan mengisi nilai properti
            Console.WriteLine("\nMasukkan jari-jari lingkaran!");
            Lingkaran lingkaran = new Lingkaran(float.Parse(Console.ReadLine()));

            Console.WriteLine("Luas lingkaran: " + lingkaran.luas());
            Console.WriteLine("keliling lingkaran: " + lingkaran.keliling());
        }

        else
        {
            Console.WriteLine("\nError!!!");
        }
    }
}