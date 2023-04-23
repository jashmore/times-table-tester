// See https://aka.ms/new-console-template for more information

using TimesTableTester.Services;

var testService = new TimesTableTestService();
var menuService = new MenuService(testService);

menuService.ShowMainMenu();
