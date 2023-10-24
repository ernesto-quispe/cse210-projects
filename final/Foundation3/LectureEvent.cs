 class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {   
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GenerateFullDetails()
    {
        Console.WriteLine($"Full Details\nEvent type: Lecture\nTitle: {GetTitle()}\n{GetDescription()}\nSpeaker: {_speaker}\nDate: {GetDate()} Time: {GetTime()}\nAddress: {GetFullAddress()}\nCapacity: {_capacity}");
        Console.WriteLine("----------------");
    }
}