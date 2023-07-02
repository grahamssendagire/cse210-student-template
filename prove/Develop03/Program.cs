using System;
class Scripture
{

  private Reference scripturereference;

  private string text;
  public Scripture(Reference scriptureName,string statement) // constructor-scripture
  {
    scripturereference = scriptureName;
    text = statement;
  }

}
class Program
 {
  static void Main(string[] args)
  {
    Reference reference = new Reference("Proverbs",3,6); // Object-refference
    Scripture scripture = new Scripture(reference," Trust in the LORD with all your heart and lean not on your own");
    Word word = new Word("Hey Reading scriptures is good");
    Console.WriteLine("scriptureName:" ); 
    Console.WriteLine("chapter:" ); 
    Console.WriteLine("verse:" ); 
    Console.WriteLine("Text:" ); 
    Console.WriteLine("word:" ); 
  }
 }
class Reference
{
  private string book;
  private int chapter;
  private int verse;
  public Reference(string bookName,int bookChapter,int bookVerse) // constructor-reference
  {
     book = bookName;
     chapter = bookChapter;
     verse = bookVerse;
     
   }
}
class Word
{
private string word;
  public Word(string wordName) // word-constructor 
  {
    word = wordName;
  }
}
  
  
   
  