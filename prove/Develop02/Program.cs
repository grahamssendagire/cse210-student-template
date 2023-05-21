using System;
using System.collections.Generic;
using System.IO;

class journal
{
    static void Main(string[] args)
  {
   Option O1 = new option();
   O1._firstword = "write";
   O1._secoundword = "Display";
   O1._thirdword = "Load";
   O1._forthword = "Save";
   O1._fifthword = "Quit";

   Console.write("Welcome to the journal program! ");
   Console.WriteLine("Please select one of the following choices:");

   list<Option>journal = new list<journal>();
   option.add(O1);


   foreach (Option O in journal)
   {
    console.writeLine(O1._firstword);
   }

}
static void SaveTofile(list<option>journal) 
{
    string filename = "journal.txt";
    using (streamWriter outputfile = new streamWriter(filename));
}
    
}