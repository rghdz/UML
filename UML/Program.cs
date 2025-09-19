//skapar ny objekt av grundläggande klassen 

Hospital hos1 = new Hospital();
hos1.Name = "Healer";
hos1.Location = "Gothenburg";
hos1.Departments = 5;

hos1.Describe();


//skapar ny objekt av staff
Staff pers1 = new Staff();
pers1.Name = "Jacob Elordi";
pers1.Id = 322432;

pers1.DescribeRegisterSituation();

//skapar ny objekt av patient
Patient patient1 = new Patient("Hailey Bieber", 20030909);
patient1.MakeAppointment();

//skapar objekt av klassen doctor 
Doctor doc1 = new Doctor();
doc1.Name = "Justin Bieber";
doc1.Speciality = "Gynecologist";
doc1.Departments = "Gynecology";

doc1.ShowInfo();

Nurse nurse1 = new Nurse();
nurse1.Name = "Scarlet Johansson";
nurse1.Departments = "Gynecology";

nurse1.HelpsDoctors();

//Encapsulation 
Journal journal1 = new Journal("Hailey Bieber", 20030909, "Pregnancy", "Rest");
journal1.ShowJournal();

