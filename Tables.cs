class Tables
{
    public int numberOfTables = 20;
    public string? availableTables;

    public static void AvailableTables(int numberOfTables, List<bool> tables)
    {
        Console.WriteLine("Available Tables:");
        Console.WriteLine("\tTable number   \t    Status");
        for (int i = 0; i < numberOfTables; i++)
        {
            Console.WriteLine("\t     {0}   \t   {1}", i + 1, tables[i] ? "Reserved" : "Available");
        }
    }
}
