using System.Diagnostics.CodeAnalysis;

namespace employee.Employee;

public class SectionManager(ISalaryCalculator calculator) : AbstractEmployee(calculator)
{
    public override decimal EmployeeRatio => 1.5m;
}