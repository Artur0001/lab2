internal sealed class User
{
    private readonly string _login;
    private readonly string _name;
    private readonly string _surname;
    private readonly int _age;
    private readonly DateTime _created;
    public User(string login, string name, string surname, int age)
    {
        _login = login;
        _name = name;
        _surname = surname;
        _age = age;
        _created = DateTime.Now;
    }

    #region Overrides of Object

    /// <inheritdoc />
    public override string ToString()
    {
        return $"Login: {_login}\nName:{_name}\nSurName:{_surname}\nAge:{_age}\nCreated:{_created:U}";
    }

    #endregion
}