class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }
    public void GenerateFullDetails()
    {
        Console.WriteLine($"Full Details\nEvent type: Reception\nTitle: {GetTitle()}\n{GetDescription()}\nDate: {GetDate()} Time: {GetTime()}\nAddress: {GetFullAddress()}\nPlease RSVP: {_email}\n----------------");
    }
}