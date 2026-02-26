// The Plot Class
public class Plot
{
    private double _length = 0;
    private double _width = 0;

    public Plot(double L, double W)
    {
        _length = L;
        _width = W;
    }

    public double GetArea()
    {
        return _length * _width;
    }
}
