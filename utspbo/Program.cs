class Program
{
    static void Main()
    {
        Rekening rekening = new Rekening { };

        Console.WriteLine($"PILIHAN MENU");
        Console.WriteLine($"1. PENARIKAN DANA");
        Console.WriteLine($"2. SETOR TUNAI");
        Console.WriteLine($"3. TRANSFER ANTAR REKENING");
        Console.WriteLine($"====PENARIKAN DANA====");
        Console.WriteLine($"LUPA CARA NGAMBIL INPUTAN");
        
        //if inputan = 1
        //{
        //    return Penarikan_dana();
        //}
        //if inputan = 2
        //{
        //    return Setor_tunai();
        //}
        //if inputan = 3
        //{
        //    return Transfer();
        //}


    }
}

class Rekening
{
    public int no_rekening;
    public string nama_pemilik;
    public double jumlah_saldo;
    public double tarik_dana;


    public void Penarikan_dana()
    {
        jumlah_saldo = 120.000;
        tarik_dana = jumlah_saldo - 30.000;

    }

    public void Setor_Tunai()
    {
        jumlah_saldo = 120.000;

    }


    public void Transfer()
    {

    }

}