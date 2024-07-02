using M1Task.Domain.Billings;
using System.Text;

string entryString = "ABE - Allegro Billing Entries\n" +
                     "Select action:\n" +
                     $"{ListCommands()}";
Console.WriteLine($"{entryString}{Environment.NewLine}" +
    $"Remember to fill in all necessary connection data in appsettings.json file before proceeding");

var exit = false;
while (!exit)
{
    string? input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out int number);

    if (!isNumber)
    {
        Console.WriteLine("Wrong input!");
        continue;
    }

    exit = ExecuteCommands(number);

    Console.WriteLine($"{Environment.NewLine}-----{Environment.NewLine}");
    Console.WriteLine(entryString);
}

return;



string ListCommands()
{
    var values = Enum.GetValues(typeof(Commands));
    StringBuilder sb = new();
    foreach (var value in values)
        sb.AppendLine($"{(int)value} - {value.ToString()}");

    return sb.ToString();
}

bool ExecuteCommands(int number)
{
    switch (number)
    {
        case var _ when number == (int)Commands.DownloadBillingData:
            var response = DownloadBillingData.DownloadData().GetAwaiter().GetResult();
            Console.WriteLine(response.Message);
            break;
        case var _ when number == (int)Commands.Exit:
            return true;
        default:
            Console.WriteLine("Unknown command");
            break;
    }

    return false;
}

enum Commands
{
    Login = 0,
    DownloadBillingData = 1,
    Exit = 9
}