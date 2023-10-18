using System;

public class Word
{
    //Word - Keeps track of a single word and whether it is shown or hidden.
    private string _word;
    private Boolean _isHidden;
    private string _hiddenWord;

    public Word(string text)
    {
            _word = text;
            _isHidden = false;
            char[] wordSize = text.ToCharArray();
            foreach(char letter in wordSize)
            {
                _hiddenWord += "_";
            }
    }

    public void Hide()
    {
            _isHidden = true;
    }

    public void Show()
    {
            _isHidden = false;
    }

    public Boolean GetVisibility()
    {
            return _isHidden;
    }
    public string GetWord()
    {
        if(_isHidden == true)
        {
            return _hiddenWord;
        }
        else
        {
        return _word;
        }
    }

}