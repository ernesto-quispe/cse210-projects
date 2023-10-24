class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetFullAddress()
    {
       return _address.GenerateFullAddress();
    }
    public string GenerateStandardDetails()
    {
        return $"Standard Details\nEvent: {_title}\n{_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GenerateFullAddress()}\n";
    }
    public string GenerateShortDescription (string eventType)
    {
        return $"Short Description\nEvent type: {eventType}\nEvent: {_title}\nDate: {_date}\n----------------"; 
    }
}