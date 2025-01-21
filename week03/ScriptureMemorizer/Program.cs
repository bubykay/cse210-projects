using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Mathew", 2, 1, 2);
        Scripture scripture = new(reference, "Now after Jesus was born in Bethlehem of Judea in the days of Herod the king, behold, wise men from the east came to Jerusalem, saying, 1  “Where is he who has been born king of the Jews? For we saw his star when it rose and have come to worship 2  him.");
        scripture.GetDisplayText();

        while (true)
        {
            string input = Console.ReadLine();
            if (input?.Trim().ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            if (input.Trim() == "")
            {
                scripture.HideRandomWord(5);
            }
            scripture.GetDisplayText();
        }
    }
}