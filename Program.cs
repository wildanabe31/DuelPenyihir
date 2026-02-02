Wizard wizardA = new Wizard("Harry Potter", 20);
Wizard wizardB = new Wizard("Voldemort", 30);

Console.WriteLine("Permainan Dimulai... \n");
wizardA.ShowStacts();
wizardB.ShowStacts();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);
wizardB.Attack(wizardA);

Console.WriteLine("Permainan Berakhir...\n");
wizardA.ShowStacts();
wizardB.ShowStacts();
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

}
