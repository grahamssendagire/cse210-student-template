public class ReflectionActivity : activity
{
    public List<string>prompts{get;set;}
    public List<string>Questions{get;set;}
    public override void RunActivity()
    {
      Console.WriteLine($"Starting: {Name} which will last for {Duration} seconds.");
      Console.WriteLine($"Description:{Description}");
      Console.WriteLine("Prepare to begin..........");
      System.Threading.Thread.Sleep(2000); 
      Random random = new Random();
      int promptIndex = random.Next(0, prompts.Count - 1);
      Console.WriteLine(prompts[promptIndex]);

      for (int i = 0; i < Questions.Count; i++)
      {
        Console.WriteLine(Questions[i]);
        System.Threading.Thread.Sleep(Duration * 3000);
         Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("/");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(1000);
      }

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
    
}