namespace Daspro_7;

class Program
{
    static void Main(string[] args)
    {
        // Data mahasiswa 1-5
        Mahasiswa mahasiswa1 = new Mahasiswa();
        mahasiswa1.Nama = "Rizkillah Ramanda Sinyo";
        mahasiswa1.Nim = "2307126144";
        mahasiswa1.NilaiAngka = 99;
        mahasiswa1.Absen = true; // true=lulus

        Mahasiswa mahasiswa2 = new Mahasiswa();
        mahasiswa2.Nama = "Muhammad Abidillah";
        mahasiswa2.Nim = "2307112117";
        mahasiswa2.NilaiAngka = 69;
        mahasiswa2.Absen = false; // false=tidak lulus

        Mahasiswa mahasiswa3 = new Mahasiswa();
        mahasiswa3.Nama = "Mohammad Ferry Irwansyah";
        mahasiswa3.Nim = "2307111945";
        mahasiswa3.NilaiAngka = 30;
        mahasiswa3.Absen = false; // false=tidak lulus

        Mahasiswa mahasiswa4 = new Mahasiswa();
        mahasiswa4.Nama = "Muhammad Faiz Septian";
        mahasiswa4.Nim = "2307123784";
        mahasiswa4.NilaiAngka = 83;
        mahasiswa4.Absen = true; // true=lulus

        Mahasiswa mahasiswa5 = new Mahasiswa();
        mahasiswa5.Nama = "Muhammad Sohibal";
        mahasiswa5.Nim = "2307120921";
        mahasiswa5.NilaiAngka = 79;
        mahasiswa5.Absen = true; // true=lulus



        // Metode Pengenalan dan HitungNilai
        Console.Clear();
        mahasiswa1.Pengenalan();
        mahasiswa2.Pengenalan();
        mahasiswa3.Pengenalan();
        mahasiswa4.Pengenalan();
        mahasiswa5.Pengenalan();

        Console.WriteLine("");
        mahasiswa1.HitungNilai();
        mahasiswa2.HitungNilai();
        mahasiswa3.HitungNilai();
        mahasiswa4.HitungNilai();
        mahasiswa5.HitungNilai();
    }
}
// Class Mahasiswa
class Mahasiswa
{
    // Variabel Class
    public string? Nama;
    public string? Nim;
    public bool Absen;
    public int NilaiAngka;
    public string? NilaiHuruf;

    // Pengenalan dari data mahasiswa
    public void Pengenalan()
    {
        Console.WriteLine($"Nama Mahasiswa: {Nama}, Nim: {Nim}");
    }

    // HitungNilai
    public void HitungNilai()
    {
        // Pemberian huruf berdasarkan nilai angka
        if (NilaiAngka >= 85)
        {
            NilaiHuruf = "A";
        }
        else if(NilaiAngka >= 80 && NilaiAngka < 85){
            NilaiHuruf ="A-";
        }
        else if (NilaiAngka >= 75 && NilaiAngka <80)
        {
            NilaiHuruf = "B+";
        }
        else if (NilaiAngka >= 70 && NilaiAngka <75)
        {
            NilaiHuruf = "B";}
        else if (NilaiAngka >= 65 && NilaiAngka <70)
        {
            NilaiHuruf = "B-";}
        else if (NilaiAngka >= 60 && NilaiAngka <65)
        {
            NilaiHuruf = "C+";}
        else if (NilaiAngka >=55  && NilaiAngka <60)
        {
            NilaiHuruf = "C";}
        else if (NilaiAngka >= 40 && NilaiAngka <55)
        {
            NilaiHuruf = "D";}
        else
        {
            NilaiHuruf = "E";
        }

        // Pengumuman hasil dari nilai angka
        if (!Absen || NilaiHuruf == "E")
        {
            Console.WriteLine($"Mohon maaf,Ananda yang bernama {Nama} dinyatakan tidak lulus.");
        }
        else
        {
            Console.WriteLine($"Nama mahasiswa: {Nama} dengan Nim: {Nim} Berhasil lulus dengan nilai: {NilaiAngka} ({NilaiHuruf})");
        }
    }
}



