class Video{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>(); 

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public string GetTitle(){
        return _title;
    }
    public void SetTitle(string title){
        _title = title;
    }
    public string GetAuthor(){
        return _author;
    }
    public void SetAuthor(string author){
        _author = author;
    }
    public double GetLength(){
        return _length;
    }
    public void SetLength(double length){
        _length = length;
    }
    public int GetLengthComments(){
        return _comments.Count;
    }
    public void AddComment(string name, string comment)
    {
        _comments.Add(new Comment(name, comment));
    }
    public void ShowComments()
    {   
        int index = 1;
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{index}. Author: {comment.GetName()}, Comment: {comment.GetComment()}");
            index++;
        }
    }
}