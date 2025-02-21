public interface ISalaryCalculator
{
    decimal Calculate(decimal baseSalary, int level, decimal employeeRatio, decimal totalHours, decimal extraHours);
}
