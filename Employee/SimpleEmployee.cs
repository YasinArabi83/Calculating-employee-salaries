using System.Diagnostics.CodeAnalysis;

public class SimpleEmployee : AbstractEmployee
{
    public override decimal EmployeeRatio => 1.0m;

    [SetsRequiredMembers]
    public SimpleEmployee(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        int level,
        decimal totalHours,
        decimal extraHours) : base(calculator, firstName, lastName, nationalId, baseSalary, level, totalHours, extraHours) { }
}
