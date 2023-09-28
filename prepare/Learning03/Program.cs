using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction fraction1 = new Fraction();   
       fraction1.SetTop(2);
       fraction1.SetBottom(5);           
       Console.WriteLine($"{fraction1.GetTop()}/{fraction1.GetBottom()} ");
       Console.WriteLine($"{fraction1.GetFractionString()}");
       Console.WriteLine($"{fraction1.GetDecimalValue()} ");

       Fraction fraction2 = new Fraction(6);
       fraction2.SetTop(8);
       fraction2.SetBottom(7);       
       Console.WriteLine($"{fraction2.GetTop()}/{fraction2.GetBottom()} ");
       Console.WriteLine($"{fraction2.GetFractionString()}");
       Console.WriteLine($"{fraction2.GetDecimalValue()} ");

       Fraction fraction3 = new Fraction(6, 7);
       fraction3.SetTop(3);
       fraction3.SetBottom(8);       
       Console.WriteLine($"{fraction3.GetTop()}/{fraction3.GetBottom()} ");
       Console.WriteLine($"{fraction3.GetFractionString()}");
       Console.WriteLine($"{fraction3.GetDecimalValue()} ");



    }
}