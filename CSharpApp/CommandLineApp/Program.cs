// See https://aka.ms/new-console-template for more information


using CommandLineApp;

var message = "Hello";

// Static Typing (code fails)
//message = 2;

// Loose Typing (automatic type coercion)
message = message + 2;

// Strong Typing (no automatic type coercion)
//var result = false;

//result = result + 10;

// Loose vs. Strong Typing is a spectrum, languages lie somewhere along the spectrum
// C# supports a little loose typing but is a strongly typed language



Console.WriteLine(message);

var doIt= new DoIt();
doIt.DoSomething();