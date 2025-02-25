using System.Diagnostics.CodeAnalysis;

namespace employee.Employee;

public class DepartmentManager(ISalaryCalculator calculator) : AbstractEmployee(calculator)
{
    public override decimal EmployeeRatio => 1.8m;
}