class Tables
{
    public bool[] tableStatus;
    public List<Reservation> reservations;

    public Tables(int numberOfTables)
    {
        tableStatus = new bool[numberOfTables];
        reservations = new List<Reservation>();
    }

    public bool tableValid(int tableNumber)
    {
        return tableNumber >= 1 && tableNumber <= tableStatus.Length && !tableStatus[tableNumber - 1];
    }

    public bool numberPeopleLimit(int numberPeople)
    {
        return numberPeople > 10;
    }

    public void updateTableStatus(int tableNumber, bool isReserved)
    {
        if (tableNumber >= 1 && tableNumber <= tableStatus.Length)
        {
            tableStatus[tableNumber - 1] = isReserved;
        }
    }
}
