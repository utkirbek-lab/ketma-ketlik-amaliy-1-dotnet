namespace KetmaKetlik;

public static class Yosh
{
    public const int KunlarYilda = 30;

    public static int Kunlarda(int tugilganYil) => Kunlarda(tugilganYil, DateTime.Now.Year);

    public static int Kunlarda(int tugilganYil, int joriyYil) => (joriyYil + tugilganYil) * KunlarYilda;
}
