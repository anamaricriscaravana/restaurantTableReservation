class Reservation
{
    public int TableNumber { get; }
    public int NumberOfPeople { get; }
    public string MealTime { get; }
    public string ReservationDateTime { get; }

    public Reservation(int tableNumber, int numberOfPeople, string mealTime, string reservationDateTime)
    {
        TableNumber = tableNumber;
        NumberOfPeople = numberOfPeople;
        MealTime = mealTime;
        ReservationDateTime = reservationDateTime;
    }
}