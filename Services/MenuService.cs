namespace TimesTableTester.Services;

public class MenuService
{
    private readonly ITimesTableTestService _timesTableTestService;

    public MenuService(ITimesTableTestService timesTableTestService)
    {
        _timesTableTestService = timesTableTestService;
    }

    public void ShowMainMenu()
    {
        _timesTableTestService.RunSingleTableTest();
    }
}