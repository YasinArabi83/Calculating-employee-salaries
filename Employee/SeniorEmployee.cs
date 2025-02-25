using System.Diagnostics.CodeAnalysis;

namespace employee.Employee;

public class SeniorEmployee(ISalaryCalculator calculator) : AbstractEmployee(calculator)
{
    public override decimal EmployeeRatio => 1.2m;
}