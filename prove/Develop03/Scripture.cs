public class Scripture
{
    // Properties
    private List<Word> _words;

    // Methods
    public void SetWords(List<Word> words)
    {
        _words = words;

        return;
    }

    public void DisplayScripture(string reference)
    {
        string scripture = "";
        foreach (Word word in _words)
        {
            string displayWord = word.GetDisplayWord();
            scripture += $"{displayWord} ";
        }

        Console.Clear();
        Console.WriteLine($"{reference} {scripture}");

        return;
    }

    public bool HideRandomWord()
    {
        Dictionary<int, Word> nonHiddenWords = new Dictionary<int, Word>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden)
            {
                nonHiddenWords[i] = _words[i];
            }
        }

        // Get a random word
        List<int> keys = new List<int>(nonHiddenWords.Keys);

        if (keys.Count < 1)
        {
            return true;
        }

        Random random = new Random();

        int randomIndex = random.Next(0, keys.Count);

        // index of the value in the _words variable
        int index = keys[randomIndex];

        _words[index].HideWord();

        return false;
    }
}