internal class CharacterLine
{
    public CharacterSegment[] Segments { get; }

    public CharacterLine(params CharacterSegment[] segments)
    {
        Segments = segments;
    }

    public CharacterLine(string line)
    {
        Segments = new CharacterSegment[]
            { new CharacterSegment(ConsoleColor.White, line)};
    }
}


public class CharacterSegment
{
    public ConsoleColor Color { get; }

    public string Text { get; }


    public CharacterSegment(ConsoleColor color, string segment)
    {
        Color = color;
        Text = segment;
    }
}
