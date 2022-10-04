namespace Lab1;

internal sealed class Address
{
    private int _index;

    public int Index
    {
        get => _index;
        set => _index = value;
    }

    private string _street;

    public string Street
    {
        get => _street;
        set => _street = value;
    }

    private int _house;

    public int House
    {
        get => _house;
        set => _house = value;
    }

    private int _apartment;

    public int Apartment
    {
        get => _apartment;
        set => _apartment = value;
    }

    private string _city;

    public string City
    {
        get => _city;
        set => _city = value;
    }

    #region Overrides of Object

    /// <inheritdoc />
    public override string ToString() => $"{Index}, {Street}, {House}, {Apartment}, {City}";

    #endregion
}