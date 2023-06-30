class Reserve
{
    public int TableNumber { get; set; }
    public int NumberOfPeople { get; set; }
    public string? MealTime { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public static List<Reserve> tables = new List<Reserve>();


    public Reserve(int tableNumber, int numberOfPeople, string? mealTime, DateOnly date, TimeOnly time)
    {
        TableNumber = tableNumber;
        NumberOfPeople = numberOfPeople;
        MealTime = mealTime;
        Date = date;
        Time = time;
    }
}