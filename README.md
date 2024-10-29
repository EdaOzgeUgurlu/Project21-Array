# Tam Sayı Dizisi Uygulaması

Bu proje, C# dilinde kullanıcıdan tam sayılar alarak bir dizi oluşturmayı, bu diziyi güncellemeyi ve sıralamayı amaçlamaktadır. Aşağıda projenin detaylı açıklaması ve kullanım kılavuzu yer almaktadır.

## İçindekiler

1. [Proje Hakkında](#proje-hakkında)
2. [Kurulum](#kurulum)
3. [Kullanım](#kullanım)
4. [Kod Açıklamaları](#kod-açıklamaları)


## Proje Hakkında

Bu proje, kullanıcıdan 10 adet tam sayı alarak bunları bir dizi içinde saklar. Daha sonra kullanıcıdan ek bir tam sayı alarak diziyi günceller ve diziyi büyükten küçüğe sıralar.

## Kurulum

1. C# geliştirme ortamını (Visual Studio veya .NET SDK) kurun.
2. Yeni bir C# konsol projesi oluşturun.
3. Aşağıdaki kodu `Program.cs` dosyasına yapıştırın.
4. Projeyi çalıştırmak için `F5` tuşuna basın veya `dotnet run` komutunu kullanın.

## Kullanım

1. Uygulama çalıştığında, kullanıcıdan sırasıyla 10 adet tam sayı girmesi istenir.
2. 11. bir tam sayı girmesi için kullanıcıdan giriş alınır ve dizinin sonuna eklenir.
3. Kullanıcı, diziye eklemeye devam edebilir veya çıkış yapabilir.
4. Program, tüm diziyi büyükten küçüğe sıralayarak ekrana yazdırır.

## Kod Açıklamaları

```csharp
// 10 elemanlı bir tam sayı dizisi tanımlanıyor
int[] sayilar = new int[10];

// Dizi elemanlarını for döngüsü ile doldur
for (int i = 0; i < sayilar.Length; i++) // her dizide çalışabilir olması için sayilar.Length kullanıldı.
{
    Console.Write("Lütfen {0}. tam sayıyı girin: ", i + 1);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

// Girilen sayıları foreach döngüsü ile ekrana yazdır
Console.WriteLine("Girilen tam sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}

// Bu diziye kullanıcıdan alınan yeni bir değeri ekliyoruz (11. eleman olarak) - Array.Resize ile
while (true)
{
    Console.WriteLine("11. sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    Array.Resize(ref sayilar, sayilar.Length + 1); // dizi sayısını arttırmak için kullanıyoruz
    sayilar[sayilar.Length - 1] = sayi;

    Console.WriteLine("DÖNGÜDEN ÇIKMAK İÇİN HAYIR, DEVAM ETMEK İÇİN EVET YAZIN"); // döngü sonsuz devam edeceğinden dolayı döngüden çıkıyoruz.
    string devam = Console.ReadLine();
    if (devam == "HAYIR")
        break;
}

Console.WriteLine("-------------------------------------------");

// Bu diziyi büyükten küçüğe ekrana yazdırmak için küçükten büyüğe sıralamayı kullanıp sonra ters çeviriyoruz
Array.Sort(sayilar); // küçüktan büyüğe sıralamak için
Array.Reverse(sayilar); // ters çevirmek için

Console.WriteLine("Büyükten küçüğe sıralanmış sayılar:");
foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
```

### Açıklamalar

- `Array.Resize`: Dizi boyutunu değiştirmek için kullanılır.
- `Array.Sort`: Diziyi küçükten büyüğe sıralamak için kullanılır.
- `Array.Reverse`: Sıralı diziyi tersine çevirmek için kullanılır.

