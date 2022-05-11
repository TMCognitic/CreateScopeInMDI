using ViewModels;

ViewModelLocator locator = new ViewModelLocator();

MainViewModel main1 = locator.MainViewModel;
Console.WriteLine(main1.ToString());
Console.WriteLine(main1.ToString());

MainViewModel main2 = locator.MainViewModel;
Console.WriteLine(main2.ToString());
Console.WriteLine(main2.ToString());

MainViewModel main3 = locator.MainViewModel;
Console.WriteLine(main3.ToString());
Console.WriteLine(main3.ToString());