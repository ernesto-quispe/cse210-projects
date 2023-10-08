using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Clear();
    Random random = new Random();
    Reference reference;
    Scripture scripture;
    // ######################################################
    ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
    scriptureLibrary.LoadScriptures();
    string scriptureRandom = scriptureLibrary.GetRandomScripture();
    string[] scriptureArray = scriptureRandom.Split('|');


    string book = scriptureArray[0];
    int chapter = Int32.Parse(scriptureArray[1]);
    int startVerse = Int32.Parse(scriptureArray[2]);
    int endVerse = Int32.Parse(scriptureArray[3]);
    string text = scriptureArray[4];
    // ######################################################

    if (endVerse == 0)
    {
      reference = new Reference(book, chapter, startVerse);
      scripture = new Scripture(reference, text);
    }
    else
    {
      reference = new Reference(book, chapter, startVerse, endVerse);
      scripture = new Scripture(reference, text);
    }

    Console.WriteLine(scripture.GetDisplayText());
    Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");
    string entry = Console.ReadLine();

    while (entry.ToLower() != "quit")
    {
      int indexRandom = random.Next(scripture.GetLengthWords());

      if (scripture.GetWordsAllHidden() == false)
      {
        while (scripture.GetWordIsHidden(indexRandom) != false)
        {
          indexRandom = random.Next(scripture.GetLengthWords());
        }
        scripture.HideRandomWords(indexRandom);
        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress 'enter' to continue or type 'quit' to finish:");
      }
      else
      {
        break;
      }
      entry = Console.ReadLine();
    }
  }
}