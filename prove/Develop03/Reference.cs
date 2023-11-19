namespace ScriptureMemorization
{
    class Reference
{
    public string Verse { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

   
    public Reference(string reference)
    {
        string[] parts = reference.Split(':');
        Verse = parts[0];
        
       
        if (parts.Length > 1 && parts[1].Contains("-"))
        {
            string[] verseRange = parts[1].Split('-');
            StartVerse = int.Parse(verseRange[0]);

           
            EndVerse = verseRange.Length > 1 ? int.Parse(verseRange[1]) : StartVerse;
        }
        else
        {
           
            StartVerse = int.Parse(parts[1]);
            EndVerse = StartVerse;
        }
    }

    
    public Reference(string verse, int startVerse, int endVerse)
    {
        Verse = verse;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse > StartVerse ? $"{Verse} {StartVerse}-{EndVerse}" : $"{Verse} {StartVerse}";
    }
}

}

