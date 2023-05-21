using System;
using System.collections.generic;
using System.Linq;
using System.Text;
using System.Threading.Task;
using System.IO;
using static System.Console;
namespace journal App

namespace journalApp
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
        Tittle = "Journal App"
        DisplayIntro();
        createjournalFile();
        WriteLine("You chose:" + Getchoice());
        //AddEntry();

        DisplayOutro();
       
        private void Runmenu()
    
        {

        }
         private string Getchoice()
        {
           Clear();
           ForegroundColor = ConsoleColor.DarkGray;
           writeLine("Welcome to the journal program");
           ForegraoundColor = ConsoleColor.Black;
           writeLine("\n Please select one of the following");
           writeLine(" > 1-Write the journal.");
           writeLine(" > 2-Display the journal.");
           writeLine(" > 3-Load the journal.");
           writeLine(" > 4-Save the journal.");
           writeLine(" > 5-Quit.");
           ForegroundColor = ConsoleColor.DarkBlue;
           string choice = ReadLine().Trim();
           ForegroundColor = ConsoleColor.Black;

           Return choice;
        }
    
         

        private void createjournalFile()
        {
           //WriteLine($"Does file exist? {File.Exists("Journal.txt)"}");
           if (!File.Exists("journey.txt"))
           {
              File,CreateText("journal.txt");    
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
           writeLine("\n journal cleared");
           waitForkey();
          }

         private void AddEntry()
           {
             ForegroundColor = ConsoleColor.Black;
             WriteLineriteLine("\n What would you like to add: ");
             ForegroundColor = ConsoleColor.DarkMagent;
             String newline = ReadLine();
             File.AppendAllText(journalFile,$"\nEntry:\n>{newline}\n");
             ForegraoundColor = Console.Black;
             WriteLine("The journal has been modified!")
             WaitForkey();
           }
        }
    }    
    
   
  
}