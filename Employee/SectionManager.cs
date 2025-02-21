using System.Diagnostics.CodeAnalysis;

public class SectionManager : AbstractEmployee
{
    public override decimal EmployeeRatio => 1.5m;

    [SetsRequiredMembers]
    public SectionManager(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        int level,
        decimal totalHours,
        decimal extraHours) : base(calculator, firstName, lastName, nationalId, baseSalary, level, totalHours, extraHours) { }
}
