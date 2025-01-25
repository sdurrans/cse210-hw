using System;

class Scripture
{
    private Reference _reference;
    private Word[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(new[] { ' ', '.', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
        _words = new List<Word>();

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
    }

    public string GetDisplayText()
    {
        return "Scripture display text";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }

}