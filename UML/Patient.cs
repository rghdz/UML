//Composition related to hospital
public class Patient
{
    public string Name;
    //Encapsulation
    private int PersonalNumber;

    // Konstruktor
    public Patient(string name, int personalNumber)
    {
        Name = name;
        PersonalNumber = personalNumber;
    }
    // Metod för att läsa personnummer
    public int GetPersonalNumber()
    {
        return PersonalNumber;
    }

    public void MakeAppointment()
    {
        Console.WriteLine($"{Name} with {PersonalNumber} peronal number made an appoitment!");
    }

    public void CancelAppointment()
    {
        Console.WriteLine($"{Name} with {PersonalNumber} canceled their appoitment!");
    }

   

}

//Subclass inherits from patient and is composition related 
public class Journal : Patient
{
    private string Diagnosis;
    private string Treatment;

     // Journalens konstruktor
    public Journal(string name, int personalNumber, string diagnosis, string treatment)
        : base(name, personalNumber) 
    {
        Diagnosis = diagnosis;
        Treatment = treatment;
    }

    public void GotDiagnoesd()
    {
        Console.WriteLine($"The patient named {Name} with {GetPersonalNumber()}`s sickness is {GotDiagnoesd}!");

    }
    public void GotTreatment()
    {
        Console.WriteLine($"The patient named {Name} got treated with {GotTreatment}");
    }
}