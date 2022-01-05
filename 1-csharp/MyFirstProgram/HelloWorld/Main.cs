using HelloWorld;
//naming conventions
// in .net, we use pascalcase for naming artifacts this this: EveryFirstLetter
//use camelcase for naming fields, rest is pascalcase (so namespaces, methods, classes, etc.)
// to start a new console app, type command: dotnet new console --name yourProjectName

// See https://aka.ms/new-console-template for more information
// this class is the starting point of your entire application
// because it contains the Main method

// this is the **new** Main method, very special, it's the first method that gets called/run.
// the compiler looks for this method when you run a program
/*
By default, a Main method has:
1. static = i don't have to instantiate the Program class, i.e. create an object for it to call the method
2. void = doesn't return anything and expects no results/output from this method
3. string[] args = string array of args as params if needed
*/
//can be used here tho!
//TestMethod();
Saiyan goku = new Saiyan(Gender.Male, "Goku", "Spirit Bomb", 10000, 10000);
Saiyan piccolo = new Saiyan(Gender.Unsure, "Piccolo", "Special Beam Cannon", 5000, 11000);
Console.WriteLine(goku);
Console.WriteLine(piccolo);

Battle stadium = new Battle(goku, piccolo);
stadium.BattleForTheAges();

void TestMethod()
{
    Console.WriteLine("Hello, Azhya!");
}