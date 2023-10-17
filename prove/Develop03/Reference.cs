using System.ComponentModel;

public class Reference
{
    // properties
    private string _reference;
    private string _scripture;

    public Scripture ScriptureClass;

    // Methods
    public void Init()
    {
        List<Word> words = new List<Word>();

        string[] splitWords = _scripture.Split(' ');

        foreach (string word in splitWords)
        {
            Word wordClass = new Word();

            wordClass.SetWord(word);

            words.Add(wordClass);
        }

        Scripture scripture = new Scripture();

        scripture.SetWords(words);

        ScriptureClass = scripture;

        return;
    }

    public void SetReference(string reference)
    {
        _reference = reference;

        return;
    }
    public void SetScripture(string scripture)
    {
        _scripture = scripture;

        return;
    }

    public string GetReference()
    {
        return _reference;
    }

    // public void DisplayScripture()
    // {
    //     _scriptureClass.DisplayScripture(_reference);

    //     return;
    // }
}