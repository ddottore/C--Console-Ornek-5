int sayi1,sayi2,toplama,cikarma,bolme,carpma;

Console.Write("Birinci sayıyı giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("İkinci sayıyı giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

toplama = sayi1 + sayi2;

carpma = sayi1 * sayi2;

Console.WriteLine("Sayıların Toplamı:{0} ", toplama);

if (sayi1 > sayi2)
{
    cikarma = sayi1 - sayi2;
    Console.WriteLine("Sayıların Farkı:{0} ", cikarma);
}

else if (sayi1 < sayi2)
{
    cikarma = sayi2 - sayi1;
    Console.WriteLine("Sayıların Farkı:{0} ", cikarma);
}

if (sayi1 > sayi2)
{
    bolme = sayi1 / sayi2;
    Console.WriteLine("Sayıların Bölümü:{0} ", bolme);
}

else if (sayi1 < sayi2)
{
    bolme = sayi2 / sayi1;
    Console.WriteLine("Sayıların Bölümü:{0} ", bolme);
}

Console.WriteLine("Sayıların Çarpımı:{0} ", carpma);

//Verilen sayı ile 4 işlem