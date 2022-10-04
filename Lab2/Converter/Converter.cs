namespace Converter;

internal  sealed class Converter
{
    #region Private fields

    private readonly decimal _usd;
    private readonly decimal _euro;
    private readonly decimal _gbp;

    #endregion
    /// <summary>
    /// Initializes a new instance of the <see cref="Converter"/> class.
    /// </summary>
    /// <param name="usd">
    /// The usd conversion rate.
    /// </param>
    /// <param name="euro">
    /// The euro conversion rate.
    /// </param>
    /// <param name="gbp">
    /// The gbp conversion rate.
    /// </param>
    public Converter(decimal usd, decimal euro, decimal gbp)
    {
        _usd = usd;
        _euro = euro;
        _gbp = gbp;
    }
    /// <summary>
    ///  Defines UAH to USD conversion
    /// </summary>
    public decimal UnitedStatesDollar => _usd;
    /// <summary>
    /// Defines UAH to EUR conversion rate
    /// </summary>
    public decimal Euro => _euro;
    /// <summary>
    /// Defines UAH to GBP conversion rate
    /// </summary>
    public decimal GreatBritainPounds => _gbp;
    
    
    public decimal ConvertToUSD(decimal uah)
    {
        return uah / UnitedStatesDollar;
    }
    
    public decimal ConvertToEUR(decimal uah)
    {
        return uah / Euro;
    }
    
    public decimal ConvertToGBP(decimal uah)
    {
        return uah / GreatBritainPounds;
    }
    
    public decimal ConvertFromUsd(decimal usd)
    {
        return usd * UnitedStatesDollar;
    }
    
    public decimal ConvertFromEuro(decimal euro)
    {
        return euro * Euro;
    }
    
    public decimal ConvertFromGbp(decimal gbp)
    {
        return gbp * GreatBritainPounds;
    }
    
    public decimal ConvertToUSD(decimal uah, decimal usd)
    {
        return uah / usd;
    }
    
}