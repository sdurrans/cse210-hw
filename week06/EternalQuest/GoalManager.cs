using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
            Console.WriteLine("Welcome to the Goal Manager!");
        while (true)
        {   
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please select an option: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Create goal ");
            }
            else if (choice == "2")
            {
                Console.WriteLine("List goals");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Save goals");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Load goals");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Record event");
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }                          
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
