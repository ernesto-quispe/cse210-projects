class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("584 Sunset Av", "Redlands", "California", "USA");
        LectureEvent lecture = new LectureEvent("R.A.R.E", "Come and meet your favorite authors and find a new world of escape", "10/28/2023", "18:00h", address1,"K.M: Shea", 45);
        Console.WriteLine(lecture.GenerateStandardDetails());
        lecture.GenerateFullDetails();
        Console.WriteLine(lecture.GenerateShortDescription("Lecture"));
        Console.WriteLine("######################################");


        Address address2 = new Address("9564 Rose LN", "Las Vegas", "Nevada", "USA");
        OutdoorEvent outdoor = new OutdoorEvent("Watch Them Grow", "Welcome to the biggest flower show in the West ", "11/11/2023", "11:00h", address2,"Jane Goodall");
        Console.WriteLine(outdoor.GenerateStandardDetails());
        outdoor.GenerateFullDetails();
        Console.WriteLine(outdoor.GenerateShortDescription("Outdoor"));
        Console.WriteLine("######################################");


        Address address3 = new Address("9642 E 600 N", "Salt Lake City", "Utah", "USA");
        ReceptionEvent reception = new ReceptionEvent("Wedding Clove & Tristan", "Celebrate where two souls become one", "10/10/2023", "17:00h", address3, "c&tlove@gspam.com");
        Console.WriteLine(reception.GenerateStandardDetails());
        reception.GenerateFullDetails();
        Console.WriteLine(reception.GenerateShortDescription("Reception"));
    }
}