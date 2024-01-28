using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordsArray = text.Split(' ');

        foreach (string wordText in wordsArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }
        public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }
        public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
