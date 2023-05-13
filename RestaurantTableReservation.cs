System.Console.WriteLine("\n Hello! Welcome to Restaurant Table Reservation System");

bool RestaurantTableReservation = true;
while(RestaurantTableReservation)
{
    System.Console.WriteLine("\n");
    System.Console.WriteLine("MENU:");
    System.Console.WriteLine("1. View Tables");
    System.Console.WriteLine("2. Book a Table");
    System.Console.WriteLine("0. Exit");

    System.Console.WriteLine(" ");
    System.Console.Write("Please enter a number (0,1,2): ");
    string? tableReservation = System.Console.ReadLine();
    switch(tableReservation)
    {
        case "1":
            System.Console.WriteLine(" ");
            System.Console.WriteLine("View Tables");
            for (int i = 1; i < 20; i++)
        {
                System.Console.Write(" " + i + " "); 
        }
        break;

        case "2":
            System.Console.WriteLine(" ");           
            System.Console.WriteLine("Book a Table");

            System.Console.Write("Table for how many person?:" );
            string? tablePerson = System.Console.ReadLine();
            System.Console.Write("Please enter the desired date for this reservation (MM/DD/YYYY):" );
            string? dateReservation = System.Console.ReadLine();
            System.Console.Write("Please enter the desired time for this reservation (HH/MM):" );
            string? timeReservation = System.Console.ReadLine();
            System.Console.WriteLine("You successfully booked the tables for " + tablePerson + " on " + dateReservation + " at " + timeReservation + " AM/PM");
        break;

        case "0":
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Exit");
            System.Console.WriteLine("Thank you for using Table Reservation System!");
            RestaurantTableReservation = false;
        break;

        default:
            System.Console.WriteLine(" ");   
            System.Console.WriteLine("Invalid Number. Please try again.");
        break;
    }
}