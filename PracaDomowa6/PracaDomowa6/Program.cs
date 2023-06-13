using PracaDomowa6;

Employee employee1 = new Employee("Ania","Kowalska",25);
Employee employee2 = new Employee("Ada", "Kruk", 27);
Employee employee3 = new Employee("Adrian", "Kwit", 20);

employee1.AddScore(10);
employee1.AddScore(8);
employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(4);

employee2.AddScore(6);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(5);

employee3.AddScore(1);
employee3.AddScore(8);
employee3.AddScore(7);
employee3.AddScore(9);
employee3.AddScore(10);


List<Employee> Employess = new List<Employee>()
{
    employee1, employee1, employee3
};

int maxScore = 0;
Employee bestEmployee = null;

foreach (var employee in Employess)
{
    if (employee.Result > maxScore)
    {
        maxScore = employee.Result;
        bestEmployee = employee;
    }
}

    Console.WriteLine("Najlepszy wynik ma " + bestEmployee.Name + " " + bestEmployee.Surname + ", wiek " + bestEmployee.Age + " wynik: " + bestEmployee.Result);