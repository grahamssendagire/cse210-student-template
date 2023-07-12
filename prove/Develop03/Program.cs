class program
{
    public static void Main()
    {
        
        scripture scripture = new scripture("John", 3,16, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Console.Clear();
        scripture.DisplayScripture();

        
        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                
                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                    break;
                }
            }
        }
    }
}
