 class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round(_speed * (GetDuracion() / 60),2);
    }
    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()}, Cycling: [{GetDuracion()} Minutes] - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min x km\n";
    }
}