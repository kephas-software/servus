Console.WriteLine("Servus, how can I help you?");
Console.WriteLine("Type 'help' for the list of available commands, and 'quit' to exit the application. Have fun!");

Console.Write("> ");
var command = Console.ReadLine();

while (command != "quit")
{
    switch (command)
    {
        case "help":
            Console.WriteLine("quit: exits the application.");
            Console.WriteLine("help: displays the list of available commands.");
            Console.WriteLine("order <item>: orders the provided item.");
            Console.WriteLine("find <something or someone>: finds something or someone.");
            break;
        case string orderCommand when orderCommand.StartsWith("order "):
            Console.WriteLine($"Your order for {orderCommand[6..]} will be delivered soon!");
            break;
        case string findCommand when findCommand.StartsWith("find "):
            Console.WriteLine($"Trying to find {findCommand[5..]}, but implementation is missing :(.");
            break;
        default:
            Console.WriteLine($"Sorry, I don't know how to handle your '{command}' command. Try 'help' for the list of available commands.");
            break;
    }

    Console.Write("> ");
    command = Console.ReadLine();
}

Console.WriteLine("Anytime at your service. See you soon!");