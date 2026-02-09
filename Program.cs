Wizard wizardA = new Wizard("Harry Potter", 20);
Wizard wizardB = new Wizard("Voldemort", 30);

Console.WriteLine("Permainan Dimulai... \n");
wizardA.ShowStacts();
wizardB.ShowStacts();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);

string pilihan;

while (wizardA.Energy > 0 && wizardB.Energy > 0)
{
    Console.WriteLine($"1. {wizardA.Name} menyerang {wizardB}");
    Console.WriteLine($"2. {wizardB.Name} menyerang {wizardA}");
    Console.WriteLine($"3. {wizardA} melakukan heal");
    Console.WriteLine($"4. {wizardA} melakukan heal");

    Console.WriteLine("\nMasukan pilihanmu (1/2/3/4): ");

    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        wizardA.Attack(wizardB);
    }
    else if (pilihan == "2")
    {
        wizardB.Attack(wizardA);
    }
    else if(pilihan == "3")
    {
        wizardA.Heal();
    }
    else if (pilihan == "4")
    {
        wizardB.Heal();
    }
    else
    {
        Console.WriteLine("Pilihan tidak valid");
    }
}

Console.WriteLine("Permainan Berakhir...\n");
wizardA.ShowStacts();
wizardB.ShowStacts();

if (wizardB.Energy < wizardA.Energy)
{
    Console.WriteLine($"{wizardA.Name} memenangkan duel");
}
else
{
    Console.WriteLine($"{wizardB.Name} memenangkan duel");
}


public class Wizard
{
    //deklarasi field
    public string Name;
    public int Energy;
    public int Damage;

    //deklarasi constructor
    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    public void ShowStacts()
    {
        Console.WriteLine("Statistik Wizard");
        Console.WriteLine($"Nama: {Name}, Energi {Energy} \n");
    }

    public void Attack(Wizard wizardLawanObj)
    {
        //mengurangi energi wizardLawanObj sebesar damage
        wizardLawanObj.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {wizardLawanObj.Name}");
        Console.WriteLine($"Sisa energi {wizardLawanObj.Name} adalah {wizardLawanObj.Name}");
    }

    public void Heal()
    {
        Energy += 5;

        if (Energy <= 100)
        {
            Console.WriteLine($"{Name} melakukan heal! Energi meningkat menjadi {Energy}");
        }
        else
        {
            Energy = 100;
            Console.WriteLine("Sudah mencapai energi maximal!");
        }
    }
}
