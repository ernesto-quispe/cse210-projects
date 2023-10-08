using System.Text;

class Scripture {

    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
         _reference = reference;
         List<string> words = new List<string>(text.Split(' '));
         foreach (var word in words)
         {
          Word tempWord = new(word);
          _words.Add(tempWord);
         }
    }
    public int getLengthWords()
    {
      return _words.Count();
    }
    public bool getWordIsHidden(int indexRandom)
    {
      return _words[indexRandom].IsHidden();
    }
    public bool getWordsAllHidden()
    {
      bool isAllHidden = true;

      foreach (Word word in _words)
      {
        if (word.IsHidden() == false)
        {
          isAllHidden = false;
        }
      } 

      return isAllHidden;
    }
    public void HideRandomWords(int indexRandom)
    {
      _words[indexRandom].Hide();
    }
    public string GetDisplayText()
    {
      StringBuilder result = new StringBuilder();

      foreach (Word word in _words)
      {
         if (word.IsHidden() == true)
         {
          string tempWord = word.GetDisplayText();
          string underscoreWord = "";

          for (int i = 1; i < tempWord.Length; i++)
          {
            underscoreWord += "_";
          }
          word.SetWord(underscoreWord);
          result.Append(word.GetDisplayText());
         }
         else
         {
          result.Append(word.GetDisplayText());

         }
      }
        return $"{_reference.GetDisplayText()}\n {result}";
    }

}