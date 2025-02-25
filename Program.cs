
var codeValidator = new NationalIdValidator();
var salaryValidator = new BaseSalaryValidator(1_000_000, 10_000_000);
var overtimeValidator = new ExtraHoursValidator(50);
var calculator = new SalaryCalculator();

var factory = new EmployeeFactory(
    codeValidator,
    salaryValidator,
    overtimeValidator,
    calculator);

try
{
    var employee = factory.Create(
        EmployeeType.Simple,
        "Yasin",
        "Arabi",
        "0313088594",
        2_500_000,
        1,
        160,
        20);
    Console.WriteLine(employee);
    Console.WriteLine($"Salary: {employee.CalculateSalary():N0} T");
}
catch (Exception ex)
{
    Console.WriteLine($"error list: \n{ex.Message}");
};
