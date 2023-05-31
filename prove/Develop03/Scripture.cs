class Scripture {

    private List<Word> _words;

    private Reference _reference = new Reference("1 Nephi",3,7);


    public Scripture(string Scripture) {
        string[] words = Scripture.Split(" ");
        foreach (string w in words) {
            var wordObj = new Word(w);
            _words.Add(wordObj);
        }
    }

    public void displayWords() {
        foreach (Word r in _words)
        Console.Write(_words);
        }
}
