class Word
{
    string _word;
    bool _isHidden = false;
    public Word(string text)
    {
        _word = text;
    }
    public void display()
    {
        if (_isHidden)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (char i in _word.ToLower())
            {
                if (alphabet.Contains(i))
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }
    public void hide()
    {
        _isHidden = true;
    }
}