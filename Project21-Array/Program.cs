// 10 elemanlı bir tam sayı dizisi tanımlanıyor
int[] sayilar = new int[10];

// Dizi elemanlarını for döngüsü ile doldur
for (int i = 0; i < sayilar.Length; i++) // dizinin her elemanını doldurmak için döngü
{
    // Kullanıcıdan tam sayı girişi al
    Console.Write("Lütfen {0}. tam sayıyı girin: ", i + 1);
    // Girilen değeri diziye kaydet
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

// Girilen sayıları foreach döngüsü ile ekrana yazdır
Console.WriteLine("Girilen tam sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi); // Her bir sayıyı ekrana yazdır
}

// Bu diziye kullanıcıdan alınan yeni bir değeri ekliyoruz (11. eleman olarak) - Array.Resize ile
while (true)
{
    // Kullanıcıdan 11. tam sayıyı al
    Console.WriteLine("11. sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    // Dizi boyutunu 1 artır
    Array.Resize(ref sayilar, sayilar.Length + 1); // dizi boyutunu artırmak için
                                                   // Yeni sayıyı dizinin sonuna ekle
    sayilar[sayilar.Length - 1] = sayi;

    // Kullanıcıya döngüden çıkma seçeneği sun
    Console.WriteLine("DÖNGÜDEN ÇIKMAK İÇİN HAYIR, DEVAM ETMEK İÇİN EVET YAZIN");
    string devam = Console.ReadLine();
    if (devam == "HAYIR") // Eğer kullanıcı "HAYIR" derse döngüden çık
        break;
}

Console.WriteLine("-------------------------------------------");

// Bu diziyi büyükten küçüğe ekrana yazdırmak için
// Öncelikle diziyi küçükten büyüğe sıralayıp sonra ters çeviriyoruz
Array.Sort(sayilar); // diziyi küçükten büyüğe sıralamak için
Array.Reverse(sayilar); // sıralı diziyi tersine çevirmek için

Console.WriteLine("Büyükten küçüğe sıralanmış sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi); // Sıralı sayıları ekrana yazdır
}
    