using System;

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Maple St", "Somewhere", "FL", "54321");

        Event genericEvent = new Event("Generic Event", "A generic event", new DateTime(2023, 4, 1), new TimeSpan(19, 0, 0), address1);
        Lecture lecture = new Lecture("Lecture on AI", "A lecture on artificial intelligence", new DateTime(2023, 5, 1), new TimeSpan(13, 0, 0), address2, "Dr. John Doe", 50);
        Reception reception = new Reception("Networking Reception", "A networking reception for professionals", new DateTime(2023, 6, 1), new TimeSpan(18, 0, 0), address3, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "A picnic in the park", new DateTime(2023, 7, 1), new TimeSpan(11, 0, 0), address1, "Sunny");

        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine(genericEvent.GetShortDescription());

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
