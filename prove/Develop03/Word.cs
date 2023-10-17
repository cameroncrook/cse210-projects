public class Word
{
    //Properties

    private string _word;
    private string _displayWord;
    public bool IsHidden = false;

    //Methods
    public void SetWord(string word)
    {
        _word = word;
        _displayWord = word;

        return;
    }

    public string GetDisplayWord()
    {
        return _displayWord;
    }

    public void HideWord()
    {
        string hiddenString = _word.Replace(_word, new string('_', _word.Length));

        _displayWord = hiddenString;

        IsHidden = true;

        return;
    }
}