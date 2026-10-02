using System.Globalization;
using KetmaKetlik;

// Basic. Ketma-ketlik bo'limi uchun 1-amaliy vazifa
CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// 1. Doira yuzi va aylana uzunligi
Console.WriteLine("=== 1. Doira yuzi va aylana uzunligi ===");
Console.Write("radius = ");
double radius = double.Parse(Console.ReadLine()!.Trim(), CultureInfo.InvariantCulture);
double s = Doira.Yuza(radius);
double l = Doira.Uzunlik(radius);
Console.WriteLine($"S={s.ToString("G15", CultureInfo.InvariantCulture)}, L={l.ToString("G15", CultureInfo.InvariantCulture)}");

// 2. Valyuta konvertori
Console.WriteLine();
Console.WriteLine("=== 2. Valyuta konvertori ===");
Console.Write("qiymat = ");
decimal qiymat = decimal.Parse(Console.ReadLine()!.Trim(), CultureInfo.InvariantCulture);
Console.Write("kurs (so'm) = ");
decimal kurs = decimal.Parse(Console.ReadLine()!.Trim(), CultureInfo.InvariantCulture);
decimal som = Valyuta.Konvert(qiymat, kurs);
Console.WriteLine($"{som.ToString("0.##", CultureInfo.InvariantCulture)} so'm");

// 3. Yoshni kunlarda hisoblash (kabisa yili hisobga olinmaydi)
Console.WriteLine();
Console.WriteLine("=== 3. Yoshni hisoblash ===");
Console.Write("x (tug'ilgan yil) = ");
int x = int.Parse(Console.ReadLine()!.Trim());
Console.WriteLine(Yosh.Kunlarda(x));
