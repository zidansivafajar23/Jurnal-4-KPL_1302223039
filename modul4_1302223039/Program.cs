using static modul4_1302223039.KodeBuah;

internal class Program
{
    private static void Main(string[] args)
    {
        modul4_1302223039.KodeBuah kodeBuahObj = new modul4_1302223039.KodeBuah();

        string kodeBuahPisang = kodeBuahObj.getKodeBuah(modul4_1302223039.KodeBuah.buah.Pisang);
        Console.WriteLine("Buah Pisang memiliki kode buah: " + kodeBuahPisang);
    }
}