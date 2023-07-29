class Reservation
{
    public int TableNumber { get; }
    public int NumberPeople { get; }
    public string DateReservation { get; }
    public string MealTimeChoice { get; }


    public Reservation(int tableNumber, int numberPeople, string dateReservation, string mealTimeChoice)
    {
        TableNumber = tableNumber;
        NumberPeople = numberPeople;
        DateReservation = dateReservation;
        MealTimeChoice = mealTimeChoice;
    }
}   