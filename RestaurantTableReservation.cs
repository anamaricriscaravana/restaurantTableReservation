class RestaurantTableReservation
{
    static void Main()
    {
        System.Console.WriteLine("\t HELLO! WELCOME TO THE BIT BITE RESTAURANT TABLE RESERVATION SYSTEM!");

        Tables tables = new Tables(20);

        int tableNumber = 0;

        bool RestaurantTableReservation = true;
        while (RestaurantTableReservation)
        {
            DisplayMenu();
            System.Console.WriteLine(" ");
            System.Console.Write("Please enter the number of your choice: ");
            string? displayMenuNumber = System.Console.ReadLine();

            switch (displayMenuNumber)
            {
                case "1":
                    System.Console.WriteLine(" ");
                    System.Console.Write("Would you like to reserve a table? (Y/N):  ");
                    string? choicetableReservation = System.Console.ReadLine().ToUpper();
                    switch (choicetableReservation)
                    {
                        case "Y":
                            availableTables(tables.tableStatus);

                            bool tableNumberChoice = true;
                            while (tableNumberChoice)
                            {
                                System.Console.WriteLine(" ");
                                System.Console.Write("Please enter the table number:  ");
                                tableNumber = Convert.ToInt16(System.Console.ReadLine());

                                if (tables.tableValid(tableNumber))
                                {
                                    tableNumberChoice = false;
                                }
                                else
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("\t Table is not available. Please try again!");
                                    System.Console.WriteLine(" ");
                                    continue;
                                }
                            }

                            System.Console.WriteLine(" ");
                            System.Console.Write("Table for how many people?:  ");
                            int numberPeople = Convert.ToInt16(System.Console.ReadLine());

                            System.Console.WriteLine(" ");
                            System.Console.Write("Please enter the desired date for this reservation (MM/DD/YYYY):  ");
                            string? dateReservation = System.Console.ReadLine();

                            mealTimeReservation();

                            string? mealTimeChoice = " ";
                            while (mealTimeChoice != "1" && mealTimeChoice != "2" && mealTimeChoice != "3")
                            {
                                System.Console.Write("Please enter the number of your selected meal time:  ");
                                mealTimeChoice = System.Console.ReadLine();
                                switch (mealTimeChoice)
                                {
                                    case "1":
                                        mealTimeChoice = "Morning";
                                        break;

                                    case "2":
                                        mealTimeChoice = "Afternoon";
                                        break;

                                    case "3":
                                        mealTimeChoice = "Evening";
                                        break;

                                    default:
                                        System.Console.WriteLine(" ");
                                        System.Console.WriteLine("\t Invalid Number!");
                                        System.Console.WriteLine(" ");
                                        continue;
                                }
                            break;
                            }

                            System.Console.WriteLine(" ");
                            System.Console.Write("Do you want to confirm the booking? (Y/N): ");
                            string confirm = System.Console.ReadLine().ToUpper();
                            if (confirm == "Y")
                            {
                                Reservation reservation = new Reservation(tableNumber, numberPeople, dateReservation, mealTimeChoice);
                                tables.updateTableStatus(tableNumber, true);
                                System.Console.WriteLine(" ");
                                System.Console.WriteLine("\t You have successfully booked the table " + tableNumber + " for " + numberPeople + " people on " + dateReservation + ", in the " + mealTimeChoice);
                            }
                            break;

                        default:
                            System.Console.WriteLine(" ");
                            System.Console.WriteLine("\t Invalid option. Please try again.");
                            break;

                        case "N":
                            break;
                    }
                    break;

                case "2":
                    availableTables(tables.tableStatus);
                    break;

                case "0":
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("\t Exit");
                    System.Console.WriteLine("\t Thank you for using Bit Bite Table Reservation System!");
                    System.Console.WriteLine(" ");
                    RestaurantTableReservation = false;
                    break;

                default:
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("\t Invalid option. Please try again.");
                    System.Console.WriteLine(" ");
                    break;

            }
        }

    }

    private static void DisplayMenu()
    {
        System.Console.WriteLine(" ");
        System.Console.WriteLine("MENU:");
        System.Console.WriteLine("1. Reserve a table");
        System.Console.WriteLine("2. View Reservation");
        System.Console.WriteLine("0. Exit");
    }

    private static void availableTables(bool[] tableStatus)
    {
        Console.WriteLine("Available Tables:");
        Console.WriteLine("\tTable number   \t    Status");
        for (int i = 0; i < tableStatus.Length; i++)
        {
            Console.WriteLine("\t     {0}   \t   {1}", i + 1, tableStatus[i] ? "Reserved" : "Available");
        }
    }
    private static void mealTimeReservation()
    {
        System.Console.WriteLine(" ");
        System.Console.Write("\t Select a meal time:");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("\t 1. Morning");
        System.Console.WriteLine("\t 2. Afternoon");
        System.Console.WriteLine("\t 3. Evening");
        System.Console.WriteLine(" ");
    }
}