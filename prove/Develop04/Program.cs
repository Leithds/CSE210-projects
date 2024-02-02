class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice, 1 - 4: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Activity activity = null;

            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ListingActivity();
                    break;
                case 3:
                    activity = new ReflectingActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please pick a number 1 - 4.\n");
                    continue;
            }
            if (activity is ListingActivity listingActivity)
            {
                listingActivity.Run();
            }
            else if (activity is ReflectingActivity reflectingActivity)
            {
                reflectingActivity.Run();
            }
        }
    }
}