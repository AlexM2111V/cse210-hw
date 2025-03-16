using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine();
    }
    public void SaveToFile(string file)
    {
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}~{entry._motivationLevel}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry entryLoaded = new Entry();

            string[] parts = line.Split("~");

            entryLoaded._date = parts[0];
            entryLoaded._promptText = parts[1];
            entryLoaded._entryText = parts[2];
            entryLoaded._motivationLevel = parts[3];

            _entries.Add(entryLoaded);
        }
    }
}