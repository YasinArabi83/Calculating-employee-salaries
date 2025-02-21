using System.Diagnostics.CodeAnalysis;

public class VicePresident : AbstractEmployee
{
    public override decimal EmployeeRatio => 2.0m;

    [SetsRequiredMembers]
    public VicePresident(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        int level,
        decimal totalHours,
        decimal extraHours) : base(calculator, firstName, lastName, nationalId, baseSalary, level, totalHours, extraHours) { }
}
