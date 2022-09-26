import math


class BangunDatar:
    def Luas(self):
        print("\nMenghitung Luas Bangun Datar")
    def Keliling(self):
        print("Menghitung Keliling Bangun Datar")

class Persegi(BangunDatar):
    def __init__(self, sisi):
        self.sisi = sisi
    def Luas(self):
        return self.sisi * self.sisi
    def Keliling(self):
        return 4 * self.sisi

class Segitiga(BangunDatar):
    def __init__(self, alas, tinggi):
        self.alas = alas
        self.tinggi = tinggi
    def Luas(self):
        return self.alas * self.tinggi / 2

class Lingkaran(BangunDatar):
    def __init__(self, jari):
        self.jari = jari
    def Luas(self):
        return math.pi * self.jari * self.jari
    def Keliling(self):
        return 2 * math.pi * self.jari

class Main(object):
    print("Polymorphisme")
    print("\nPilih operasi bangun datar!")
    print("1. Persegi\n2. Segitiga\n3. Lingkaran")
    menu = int(input())

    if menu==1:
        persegi=Persegi(int(input("\nMasukkan Sisi : ")))
        print("\nLuas Persegi: ", persegi.Luas())
        print("Keliling Persegi: ", persegi.Keliling())
    elif menu==2:
        segitiga=Segitiga(int(input("\nMasukkan Alas : ")), int(input("Masukkan Tinggi : ")))
        print("\nLuas Segitiga: ", segitiga.Luas())
        segitiga.Keliling()
    elif menu==3:
        lingkaran=Lingkaran(int(input("\nMasukkan Jari-Jari : ")))
        print("\nLuas Lingkaran: ", lingkaran.Luas())
        print("Keliling Lingkaran: ", lingkaran.Keliling())