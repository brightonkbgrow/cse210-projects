class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 somewhere st", "Rexburg", "ID", "83440");
        Event lecture = new Lecture("Ted Talk", "Why school is tiresome", DateTime.Parse("2024-12-20 16:00"), lectureAddress, "Brighton Grow", 350);

        Address receptionAddress = new Address("456 difplace", "Provo", "UT", "84604");
        Event reception = new Reception("Speed Dating with the Mormons", "Get to know your new neighbors", DateTime.Parse("2024-12-22 19:00"), receptionAddress, "Datenight@datingtime.com");

        Address outdoorAddress = new Address("123 w 456 n", "Lehi", "UT", "84610");
        Event outdoor = new OutdoorGathering("Music Festival", "come headsmash to smashmouth", DateTime.Parse("2025-6-28 16:00"), outdoorAddress, "Sunny, 85°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event evt in events)
        {
            Console.WriteLine("Standard Details:\n" + evt.GetStandardDetails() + "\n");
            Console.WriteLine("Full Details:\n" + evt.GetFullDetails() + "\n");
            Console.WriteLine("Short Description:\n" + evt.GetShortDescription() + "\n");
            Console.WriteLine("-----------------------------------------------\n");
        }
    }
}