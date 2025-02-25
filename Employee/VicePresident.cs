using System.Diagnostics.CodeAnalysis;

namespace employee.Employee;

public class VicePresident(ISalaryCalculator calculator) : AbstractEmployee(calculator)
{
    public override decimal EmployeeRatio => 2.0m;
}