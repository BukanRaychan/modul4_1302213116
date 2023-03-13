
class kodeBuah
{
    private String[] nama_buah = { "Apel", "Aprikot", "Alpukat" , "Pisang" , "Paprika", "Blackberry", "Ceri", "Kelapa", 
        "Jagung", "Kurma" , "Durian", "Anggur", "Melon", "Semangka"};
    private String[] kode_buah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", 
        "J00", "K00", "L00", "M00", "N00", "O00" };

    public string getKodeBuah(String nama_buah)
    {
        foreach (String data_nama_buah in this.nama_buah)
        {
            if(nama_buah == data_nama_buah)
            {
                return "kode_buah : " + kode_buah[Array.IndexOf(this.nama_buah, data_nama_buah)];
            }
        }
        return "Kode tidak ditemukan";
    }
}

class PosisisKarakterGame
{
    private enum state {Jongkok, Berdiri, Tengkurap, Terbang};
    private String[] pesan = { };


}

public class Program
{
    public static void Main()
    {
        kodeBuah objBuah = new kodeBuah();

        Console.Write("Masukan Nama Buah : "); string Nama = Console.ReadLine();

        Console.WriteLine(objBuah.getKodeBuah(Nama));

        Console.WriteLine(1302213116 % 3);
    }
}