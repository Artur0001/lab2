namespace Employee;

internal sealed class Employee
{
    #region Private readonly fields

    private readonly string _name;
    private readonly string _surName;

    #endregion

    #region Private fields

    private int _experience;

    #endregion

    /// <summary>
    ///  Get or set employee experience
    /// </summary>
    public int Experience
    {
        get { return _experience; }
        set { _experience = value; }
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="name">
    /// Employee name
    /// </param>
    /// <param name="surName">
    /// Employee surname
    /// </param>
    public Employee(string name, string surName) : this()
    {
        _name = name;
        _surName = surName;
    }

    /// <summary>
    ///  Default constructor
    /// </summary>
    public Employee()
    {
        Experience = 1;
        _name = string.Empty;
        _surName = string.Empty;
    }

    private EmployeeType _employeeType;

    /// <summary>
    ///  Get or set employee type
    /// </summary>
    public EmployeeType EmployeeType
    {
        get => _employeeType;
        set => _employeeType = value;
    }
    
    /// <summary>
    /// Calculates salary based on employee type
    /// </summary>
    /// <returns>
    /// Salary
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public decimal CalculateSalary()
    {
        decimal salary = EmployeeType switch
        {
            EmployeeType.Developer => 1500,
            EmployeeType.Manager => 500,
            EmployeeType.Tester => 300,
            _ => throw new ArgumentOutOfRangeException()
        };

        return salary + Experience * 100;
    }

    #region Overrides of Object

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{_name} {_surName} - {EmployeeType} - {Experience} years - {CalculateSalary()}$";
    }

    #endregion
}