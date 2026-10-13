int count = 0;
int sum = 0;
int highest = 0;
int lowest = 0;

Console.Write("Enter grade (-1 to stop):  ");
int grade = int.Parse(Console.ReadLine()!);

while (grade != -1)
{
    if (count == 0)
    {
        highest = grade;
        lowest = grade;
    }
    else
    {
        if (grade > highest)
        {
            highest = grade;
        }
        if (grade < lowest)
        {
            lowest = grade;
        }
    }

    sum += grade;
    count = count + 1;

    Console.Write("Enter grade (-1 to stop): ");
    grade = int.Parse(Console.ReadLine()!);

}

if (count > 0)
{
    double average = (double)sum / count;

    Console.WriteLine($"count: {count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average:F2}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Lowest: {lowest}");
}
else
{
    Console.WriteLine("No grades were entered.");
}



Console.Write("Enter a number (1-10): ");
int n = int.Parse(Console.ReadLine()!);

if (n >= 1 && n <= 10)
{ 
   for (int i=1; i <= 10; i++)
    {
        Console.WriteLine($"{n} x {i} = {n * i}");
    }
}
else
{
    Console.WriteLine("Please enter a number between 1 and 10.");
}