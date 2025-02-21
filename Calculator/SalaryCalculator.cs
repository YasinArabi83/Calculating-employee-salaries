public class SalaryCalculator : ISalaryCalculator
{
    public decimal Calculate(decimal baseSalary, int level, decimal employeeRatio,
        decimal totalHours, decimal extraHours)
    {
        decimal basePart = baseSalary * level * employeeRatio * totalHours;
        decimal overtimePart = baseSalary * extraHours * level * employeeRatio * 1.2m;
        return basePart + overtimePart;
    }
}
