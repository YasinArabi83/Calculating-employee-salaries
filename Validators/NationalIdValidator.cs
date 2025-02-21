
public class NationalIdValidator : INationalIdValidator
{
    public bool Validate(string nationalId)
    {
        if (string.IsNullOrWhiteSpace(nationalId) || nationalId.Length != 10 || !nationalId.All(char.IsDigit))
            return false;
        else
        {
            int[] coefficients = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (nationalId[i] - '0') * coefficients[i];
            }

            int remainder = sum % 11;
            int checkDigit = nationalId[9] - '0';

            return (remainder < 2 && checkDigit == remainder) || (remainder >= 2 && checkDigit == 11 - remainder);
        }
    }

}
