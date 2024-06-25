using System.Text;

string entryString = "ABE - Allegro Billing Entries\n" +
                     "Select action:\n" +
                     $"{ListCommands()}";

while (true)
{
    Console.WriteLine(entryString);
    string? input = Console.ReadLine();
    bool isNumber = int.TryParse(input, out int number);

    if (!isNumber)
    {
        Console.WriteLine("Wrong input!");
        continue;
    }

    break;
}

return;




string GetDownloadPrompt()
{
    string prompt = "";
    return prompt;
}

string ListCommands()
{
    var values = Enum.GetValues(typeof(Commands));
    StringBuilder sb = new();
    foreach (var value in values)
        sb.AppendLine($"{(int)value} - {value.ToString()}");

    return sb.ToString();
}

enum Commands
{
    DownloadBillingData = 0,
    Exit = 9
}