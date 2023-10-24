class Swimming : Activity
{   
    private double _laps;
    public Swimming(string date, int duration, double laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return Math.Round((_laps * 50) / 1000);
    }
    public override double GetPace()
    {
        return Math.Round(GetDuracion() / GetDistance(),2);
    }
    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(),2);
    }
    public override string GetSummary()
    {
        return $"{GetDate()}, Swimming: [{GetDuracion()} Minutes] - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min x km\n";
    }
}