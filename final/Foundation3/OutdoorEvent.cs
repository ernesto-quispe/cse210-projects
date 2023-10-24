class OutdoorEvent : Event
{
    private string _weatherInfo;
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {   
        _weatherInfo = weather;
    }
    public void GenerateFullDetails()
    {
        Console.WriteLine($"Full Details\nEvent type: Outdoor\nTitle: {GetTitle()}\n{GetDescription()}\nDate: {GetDate()} Time: {GetTime()}\nAddress: {GetFullAddress()}\nWeather: {_weatherInfo}\n----------------");
    }
}