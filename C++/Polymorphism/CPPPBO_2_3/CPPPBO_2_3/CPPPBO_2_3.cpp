#include <iostream>
#include <math.h>
#define Pi 3.14159265358979323846  /* pi */
using namespace std;

class BangunDatar
{
public:
    float luas()
    {
        cout << "\nMenghitung luas bangun datar\n";
        return 0;
    }
    float keliling()
    {
        cout << "Menghitung keliling bangun datar\n";
        return 0;
    }
};

class Persegi : public BangunDatar
{
public:
    float sisi = 0;
    Persegi(float a = 0) { sisi = a; }
    float luas() {
        return sisi * sisi;
    }

    float keliling() {
        return 4 * sisi;
    }
};

class Lingkaran : public BangunDatar
{
public:
    float r = 0;
    Lingkaran(float a = 0) { r = a; }
    float luas() {
        return (float)(Pi * Lingkaran::r * Lingkaran::r);
    }

    float keliling() {
        return (float)(2 * Pi * Lingkaran::r);
    }
};

class Segitiga : public BangunDatar
{
public:
    float alas = 0;
    float tinggi = 0;
    Segitiga(float a = 0, float b = 0) {
        alas = a;
        tinggi = b;
    }
    float luas() {
        return (Segitiga::alas * Segitiga::tinggi) / 2;
    }
};

int main()
{
    int pilih;
    cout << "Polymerphism\n";
    cout << "\nPilih operasi bangun datar!\n";
    cout << "1. Persegi \n2. Segitiga \n3. Lingkaran\n";
    cin >> pilih;

    BangunDatar bangunDatar;

    bangunDatar.luas();
    bangunDatar.keliling();

    if (pilih == 1)
    {
        float a;
        cout << "\nMasukkan Sisi : ";
        cin >> a;
        Persegi persegi(a);

        cout << "\nLuas Persegi: " << persegi.luas() << endl;
        cout << "Keliling Persegi: " << persegi.keliling() << endl;
    }

    else if (pilih == 2)
    {
        float a, b;
        cout << "\nMasukkan Alas : ";
        cin >> a;
        cout << "Masukkan Tinggi : ";
        cin >> b;
        Segitiga mSegitiga(a, b);

        cout << "\nLuas Segitiga: " << mSegitiga.luas() << endl;
        mSegitiga.keliling();
    }

    else if (pilih == 3)
    {
        float a;
        cout << "\nMasukkan Jari-Jari : ";
        cin >> a;
        Lingkaran lingkaran(a);

        cout << "\nLuas lingkaran: " << lingkaran.luas() << endl;
        cout << "Keliling Lingkaran: " << lingkaran.keliling() << endl;
    }

    else
    {
        cout << "\nError!!!\n\n";
    }
}