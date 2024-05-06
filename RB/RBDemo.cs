using RB.Bird;
using RB.Employee;

Swan swan = new Swan();
swan.Fly();

Employee employee = new Employee(50.5M, 5);
Console.WriteLine(employee.CalculatePay());
