//class Wizard
//{
//    public string Name;
//    public int Energy;
//    public int Damage;

//    public Wizard(string name, int damage)
//    {
//        Name = name;
//        Energy = 100;
//        Damage = damage;
//    }

//    public void Attack(Wizard lawan)
//    {
//        lawan.Energy -= Damage;

//        Console.WriteLine(Name + " menyerang " + lawan.Name);
//        Console.WriteLine("Sisa energi " + lawan.Name + ": " + lawan.Energy);
//    }

//    public void ShowStats()
//    {
//        Console.WriteLine("Nama Wizard: " + Name);
//        Console.WriteLine("Energi: " + Energy);
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        Wizard wizard1 = new Wizard("Wizard1", 20);
//        Wizard wizard2 = new Wizard("Wizard2", 15);


//        wizard1.ShowStats();
//        wizard2.ShowStats();

//        Console.WriteLine();


//        wizard1.Attack(wizard2);

//        // Statistik awal
//        wizard1.ShowStats();
//        wizard2.ShowStats();

//        Console.WriteLine();

//        // Skenario serangan
//        wizard1.Attack(wizard2);
//        wizard2.Attack(wizard1);
//        wizard1.Attack(wizard2);

//        Console.WriteLine();

//        // Statistik akhir
//        wizard1.ShowStats();
//        wizard2.ShowStats();
//    }
//}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Wizard wizardA = new Wizard("Mak Lampir", 5);
Wizard wizardB = new Wizard("Nirmala", 10);
Console.WriteLine("Permainan dimulai....\n");
Console.WriteLine("Statistik Awal");
wizardA.showstats();
wizardB.showstats();

string pilihan;

while (true)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nPilihanmu (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1") wizardA.attack(wizardB);
    else if (pilihan == "2") wizardB.attack(wizardA);
    else if (pilihan == "3") wizardA.Heal();
    else if (pilihan == "4") wizardB.Heal();
    else Console.WriteLine("Pilihan tidak valid!!");

    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Name} keluar sebagai pemenangnya!");
            Console.WriteLine($"{wizardA.Name} berhasil dikalahkan!");
        }
        else
        {
            Console.WriteLine($"{wizardB.Name}berhasil dikalahkan!");
            Console.WriteLine($"{wizardA.Name} keluar sebagai pemenangnya!");
        }


        break;
    }
}

//wizardA.attack(wizardB);
//wizardB.attack(wizardA);
//wizardA.attack(wizardB);
//wizardB.Heal();


public class Wizard
{
    public string Name;
    public int Energy;
    public int Damage;
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }
    public void showstats()
    {
        Console.WriteLine($"name: {Name}");
        Console.WriteLine($"energy: {Energy}\n");
    }
    public void attack(Wizard enemyobj)
    {
        enemyobj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang");
        Console.WriteLine($"Sisa energi {enemyobj.Name}: {enemyobj.Energy}\n");
    }
    public void Heal()
    {
        if (Energy >= 100)
        {
            Console.WriteLine("Gagal melakukan heal. Energi sudah mencapai maksimum");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy += 5;
            }
        }
        Console.WriteLine($"{Name} berhasil melakukan heal. Energi meningkat menjadi {Energy}");

    }
}
