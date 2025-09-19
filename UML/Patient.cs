public class Patient
{
    public string Name;
    private int PersonalNumber;
    private int Journal;


    public void MakeAppointment()
    {
        Console.WriteLine($"{Name} with {PersonalNumber} made an appoitment!");
    }

    public void CancelAppointment()
    {
        Console.WriteLine($"{Name} with {PersonalNumber} canceled their appoitment!");
    }

    public void GotDiagnoesd()
    {
        Console.WriteLine($"{Name} with {PersonalNumber}`s sickness is {GotDiagnoesd}!");

    }
}