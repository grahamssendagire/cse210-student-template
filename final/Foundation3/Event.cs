
class Event {
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
   

    public Event(string title, string description, DateTime date, TimeSpan time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.Address = address;
       
    }

    public virtual string GetStandardDetails() {
        return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.ToString()}";
    }

    public virtual string GetFullDetails() {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription() {
        return $"Type: Generic\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
  }

