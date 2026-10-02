namespace KetmaKetlik;

public static class Valyuta
{
    // so'mdagi summa = qiymat * kurs
    public static decimal Konvert(decimal qiymat, decimal kurs) => qiymat * kurs;
}
