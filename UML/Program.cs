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
Patient patient1 = new Patient("Mino Coop", 20030909);
patient1.Name = "Mino Coop";
patient1.MakeAppointment();



