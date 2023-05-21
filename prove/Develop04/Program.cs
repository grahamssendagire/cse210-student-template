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
        Tittle = "Daily Journal App"
        DisplayIntro();
        createjournalFile();
        DisplayOutro();
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
           WriteLine("\npress any key...");
           Readkey(true);
         }
         private void Displayjournal Contents(){}

         private void ClearFile(){}

         private void AddEntry(){}

         private string Getchoice  
    
   }
  
}