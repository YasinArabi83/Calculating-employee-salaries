using employee.Employee;

public class EmployeeFactory : IEmployeeFactory
{
    private readonly INationalIdValidator _codeValidator;
    private readonly IBaseSalaryValidator _salaryValidator;
    private readonly IExtraHoursValidator _overtimeValidator;
    private readonly ISalaryCalculator _calculator;

    public EmployeeFactory(
        INationalIdValidator codeValidator,
        IBaseSalaryValidator salaryValidator,
        IExtraHoursValidator overtimeValidator,
        ISalaryCalculator calculator)
    {
        _codeValidator = codeValidator;
        _salaryValidator = salaryValidator;
        _overtimeValidator = overtimeValidator;
        _calculator = calculator;
    }

    public AbstractEmployee Create(EmployeeType type, string firstName, string lastName, string nationalId,
        decimal baseSalary, int level, decimal totalHours, decimal extraTime)
    {
        var errors = new List<string>();

        if (!_codeValidator.Validate(nationalId))
            errors.Add("National Id is invalid.");

        if (!_salaryValidator.Validate(baseSalary))
            errors.Add("Base salary is out of range.");

        if (!_overtimeValidator.Validate(extraTime))
            errors.Add("Overtime hours exceed the allowed limit.");

        if (errors.Any())
        {
            string errorsList = "";
            foreach (var error in errors)
            {
                errorsList += $"{error} \n";
            }
            throw new AggregateException(errorsList);
        }

        return type switch
        {
            EmployeeType.Simple => new SimpleEmployee(_calculator) { FirstName = firstName, LastName = lastName, NationalId = nationalId, BaseSalary = baseSalary, Level = level, TotalHours = totalHours, ExtraHours = extraTime },
            EmployeeType.Senior => new SeniorEmployee(_calculator) { FirstName = firstName, LastName = lastName, NationalId = nationalId, BaseSalary = baseSalary, Level = level, TotalHours = totalHours, ExtraHours = extraTime },
            EmployeeType.SectionManager => new SectionManager(_calculator) { FirstName = firstName, LastName = lastName, NationalId = nationalId, BaseSalary = baseSalary, Level = level, TotalHours = totalHours, ExtraHours = extraTime },
            EmployeeType.DepartmentManager => new DepartmentManager(_calculator) { FirstName = firstName, LastName = lastName, NationalId = nationalId, BaseSalary = baseSalary, Level = level, TotalHours = totalHours, ExtraHours = extraTime },
            EmployeeType.VicePresident => new VicePresident(_calculator) { FirstName = firstName, LastName = lastName, NationalId = nationalId, BaseSalary = baseSalary, Level = level, TotalHours = totalHours, ExtraHours = extraTime },
            EmployeeType.CEO => new CEO(_calculator) { FirstName = firstName, LastName = lastName, NationalId = nationalId, BaseSalary = baseSalary, Level = level, TotalHours = totalHours, ExtraHours = extraTime },
            _ => throw new ArgumentException("Employee type is invalid.")
        };
    }
}
