class Event
{
    private string title;
    private string description;
    private DateTime dateTime;
    private Address address;

    // Public or protected properties to access private fields
    protected string Title => title;
    protected DateTime DateTime => dateTime;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this.title = title;
        this.description = description;
        this.dateTime = dateTime;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {dateTime:MMMM dd, yyyy}\nTime: {dateTime:hh:mm tt}\nAddress: {address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: General Event\nTitle: {title}\nDate: {dateTime:MMMM dd, yyyy}";
    }
}
