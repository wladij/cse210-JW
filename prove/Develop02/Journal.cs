public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void ShowEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Question: {entry.Question}");
            Console.WriteLine($"Answer: {entry.Answer}\n");
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                

                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Question},{entry.Answer}");
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error to save journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
        entries.Clear(); 

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry
                        {
                            Date = parts[0],
                            Question = parts[1],
                            Answer = parts[2]
                        };
                        entries.Add(entry);
                    }
                }
            }
        }
    catch (Exception ex)
    {
        throw new Exception($"Error to load from file: {ex.Message}");
    }
    }
    
    public void ImportFromCSV(string fileName)
    {
        try
        {
            List<Entry> importedEntries = new List<Entry>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry
                        {
                            Date = parts[0],
                            Question = parts[1],
                            Answer = parts[2]
                        };
                        importedEntries.Add(entry);
                    }
                }
            }

            // Agregar las nuevas entradas a la lista existente
            entries.AddRange(importedEntries);
        }
        catch (Exception ex)
        {
            throw new Exception($"Error when importing the journal from CSV: {ex.Message}");
        }
    }

    public void DisplayCSVContent(string fileName)
    {
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error displaying the contents of the CSV file: {ex.Message}");
        }
    }

}

