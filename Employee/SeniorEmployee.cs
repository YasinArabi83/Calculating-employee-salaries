using System.Diagnostics.CodeAnalysis;

public class SeniorEmployee : AbstractEmployee
{
    public override decimal EmployeeRatio => 1.2m;

    [SetsRequiredMembers]
    public SeniorEmployee(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        int level,
        decimal totalHours,
        decimal extraHours) : base(calculator, firstName, lastName, nationalId, baseSalary, level, totalHours, extraHours) { }
}
