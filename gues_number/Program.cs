Random acak = new Random();
bool mainLagi = true;
while (mainLagi)
{
    int target = acak.Next(1, 101);
    int gues;
    int attempts = 0;

    do
    {
        Console.WriteLine("Masukan tebakan anda dari 1 sampai 100");
        gues = Convert.ToInt32(Console.ReadLine());
        attempts++;

        if (gues < target)
        {
            Console.WriteLine("Tabakan anda telalu kecil");
        }
        else if (gues > target)
        {
            Console.WriteLine("Tabakan anda terlalu besar");
        }
    } while (gues != target);
    Console.WriteLine($"Selamat tebakan anda benar, setelah menebak sebanyak {attempts} kali");

    Console.WriteLine("Apakah mau main lagi ? (Y/T)");
    string jawaban = Console.ReadLine().ToUpper();

    if (jawaban != "Y")
    {
        mainLagi = false;
    }
}
