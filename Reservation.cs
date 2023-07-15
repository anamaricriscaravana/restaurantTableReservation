class Reservation
{
    public int TableNumber { get; }
    public int NumberOfPeople { get; }
    public string DateReservation { get; }
    public string MealTimeChoice { get; }


    public Reservation(int tableNumber, int numberOfPeople, string dateReservation, string mealTimeChoice)
    {
        TableNumber = tableNumber;
        NumberOfPeople = numberOfPeople;
        DateReservation = dateReservation;
        MealTimeChoice = mealTimeChoice;
    }
}   