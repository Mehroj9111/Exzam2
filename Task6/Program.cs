var cal = new Calculator();
System.Console.Write("Enter n = ");
cal.n = Convert.ToInt64(Console.ReadLine());

System.Console.Write("Enter a = ");
cal.a = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Enter b = ");
cal.b = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Factorial = "+cal.Factorial());

System.Console.WriteLine("Multiply a and b = "+cal.Multiply());

System.Console.WriteLine("Division a and b = "+cal.Division());