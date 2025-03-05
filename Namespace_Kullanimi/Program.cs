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

//Araştırma kısmı:
/*
Namespace, C#’ta sınıfları, arayüzleri, yapıları ve diğer türleri organize etmek için kullanılan bir kapsayıcıdır.
Büyük projelerde çakışmaları önlemek ve kod organizasyonunu kolaylaştırmak için kullanılır.
Farklı Namespace’ler Kullanmanın Avantajları
Kod Organizasyonu: Büyük projelerde kodun düzenli olmasını sağlar.
İsim Çakışmalarını Önleme: Aynı isimde farklı sınıflar farklı namespace’ler altında bulunabilir.
Modülerlik ve Bakım Kolaylığı: Farklı bileşenleri ayrı namespace’ler içinde tutmak, geliştirme ve bakım sürecini kolaylaştırır.
Genişletilebilirlik ve Yeniden Kullanılabilirlik: Farklı modüllerin bağımsız çalışmasını sağlar, böylece kod yeniden kullanılabilir.
Erişim Kontrolü: Farklı namespace’lerdeki bileşenlerin erişimini kontrol edebiliriz.

Genişletilebilirlik, bir yazılımın yeni gereksinimlere uyum sağlayacak şekilde geliştirilmesini ifade eder.
Bir yazılım genişletilebilir olduğunda, mevcut kodu değiştirmeden yeni özellikler eklemek mümkündür.
Bir Yazılımı Genişletilebilir Yapmanın Yolları:
1-SOLID Prensiplerine Uygunluk
2-Modüler Tasarım
3-Arayüzler (Interfaces) ve Soyutlama (Abstraction) Kullanımı
4-Event ve Observer Deseni Kullanımı
5-Factory ve Strategy Gibi Tasarım Kalıpları Kullanımı
6-API ve Plugin Desteği
*/
