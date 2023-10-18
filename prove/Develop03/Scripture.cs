using System;

public class Scripture
{
    //Scripture - Keeps track of the reference and the text of the scripture. 
    //Can hide words and get the rendered display of the text.
    private Reference _reference;
    private string[] _text;
    private List<Word> _wordList = new();

    public void DisplayScripture()
    {
        _reference.DisplayReference();
        foreach (var word in _wordList)
        {
            Console.Write(word.GetWord() + " ");
        }
    }

    public void DisplayShortScripture()
    {
        _reference.DisplayShortReference();
        foreach (var word in _wordList)
        {
            Console.Write(word.GetWord() + " ");
        }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text.Split(' ');
        foreach(string word in _text)
        {
            if(word != "")
            {
            Word Word1 = new Word(word);
            _wordList.Add(Word1);
            }
        }
    }
    public string[] HideWords()
    {
        //randomly choose indexes from the array
        Random randIndex = new Random(); 

        //replace 1-4 those words with ___
        Random randWords = new Random();
        int hiddenWords = randWords.Next(1, 5);
            for (int i = 1; i <= hiddenWords ; i++)
            {
                int ranDex = randIndex.Next(_text.Length);
                _wordList[ranDex].Hide();
            }

        return _text;
    }

    public Boolean IsCompletelyHidden()
    {
        Boolean allHidden = true;
        foreach(Word word in _wordList)
        {
            if(word.GetVisibility() == false)
            {
                allHidden = false;
            }
        }
        return allHidden;
    }

}