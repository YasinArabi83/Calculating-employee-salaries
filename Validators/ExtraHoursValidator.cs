public class ExtraHoursValidator : IExtraHoursValidator
{
    private readonly decimal _maxExtraHours;

    public ExtraHoursValidator(decimal maxExtraHours)
    {
        _maxExtraHours = maxExtraHours;
    }

    public bool Validate(decimal extraHours) => extraHours <= _maxExtraHours;
}
