using System.Text.Json;

class ScriptureLibrary {

    private string _fileName = "ScriptureLibrary.json";
    public string _book { get; set; }
    public int _chapter { get; set; }
    public int _startVerse { get; set; }
    public int _endVerse { get; set; }
    public string _text { get; set; }
    private List<ScriptureLibrary> _scripture = new List<ScriptureLibrary>();

    public void LoadScriptures()
    {
        string jsonContent = File.ReadAllText(_fileName);

        List<ScriptureLibrary> scriptures = JsonSerializer.Deserialize<List<ScriptureLibrary>>(jsonContent);

        foreach (var obj in scriptures)
            {
                ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

                scriptureLibrary._book = obj._book;
                scriptureLibrary._chapter = obj._chapter;
                scriptureLibrary._startVerse = obj._startVerse;
                scriptureLibrary._endVerse = obj._endVerse;
                scriptureLibrary._text = obj._text;
                _scripture.Add(scriptureLibrary);
            }
    }

    public string GetRandomScripture()
    {
        Random random = new Random(); 
        int indexRandom = random.Next(_scripture.Count());

        string book = _scripture[indexRandom]._book;
        int chapter = _scripture[indexRandom]._chapter;
        int startVerse = _scripture[indexRandom]._startVerse;
        int endVerse = _scripture[indexRandom]._endVerse;
        string text = _scripture[indexRandom]._text;
        return $"{book}| {chapter}| {startVerse}| {endVerse}| {text}";
    }
    

}