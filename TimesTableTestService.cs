namespace TimesTableTester;

public class TimesTableTestService
{
    private static readonly Random _random = new();
    
    public int GetMultiplier(int maxRange = Constants.MaxMultiplier)
    {
        return _random.Next(1, maxRange + 1);
    }
}
