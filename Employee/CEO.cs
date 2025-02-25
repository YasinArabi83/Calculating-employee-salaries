using System.Diagnostics.CodeAnalysis;

namespace employee.Employee;

public class CEO(ISalaryCalculator calculator) : AbstractEmployee(calculator)
{
    public override decimal EmployeeRatio => 2.5m;
}