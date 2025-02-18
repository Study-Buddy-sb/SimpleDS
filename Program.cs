// Simple DS

//  []


// integers
// int[] myNumbners = new int[5] {1,2,3,4,5};
// foreach (var item in myNumbners)
// {
//     Console.WriteLine(item);
// }

// string[] daysOfTheWeek= new string[7];
// daysOfTheWeek[0] = "SUNDAY";
// daysOfTheWeek[1] = "MONDAY";

// foreach (var item in daysOfTheWeek)
// {
//     Console.WriteLine(item);
// }

// int totalAcceptableRange = daysOfTheWeek.Length;
// Console.WriteLine(totalAcceptableRange);


// List<string> todos = new List<string>();
// Console.WriteLine("Adding .....");
// todos.Add("Read My Book");
// todos.Add("have the class");

// foreach (var item in todos)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("Removing .....");
// todos.RemoveAt(1);
// foreach (var item in todos)
// {
//     Console.WriteLine(item);
// }
// Initialize a boolean variable to control the loop
bool isRunning = true;

// Initialize a list to store todo items
var todoItems = new List<string>();

// Print the title of the todo list application
Console.WriteLine("A simple todo List");

// Print a greeting message
Console.WriteLine("How far wagwan man");

// Start a loop that will run until isRunning is set to false
while (isRunning)
{
    // Create a list of options for the user
    var options = new List<string>()
    {
        "Press 1 to add a todo item",
        "Press 2 to remove a todo item",
        "Press 3 to view all todo items",
        "press 4 to exit",
    };

    // Print each option to the console
    foreach (var item in options)
    {
        // Set the text color to dark red
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(item);
        // Reset the text color to black
        Console.ForegroundColor = ConsoleColor.Black;
    }

    // Prompt the user to make a choice
    Console.Write("wetin you choose: ");
    // Read the user's choice from the console
    string userChoice = Console.ReadLine()!;

    // Handle the user's choice using a switch statement
    switch (userChoice)
    {
        case "1":
            // Prompt the user to enter a new todo item
            Console.Write("wetin you wan add: ");
            // Read the new todo item from the console
            string todo = Console.ReadLine()!;
            // Add the new todo item to the list
            todoItems.Add(todo);
            break;
        case "2":
            // Prompt the user to enter the position of the item to remove
            Console.Write("wetin be the position you wan remove: ");
            // Read the position from the console and convert it to an integer
            int position = int.Parse(Console.ReadLine()!);
            // Remove the item at the specified position from the list
            todoItems.RemoveAt(position);
            break;
        case "3":
            // Check if there are any items in the list
            if (todoItems.Count() != 0)
            {
                // Initialize an index variable
                int index = 0;
                // Print each item in the list along with its position
                foreach (var item in todoItems)
                {
                    Console.WriteLine($"position:{index} item :{item}");
                    ++index;
                    Console.WriteLine("-------------");
                }
            }
            else
            {
                // Print a message if the list is empty
                Console.WriteLine("Nothing dey here");
            }
            break;
        case "4":
            // Print a message indicating the program is exiting
            Console.WriteLine("Exited Sucessfully");
            // Set isRunning to false to exit the loop
            isRunning = false;
            break;
        default:
            // Print a message if the user enters an invalid choice
            Console.WriteLine("You don't follow instructions");
            break;
    }
    // Print a separator line
    Console.WriteLine("=============================");
}
