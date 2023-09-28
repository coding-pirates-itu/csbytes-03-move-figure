var character = new CharacterLine[]
{
    new CharacterLine(
        new CharacterSegment(ConsoleColor.White, "  ("),
        new CharacterSegment(ConsoleColor.Blue, "°°"),
        new CharacterSegment(ConsoleColor.White, ")  ")),
    new CharacterLine("==╡██╞=="),
    new CharacterLine("  └║║┘  "),
};


var isExit = false;
var x = 0;
var y = 0;
var charWidth = character.Last().Segments.First().Text.Length;
var charHeight = character.Length;

Console.CursorVisible = false;

while (!isExit)
{
    Console.Clear();
    var windowWidth = Console.BufferWidth;
    var windowHeight = Console.BufferHeight;

    for (var lineIndex = 0; lineIndex < charHeight; lineIndex++)
    {
        Console.SetCursorPosition(x, y + lineIndex);
        foreach (var segment in character[lineIndex].Segments)
        {
            Console.ForegroundColor = segment.Color;
            Console.Write(segment.Text);
        }
    }

    var ch = Console.ReadKey(true);

    switch (ch.Key)
    {
        case ConsoleKey.Q:
        case ConsoleKey.Escape:
            isExit = true;
            break;

        case ConsoleKey.UpArrow when y > 0:
            y--;
            break;

        case ConsoleKey.DownArrow when y + charHeight < windowHeight:
            y++;
            break;

        case ConsoleKey.LeftArrow when x > 0:
            x--;
            break;

        case ConsoleKey.RightArrow when x + charWidth < windowWidth:
            x++;
            break;
    }
}

Console.CursorVisible = true;
