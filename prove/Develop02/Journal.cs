using System;


public class Journal{

  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry newEntry)
  {
    _entries.Add(newEntry);
  }

  public void DisplayAll()
  {
    int i = 1; 
    foreach(Entry entry in _entries )
    {
      if (i > 1)
      {
        entry.Display();
        Console.WriteLine("");
      }
      i+=1;
    }
  }
  public void SaveToFile(string file)
  {
     string fileName = file;

     using (StreamWriter outputFile = new StreamWriter(fileName))
     {

        if (!File.Exists(fileName))
        {
           outputFile.WriteLine("Date; Prompt; Response");
        }
       
        foreach (Entry entry in _entries)
          outputFile.WriteLine($"{entry._date};{entry._promptText}; {entry._entryText}");
     }
  }

  public void LoadFromFile(string file)
  {
    _entries.Clear();
    string fileName = file;

    if (!File.Exists(fileName))
    {
      Console.WriteLine("\nThe file does not exists\n");
    }
    else{

      string[] lines = System.IO.File.ReadAllLines(fileName);

      foreach (string line in lines)
      {
        string[] entryLine = line.Split(";");
        Entry entry = new Entry();

        entry._date = entryLine[0];
        entry._promptText = entryLine[1];
        entry._entryText = entryLine[2];

        _entries.Add(entry);
      }
    }



  }


}