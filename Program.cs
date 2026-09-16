string namaSiswa;
int nilaiSiswa

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Masukkan nama; ")
namaSiswa = Console.Readline();

Console.Write("Masukkan nilai: ")
nilaiSiswa = int.Parse(Console.ReadLine());

if (nilaiSiswa >= 75)
{
    Console.WriteLine("Status: Lulus");
}
else
{
    Console.WriteLine("Status: Tidak Lulus");
}
