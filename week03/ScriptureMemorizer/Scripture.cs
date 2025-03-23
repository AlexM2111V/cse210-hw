using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    int hiddenCount = 0;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the sentence into words and convert it into a List
        List<string> phrase = new List<string>(text.Split(' '));
        foreach (string word in phrase)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;

        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];
            //Check if the word is already hidden
            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
                count++;
                if (IsCompletelyHidden())
                {
                    break;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        List<string> scriptureContent = new List<string>();

        foreach (Word word in _words)
        {
            scriptureContent.Add(word.GetDisplayText());
        }

        string scriptureText = string.Join(" ", scriptureContent);
        string fullScripture = $"{_reference.GetDisplayText()} {scriptureText}";
        return fullScripture;
    }
    public bool IsCompletelyHidden()
    {
        if (hiddenCount == _words.Count)
        {
            return true;
        }
        else return false;
    }

}