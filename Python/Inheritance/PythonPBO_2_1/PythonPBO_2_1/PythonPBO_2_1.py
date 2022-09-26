class BangunDatar:
    def Luas(self):
        print("\nMenghitung Luas Bangun Datar")
    def Keliling(self):
        print("Menghitung Keliling Bangun Datar")

class Persegi(BangunDatar):
    def sisi(self):
        pass

class PersegiPanjang(BangunDatar):
    def panjang(self):
        pass
    def lebar(self):
        pass

class Segitiga(BangunDatar):
    def alas(self):
        pass
    def tinggi(self):
        pass

class Lingkaran(BangunDatar):
    def jari(self):
        pass

class Main(object):
    print("Inheritance")
    print("\nPilih operasi bangun datar!")
    print("1. Persegi\n2. Lingkaran\n3. Persegi Panjang\n4. Segitiga")
    menu = int(input())

    if menu==1:
        persegi=Persegi()
        persegi.sisi = int(input("\nMasukkan Sisi : "))
        persegi.Luas()
        persegi.Keliling()
    elif menu==2:
        lingkaran=Lingkaran()
        lingkaran.jari = int(input("\nMasukkan Jari-Jari : "))
        lingkaran.Luas()
        lingkaran.Keliling()
    elif menu==3:
        persegipanjang=PersegiPanjang()
        persegipanjang.panjang = int(input("\nMasukkan Panjang : "))
        persegipanjang.lebar = int(input("Masukkan Lebar : "))
        persegipanjang.Luas()
        persegipanjang.Keliling()
    elif menu==4:
        segitiga=Segitiga()
        segitiga.alas = int(input("\nMasukkan Alas : "))
        segitiga.tinggi = int(input("Masukkan Tinggi : "))
        segitiga.Luas()
        segitiga.Keliling()