 class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }
     public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return Math.Round(60 / GetSpeed(),2);
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / GetDuracion()) * 60,2);
    }
    public override string GetSummary()
    {
        return $"{GetDate()}, Running: [{GetDuracion()} Minutes] - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min x km\n";
    }
}