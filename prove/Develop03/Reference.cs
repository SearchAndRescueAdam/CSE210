class Reference {
    
    private string _book;
    
    private int _chapter;

    private int _verse;

    private int _endVerse;


    public Reference(string book, int chapter, int verse) {

        book = _book;
        chapter = _chapter;
        verse = _verse;  
    }
    public Reference(string book, int chapter, int verse, int endVerse) {

        book = _book;
        chapter = _chapter;
        verse = _verse;
        endVerse = _endVerse;
    }

    public void showReference() {
        if (_endVerse != 0) {
            Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse} ");
        }
        else {
            Console.Write($"{_book} {_chapter}:{_verse} ");
        }
    }
}

