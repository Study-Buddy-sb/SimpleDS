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

bool isRunning = true;
var todoItems = new List<string>();

Console.WriteLine("A simple todo List");
Console.WriteLine("How far wagwan man");
while (isRunning)
{
    var options = new List<string>()
    {
        "Press 1 to add a todo item",
        "Press 2 to remove a todo item",
        "Press 3 to view all todo items",
        "press 4 to exit",
    };

    foreach (var item in options)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(item);
        Console.ForegroundColor = ConsoleColor.Black;
    }

    Console.Write("wetin you choose: ");
    string userChoice = Console.ReadLine()!;
    switch (userChoice)
    {
        case "1":
            Console.Write("wetin you wan add: ");
            string todo = Console.ReadLine()!;
            todoItems.Add(todo);
            break;
        case "2":
            Console.Write("wetin be the position you wan remove: ");
            int position = int.Parse(Console.ReadLine()!);
            todoItems.RemoveAt(position);
            break;
        case "3":
            if (todoItems.Count() != 0)
            {
                foreach (var item in todoItems)
                {
                    int index = 0;
                    Console.WriteLine($"position:{index} item :{item}");
                    ++index;
                    Console.WriteLine("-------------");
                }
            }
            else{

            Console.WriteLine("Nothing dey here");
            }

            break;

        case "4":
            Console.WriteLine("Exited Sucessfully");
            isRunning = false;
            break;
        default:
            Console.WriteLine("You don't follow instructions");
            break;
    }
    Console.WriteLine("=============================");
}
