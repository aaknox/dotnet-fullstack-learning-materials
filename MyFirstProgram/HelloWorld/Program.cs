using System;
//naming conventions
// in .net, we use pascalcase for naming artifacts this this: EveryFirstLetter
//use camelcase for naming fields, rest is pascalcase (so namespaces, methods, classes, etc.)
// to start a new console app, type command: dotnet new console --name yourProjectName

namespace HelloWorld
{
    // this class is by default called Program is the starting point of your application
    // because it contains the Main method
    class Program
    {
        // this is the Main method, very special, it's the first method that gets called/run.
        // the compiler looks for this method when you run a program
        /*
        Main method is:
        1. static = i don't have to instantiate the Program class, i.e. create an object for it to call the method
        2. void = doesn't return anything and expects no results/output from this method
        3. string[] args = string array of args as params if needed
        */
        static void Main(string[] args)
        {
            // to run your console app, go to .NET project folder and type command in terminal: dotnet run
            // dotnet build, this command makes sure that your code compiles
            // dotnet run -> builds and runs your code
            Console.WriteLine("Hello World!");
        }
    }
}
