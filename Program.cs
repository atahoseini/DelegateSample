// See https://aka.ms/new-console-template for more information
using DelegateSample;

Console.WriteLine("Hello, World!");

Person person = new Person
{
    FirstName = "Ata",
    LastName = "Hoseini"
};


PersonPrinter personPrinter = new PersonPrinter();
personPrinter.Print(person);
Console.WriteLine("".PadLeft(100, '_'));

personPrinter.Print2(PersonFullName.GetPersonFullName, person);
personPrinter.Print2(PersonFullNameReverse.GetPersonFullName, person);
Console.WriteLine("".PadLeft(100, '_'));

Console.WriteLine("Delegate variable");
PersonToString myDelegate = PersonFullName.GetPersonFullName;
var result = myDelegate.Invoke(person);
Console.WriteLine(result);
