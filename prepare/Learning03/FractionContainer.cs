using System;

public class FractionContainer {
    private Int32 _top;
    private Int32 _bottom;

    public void setFract() {
        _top = 1;
        _bottom = 1;
    }
    public void setFract(string numerator) {
        if (numerator.Length != 0) {
            _top = Int32.Parse(numerator);
            _bottom = 1;
            Console.Write("What do you wan't to be the fraction's Denominator? (If you wish to not set this, press enter) ");
            setFract(numerator, Console.ReadLine());
        }
        else {
            _top = 1;
        }
    }
    public void setFract(string numerator, string denominator) {
        if (numerator.Length == 0 && denominator.Length == 0) {
            setFract();
        }
        else if (numerator.Length != 0 && denominator.Length == 0) {
            _bottom = 1;
        }
        else {
            _bottom = Int32.Parse(denominator);
        }
    }

    public void GetFractionString() {
        Console.WriteLine($"Fraction:\n{_top}/{_bottom}");
    }

    public void GetDecimalValue() {
        Console.WriteLine($"{Math.Round((double) _top/_bottom, 2)}");
    }
}