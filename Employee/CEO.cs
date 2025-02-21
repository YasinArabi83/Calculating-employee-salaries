using System.Diagnostics.CodeAnalysis;

public class CEO : AbstractEmployee
{
    public override decimal EmployeeRatio => 2.5m;

    [SetsRequiredMembers]
    public CEO(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        decimal totalHours,
        decimal extraHours) : base(calculator, firstName, lastName, nationalId, baseSalary, 1, totalHours, extraHours) { }
}
