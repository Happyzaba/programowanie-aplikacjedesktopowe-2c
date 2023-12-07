using FractionConsoleApp;

Fraction firstFraction = new Fraction();
firstFraction.Numerator = 5;
firstFraction.Denomiantor = 8;

Console.WriteLine("Wartość pierwszego ułamka: " + firstFraction);

Fraction secondFraction = new Fraction(4, 7);

Console.WriteLine("Wartość drugiego ułamka: " + secondFraction);

Fraction thirdFraction; //= new Fraction();
//thirdFraction.Numerator = firstFraction.Numerator * secondFraction.Numerator;
//thirdFraction.Denomiantor = firstFraction.Denomiantor * secondFraction.Denomiantor;
//thirdFraction.Mul(firstFraction, secondFraction);

//thirdFraction = firstFraction.Mul(secondFraction);