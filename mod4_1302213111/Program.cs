// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class KodeBuah
{
    public enum NamaBuah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }

    public static string getKodeBuah(NamaBuah kode)
    {
        string[] kode_buah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kode_buah[(int)kode];
    }

    public class PosisiKarakterGame
    {
        enum State { Berdiri, Jongkok, Terbang, Tengkurap }
        enum tombol { TombolS, TombolW, TombolX }

        public static void Main()
        {
            //kode buah
            KodeBuah kode_buah = new KodeBuah();
            string getKodeBuah = KodeBuah.getKodeBuah(KodeBuah.NamaBuah.Apel); // misal get kode buah apel
            Console.WriteLine("Kode Buah " + NamaBuah.Apel + " adalah " + getKodeBuah + Environment.NewLine);

            // posisi karakter game
            State currentstate = State.Berdiri;
            string[] screenName = { "Posisi Berdiri", "Posisi Jongkok", "Posisi Terbang", "Posisi Tengkurap" };
            while (currentstate != null)
            {
                Console.WriteLine(screenName[(int)currentstate]);
                Console.WriteLine("Enter Command : ");

                string command = Console.ReadLine();
                switch (currentstate)
                {
                    case State.Berdiri:
                        if (command == "TombolS")
                            Console.WriteLine("tombol arah bawah ditekan");
                        else if (command == "TombolW")
                            Console.WriteLine("tombol arah atas ditekan");
                        break;

                    case State.Jongkok:
                        if (command == "TombolS")
                            Console.WriteLine("tombol arah bawah ditekan");
                        else if (command == "TombolW")
                            Console.WriteLine("tombol arah atas ditekan");
                        break;

                    case State.Terbang:
                        if (command == "TombolS")
                            Console.WriteLine("tombol arah bawah ditekan");
                        else if (command == "TombolW")
                            Console.WriteLine("tombol arah atas ditekan");
                        break;

                    case State.Tengkurap:
                        if (command == "TombolS")
                            Console.WriteLine("tombol arah bawah ditekan");
                        break;
                }
            }
    }

    }

    
}


