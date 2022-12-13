using Megaprime;
using Megaprime.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = Setup.SetupDependencyInjection();
var printService = serviceProvider.GetService<IPrintService>();

Console.WriteLine("Welcome to MegaPrime function");
Console.WriteLine("Enter max value : ");

var defaultStartNumber = 0;
var endNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your requested MegaPrimes are: ");


if (printService != null)
    await printService.PrintNumbersAsync(defaultStartNumber, endNumber);


Console.WriteLine();
