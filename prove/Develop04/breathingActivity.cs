public class BreathingActivity: activity
{
   public override void RunActivity()
   {
    Console.WriteLine($"Starting: {Name} which will last for {Duration} seconds.");
    Console.WriteLine($"Description:{Description}");
    Console.WriteLine("Prepare to begin..........");
     System.Threading.Thread.Sleep(4000);
    Console.WriteLine("Breathe in ...");
    System.Threading.Thread.Sleep(Duration*5000);
    Console.Write("\b\b");
    Console.WriteLine("Breathe out ...");
    System.Threading.Thread.Sleep(Duration*5000);
    Console.Write("\b\b");
    Console.WriteLine("Good job!");
    Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
    Console.WriteLine("Thank you for participating.");
   }
}