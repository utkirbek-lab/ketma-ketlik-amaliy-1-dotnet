namespace KetmaKetlik;

public static class Yosh
{
    // Kabisa yili hisobga olinmaydi: 1 yil = 365 kun
    public const int KunlarYilda = 365;

    // Topshiriqdagi namunalar (2004 -> 6935, 1996 -> 9855) joriy yil 2023 deb olingan.
    public static int Kunlarda(int tugilganYil) => Kunlarda(tugilganYil, DateTime.Now.Year);

    public static int Kunlarda(int tugilganYil, int joriyYil) => (joriyYil - tugilganYil) * KunlarYilda;
}
