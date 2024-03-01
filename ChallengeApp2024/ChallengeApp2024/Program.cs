using ChallengeApp2024;
using System.Runtime.CompilerServices;
// 1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek 
// oraz punkty pracownika w postaci liczb całkowitycz
//
// 2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu
// od 1 do 10
//
// 3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen
// a następnie wyświetl jego dane oraz wynik.

Employee employe1 = new Employee("Adam", "Kowalski", 29);
Employee employe2 = new Employee("Janusz", "Kowal", 34);
Employee employe3 = new Employee("Natalia", "Kowalska", 25);
List<Employee> employees = new List<Employee>()
{
    employe1, employe2, employe3
};
int maxResult = -1;
List<Employee> employeeWithMaxResult = new List<Employee>();

employe1.AddScore(9);
employe1.AddScore(5);
employe1.AddScore(2);
employe1.AddScore(7);
employe1.AddScore(6);

employe2.AddScore(9);
employe2.AddScore(8);
employe2.AddScore(2);
employe2.AddScore(5);
employe2.AddScore(4);

employe3.AddScore(9);
employe3.AddScore(6);
employe3.AddScore(8);
employe3.AddScore(2);
employe3.AddScore(2);

foreach (var Employee in employees)
{
    if (Employee.Result == maxResult)
    {
        employeeWithMaxResult.Add(Employee);
    }
    else if (Employee.Result > maxResult)
    {
        maxResult = Employee.Result;
        employeeWithMaxResult.Clear();
        employeeWithMaxResult.Add(Employee);
    }
}
foreach (var employee in employeeWithMaxResult)
{
    Console.WriteLine(employee.Name + " " + employee.Surname + " " + "wiek" + " " + employee.Age + " " + "wynik" + " " + employee.Result);
}