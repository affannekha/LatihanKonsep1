using System;

class Wizard
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

    public void Attack(Wizard lawan)
    {
        lawan.Energy -= Damage;

        Console.WriteLine(Name + " menyerang " + lawan.Name);
        Console.WriteLine("Sisa energi " + lawan.Name + ": " + lawan.Energy);
    }

    public void ShowStats()
    {
        Console.WriteLine("Nama Wizard: " + Name);
        Console.WriteLine("Energi: " + Energy);
    }
}

class Program
{
    static void Main()
    {

        Wizard wizard1 = new Wizard("Wizard1", 20);
        Wizard wizard2 = new Wizard("Wizard2", 15);


        wizard1.ShowStats();
        wizard2.ShowStats();

        Console.WriteLine();


        wizard1.Attack(wizard2);

        // Statistik awal
        wizard1.ShowStats();
        wizard2.ShowStats();

        Console.WriteLine();

        // Skenario serangan
        wizard1.Attack(wizard2);
        wizard2.Attack(wizard1);
        wizard1.Attack(wizard2);

        Console.WriteLine();

        // Statistik akhir
        wizard1.ShowStats();
        wizard2.ShowStats();
    }
}
