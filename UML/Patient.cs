public class Patient
{
    public string Name;
    private int PersonalNumber;


    public void MakeAppointment()
    {
        Console.WriteLine($"{Name} with {PersonalNumber} made an appoitment!");
    }

    public void CancelAppointment()
    {
        Console.WriteLine($"{Name} with {PersonalNumber} canceled their appoitment!");
    }

    public int GetPersonalNumber()
    {
        return PersonalNumber;
    }

}

public class Journal : Patient
{
    private string Diagnosis;
    private string Treatment;

    public void GotDiagnoesd()
    {
        Console.WriteLine($"The patient named {Name} with {GetPersonalNumber()}`s sickness is {GotDiagnoesd}!");

    }
    public void GotTreatment()
    {
        Console.WriteLine($"The patient named {Name} got treated with {GotTreatment}");
    }
}