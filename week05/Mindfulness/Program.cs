using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {



        Activity activity = new Activity();
        while (true)
        {
            activity.Start();
            string choice = activity._option;

            if (choice == "")
            {
                Console.WriteLine("Invalid choice");
                continue;
            }
            if (choice == "4")
            {
                activity.Stop();
                break;
            }
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                continue;
                // activity.Start();
            }
            if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                continue;
                // activity.Start();
            }

            if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                continue;
                // activity.Start();
            }


        }
    }

}