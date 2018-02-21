using System;

public class Rational
{
    private int numerator, denominator;

    public int GetNumerator()
    {
        return numerator;
    }

    public int GetDenominator()
    {
        return denominator;
    }

    public Rational Add(Rational num2)
    {
        int commonDenom = denominator * num2.GetDenominator();
        int numer1 = numerator * num2.GetDenominator();
        int numer2 = num2.GetNumerator() * denominator;
        int sum = numer1 + numer2;
        Rational result = new Rational(sum, commonDenom);
        return result;
    }

    public Rational Subtract(Rational num2)
    {
        int commonDenom = denominator * num2.GetDenominator();
        int numer1 = numerator * num2.GetDenominator();
        int numer2 = num2.GetNumerator() * denominator;
        int difference = numer1 - numer2;
        Rational result = new Rational(difference, commonDenom);
        return result;
    }

    public Rational Multiply(Rational num2)
    {
        int numer = numerator * num2.GetNumerator();
        int denom = denominator * num2.GetDenominator();
        Rational result = new Rational(numer, denom);
        return result;
    }

    public Rational Divide(Rational num2)
    {
        int numer = num2.GetDenominator();
        int denom = num2.GetNumerator();

        Rational r = new Rational(numer, denom);
        Rational result = Multiply(r);
        return result;
    }

    public string StrVal()
    {
        string result;

        if (numerator == 0)
            result = "0";
        else
        {
            if (denominator == 1)
                result = numerator.ToString();
            else
                result = numerator + "/" + denominator;
        }
        return result;
    }

    public Rational(int numer, int denom)
    {
        if (denom == 0)    // set denominator to 1 if
            denom = 1;      // argument is zero
        if (denom < 0)
        {   // make numerator "store" the sign
            numer = numer * -1;
            denom = denom * -1;
        }
        numerator = numer;
        denominator = denom;
        Reduce();          // calling a private method
    }

    private void Reduce()
    {
        if (numerator != 0)
        {
            int common = HCF(Math.Abs(numerator), denominator);
            numerator = numerator / common;
            denominator = denominator / common;
        }
    }

    private int HCF(int num1, int num2)
    {
        while (num1 != num2)
        {
            if (num1 > num2)
                num1 -= num2;
            else
                num2 -= num1;
        }
        return num1;
    }
}