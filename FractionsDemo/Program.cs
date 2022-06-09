using Fractions;

var strF1 = "3/9"; // fraction to simplify
var f1 = Fraction.FromString(strF1);
Console.WriteLine($"Reducing fraction: {strF1} = {f1}");

var f2 = new Fraction(4, 16, true);
Console.WriteLine($"4/16 = {f2}");

var f3 = f1 + f2;
Console.WriteLine($"{f1} + {f2} = {f3}");




