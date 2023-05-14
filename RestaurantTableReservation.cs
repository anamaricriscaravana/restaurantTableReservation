System.Console.WriteLine("\t HELLO! WELCOME TO RESTAURANT TABLE RESERVATION SYSTEM!");

bool reserved1 = false;
bool reserved2 = false;
bool reserved3 = false;
bool reserved4 = false;
bool reserved5 = false;
bool reserved6 = false;
bool reserved7 = false;
bool reserved8 = false;
bool reserved9 = false;

bool RestaurantTableReservation = true;
while (RestaurantTableReservation)
{
    System.Console.WriteLine(" ");
    System.Console.Write("Would you like to reserve a table? (Y/N):  ");
    string? choicetableReservation = System.Console.ReadLine().ToUpper();

    switch (choicetableReservation)
    {

        case "Y":
            System.Console.WriteLine("\n Available Tables");
            System.Console.WriteLine("\n Table Number \t            Status");
            System.Console.WriteLine("      1 \t\t  {0}  \t     ", reserved1 ? "Reserved" : "Available");
            System.Console.WriteLine("      2 \t\t  {0}  \t     ", reserved2 ? "Reserved" : "Available");
            System.Console.WriteLine("      3 \t\t  {0}  \t     ", reserved3 ? "Reserved" : "Available");
            System.Console.WriteLine("      4 \t\t  {0}  \t     ", reserved4 ? "Reserved" : "Available");
            System.Console.WriteLine("      5 \t\t  {0}  \t     ", reserved5 ? "Reserved" : "Available");
            System.Console.WriteLine("      6 \t\t  {0}  \t     ", reserved6 ? "Reserved" : "Available");
            System.Console.WriteLine("      7 \t\t  {0}  \t     ", reserved7 ? "Reserved" : "Available");
            System.Console.WriteLine("      8 \t\t  {0}  \t     ", reserved8 ? "Reserved" : "Available");
            System.Console.WriteLine("      9 \t\t  {0}  \t     ", reserved9 ? "Reserved" : "Available");

            System.Console.WriteLine(" ");
            System.Console.Write("Please enter the table number:  ");
            string? tableNumber = System.Console.ReadLine();

            if (tableNumber == "1" && !reserved1)
            {
                reserved1 = true;
            }
            else if (tableNumber == "2" && !reserved2)
            {
                reserved2 = true;
            }
            else if (tableNumber == "3" && !reserved3)
            {
                reserved3 = true;
            }
            else if (tableNumber == "4" && !reserved4)
            {
                reserved4 = true;
            }
            else if (tableNumber == "5" && !reserved5)
            {
                reserved5 = true;
            }
            else if (tableNumber == "6" && !reserved6)
            {
                reserved6 = true;
            }
            else if (tableNumber == "7" && !reserved7)
            {
                reserved7 = true;
            }
            else if (tableNumber == "8" && !reserved8)
            {
                reserved8 = true;
            }
            else if (tableNumber == "9" && !reserved9)
                reserved9 = true;
            else
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine("\t Table is not available. Please try again!");
                break;
            }
            System.Console.WriteLine(" ");
            System.Console.Write("Table for how many poeple?:  ");
            int numberPeople = Convert.ToInt16(System.Console.ReadLine());

            System.Console.WriteLine(" ");
            System.Console.Write("Please enter the desired date for this reservation (MM/DD/YYYY):  ");
            string? dateReservation = System.Console.ReadLine();

            System.Console.WriteLine(" ");
            System.Console.Write("\t Select a meal time:");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("\t 1. Morning");
            System.Console.WriteLine("\t 2. Afternoon");
            System.Console.WriteLine("\t 3. Evening");
            System.Console.WriteLine(" ");
            System.Console.Write("Please enter the number of your selected meal time:  ");
            string? mealTimeReservation = System.Console.ReadLine();

            switch (mealTimeReservation)
            {
                case "1":
                    mealTimeReservation = "Morning";
                    break;

                case "2":
                    mealTimeReservation = "Afternoon";
                    break;

                case "3":
                    mealTimeReservation = "Evening";
                    break;

                default:
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("\t Invalid Number. Please try again!");
                    break;
            }

            System.Console.WriteLine(" ");
            System.Console.Write("Do you want to confirm the booking? (Y/N): ");
            string confirm = System.Console.ReadLine().ToUpper();
            if (confirm == "Y")
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine("\t You have successfully booked the table" + tableNumber + " for " + numberPeople + " people on " + dateReservation + ", in the " + mealTimeReservation);
            }
            break;

        case "N":
            System.Console.WriteLine(" ");
            System.Console.WriteLine("\t Exit");
            System.Console.WriteLine("\t Thank you for using Table Reservation System!");
            break;

        default:
            System.Console.WriteLine(" ");
            System.Console.WriteLine("\t Invalid option. Please try again.");
            break;
    }
}