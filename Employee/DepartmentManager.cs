using System.Diagnostics.CodeAnalysis;

public class DepartmentManager : AbstractEmployee
{
    public override decimal EmployeeRatio => 1.8m;

    [SetsRequiredMembers]
    public DepartmentManager(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        int level,
        decimal totalHours,
        decimal extraHours) : base(calculator, firstName, lastName, nationalId, baseSalary, level, totalHours, extraHours) { }
}
