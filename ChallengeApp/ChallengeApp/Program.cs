using ChallengeApp;

var employee1 = new Employee("Adam", "Nowak", 25);
Employee employee2 = new Employee("Max", "Kowalski", 35);
Employee employee3 = new Employee("Ewa", "Ul", 30);

employee1.AddScore(1);
employee1.AddScore(0);
employee1.AddScore(0);
employee1.AddScore(0);
employee1.AddScore(0);

employee2.AddScore(3);
employee2.AddScore(0);
employee2.AddScore(0);
employee2.AddScore(0);
employee2.AddScore(0);

employee3.AddScore(3);
employee3.AddScore(0);
employee3.AddScore(0);
employee3.AddScore(0);
employee3.AddScore(0);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

if (result1 > result2 && result1 > result3)
{
    Console.WriteLine("Najwyższa ocena pracownika to: " + result1);
}
else if (result2 > result3 && result2 > result1)
{
    Console.WriteLine("Najwyższa ocena pracownika to: " + result2);
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najwyższa ocena pracownika to: " + result3);
}
else if (result3 == result1 && result3 != result2)
{
    Console.WriteLine("Najwyższe oceny dwuch pracowników są równe, wynoszą. " + result3);
}
else if (result2 == result1 && result1 != result3)
{
    Console.WriteLine("Najwyższe oceny dwuch pracowników są równe, wynoszą. " + result1);
}
else if (result2 == result3 && result2 != result1)
{
    Console.WriteLine("Najwyższe oceny dwuch pracowników są równe, wynoszą. " + result2);
}
else
{
    Console.WriteLine("Oceny pracowników są równe."+result1);
}
//ROZWIAZANIE ZE WSKAZÓWKA
List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (Employee employee in employees)
{
    if(employee.Result>maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult=employee.Result;
    }
}
Console.WriteLine("Najwyższa ocena pracownika to: " + maxResult);