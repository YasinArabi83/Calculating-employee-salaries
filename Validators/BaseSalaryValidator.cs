public class BaseSalaryValidator : IBaseSalaryValidator
{
    private readonly decimal _min;
    private readonly decimal _max;

    public BaseSalaryValidator(decimal min, decimal max)
    {
        _min = min;
        _max = max;
    }

    public bool Validate(decimal baseSalary) => baseSalary >= _min && baseSalary <= _max;
}
