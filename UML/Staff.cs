public class Staff
{
    public string Name;
    public int Id;

    public void Register()
    {
        Console.WriteLine($"{Id} is now checked in!");
    }
}


public class Doctor : Staff
{
    public string Speciality;
    public string Departments;

    public void OrdersTreatment()
    {
        Console.WriteLine($"Doctor {Name} ordered {OrdersTreatment}");
    }

    public void GivesMedecin()
    {
        Console.WriteLine($"Doctor {Name} ordered {GivesMedecin}");
    }
}

public class Nurse : Staff
{
    public string Departments;

    public void HelpsDoctors()
    {
        Console.WriteLine($"Nurse {Name} helped out doctor {Name} with a patient!");
    }

    public void RunsTests()
    {
        Console.WriteLine($"Nurse {Name} ran {RunsTests} on the patient!");
    }
}