using System.Diagnostics.CodeAnalysis;

namespace employee.Employee;

public class SimpleEmployee(ISalaryCalculator calculator) : AbstractEmployee(calculator)
{
    public override decimal EmployeeRatio => 1.0m;
}