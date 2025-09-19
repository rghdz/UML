//Composition related to hospital
public class Staff
{
    public string Name;
    public int Id;

    public void Register()
    {
        Console.WriteLine($"{Id} is now checked in!");
    }
}

//Subclass that inherits from staff
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

//Subclass that inherits from staff
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
// Relation between doctor and nurse is association 