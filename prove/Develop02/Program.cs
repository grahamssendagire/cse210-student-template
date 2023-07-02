using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Static System.Console;
using System.IO;

namespace JournalApp
{
  class Journal
  {
    private string JournalFile = "Journal.txt";
    private string TitleArt = @"(\      _.--._  _.--._
,-=.-":;:;:;\':;:;:;"-._
\\\:;:;:;:;:;\:;:;:;:;:;\
 \\\:;:;:;:;:;\:;:;:;:;:;\
  \\\:;:;:;:;:;\:;:;:;:;:;\
   \\\:;:;:;:;:;\:;::;:;:;:\
    \\\;:;::;:;;\:;:;:;::;:\
     \\\;;:;:_:--:\:_:--:_;:;\    -shimrod
      \\\_.-"      :      "-._\
       \`_..--""--.;.--""--.._=> ";

       
       public void Run()
       {
        Title = "Journal App";
        DisplayIntro();
        DisplayjournalContents();
        WriteJournalContent();
        createjournalFile();
        RunMenu();
        DisplayOutro();
        Load();
        Write();
        Save();
       }
       private void RunMenu()
       {
       do
       {
         choice = GetChoice();
         switch(choice)
         {
         case "1":
             Write();
             break;
         case "2":
             DisplayIntro();
             break;
         case "3":
             Load();
             break;
         case "4":
             SavejournalContent();
             break;
        default:
            break;
        }
      } while (choice != "5");  
    }
    private string GetChoice()
   {
      bool ischoiceValid = false;
      string choice = "";

            do
            {
               Write();
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
               choice= ReadLine().Trim();
               ForegroundColor = ConsoleColor.Black;

               if(choice== "1" || choice == "2" || choice =="3" || choice=="4" || choice== "5")
            {
                ischoiceValid = true;
            }
           else
           {
             ForegroundColor = ConsoleColor.Red;
             WriteLine($"\"{choice}\" is not a valid option.Please choose 1-5.");
             waitForkey();
           } 
           
        } while(!ischoiceValid);
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
           waitForkey();
         }
     
         private void DisplayOutro()
         {
           WriteLine("\n Art from:-shimrod");
           WriteLine("Thanks for using the journal App!");
           waitForkey();
         }
         private void waitForkey()
         {
           ForegroundColor = ConsoleColor.DarkGray;
           WriteLine("\n press any key...");
           Readkey(true);
         }
         private void DisplayjournalContents()
         {
            ForegroundColor = ConsoleColor.DarkMagenta;
            String journal.Text = File.ReadAllText(journalFile);
            WriteLine("\n === journey Contents===");
            WriteLine(journal.text);
            WriteLine("=================");
            waitForkey();
         }
            private void Write()
          {
           ForegroundColor = ConsoleColor.Black;
           File.WriteAllText(journal.File, " ");
           WriteLine("\n journal Written");
           waitForkey();
          }

         private void LoadEntry()
           {
             ForegroundColor = ConsoleColor.Black;
             WriteLine("\n What would you like to Load: ");
             ForegroundColor = ConsoleColor.DarkMagenta;
             String newline = ReadLine();
             File.AppendAllText(JournalFile,$"\nEntry:\n>{newline}\n");
             ForegroundColor = ConsoleColor.Black;
             WriteLine("The journal has been modified!");
             waitForkey();
           }
         private void SavejournalContent()
           {
             ForegroundColor = ConsoleColor.Black;
             WriteLine("\n What would you like to Save:? ");
             ForegroundColor = ConsoleColor.DarkMagenta;
             String newline = ReadLine();
             File.AppendAllText(JournalFile,$"\nEntry:\n>{newline}\n");
             ForegroundColor = ConsoleColor.Black;
             WriteLine("The journal has been modified!")
             waitForkey();
           }
      }
    
}  
  
