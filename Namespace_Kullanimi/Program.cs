using MatematikIslemleri;
using System;
/*
 1. "MatematikIslemleri" adında ProgramTest namespace'ine benzer bir namespace oluşturun.
 2. MatematikIslemleri namespace'inin içine "Hesaplama" adında bir sınıf oluşturun.
 3. Hesaplama sınıfı içine "Topla" ve "Çarp" adında iki metot oluşturun.
    - Bu metotlar "sayi1" ve "sayi2" adında parametreler almalı.
    - Topla metodu "sayi1 + sayi2" işlemini ekrana yazdırmalı.
    - Çarpma metodu "sayi1 * sayi2" işlemini ekrana yazdırmalı.
*/
namespace MatematikIslemleri
{
    // Hesaplama sınıfı oluşturmanız isteniyor.
    // Hesaplama sınıfı içerisine Topla ve Carp metotlarını ekleyiniz. 
    public class Hesaplama
    {
        public void topla(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        public void carp(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 * sayi2);
        }

    }
}
// ProgramTest adında "MatematikIslemleri" namespace'i gibi yeni bir namespace oluşturun.
namespace ProgramTest
{
    // Main metodu içeren sınıf
    public class Program
    {
        static void Main(string[] args)
        {
            // MatematikIslemleri namespace'inden Hesaplama sınıfının nesnesini oluşturun.
            // Yazdığınız metotları çağırın ve doğru çıktıları konsol ekranında görün.
            Hesaplama hesaplama = new Hesaplama();
            hesaplama.topla(10, 5);
            hesaplama.carp(10, 5);
        }
    }
}
