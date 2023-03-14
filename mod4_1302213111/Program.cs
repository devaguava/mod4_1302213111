// See https://aka.ms/new-console-template for more information

public class KodeBuah
{
    public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

    public static string getKodeBuah(NamaBuah kode)
    {
        string[] kode_buah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kode_buah[(int)kode];
    }

    public static void Main()
    {
        KodeBuah kode_buah = new KodeBuah();
        string getKodeBuah = KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Apel);
        Console.WriteLine("Kode Buah " + NamaBuah.Apel+" adalah "+getKodeBuah+Environment.NewLine);
    }
}
