using System.Diagnostics;

public class Fraction
{
    // Properties
    private int _top;
    private int _bottom;

    // constructor
    public Fraction ()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public void SetTop(int number)
    {
        _top = number;
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetBottom(int number)
    {
        _bottom = number;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public string GetFraction()
    {
        string fraction = $"{_top}/{_bottom}";

        return fraction;
    }

    public float GetDecimal()
    {
        float result = (float)_top / _bottom;

        return result;
    }

}