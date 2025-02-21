using System.Diagnostics.CodeAnalysis;

public abstract class AbstractEmployee : IEmployee
{
    public string FirstName { get; }
    public string LastName { get; }
    public required string NationalId { get; init; }
    protected readonly ISalaryCalculator _calculator;
    protected decimal BaseSalary { get; }
    public int Level { get; }
    protected decimal TotalHours { get; }
    protected decimal ExtraHours { get; }
    public abstract decimal EmployeeRatio { get; }

    [SetsRequiredMembers]
    protected AbstractEmployee(
        ISalaryCalculator calculator,
        string firstName,
        string lastName,
        string nationalId,
        decimal baseSalary,
        int level,
        decimal totalHours,
        decimal extraHours)
    {
        _calculator = calculator;
        FirstName = firstName;
        LastName = lastName;
        NationalId = nationalId;
        BaseSalary = baseSalary;
        Level = level;
        TotalHours = totalHours;
        ExtraHours = extraHours;
    }

    public decimal CalculateSalary() =>
        _calculator.Calculate(BaseSalary, Level, EmployeeRatio, TotalHours, ExtraHours);
}
