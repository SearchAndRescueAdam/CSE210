class Scripture {

    private List<Word> _words = new List<Word>();

    private Reference _reference = new Reference("1 Nephi", 3, 7);

    private Random _random = new Random();


    public Scripture(string Scripture) {
        string[] words = Scripture.Split(" ");
        foreach (string w in words) {
            var wordObj = new Word(w);
            _words.Add(wordObj);
        }
    }

    public void displayWords() {
        _reference.showReference();
        foreach (Word r in _words) {
            Console.Write($"{r.GetText()} ");
            }
        }

    public void hideWord() {
        for (int i = 0; i < 3; i++){
            while (!CheckHidden()) {
            int ranNum = _random.Next(_words.Count());
            if (!_words[ranNum].getHidden()) {
                _words[ranNum].Hide();
                break;
            }
        }
        }
    }

    public bool CheckHidden() {
        foreach (Word r in _words){
            if (r.getHidden() == false) {
                return false;
            }
        }
        return true;
    }
}
