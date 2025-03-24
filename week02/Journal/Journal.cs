public class Journal
{
    private List<Entry> entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    // Display all entries in the journal
    public void DisplayAll()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }
    }

    // Save all entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

    // Load entries from a file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                if (parts.Length == 3)
                {
                    Entry newEntry = new Entry(parts[0], parts[1], parts[2]);
                    entries.Add(newEntry);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}