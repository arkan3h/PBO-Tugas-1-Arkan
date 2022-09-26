import math


class BangunDatar:
    def Luas(self):
        print("\nMenghitung Luas Bangun Datar")
    def Keliling(self):
        print("Menghitung Keliling Bangun Datar")

class Persegi(BangunDatar):
    def sisi(self):
        pass
    def Luas(self):
        self.luas = self.sisi * self.sisi
        print("\nLuas Persegi: ", format(self.luas))
    def Keliling(self):
        self.keliling = 4 * self.sisi
        print("Keliling Persegi: ", format(self.keliling))

class Lingkaran(BangunDatar):
    def jari(self):
        pass
    def Luas(self):
        self.luas = math.pi * self.jari * self.jari
        print("\nLuas Lingkaran: ", format(self.luas))
    def Keliling(self):
        self.keliling = 2 * math.pi * self.jari
        print("Keliling Lingkaran: ", format(self.keliling))

class PersegiPanjang(BangunDatar):
    def panjang(self):
        pass
    def lebar(self):
        pass
    def Luas(self):
        self.luas = self.panjang * self.lebar
        print("\nLuas Persegi Panjang: ", format(self.luas))
    def Keliling(self):
        self.keliling = 2 * self.panjang + 2 * self.lebar
        print("Keliling Persegi Panjang: ", format(self.keliling))

class Segitiga(BangunDatar):
    def alas(self):
        pass
    def tinggi(self):
        pass
    def Luas(self):
        self.luas = self.alas * self.tinggi / 2
        print("\nLuas Segitiga: ", format(self.luas))

class Main(object):
    print("Method Overriding")
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