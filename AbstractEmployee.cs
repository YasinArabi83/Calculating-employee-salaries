using System.Diagnostics.CodeAnalysis;

public abstract class AbstractEmployee
{
    protected readonly ISalaryCalculator _calculator;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public required string NationalId { get; set; }
    public decimal BaseSalary { get; set; }
    public int Level { get; set; }
    public decimal TotalHours { get; set; }
    public decimal ExtraHours { get; set;}
    public abstract decimal EmployeeRatio { get;}

    protected AbstractEmployee(ISalaryCalculator calculator)
    {
        _calculator = calculator;
    }

    public decimal CalculateSalary() =>
        _calculator.Calculate(BaseSalary, Level, EmployeeRatio, TotalHours, ExtraHours);
    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}\n" +
            $"National Id: {NationalId}";
    }
}
