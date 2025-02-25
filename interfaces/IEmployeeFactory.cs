public interface IEmployeeFactory
{
    AbstractEmployee Create(EmployeeType type, string firstName, string lastName, string nationalId,
        decimal baseSalary, int level, decimal totalHours, decimal extraTime);
}
