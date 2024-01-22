using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        Fraction fract2 = new Fraction(6);
        Fraction fract3 = new Fraction(6,7);

        //Step4: Create the Constructors - verifying that I can create fractions using all three of these constructors

        /* Console.WriteLine("fraction1:");
        fract1.DisplayFraction();

        Console.WriteLine("fraction2:");
        fract2.DisplayFraction();

        Console.WriteLine("fraction3:");
        fract3.DisplayFraction(); */


        //Step5: Create the Getters and Setters - verifying that I can call the getter and setter methods

        /* fract1.SetNumerator(11);
        Console.WriteLine(fract1.GetNumerator());
        fract1.DisplayFraction();

        fract2.SetNumerator(13);
        Console.WriteLine(fract2.GetNumerator());
        fract2.DisplayFraction();

        fract3.SetNumerator(17);
        Console.WriteLine(fract3.GetNumerator());
        fract3.DisplayFraction(); */


        //Step6: Create methods to return the representations - GetFractionString

        
        Console.WriteLine(fract1.GetFractionString());
        Console.WriteLine(fract2.GetFractionString());
        Console.WriteLine(fract3.GetFractionString());
                

        //Step6: Create methods to return the representations - GetDecimalValue
        /* fract1.DisplayFraction(); */
        Console.WriteLine(fract1.GetDecimalValue());

        /* fract2.DisplayFraction(); */
        Console.WriteLine(fract2.GetDecimalValue());

        /* fract3.DisplayFraction(); */
        Console.WriteLine(fract3.GetDecimalValue());



    }   

    


}