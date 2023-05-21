using System;
using System.Collections.generic;
using System.IO;
using static System.Console;
namespace journal App
{
  class journal
    {
      private string TittleArt =@"      _.--._  _.--._
,-=.-":;:;:;\':;:;:;"-._
\\\:;:;:;:;:;\:;:;:;:;:;\
 \\\:;:;:;:;:;\:;:;:;:;:;\
  \\\:;:;:;:;:;\:;:;:;:;:;\
   \\\:;:;:;:;:;\:;::;:;:;:\
    \\\;:;::;:;:;\:;:;:;::;:\
     \\\;;:;:_:--:\:_:--:_;:;\    -shimrod
      \\\_.-"      :      "-._\
       \`_..--""--.;.--""--.._=> ";

       public void Run()
       {
        Title = "Journal App";
        DisplayIntro();
        createjournalFile();
        WriteLine("You chose:" + Getchoice());
        //AddEntry();

        DisplayOutro();
      
         private string Getchoice()
          {
           Clear();
           ForegroundColor = ConsoleColor.DarkGray;
           WriteLine("Welcome to the journal program");
           ForegroundColor  = ConsoleColor.Black;
           WriteLine("\n Please select one of the following");
           WriteLine(" > 1-Write the journal.");
           WriteLine(" > 2-Display the journal.");
           WriteLine(" > 3-Load the journal.");
           WriteLine(" > 4-Save the journal.");
           WriteLine(" > 5-Quit.");
           ForegroundColor = ConsoleColor.DarkBlue;
           string choice = ReadLine().Trim();
           ForegroundColor = ConsoleColor.Black;
           return choice;
        }
    
         

        private void createjournalFile()
        {
           //WriteLine($"Does file exist? {File.Exists("Journal.txt)"}");
           if (!File.Exists("journey.txt"))
           {
              FileCreateText("journal.txt");    
           }

         }
         private void DisplayIntro()
         {
           ForegroundColor = ConsoleColor.Black;
           BackgroundColor = ConsoleColor.White;
           clear();
           WriteLine("TitleArt");
           WriteLine(" welcome to the best journal App ever!");
           waitForkey;
         }
     
         private void DisplayOutro()
         {
           WriteLine("\n Art from:-shimrod");
           WriteLine("Thanks for using the journal App!");
           waitForkey;
         }
         private void waitForkey()
         {
           ForegroundColor = ConsoleColor.DarkGray;
           WriteLine("\n press any key...");
           Readkey(true);
         }
         private void Displayjournal Contents()
         {
            ForegroundColor = ConsoleColor.DarkMagenta;
            String journal.Text = File.ReadAllText(journalFile);
            WriteLine("\n === journey Contents===");
            WriteLine(journalText);
            WriteLine("=================");
            WaitForkey;
         }

         private void ClearFile()
          {
           ForegroundColor = ConsoleColor.Black;
           File.WriteAllText(journalFile, " ");
           WriteLine("\n journal cleared");
           WaitForkey();
          }

         private void AddEntry()
           {
             ForegroundColor = ConsoleColor.Black;
             WriteLine("\n What would you like to add: ");
             ForegroundColor = ConsoleColor.DarkMagenta;
             String newline = ReadLine();
             File.AppendAllText(JournalFile,$"\nEntry:\n>{newline}\n");
             ForegroundColor = Console.Black;
             WriteLine("The journal has been modified!")
             WaitForkey();
           }
        }
    }    
    
   
  
}