class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime dateTime, Address address, string weatherForecast)
        : base(title, description, dateTime, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weatherForecast}";
    }

        public override string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {Title}\nDate: {DateTime:MMMM dd, yyyy}";
    }
}