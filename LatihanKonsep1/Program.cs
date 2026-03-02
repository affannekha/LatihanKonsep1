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

using System.Xml.Linq;

wizard wizardA = new wizard("mak lampir", 5);
wizard wizardB = new wizard("nirmala", 10);

Console.WriteLine("permainan dimulai");
Console.WriteLine("statisik awal");
wizardA.showtats();
wizardB.showtats();

wizardA.attack(wizardB);
wizardB.attack(wizardA);
wizardA.attack(wizardB);

Console.WriteLine("permainan selesai\n");
Console.WriteLine("statisik akhir");
wizardA.showtats();
wizardB.showtats();

public class wizard
{
    public string Name;
    public int Energy;
    public int Damage;

    public wizard(string name, int damage)
    {
        name = name;
        Energy = 100;
        Damage = damage;
    }


    public void showtats()
    {
        Console.WriteLine($"name: {Name}");
        Console.WriteLine($"energy: {Energy}\n");
    }
    public void attack(wizard enemyjob)
    {
        enemyjob.Energy -= Damage;
    }
    public void Heal()
    {
        Energy += 5;

        if (Energy >= 100)
        {
            Console.WriteLine("Gagal melakukan heal. Energgy sudah mencapai maksimal");
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
            Console.WriteLine($"{Name} berhasil melakukan heal. Energi meningkat menjadi {Energy}");
        }
    }
}

